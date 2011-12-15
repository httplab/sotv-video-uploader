using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace SOTVVideoUploader
{
    public partial class frmLongOperation : Form
    {
        public event EventHandler Cancel;
        private bool _canCancel = true;
        private bool _isCancelled = false;
        private Exception _exception;
        private object _result;
        private Action CancelAction;

        public frmLongOperation()
        {
            InitializeComponent();
            btnCancel.DialogResult = DialogResult.None;
        }

        public string Message
        {
            get
            {
                return lblMessage.Text;
            }

            set
            {
                lblMessage.Text = value;
            }
        }

        bool CanCancel
        {
            get
            {
                return _canCancel;
            }

            set
            {
                _canCancel = value;
                btnCancel.Visible = value;
            }
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Прервать операцию?","Отмена", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (CancelAction != null)
                {
                    CancelAction();
                    
                }
                _isCancelled = true;
                Close();
            }
        }

        public void ExecuteOperation<T>(AsyncTask<T>.TaskDelegate operation, params object[] args)
        {
            AsyncTask<T> asyncTask = new AsyncTask<T>(operation);
            asyncTask.Error += new EventHandler<AsyncTask<T>.TaskEventArgs>(asyncTask_Error);
            asyncTask.Cancelled += new EventHandler(asyncTask_Cancelled);
            asyncTask.Ready += new EventHandler<AsyncTask<T>.TaskEventArgs>(asyncTask_Ready);
            asyncTask.BeginInvoke(args);
            CancelAction = asyncTask.Cancel;
            this.ShowDialog();
        }

        void asyncTask_Error<T>(object sender, AsyncTask<T>.TaskEventArgs e)
        {
            _result = default(T);
            _exception = e.Exception;
            _isCancelled = false;
            if (this.InvokeRequired)
            {
                this.BeginInvoke((Action)PerformClose);
            }
            else
            {
                this.Close();
            }
        }

        void asyncTask_Ready<T>(object sender, AsyncTask<T>.TaskEventArgs e)
        {
            _result = e.Result;
            if (this.InvokeRequired)
            {
                this.BeginInvoke((Action)PerformClose);
            }
            else
            {
                this.Close();
            }
        }


        public void PerformClose()
        {
            this.Close();
        }

        void asyncTask_Cancelled(object sender, EventArgs e)
        {
            _isCancelled = true;
            if (this.InvokeRequired)
            {
                this.BeginInvoke((Action)PerformClose);
            }
            else
            {
                this.Close();
            }
        }

        

        public static void PerformAsync<T>(AsyncTask<T>.TaskDelegate operation, string message, out T result, out bool isCancelled , out Exception ex, params object[] args) where T:class
        {
            var frm = new frmLongOperation();
            frm.Message = message;
            frm.ExecuteOperation(operation, args);
            isCancelled = frm._isCancelled;
            result = frm._result as T;
            ex = frm._exception;
        }
    }
}
