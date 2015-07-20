namespace PickleStudio
{
    partial class MainForm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.tscMain = new System.Windows.Forms.ToolStripContainer();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.tclMain = new System.Windows.Forms.TabControl();
            this.tbpTest = new System.Windows.Forms.TabPage();
            this.tbpOutput = new System.Windows.Forms.TabPage();
            this.tscMain.ContentPanel.SuspendLayout();
            this.tscMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.SuspendLayout();
            this.tclMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tscMain
            // 
            // 
            // tscMain.ContentPanel
            // 
            this.tscMain.ContentPanel.Controls.Add(this.splitContainer1);
            this.tscMain.ContentPanel.Size = new System.Drawing.Size(1008, 704);
            this.tscMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tscMain.Location = new System.Drawing.Point(0, 0);
            this.tscMain.Name = "tscMain";
            this.tscMain.Size = new System.Drawing.Size(1008, 729);
            this.tscMain.TabIndex = 0;
            this.tscMain.Text = "toolStripContainer1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel2;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tclMain);
            this.splitContainer1.Size = new System.Drawing.Size(1008, 704);
            this.splitContainer1.SplitterDistance = 522;
            this.splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Size = new System.Drawing.Size(1008, 522);
            this.splitContainer2.SplitterDistance = 224;
            this.splitContainer2.TabIndex = 0;
            // 
            // tclMain
            // 
            this.tclMain.Controls.Add(this.tbpTest);
            this.tclMain.Controls.Add(this.tbpOutput);
            this.tclMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tclMain.Location = new System.Drawing.Point(0, 0);
            this.tclMain.Name = "tclMain";
            this.tclMain.SelectedIndex = 0;
            this.tclMain.Size = new System.Drawing.Size(1008, 178);
            this.tclMain.TabIndex = 0;
            // 
            // tbpTest
            // 
            this.tbpTest.Location = new System.Drawing.Point(4, 22);
            this.tbpTest.Name = "tbpTest";
            this.tbpTest.Padding = new System.Windows.Forms.Padding(3);
            this.tbpTest.Size = new System.Drawing.Size(1000, 152);
            this.tbpTest.TabIndex = 1;
            this.tbpTest.Text = "Test";
            this.tbpTest.UseVisualStyleBackColor = true;
            // 
            // tbpOutput
            // 
            this.tbpOutput.Location = new System.Drawing.Point(4, 22);
            this.tbpOutput.Name = "tbpOutput";
            this.tbpOutput.Padding = new System.Windows.Forms.Padding(3);
            this.tbpOutput.Size = new System.Drawing.Size(1000, 152);
            this.tbpOutput.TabIndex = 0;
            this.tbpOutput.Text = "Output";
            this.tbpOutput.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.tscMain);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SpecFlow Editor";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.tscMain.ContentPanel.ResumeLayout(false);
            this.tscMain.ResumeLayout(false);
            this.tscMain.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.tclMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolStripContainer tscMain;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.TabControl tclMain;
        private System.Windows.Forms.TabPage tbpOutput;
        private System.Windows.Forms.TabPage tbpTest;
    }
}

