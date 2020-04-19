namespace WMI_view
{
    partial class frmWmiViewer
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbClasses = new System.Windows.Forms.ListBox();
            this.tbQuerry = new System.Windows.Forms.TextBox();
            this.btnExec = new System.Windows.Forms.Button();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.tabPageInstances = new System.Windows.Forms.TabPage();
            this.lvInstances = new System.Windows.Forms.ListView();
            this.tabPageProperties = new System.Windows.Forms.TabPage();
            this.lvProperties = new System.Windows.Forms.ListView();
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCIMType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOrigins = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabPageMethods = new System.Windows.Forms.TabPage();
            this.lvMethods = new System.Windows.Forms.ListView();
            this.colNam = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colMDescription = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colInP = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colOut = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.tabControl.SuspendLayout();
            this.tabPageInstances.SuspendLayout();
            this.tabPageProperties.SuspendLayout();
            this.tabPageMethods.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbClasses
            // 
            this.lbClasses.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lbClasses.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbClasses.FormattingEnabled = true;
            this.lbClasses.Location = new System.Drawing.Point(12, 12);
            this.lbClasses.Name = "lbClasses";
            this.lbClasses.ScrollAlwaysVisible = true;
            this.lbClasses.Size = new System.Drawing.Size(225, 444);
            this.lbClasses.Sorted = true;
            this.lbClasses.TabIndex = 1;
            this.lbClasses.DoubleClick += new System.EventHandler(this.lbClasses_DoubleClick);
            // 
            // tbQuerry
            // 
            this.tbQuerry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tbQuerry.Location = new System.Drawing.Point(243, 12);
            this.tbQuerry.Name = "tbQuerry";
            this.tbQuerry.Size = new System.Drawing.Size(634, 20);
            this.tbQuerry.TabIndex = 3;
            // 
            // btnExec
            // 
            this.btnExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExec.Location = new System.Drawing.Point(883, 12);
            this.btnExec.Name = "btnExec";
            this.btnExec.Size = new System.Drawing.Size(75, 20);
            this.btnExec.TabIndex = 4;
            this.btnExec.Text = "&Execute";
            this.btnExec.UseVisualStyleBackColor = true;
            this.btnExec.Click += new System.EventHandler(this.btnExec_Click);
            // 
            // tabControl
            // 
            this.tabControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl.Controls.Add(this.tabPageInstances);
            this.tabControl.Controls.Add(this.tabPageProperties);
            this.tabControl.Controls.Add(this.tabPageMethods);
            this.tabControl.Location = new System.Drawing.Point(243, 39);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(715, 417);
            this.tabControl.TabIndex = 5;
            // 
            // tabPageInstances
            // 
            this.tabPageInstances.Controls.Add(this.lvInstances);
            this.tabPageInstances.Location = new System.Drawing.Point(4, 22);
            this.tabPageInstances.Name = "tabPageInstances";
            this.tabPageInstances.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageInstances.Size = new System.Drawing.Size(707, 391);
            this.tabPageInstances.TabIndex = 0;
            this.tabPageInstances.Text = "Instances";
            this.tabPageInstances.UseVisualStyleBackColor = true;
            // 
            // lvInstances
            // 
            this.lvInstances.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvInstances.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvInstances.FullRowSelect = true;
            this.lvInstances.GridLines = true;
            this.lvInstances.HideSelection = false;
            this.lvInstances.Location = new System.Drawing.Point(6, 6);
            this.lvInstances.Name = "lvInstances";
            this.lvInstances.Size = new System.Drawing.Size(695, 379);
            this.lvInstances.TabIndex = 3;
            this.lvInstances.UseCompatibleStateImageBehavior = false;
            this.lvInstances.View = System.Windows.Forms.View.Details;
            // 
            // tabPageProperties
            // 
            this.tabPageProperties.Controls.Add(this.lvProperties);
            this.tabPageProperties.Location = new System.Drawing.Point(4, 22);
            this.tabPageProperties.Name = "tabPageProperties";
            this.tabPageProperties.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageProperties.Size = new System.Drawing.Size(707, 391);
            this.tabPageProperties.TabIndex = 1;
            this.tabPageProperties.Text = "Properties";
            this.tabPageProperties.UseVisualStyleBackColor = true;
            // 
            // lvProperties
            // 
            this.lvProperties.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvProperties.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvProperties.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colName,
            this.colCIMType,
            this.colOrigins,
            this.colPDescription});
            this.lvProperties.FullRowSelect = true;
            this.lvProperties.GridLines = true;
            this.lvProperties.HideSelection = false;
            this.lvProperties.Location = new System.Drawing.Point(6, 6);
            this.lvProperties.Name = "lvProperties";
            this.lvProperties.Size = new System.Drawing.Size(695, 379);
            this.lvProperties.TabIndex = 4;
            this.lvProperties.UseCompatibleStateImageBehavior = false;
            this.lvProperties.View = System.Windows.Forms.View.Details;
            this.lvProperties.DoubleClick += new System.EventHandler(this.lvProperties_DoubleClick);
            // 
            // colName
            // 
            this.colName.Text = "Name";
            this.colName.Width = 150;
            // 
            // colCIMType
            // 
            this.colCIMType.Text = "CIM Type";
            this.colCIMType.Width = 150;
            // 
            // colOrigins
            // 
            this.colOrigins.Text = "Origin";
            this.colOrigins.Width = 150;
            // 
            // colPDescription
            // 
            this.colPDescription.Text = "Description";
            this.colPDescription.Width = 150;
            // 
            // tabPageMethods
            // 
            this.tabPageMethods.Controls.Add(this.lvMethods);
            this.tabPageMethods.Location = new System.Drawing.Point(4, 22);
            this.tabPageMethods.Name = "tabPageMethods";
            this.tabPageMethods.Size = new System.Drawing.Size(707, 391);
            this.tabPageMethods.TabIndex = 2;
            this.tabPageMethods.Text = "Methods";
            this.tabPageMethods.UseVisualStyleBackColor = true;
            // 
            // lvMethods
            // 
            this.lvMethods.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvMethods.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvMethods.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colNam,
            this.colMDescription,
            this.colInP,
            this.colOut});
            this.lvMethods.FullRowSelect = true;
            this.lvMethods.GridLines = true;
            this.lvMethods.HideSelection = false;
            this.lvMethods.Location = new System.Drawing.Point(6, 6);
            this.lvMethods.Name = "lvMethods";
            this.lvMethods.Size = new System.Drawing.Size(695, 379);
            this.lvMethods.TabIndex = 5;
            this.lvMethods.UseCompatibleStateImageBehavior = false;
            this.lvMethods.View = System.Windows.Forms.View.Details;
            this.lvMethods.DoubleClick += new System.EventHandler(this.lvMethods_DoubleClick);
            // 
            // colNam
            // 
            this.colNam.Text = "Name";
            this.colNam.Width = 150;
            // 
            // colMDescription
            // 
            this.colMDescription.DisplayIndex = 3;
            this.colMDescription.Text = "Description";
            this.colMDescription.Width = 300;
            // 
            // colInP
            // 
            this.colInP.DisplayIndex = 1;
            this.colInP.Text = "In Parameters";
            this.colInP.Width = 120;
            // 
            // colOut
            // 
            this.colOut.DisplayIndex = 2;
            this.colOut.Text = "Out Parameters";
            this.colOut.Width = 120;
            // 
            // frmWmiViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 467);
            this.Controls.Add(this.tabControl);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.tbQuerry);
            this.Controls.Add(this.lbClasses);
            this.Name = "frmWmiViewer";
            this.Text = "WMI Viewer";
            this.tabControl.ResumeLayout(false);
            this.tabPageInstances.ResumeLayout(false);
            this.tabPageProperties.ResumeLayout(false);
            this.tabPageMethods.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbClasses;
        private System.Windows.Forms.TextBox tbQuerry;
        private System.Windows.Forms.Button btnExec;
        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage tabPageInstances;
        private System.Windows.Forms.ListView lvInstances;
        private System.Windows.Forms.TabPage tabPageProperties;
        private System.Windows.Forms.TabPage tabPageMethods;
        private System.Windows.Forms.ListView lvProperties;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colCIMType;
        private System.Windows.Forms.ColumnHeader colOrigins;
        private System.Windows.Forms.ListView lvMethods;
        private System.Windows.Forms.ColumnHeader colNam;
        private System.Windows.Forms.ColumnHeader colMDescription;
        private System.Windows.Forms.ColumnHeader colPDescription;
        private System.Windows.Forms.ColumnHeader colInP;
        private System.Windows.Forms.ColumnHeader colOut;
    }
}

