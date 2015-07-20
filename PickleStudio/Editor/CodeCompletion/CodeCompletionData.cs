using ICSharpCode.AvalonEdit.CodeCompletion;
using ICSharpCode.AvalonEdit.Document;
using ICSharpCode.AvalonEdit.Editing;
using System;
using System.Windows.Media;

namespace PickleStudio.Editor.CodeCompletion
{
    public class CodeCompletionData : ICompletionData
    {
        public CodeCompletionData(string text)
        {
            this.Text = text;
        }

        public ImageSource Image
        {
            get { return null; }
        }


        public double Priority
        {
            get { return 0; }
        }

        public string Text { get; private set; }

        public object Content
        {
            get { return Text; }
        }

        public object Description
        {
            get { return null; }
        }

        public void Complete(TextArea textArea, ISegment completionSegment, EventArgs insertionRequestEventArgs)
        {
            textArea.Document.Replace(completionSegment, Text);
        }
    }
}
