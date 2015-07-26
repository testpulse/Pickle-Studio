using PickleStudio.Core.Options;
using PickleStudio.Extensions;
using PickleStudio.Interfaces;
using PickleStudio.Resources;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Media;

namespace PickleStudio.Views
{
    public partial class EditorOptionsView : UserControl, IDialogControl
    {
        public EditorOptionsView(EditorOptions options)
        {
            InitializeComponent();

            btnOk.Text = Strings.OkButtonText;
            btnCancel.Text = Strings.CancelButtonText;

            //ParentForm.AcceptButton = btnOk;
            //ParentForm.CancelButton = btnCancel;

            cbxFontFamily.DataSource = Fonts.SystemFontFamilies.Select(f => f.Source).ToList();
            cbxFontSize.DataSource = Enumerable.Range(6, 18).Select(i => string.Format("{0}pt", i)).ToList();

            SetEditorOptions(options);
        }

        public string Title
        {
            get
            {
                return Strings.EditorOptionsViewTitle;
            }
        }

        public IButtonControl AcceptButton
        {
            get { return btnOk; }
        }

        public IButtonControl CancelButton
        {
            get { return btnCancel; }
        }

        public EditorOptions EditorOptions
        {
            get
            {
                return GetEditorOptions();
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

        private void SetEditorOptions(EditorOptions value)
        {
            cbxFontFamily.SelectedItem = value.FontFamily;
            cbxFontSize.SelectedItem = value.FontSize;
            focFontOptions.FontOptions = value.FontOptions;
            focCommentOptions.FontOptions = value.CommentFontOptions;
            focTagOptions.FontOptions = value.TagFontOptions;
            focParametersOptions.FontOptions = value.ParametersFontOptions;
            focStringsOptions.FontOptions = value.StringsFontOptions;
            focTableOptions.FontOptions = value.TableFontOptions;
            focFeatureKeywordOptions.FontOptions = value.FeatureKeywordFontOptions;
            focStepKeywordOptions.FontOptions = value.StepKeywordFontOptions;
            chkWordWrap.Checked = value.WordWrap;
            chkDisplayLineNumbers.Checked = value.DisplayLineNumbers;
            chkDisplaySymbols.Checked = value.DisplaySymbols;
        }

        private EditorOptions GetEditorOptions()
        {
            var options = new EditorOptions
            {
                FontFamily = (string)cbxFontFamily.SelectedItem,
                FontSize = (string)cbxFontSize.SelectedItem,
                FontOptions = focFontOptions.FontOptions,
                CommentFontOptions = focCommentOptions.FontOptions,
                TagFontOptions = focTagOptions.FontOptions,
                ParametersFontOptions = focParametersOptions.FontOptions,
                StringsFontOptions = focStringsOptions.FontOptions,
                TableFontOptions = focTableOptions.FontOptions,
                FeatureKeywordFontOptions = focFeatureKeywordOptions.FontOptions,
                StepKeywordFontOptions = focStepKeywordOptions.FontOptions,
                WordWrap = chkWordWrap.Checked,
                DisplayLineNumbers = chkDisplayLineNumbers.Checked,
                DisplaySymbols = chkDisplaySymbols.Checked
            };
            return options;
        }
    }
}
