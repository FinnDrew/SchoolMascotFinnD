namespace SchoolMascotFinnD
{
    partial class frmSchoolMascot
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
            this.mnuMenu = new System.Windows.Forms.MenuStrip();
            this.mniSchools = new System.Windows.Forms.ToolStripMenuItem();
            this.mniImmaculata = new System.Windows.Forms.ToolStripMenuItem();
            this.mniSaintPauls = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSchool = new System.Windows.Forms.Label();
            this.lblMascot = new System.Windows.Forms.Label();
            this.mniMotherTeresa = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnuMenu
            // 
            this.mnuMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniSchools});
            this.mnuMenu.Location = new System.Drawing.Point(0, 0);
            this.mnuMenu.Name = "mnuMenu";
            this.mnuMenu.Size = new System.Drawing.Size(505, 24);
            this.mnuMenu.TabIndex = 0;
            this.mnuMenu.Text = "Menu";
            // 
            // mniSchools
            // 
            this.mniSchools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mniImmaculata,
            this.mniSaintPauls,
            this.mniMotherTeresa});
            this.mniSchools.Name = "mniSchools";
            this.mniSchools.Size = new System.Drawing.Size(60, 20);
            this.mniSchools.Text = "Schools";
            // 
            // mniImmaculata
            // 
            this.mniImmaculata.Name = "mniImmaculata";
            this.mniImmaculata.Size = new System.Drawing.Size(152, 22);
            this.mniImmaculata.Text = "Immaculata";
            this.mniImmaculata.Click += new System.EventHandler(this.mniImmaculata_Click);
            // 
            // mniSaintPauls
            // 
            this.mniSaintPauls.Name = "mniSaintPauls";
            this.mniSaintPauls.Size = new System.Drawing.Size(152, 22);
            this.mniSaintPauls.Text = "Saint Pauls";
            // 
            // lblSchool
            // 
            this.lblSchool.AutoSize = true;
            this.lblSchool.Location = new System.Drawing.Point(188, 93);
            this.lblSchool.Name = "lblSchool";
            this.lblSchool.Size = new System.Drawing.Size(0, 13);
            this.lblSchool.TabIndex = 1;
            // 
            // lblMascot
            // 
            this.lblMascot.AutoSize = true;
            this.lblMascot.Location = new System.Drawing.Point(188, 133);
            this.lblMascot.Name = "lblMascot";
            this.lblMascot.Size = new System.Drawing.Size(0, 13);
            this.lblMascot.TabIndex = 2;
            // 
            // mniMotherTeresa
            // 
            this.mniMotherTeresa.Name = "mniMotherTeresa";
            this.mniMotherTeresa.Size = new System.Drawing.Size(152, 22);
            this.mniMotherTeresa.Text = "Mother Teresa";
            // 
            // frmSchoolMascot
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(505, 261);
            this.Controls.Add(this.lblMascot);
            this.Controls.Add(this.lblSchool);
            this.Controls.Add(this.mnuMenu);
            this.MainMenuStrip = this.mnuMenu;
            this.Name = "frmSchoolMascot";
            this.Text = "Schools And their Mascots";
            this.mnuMenu.ResumeLayout(false);
            this.mnuMenu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnuMenu;
        private System.Windows.Forms.ToolStripMenuItem mniSchools;
        private System.Windows.Forms.ToolStripMenuItem mniImmaculata;
        private System.Windows.Forms.ToolStripMenuItem mniSaintPauls;
        private System.Windows.Forms.Label lblSchool;
        private System.Windows.Forms.Label lblMascot;
        private System.Windows.Forms.ToolStripMenuItem mniMotherTeresa;
    }
}

