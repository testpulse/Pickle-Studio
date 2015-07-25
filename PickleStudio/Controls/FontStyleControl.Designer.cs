namespace PickleStudio.Controls
{
    partial class FontOptionsControl
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
            this.chkUnderline = new System.Windows.Forms.CheckBox();
            this.cbxFontStyle = new System.Windows.Forms.ComboBox();
            this.cbxFontWeight = new System.Windows.Forms.ComboBox();
            this.lblFontStyle = new System.Windows.Forms.Label();
            this.lblFontWeight = new System.Windows.Forms.Label();
            this.lblTextColor = new System.Windows.Forms.Label();
            this.lblBackgroundColor = new System.Windows.Forms.Label();
            this.txtTextColor = new System.Windows.Forms.TextBox();
            this.txtBackgroundColor = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // chkUnderline
            // 
            this.chkUnderline.AutoSize = true;
            this.chkUnderline.Location = new System.Drawing.Point(666, 4);
            this.chkUnderline.Name = "chkUnderline";
            this.chkUnderline.Size = new System.Drawing.Size(71, 17);
            this.chkUnderline.TabIndex = 0;
            this.chkUnderline.Text = "Underline";
            this.chkUnderline.UseVisualStyleBackColor = true;
            // 
            // cbxFontStyle
            // 
            this.cbxFontStyle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFontStyle.FormattingEnabled = true;
            this.cbxFontStyle.Location = new System.Drawing.Point(539, 0);
            this.cbxFontStyle.Name = "cbxFontStyle";
            this.cbxFontStyle.Size = new System.Drawing.Size(121, 21);
            this.cbxFontStyle.TabIndex = 1;
            // 
            // cbxFontWeight
            // 
            this.cbxFontWeight.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFontWeight.FormattingEnabled = true;
            this.cbxFontWeight.Location = new System.Drawing.Point(373, 0);
            this.cbxFontWeight.Name = "cbxFontWeight";
            this.cbxFontWeight.Size = new System.Drawing.Size(121, 21);
            this.cbxFontWeight.TabIndex = 2;
            // 
            // lblFontStyle
            // 
            this.lblFontStyle.AutoSize = true;
            this.lblFontStyle.Location = new System.Drawing.Point(500, 4);
            this.lblFontStyle.Name = "lblFontStyle";
            this.lblFontStyle.Size = new System.Drawing.Size(33, 13);
            this.lblFontStyle.TabIndex = 3;
            this.lblFontStyle.Text = "Style:";
            // 
            // lblFontWeight
            // 
            this.lblFontWeight.AutoSize = true;
            this.lblFontWeight.Location = new System.Drawing.Point(323, 4);
            this.lblFontWeight.Name = "lblFontWeight";
            this.lblFontWeight.Size = new System.Drawing.Size(44, 13);
            this.lblFontWeight.TabIndex = 4;
            this.lblFontWeight.Text = "Weight:";
            // 
            // lblTextColor
            // 
            this.lblTextColor.AutoSize = true;
            this.lblTextColor.Location = new System.Drawing.Point(0, 4);
            this.lblTextColor.Name = "lblTextColor";
            this.lblTextColor.Size = new System.Drawing.Size(31, 13);
            this.lblTextColor.TabIndex = 5;
            this.lblTextColor.Text = "Text:";
            // 
            // lblBackgroundColor
            // 
            this.lblBackgroundColor.AutoSize = true;
            this.lblBackgroundColor.Location = new System.Drawing.Point(143, 4);
            this.lblBackgroundColor.Name = "lblBackgroundColor";
            this.lblBackgroundColor.Size = new System.Drawing.Size(68, 13);
            this.lblBackgroundColor.TabIndex = 6;
            this.lblBackgroundColor.Text = "Background:";
            // 
            // txtTextColor
            // 
            this.txtTextColor.Location = new System.Drawing.Point(37, 0);
            this.txtTextColor.Name = "txtTextColor";
            this.txtTextColor.ReadOnly = true;
            this.txtTextColor.Size = new System.Drawing.Size(100, 20);
            this.txtTextColor.TabIndex = 7;
            this.txtTextColor.Click += new System.EventHandler(this.txtTextColor_Click);
            // 
            // txtBackgroundColor
            // 
            this.txtBackgroundColor.Location = new System.Drawing.Point(217, 0);
            this.txtBackgroundColor.Name = "txtBackgroundColor";
            this.txtBackgroundColor.ReadOnly = true;
            this.txtBackgroundColor.Size = new System.Drawing.Size(100, 20);
            this.txtBackgroundColor.TabIndex = 8;
            this.txtBackgroundColor.Click += new System.EventHandler(this.txtBackgroundColor_Click);
            // 
            // FontStyleControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtBackgroundColor);
            this.Controls.Add(this.txtTextColor);
            this.Controls.Add(this.lblBackgroundColor);
            this.Controls.Add(this.lblTextColor);
            this.Controls.Add(this.lblFontWeight);
            this.Controls.Add(this.lblFontStyle);
            this.Controls.Add(this.cbxFontWeight);
            this.Controls.Add(this.cbxFontStyle);
            this.Controls.Add(this.chkUnderline);
            this.MaximumSize = new System.Drawing.Size(736, 21);
            this.MinimumSize = new System.Drawing.Size(736, 21);
            this.Name = "FontStyleControl";
            this.Size = new System.Drawing.Size(736, 21);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox chkUnderline;
        private System.Windows.Forms.ComboBox cbxFontStyle;
        private System.Windows.Forms.ComboBox cbxFontWeight;
        private System.Windows.Forms.Label lblFontStyle;
        private System.Windows.Forms.Label lblFontWeight;
        private System.Windows.Forms.Label lblTextColor;
        private System.Windows.Forms.Label lblBackgroundColor;
        private System.Windows.Forms.TextBox txtTextColor;
        private System.Windows.Forms.TextBox txtBackgroundColor;
    }
}
