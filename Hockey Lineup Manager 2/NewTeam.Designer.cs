namespace Hockey_Lineup_Manager_2
{
    partial class NewTeam
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NewTeam));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.NHLtb = new System.Windows.Forms.TextBox();
            this.AHLtb = new System.Windows.Forms.TextBox();
            this.CreateTeambtn = new System.Windows.Forms.Button();
            this.Starttb = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(29, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "NHL Team";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(31, 101);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "AHL Team";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(12, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Starting Year";
            // 
            // NHLtb
            // 
            this.NHLtb.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.NHLtb.Location = new System.Drawing.Point(116, 22);
            this.NHLtb.Name = "NHLtb";
            this.NHLtb.Size = new System.Drawing.Size(426, 39);
            this.NHLtb.TabIndex = 4;
            // 
            // AHLtb
            // 
            this.AHLtb.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AHLtb.Location = new System.Drawing.Point(116, 89);
            this.AHLtb.Name = "AHLtb";
            this.AHLtb.Size = new System.Drawing.Size(426, 39);
            this.AHLtb.TabIndex = 5;
            // 
            // CreateTeambtn
            // 
            this.CreateTeambtn.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CreateTeambtn.Location = new System.Drawing.Point(256, 144);
            this.CreateTeambtn.Name = "CreateTeambtn";
            this.CreateTeambtn.Size = new System.Drawing.Size(276, 54);
            this.CreateTeambtn.TabIndex = 7;
            this.CreateTeambtn.Text = "Create a Team";
            this.CreateTeambtn.UseVisualStyleBackColor = true;
            this.CreateTeambtn.Click += new System.EventHandler(this.CreateTeambtn_Click);
            // 
            // Starttb
            // 
            this.Starttb.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Starttb.Location = new System.Drawing.Point(116, 156);
            this.Starttb.Mask = "0000-0000";
            this.Starttb.Name = "Starttb";
            this.Starttb.Size = new System.Drawing.Size(121, 39);
            this.Starttb.TabIndex = 6;
            // 
            // NewTeam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 216);
            this.Controls.Add(this.Starttb);
            this.Controls.Add(this.CreateTeambtn);
            this.Controls.Add(this.AHLtb);
            this.Controls.Add(this.NHLtb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NewTeam";
            this.Text = "Create a Team";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.NewTeam_FormClosed);
            this.Load += new System.EventHandler(this.NewTeam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox NHLtb;
        private TextBox AHLtb;
        private Button CreateTeambtn;
        private MaskedTextBox Starttb;
    }
}