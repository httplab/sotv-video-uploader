using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace SOTVVideoUploader
{
    public class AsyncTask<T>
    {
        public delegate T TaskDelegate(params object[] args);
        public event EventHandler<TaskEventArgs> Ready;
        public event EventHandler<TaskEventArgs> Error;
        public event EventHandler Cancelled;
        private bool _isRunning = false;
        private Thread _workingThread;

        public class TaskEventArgs : EventArgs
        {
            public T Result { get; set; }
            public Exception Exception { get; set; }
        }

        private TaskDelegate _delegate;

        public AsyncTask(TaskDelegate operation)
        {
            _delegate = operation;
        }

        public void BeginInvoke(params object[] args)
        {
            if (!_isRunning)
            {
                ParameterizedThreadStart pts = new ParameterizedThreadStart(thread_start);
                _workingThread = new Thread(pts);
                _workingThread.Start(args);
                _isRunning = true;
            }
            else
            {
                throw new ApplicationException("Данный объект уже выполняет работу.");
            }
        }

        public void Cancel()
        {
            if (_isRunning)
            {
                _workingThread.Abort();
                if (Cancelled != null)
                {
                    Cancelled(this, new EventArgs());
                }
                _isRunning = false;
            }
        }

        private void thread_start(object arg)
        {
            try
            {
               var result =  _delegate(arg as object[]);
               if (Ready != null)
               {
                   Ready(this, new TaskEventArgs(){Exception = null, Result = result});
               }
            }
            catch (ThreadAbortException tae)
            {

            }
            catch (Exception ex)
            {
                if (Error!=null)
                {
                    Error(this, new TaskEventArgs() { Result = default(T), Exception = ex });
                }
            }
        }
    }
}
