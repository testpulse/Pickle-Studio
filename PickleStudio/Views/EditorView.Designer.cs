namespace PickleStudio.Views
{
    partial class EditorView
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ehoEditor = new System.Windows.Forms.Integration.ElementHost();
            this.SuspendLayout();
            // 
            // ehoEditor
            // 
            this.ehoEditor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ehoEditor.Location = new System.Drawing.Point(0, 0);
            this.ehoEditor.Name = "ehoEditor";
            this.ehoEditor.Size = new System.Drawing.Size(676, 462);
            this.ehoEditor.TabIndex = 0;
            this.ehoEditor.Child = null;
            // 
            // EditorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ehoEditor);
            this.Name = "EditorView";
            this.Size = new System.Drawing.Size(676, 462);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Integration.ElementHost ehoEditor;
    }
}
