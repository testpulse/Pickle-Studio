namespace PickleStudio.Controls
{
    partial class AboutView
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
            this.btnClose = new System.Windows.Forms.Button();
            this.lblAbout = new System.Windows.Forms.Label();
            this.olvThirdPartyComponents = new BrightIdeasSoftware.ObjectListView();
            this.colName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.colLicense = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvThirdPartyComponents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(534, 321);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 0;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // lblAbout
            // 
            this.lblAbout.AutoSize = true;
            this.lblAbout.Location = new System.Drawing.Point(15, 13);
            this.lblAbout.Name = "lblAbout";
            this.lblAbout.Size = new System.Drawing.Size(322, 13);
            this.lblAbout.TabIndex = 1;
            this.lblAbout.Text = "This application makes use of the following third party components:";
            // 
            // olvThirdPartyComponents
            // 
            this.olvThirdPartyComponents.AllColumns.Add(this.colName);
            this.olvThirdPartyComponents.AllColumns.Add(this.colLicense);
            this.olvThirdPartyComponents.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.olvThirdPartyComponents.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colLicense});
            this.olvThirdPartyComponents.Cursor = System.Windows.Forms.Cursors.Default;
            this.olvThirdPartyComponents.Location = new System.Drawing.Point(18, 40);
            this.olvThirdPartyComponents.Name = "olvThirdPartyComponents";
            this.olvThirdPartyComponents.Size = new System.Drawing.Size(591, 275);
            this.olvThirdPartyComponents.TabIndex = 2;
            this.olvThirdPartyComponents.UseCompatibleStateImageBehavior = false;
            this.olvThirdPartyComponents.UseHyperlinks = true;
            this.olvThirdPartyComponents.View = System.Windows.Forms.View.Details;
            // 
            // colName
            // 
            this.colName.AspectName = "Name";
            this.colName.FillsFreeSpace = true;
            this.colName.Groupable = false;
            this.colName.Hyperlink = true;
            this.colName.IsEditable = false;
            this.colName.Text = "Name";
            // 
            // colLicense
            // 
            this.colLicense.AspectName = "LicenseName";
            this.colLicense.FillsFreeSpace = true;
            this.colLicense.Groupable = false;
            this.colLicense.Hyperlink = true;
            this.colLicense.IsEditable = false;
            this.colLicense.Text = "License";
            // 
            // AboutView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.olvThirdPartyComponents);
            this.Controls.Add(this.lblAbout);
            this.Controls.Add(this.btnClose);
            this.Name = "AboutView";
            this.Size = new System.Drawing.Size(627, 357);
            ((System.ComponentModel.ISupportInitialize)(this.olvThirdPartyComponents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblAbout;
        private BrightIdeasSoftware.ObjectListView olvThirdPartyComponents;
        private BrightIdeasSoftware.OLVColumn colName;
        private BrightIdeasSoftware.OLVColumn colLicense;
    }
}
