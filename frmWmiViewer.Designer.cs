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
            this.lvData = new System.Windows.Forms.ListView();
            this.tbQuerry = new System.Windows.Forms.TextBox();
            this.btnExec = new System.Windows.Forms.Button();
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
            // lvData
            // 
            this.lvData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lvData.FullRowSelect = true;
            this.lvData.GridLines = true;
            this.lvData.HideSelection = false;
            this.lvData.Location = new System.Drawing.Point(243, 38);
            this.lvData.Name = "lvData";
            this.lvData.Size = new System.Drawing.Size(715, 424);
            this.lvData.TabIndex = 2;
            this.lvData.UseCompatibleStateImageBehavior = false;
            this.lvData.View = System.Windows.Forms.View.Details;
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(970, 467);
            this.Controls.Add(this.btnExec);
            this.Controls.Add(this.tbQuerry);
            this.Controls.Add(this.lvData);
            this.Controls.Add(this.lbClasses);
            this.Name = "Form1";
            this.Text = "WMI Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbClasses;
        private System.Windows.Forms.ListView lvData;
        private System.Windows.Forms.TextBox tbQuerry;
        private System.Windows.Forms.Button btnExec;
    }
}

