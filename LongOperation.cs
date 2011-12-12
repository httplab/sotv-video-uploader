using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SOTVVideoUploader
{
    public class LongOperationProcessor
    {
        public delegate void LongOperation(params object[] args);

        public static void PerformLongOperation(LongOperation operation, string message, params object[] args)
        {
            var frm = new frmLongOperation();
            frm.Message = message;
            operation.BeginInvoke(args, Callback, frm);
            frm.ShowDialog();
        }

        private static void Callback(IAsyncResult result)
        {
            var frm = result.AsyncState as frmLongOperation;
            frm.BeginInvoke((Action)(() => { frm.Close(); }));
        }
    }
}
