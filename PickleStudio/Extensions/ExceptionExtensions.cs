using System;
using System.Windows.Forms;

namespace PickleStudio.Extensions
{
    public static class ExceptionExtensions
    {
        public static void Show(this Exception exception)
        {
            MessageBox.Show(exception.Message, "Exception", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
