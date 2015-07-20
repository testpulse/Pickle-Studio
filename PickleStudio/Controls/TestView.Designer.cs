namespace PickleStudio.Controls
{
    partial class TestView
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
            this.components = new System.ComponentModel.Container();
            this.tscTest = new System.Windows.Forms.ToolStripContainer();
            this.tlvTest = new BrightIdeasSoftware.TreeListView();
            this.tscTest.ContentPanel.SuspendLayout();
            this.tscTest.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlvTest)).BeginInit();
            this.SuspendLayout();
            // 
            // tscTest
            // 
            // 
            // tscTest.ContentPanel
            // 
            this.tscTest.ContentPanel.Controls.Add(this.tlvTest);
            this.tscTest.ContentPanel.Size = new System.Drawing.Size(670, 320);
            this.tscTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscTest.Location = new System.Drawing.Point(0, 0);
            this.tscTest.Name = "tscTest";
            this.tscTest.Size = new System.Drawing.Size(670, 345);
            this.tscTest.TabIndex = 2;
            this.tscTest.Text = "toolStripContainer1";
            // 
            // tlvTest
            // 
            this.tlvTest.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tlvTest.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tlvTest.Location = new System.Drawing.Point(0, 0);
            this.tlvTest.Name = "tlvTest";
            this.tlvTest.OwnerDraw = true;
            this.tlvTest.ShowGroups = false;
            this.tlvTest.Size = new System.Drawing.Size(670, 320);
            this.tlvTest.TabIndex = 2;
            this.tlvTest.UseCompatibleStateImageBehavior = false;
            this.tlvTest.View = System.Windows.Forms.View.Details;
            this.tlvTest.VirtualMode = true;
            // 
            // TestView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tscTest);
            this.Name = "TestView";
            this.Size = new System.Drawing.Size(670, 345);
            this.tscTest.ContentPanel.ResumeLayout(false);
            this.tscTest.ResumeLayout(false);
            this.tscTest.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tlvTest)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscTest;
        private BrightIdeasSoftware.TreeListView tlvTest;

    }
}
