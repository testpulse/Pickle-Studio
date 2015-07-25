namespace PickleStudio.Views
{
    partial class ProjectView
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
            this.olvProject = new BrightIdeasSoftware.ObjectListView();
            this.colName = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.olvProject)).BeginInit();
            this.SuspendLayout();
            // 
            // olvProject
            // 
            this.olvProject.AllColumns.Add(this.colName);
            this.olvProject.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.olvProject.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName});
            this.olvProject.Dock = System.Windows.Forms.DockStyle.Fill;
            this.olvProject.FullRowSelect = true;
            this.olvProject.HideSelection = false;
            this.olvProject.Location = new System.Drawing.Point(0, 0);
            this.olvProject.Name = "olvProject";
            this.olvProject.Size = new System.Drawing.Size(295, 343);
            this.olvProject.TabIndex = 0;
            this.olvProject.UseCompatibleStateImageBehavior = false;
            this.olvProject.View = System.Windows.Forms.View.Details;
            this.olvProject.ItemSelectionChanged += new System.Windows.Forms.ListViewItemSelectionChangedEventHandler(this.olvProject_ItemSelectionChanged);
            // 
            // colName
            // 
            this.colName.AspectName = "Name";
            this.colName.FillsFreeSpace = true;
            this.colName.Groupable = false;
            this.colName.IsEditable = false;
            this.colName.Text = "Feature";
            // 
            // ProjectView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.olvProject);
            this.Name = "ProjectView";
            this.Size = new System.Drawing.Size(295, 343);
            ((System.ComponentModel.ISupportInitialize)(this.olvProject)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BrightIdeasSoftware.ObjectListView olvProject;
        private BrightIdeasSoftware.OLVColumn colName;

    }
}
