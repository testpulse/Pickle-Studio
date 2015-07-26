namespace PickleStudio.Views
{
    partial class EditorOptionsView
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
            PickleStudio.Core.Options.FontOptions fontOptions1 = new PickleStudio.Core.Options.FontOptions();
            PickleStudio.Core.Options.FontOptions fontOptions2 = new PickleStudio.Core.Options.FontOptions();
            PickleStudio.Core.Options.FontOptions fontOptions3 = new PickleStudio.Core.Options.FontOptions();
            PickleStudio.Core.Options.FontOptions fontOptions4 = new PickleStudio.Core.Options.FontOptions();
            PickleStudio.Core.Options.FontOptions fontOptions5 = new PickleStudio.Core.Options.FontOptions();
            PickleStudio.Core.Options.FontOptions fontOptions6 = new PickleStudio.Core.Options.FontOptions();
            PickleStudio.Core.Options.FontOptions fontOptions7 = new PickleStudio.Core.Options.FontOptions();
            PickleStudio.Core.Options.FontOptions fontOptions8 = new PickleStudio.Core.Options.FontOptions();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.lblFontOptions = new System.Windows.Forms.Label();
            this.lblFontSize = new System.Windows.Forms.Label();
            this.lblStepKeywordOptions = new System.Windows.Forms.Label();
            this.lblTagOptions = new System.Windows.Forms.Label();
            this.lblCommentOptions = new System.Windows.Forms.Label();
            this.lblFeatureKeywordOptions = new System.Windows.Forms.Label();
            this.lblStringsOptions = new System.Windows.Forms.Label();
            this.lblTableOptions = new System.Windows.Forms.Label();
            this.lblParametersOptions = new System.Windows.Forms.Label();
            this.lblFontFamily = new System.Windows.Forms.Label();
            this.cbxFontFamily = new System.Windows.Forms.ComboBox();
            this.cbxFontSize = new System.Windows.Forms.ComboBox();
            this.chkDisplaySymbols = new System.Windows.Forms.CheckBox();
            this.chkDisplayLineNumbers = new System.Windows.Forms.CheckBox();
            this.chkWordWrap = new System.Windows.Forms.CheckBox();
            this.focStepKeywordOptions = new PickleStudio.Views.Controls.FontOptionsControl();
            this.focFeatureKeywordOptions = new PickleStudio.Views.Controls.FontOptionsControl();
            this.focTableOptions = new PickleStudio.Views.Controls.FontOptionsControl();
            this.focStringsOptions = new PickleStudio.Views.Controls.FontOptionsControl();
            this.focParametersOptions = new PickleStudio.Views.Controls.FontOptionsControl();
            this.focTagOptions = new PickleStudio.Views.Controls.FontOptionsControl();
            this.focCommentOptions = new PickleStudio.Views.Controls.FontOptionsControl();
            this.focFontOptions = new PickleStudio.Views.Controls.FontOptionsControl();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancel.Location = new System.Drawing.Point(841, 355);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOk
            // 
            this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnOk.Location = new System.Drawing.Point(760, 355);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(75, 23);
            this.btnOk.TabIndex = 2;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
            // 
            // lblFontOptions
            // 
            this.lblFontOptions.AutoSize = true;
            this.lblFontOptions.Location = new System.Drawing.Point(10, 66);
            this.lblFontOptions.Name = "lblFontOptions";
            this.lblFontOptions.Size = new System.Drawing.Size(55, 13);
            this.lblFontOptions.TabIndex = 48;
            this.lblFontOptions.Text = "Font style:";
            // 
            // lblFontSize
            // 
            this.lblFontSize.AutoSize = true;
            this.lblFontSize.Location = new System.Drawing.Point(10, 42);
            this.lblFontSize.Name = "lblFontSize";
            this.lblFontSize.Size = new System.Drawing.Size(52, 13);
            this.lblFontSize.TabIndex = 47;
            this.lblFontSize.Text = "Font size:";
            // 
            // lblStepKeywordOptions
            // 
            this.lblStepKeywordOptions.AutoSize = true;
            this.lblStepKeywordOptions.Location = new System.Drawing.Point(10, 255);
            this.lblStepKeywordOptions.Name = "lblStepKeywordOptions";
            this.lblStepKeywordOptions.Size = new System.Drawing.Size(99, 13);
            this.lblStepKeywordOptions.TabIndex = 46;
            this.lblStepKeywordOptions.Text = "Step keyword style:";
            // 
            // lblTagOptions
            // 
            this.lblTagOptions.AutoSize = true;
            this.lblTagOptions.Location = new System.Drawing.Point(10, 120);
            this.lblTagOptions.Name = "lblTagOptions";
            this.lblTagOptions.Size = new System.Drawing.Size(53, 13);
            this.lblTagOptions.TabIndex = 45;
            this.lblTagOptions.Text = "Tag style:";
            // 
            // lblCommentOptions
            // 
            this.lblCommentOptions.AutoSize = true;
            this.lblCommentOptions.Location = new System.Drawing.Point(10, 93);
            this.lblCommentOptions.Name = "lblCommentOptions";
            this.lblCommentOptions.Size = new System.Drawing.Size(78, 13);
            this.lblCommentOptions.TabIndex = 44;
            this.lblCommentOptions.Text = "Comment style:";
            // 
            // lblFeatureKeywordOptions
            // 
            this.lblFeatureKeywordOptions.AutoSize = true;
            this.lblFeatureKeywordOptions.Location = new System.Drawing.Point(10, 228);
            this.lblFeatureKeywordOptions.Name = "lblFeatureKeywordOptions";
            this.lblFeatureKeywordOptions.Size = new System.Drawing.Size(113, 13);
            this.lblFeatureKeywordOptions.TabIndex = 43;
            this.lblFeatureKeywordOptions.Text = "Feature keyword style:";
            // 
            // lblStringsOptions
            // 
            this.lblStringsOptions.AutoSize = true;
            this.lblStringsOptions.Location = new System.Drawing.Point(10, 174);
            this.lblStringsOptions.Name = "lblStringsOptions";
            this.lblStringsOptions.Size = new System.Drawing.Size(66, 13);
            this.lblStringsOptions.TabIndex = 42;
            this.lblStringsOptions.Text = "Strings style:";
            // 
            // lblTableOptions
            // 
            this.lblTableOptions.AutoSize = true;
            this.lblTableOptions.Location = new System.Drawing.Point(10, 201);
            this.lblTableOptions.Name = "lblTableOptions";
            this.lblTableOptions.Size = new System.Drawing.Size(90, 13);
            this.lblTableOptions.TabIndex = 41;
            this.lblTableOptions.Text = "Table value style:";
            // 
            // lblParametersOptions
            // 
            this.lblParametersOptions.AutoSize = true;
            this.lblParametersOptions.Location = new System.Drawing.Point(10, 147);
            this.lblParametersOptions.Name = "lblParametersOptions";
            this.lblParametersOptions.Size = new System.Drawing.Size(87, 13);
            this.lblParametersOptions.TabIndex = 40;
            this.lblParametersOptions.Text = "Parameters style:";
            // 
            // lblFontFamily
            // 
            this.lblFontFamily.AutoSize = true;
            this.lblFontFamily.Location = new System.Drawing.Point(10, 15);
            this.lblFontFamily.Name = "lblFontFamily";
            this.lblFontFamily.Size = new System.Drawing.Size(60, 13);
            this.lblFontFamily.TabIndex = 39;
            this.lblFontFamily.Text = "Font family:";
            // 
            // cbxFontFamily
            // 
            this.cbxFontFamily.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFontFamily.FormattingEnabled = true;
            this.cbxFontFamily.Location = new System.Drawing.Point(182, 12);
            this.cbxFontFamily.Name = "cbxFontFamily";
            this.cbxFontFamily.Size = new System.Drawing.Size(214, 21);
            this.cbxFontFamily.TabIndex = 38;
            // 
            // cbxFontSize
            // 
            this.cbxFontSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxFontSize.FormattingEnabled = true;
            this.cbxFontSize.Location = new System.Drawing.Point(182, 39);
            this.cbxFontSize.Name = "cbxFontSize";
            this.cbxFontSize.Size = new System.Drawing.Size(214, 21);
            this.cbxFontSize.TabIndex = 37;
            // 
            // chkDisplaySymbols
            // 
            this.chkDisplaySymbols.AutoSize = true;
            this.chkDisplaySymbols.Location = new System.Drawing.Point(181, 328);
            this.chkDisplaySymbols.Name = "chkDisplaySymbols";
            this.chkDisplaySymbols.Size = new System.Drawing.Size(100, 17);
            this.chkDisplaySymbols.TabIndex = 36;
            this.chkDisplaySymbols.Text = "Display symbols";
            this.chkDisplaySymbols.UseVisualStyleBackColor = true;
            // 
            // chkDisplayLineNumbers
            // 
            this.chkDisplayLineNumbers.AutoSize = true;
            this.chkDisplayLineNumbers.Location = new System.Drawing.Point(181, 305);
            this.chkDisplayLineNumbers.Name = "chkDisplayLineNumbers";
            this.chkDisplayLineNumbers.Size = new System.Drawing.Size(122, 17);
            this.chkDisplayLineNumbers.TabIndex = 35;
            this.chkDisplayLineNumbers.Text = "Display line numbers";
            this.chkDisplayLineNumbers.UseVisualStyleBackColor = true;
            // 
            // chkWordWrap
            // 
            this.chkWordWrap.AutoSize = true;
            this.chkWordWrap.Location = new System.Drawing.Point(182, 282);
            this.chkWordWrap.Name = "chkWordWrap";
            this.chkWordWrap.Size = new System.Drawing.Size(78, 17);
            this.chkWordWrap.TabIndex = 34;
            this.chkWordWrap.Text = "Word wrap";
            this.chkWordWrap.UseVisualStyleBackColor = true;
            // 
            // focStepKeywordOptions
            // 
            fontOptions1.BackgroundColor = System.Windows.Media.Color.FromArgb(((byte)(255)), ((byte)(240)), ((byte)(240)), ((byte)(240)));
            fontOptions1.TextColor = System.Windows.Media.Color.FromArgb(((byte)(255)), ((byte)(240)), ((byte)(240)), ((byte)(240)));
            fontOptions1.Underline = false;
            fontOptions1.Weight = System.Windows.FontWeight.FromOpenTypeWeight(900);
            this.focStepKeywordOptions.FontOptions = fontOptions1;
            this.focStepKeywordOptions.Location = new System.Drawing.Point(182, 255);
            this.focStepKeywordOptions.MaximumSize = new System.Drawing.Size(736, 21);
            this.focStepKeywordOptions.MinimumSize = new System.Drawing.Size(736, 21);
            this.focStepKeywordOptions.Name = "focStepKeywordOptions";
            this.focStepKeywordOptions.Size = new System.Drawing.Size(736, 21);
            this.focStepKeywordOptions.TabIndex = 33;
            // 
            // focFeatureKeywordOptions
            // 
            fontOptions2.BackgroundColor = System.Windows.Media.Color.FromArgb(((byte)(255)), ((byte)(240)), ((byte)(240)), ((byte)(240)));
            fontOptions2.TextColor = System.Windows.Media.Color.FromArgb(((byte)(255)), ((byte)(240)), ((byte)(240)), ((byte)(240)));
            fontOptions2.Underline = false;
            fontOptions2.Weight = System.Windows.FontWeight.FromOpenTypeWeight(900);
            this.focFeatureKeywordOptions.FontOptions = fontOptions2;
            this.focFeatureKeywordOptions.Location = new System.Drawing.Point(182, 228);
            this.focFeatureKeywordOptions.MaximumSize = new System.Drawing.Size(736, 21);
            this.focFeatureKeywordOptions.MinimumSize = new System.Drawing.Size(736, 21);
            this.focFeatureKeywordOptions.Name = "focFeatureKeywordOptions";
            this.focFeatureKeywordOptions.Size = new System.Drawing.Size(736, 21);
            this.focFeatureKeywordOptions.TabIndex = 32;
            // 
            // focTableOptions
            // 
            fontOptions3.BackgroundColor = System.Windows.Media.Color.FromArgb(((byte)(255)), ((byte)(240)), ((byte)(240)), ((byte)(240)));
            fontOptions3.TextColor = System.Windows.Media.Color.FromArgb(((byte)(255)), ((byte)(240)), ((byte)(240)), ((byte)(240)));
            fontOptions3.Underline = false;
            fontOptions3.Weight = System.Windows.FontWeight.FromOpenTypeWeight(900);
            this.focTableOptions.FontOptions = fontOptions3;
            this.focTableOptions.Location = new System.Drawing.Point(182, 201);
            this.focTableOptions.MaximumSize = new System.Drawing.Size(736, 21);
            this.focTableOptions.MinimumSize = new System.Drawing.Size(736, 21);
            this.focTableOptions.Name = "focTableOptions";
            this.focTableOptions.Size = new System.Drawing.Size(736, 21);
            this.focTableOptions.TabIndex = 31;
            // 
            // focStringsOptions
            // 
            fontOptions4.BackgroundColor = System.Windows.Media.Color.FromArgb(((byte)(255)), ((byte)(240)), ((byte)(240)), ((byte)(240)));
            fontOptions4.TextColor = System.Windows.Media.Color.FromArgb(((byte)(255)), ((byte)(240)), ((byte)(240)), ((byte)(240)));
            fontOptions4.Underline = false;
            fontOptions4.Weight = System.Windows.FontWeight.FromOpenTypeWeight(900);
            this.focStringsOptions.FontOptions = fontOptions4;
            this.focStringsOptions.Location = new System.Drawing.Point(182, 174);
            this.focStringsOptions.MaximumSize = new System.Drawing.Size(736, 21);
            this.focStringsOptions.MinimumSize = new System.Drawing.Size(736, 21);
            this.focStringsOptions.Name = "focStringsOptions";
            this.focStringsOptions.Size = new System.Drawing.Size(736, 21);
            this.focStringsOptions.TabIndex = 30;
            // 
            // focParametersOptions
            // 
            fontOptions5.BackgroundColor = System.Windows.Media.Color.FromArgb(((byte)(255)), ((byte)(240)), ((byte)(240)), ((byte)(240)));
            fontOptions5.TextColor = System.Windows.Media.Color.FromArgb(((byte)(255)), ((byte)(240)), ((byte)(240)), ((byte)(240)));
            fontOptions5.Underline = false;
            fontOptions5.Weight = System.Windows.FontWeight.FromOpenTypeWeight(900);
            this.focParametersOptions.FontOptions = fontOptions5;
            this.focParametersOptions.Location = new System.Drawing.Point(182, 147);
            this.focParametersOptions.MaximumSize = new System.Drawing.Size(736, 21);
            this.focParametersOptions.MinimumSize = new System.Drawing.Size(736, 21);
            this.focParametersOptions.Name = "focParametersOptions";
            this.focParametersOptions.Size = new System.Drawing.Size(736, 21);
            this.focParametersOptions.TabIndex = 29;
            // 
            // focTagOptions
            // 
            fontOptions6.BackgroundColor = System.Windows.Media.Color.FromArgb(((byte)(255)), ((byte)(240)), ((byte)(240)), ((byte)(240)));
            fontOptions6.TextColor = System.Windows.Media.Color.FromArgb(((byte)(255)), ((byte)(240)), ((byte)(240)), ((byte)(240)));
            fontOptions6.Underline = false;
            fontOptions6.Weight = System.Windows.FontWeight.FromOpenTypeWeight(900);
            this.focTagOptions.FontOptions = fontOptions6;
            this.focTagOptions.Location = new System.Drawing.Point(182, 120);
            this.focTagOptions.MaximumSize = new System.Drawing.Size(736, 21);
            this.focTagOptions.MinimumSize = new System.Drawing.Size(736, 21);
            this.focTagOptions.Name = "focTagOptions";
            this.focTagOptions.Size = new System.Drawing.Size(736, 21);
            this.focTagOptions.TabIndex = 28;
            // 
            // focCommentOptions
            // 
            fontOptions7.BackgroundColor = System.Windows.Media.Color.FromArgb(((byte)(255)), ((byte)(240)), ((byte)(240)), ((byte)(240)));
            fontOptions7.TextColor = System.Windows.Media.Color.FromArgb(((byte)(255)), ((byte)(240)), ((byte)(240)), ((byte)(240)));
            fontOptions7.Underline = false;
            fontOptions7.Weight = System.Windows.FontWeight.FromOpenTypeWeight(900);
            this.focCommentOptions.FontOptions = fontOptions7;
            this.focCommentOptions.Location = new System.Drawing.Point(182, 93);
            this.focCommentOptions.MaximumSize = new System.Drawing.Size(736, 21);
            this.focCommentOptions.MinimumSize = new System.Drawing.Size(736, 21);
            this.focCommentOptions.Name = "focCommentOptions";
            this.focCommentOptions.Size = new System.Drawing.Size(736, 21);
            this.focCommentOptions.TabIndex = 27;
            // 
            // focFontOptions
            // 
            fontOptions8.BackgroundColor = System.Windows.Media.Color.FromArgb(((byte)(255)), ((byte)(240)), ((byte)(240)), ((byte)(240)));
            fontOptions8.TextColor = System.Windows.Media.Color.FromArgb(((byte)(255)), ((byte)(240)), ((byte)(240)), ((byte)(240)));
            fontOptions8.Underline = false;
            fontOptions8.Weight = System.Windows.FontWeight.FromOpenTypeWeight(900);
            this.focFontOptions.FontOptions = fontOptions8;
            this.focFontOptions.Location = new System.Drawing.Point(182, 66);
            this.focFontOptions.MaximumSize = new System.Drawing.Size(736, 21);
            this.focFontOptions.MinimumSize = new System.Drawing.Size(736, 21);
            this.focFontOptions.Name = "focFontOptions";
            this.focFontOptions.Size = new System.Drawing.Size(736, 21);
            this.focFontOptions.TabIndex = 26;
            // 
            // EditorOptionsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFontOptions);
            this.Controls.Add(this.lblFontSize);
            this.Controls.Add(this.lblStepKeywordOptions);
            this.Controls.Add(this.lblTagOptions);
            this.Controls.Add(this.lblCommentOptions);
            this.Controls.Add(this.lblFeatureKeywordOptions);
            this.Controls.Add(this.lblStringsOptions);
            this.Controls.Add(this.lblTableOptions);
            this.Controls.Add(this.lblParametersOptions);
            this.Controls.Add(this.lblFontFamily);
            this.Controls.Add(this.cbxFontFamily);
            this.Controls.Add(this.cbxFontSize);
            this.Controls.Add(this.chkDisplaySymbols);
            this.Controls.Add(this.chkDisplayLineNumbers);
            this.Controls.Add(this.chkWordWrap);
            this.Controls.Add(this.focStepKeywordOptions);
            this.Controls.Add(this.focFeatureKeywordOptions);
            this.Controls.Add(this.focTableOptions);
            this.Controls.Add(this.focStringsOptions);
            this.Controls.Add(this.focParametersOptions);
            this.Controls.Add(this.focTagOptions);
            this.Controls.Add(this.focCommentOptions);
            this.Controls.Add(this.focFontOptions);
            this.Controls.Add(this.btnOk);
            this.Controls.Add(this.btnCancel);
            this.Name = "EditorOptionsView";
            this.Size = new System.Drawing.Size(929, 392);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label lblFontOptions;
        private System.Windows.Forms.Label lblFontSize;
        private System.Windows.Forms.Label lblStepKeywordOptions;
        private System.Windows.Forms.Label lblTagOptions;
        private System.Windows.Forms.Label lblCommentOptions;
        private System.Windows.Forms.Label lblFeatureKeywordOptions;
        private System.Windows.Forms.Label lblStringsOptions;
        private System.Windows.Forms.Label lblTableOptions;
        private System.Windows.Forms.Label lblParametersOptions;
        private System.Windows.Forms.Label lblFontFamily;
        private System.Windows.Forms.ComboBox cbxFontFamily;
        private System.Windows.Forms.ComboBox cbxFontSize;
        private System.Windows.Forms.CheckBox chkDisplaySymbols;
        private System.Windows.Forms.CheckBox chkDisplayLineNumbers;
        private System.Windows.Forms.CheckBox chkWordWrap;
        private Controls.FontOptionsControl focStepKeywordOptions;
        private Controls.FontOptionsControl focFeatureKeywordOptions;
        private Controls.FontOptionsControl focTableOptions;
        private Controls.FontOptionsControl focStringsOptions;
        private Controls.FontOptionsControl focParametersOptions;
        private Controls.FontOptionsControl focTagOptions;
        private Controls.FontOptionsControl focCommentOptions;
        private Controls.FontOptionsControl focFontOptions;
    }
}
