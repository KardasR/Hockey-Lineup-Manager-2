namespace Hockey_Lineup_Manager_2
{
    partial class MainMenu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            this.Titlelbl = new System.Windows.Forms.Label();
            this.SelectTeambtn = new DevExpress.XtraEditors.SimpleButton();
            this.NewTeambtn = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // Titlelbl
            // 
            this.Titlelbl.AutoSize = true;
            this.Titlelbl.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Titlelbl.Location = new System.Drawing.Point(12, 9);
            this.Titlelbl.Name = "Titlelbl";
            this.Titlelbl.Size = new System.Drawing.Size(617, 65);
            this.Titlelbl.TabIndex = 0;
            this.Titlelbl.Text = "Hockey Lineup Manager 2";
            // 
            // SelectTeambtn
            // 
            this.SelectTeambtn.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectTeambtn.Appearance.Options.UseFont = true;
            this.SelectTeambtn.Location = new System.Drawing.Point(26, 107);
            this.SelectTeambtn.Name = "SelectTeambtn";
            this.SelectTeambtn.Size = new System.Drawing.Size(277, 128);
            this.SelectTeambtn.TabIndex = 1;
            this.SelectTeambtn.Text = "Select Team";
            this.SelectTeambtn.Click += new System.EventHandler(this.SelectTeambtn_Click);
            // 
            // NewTeambtn
            // 
            this.NewTeambtn.Appearance.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NewTeambtn.Appearance.Options.UseFont = true;
            this.NewTeambtn.Location = new System.Drawing.Point(324, 107);
            this.NewTeambtn.Name = "NewTeambtn";
            this.NewTeambtn.Size = new System.Drawing.Size(277, 128);
            this.NewTeambtn.TabIndex = 2;
            this.NewTeambtn.Text = "New Team";
            this.NewTeambtn.Click += new System.EventHandler(this.NewTeambtn_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(635, 260);
            this.Controls.Add(this.NewTeambtn);
            this.Controls.Add(this.SelectTeambtn);
            this.Controls.Add(this.Titlelbl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainMenu";
            this.Text = "Hockey Lineup Manager 2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MainMenu_FormClosed);
            this.Load += new System.EventHandler(this.MainMenu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label Titlelbl;
        private DevExpress.XtraEditors.SimpleButton SelectTeambtn;
        private DevExpress.XtraEditors.SimpleButton NewTeambtn;
    }
}