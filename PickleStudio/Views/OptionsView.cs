using PickleStudio.Extensions;
using PickleStudio.Interfaces;
using PickleStudio.Resources;
using System;
using System.Windows.Forms;

namespace PickleStudio.Views
{
    public partial class OptionsView : UserControl, IDialogControl
    {
        public OptionsView()
        {
            InitializeComponent();

            btnOk.Text = Strings.OkButtonText;
            btnCancel.Text = Strings.CancelButtonText;

            //ParentForm.AcceptButton = btnOk;
            //ParentForm.CancelButton = btnCancel;
        }

        public string Title
        {
            get
            {
                return Strings.OptionsViewTitle;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            this.Close(DialogResult.OK);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(DialogResult.Cancel);
        }
    }
}
