namespace Hockey_Lineup_Manager_2
{
    partial class SOEAform
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SOEAform));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.EA1txt = new DevExpress.XtraEditors.TextEdit();
            this.EA2txt = new DevExpress.XtraEditors.TextEdit();
            this.SO1txt = new DevExpress.XtraEditors.TextEdit();
            this.SO3txt = new DevExpress.XtraEditors.TextEdit();
            this.SO2txt = new DevExpress.XtraEditors.TextEdit();
            this.SO4txt = new DevExpress.XtraEditors.TextEdit();
            this.SO5txt = new DevExpress.XtraEditors.TextEdit();
            this.Savebtn = new System.Windows.Forms.Button();
            this.Clearbtn = new System.Windows.Forms.Button();
            this.Loadbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.EA1txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EA2txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SO1txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SO3txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SO2txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SO4txt.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SO5txt.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(92, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 45);
            this.label1.TabIndex = 10;
            this.label1.Text = "Extra Attackers";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(139, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 45);
            this.label2.TabIndex = 11;
            this.label2.Text = "Shootout";
            // 
            // EA1txt
            // 
            this.EA1txt.AllowDrop = true;
            this.EA1txt.Location = new System.Drawing.Point(35, 84);
            this.EA1txt.Name = "EA1txt";
            this.EA1txt.Size = new System.Drawing.Size(100, 20);
            this.EA1txt.TabIndex = 0;
            this.EA1txt.DragDrop += new System.Windows.Forms.DragEventHandler(this.AllTextBoxes_DragDrop);
            this.EA1txt.DragEnter += new System.Windows.Forms.DragEventHandler(this.AllTextBoxes_DragEnter);
            this.EA1txt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllTextBoxes_MouseDown);
            // 
            // EA2txt
            // 
            this.EA2txt.AllowDrop = true;
            this.EA2txt.Location = new System.Drawing.Point(300, 84);
            this.EA2txt.Name = "EA2txt";
            this.EA2txt.Size = new System.Drawing.Size(100, 20);
            this.EA2txt.TabIndex = 1;
            this.EA2txt.DragDrop += new System.Windows.Forms.DragEventHandler(this.AllTextBoxes_DragDrop);
            this.EA2txt.DragEnter += new System.Windows.Forms.DragEventHandler(this.AllTextBoxes_DragEnter);
            this.EA2txt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllTextBoxes_MouseDown);
            // 
            // SO1txt
            // 
            this.SO1txt.AllowDrop = true;
            this.SO1txt.Location = new System.Drawing.Point(12, 270);
            this.SO1txt.Name = "SO1txt";
            this.SO1txt.Size = new System.Drawing.Size(100, 20);
            this.SO1txt.TabIndex = 2;
            this.SO1txt.DragDrop += new System.Windows.Forms.DragEventHandler(this.AllTextBoxes_DragDrop);
            this.SO1txt.DragEnter += new System.Windows.Forms.DragEventHandler(this.AllTextBoxes_DragEnter);
            this.SO1txt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllTextBoxes_MouseDown);
            // 
            // SO3txt
            // 
            this.SO3txt.AllowDrop = true;
            this.SO3txt.Location = new System.Drawing.Point(330, 270);
            this.SO3txt.Name = "SO3txt";
            this.SO3txt.Size = new System.Drawing.Size(100, 20);
            this.SO3txt.TabIndex = 4;
            this.SO3txt.DragDrop += new System.Windows.Forms.DragEventHandler(this.AllTextBoxes_DragDrop);
            this.SO3txt.DragEnter += new System.Windows.Forms.DragEventHandler(this.AllTextBoxes_DragEnter);
            this.SO3txt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllTextBoxes_MouseDown);
            // 
            // SO2txt
            // 
            this.SO2txt.AllowDrop = true;
            this.SO2txt.Location = new System.Drawing.Point(171, 270);
            this.SO2txt.Name = "SO2txt";
            this.SO2txt.Size = new System.Drawing.Size(100, 20);
            this.SO2txt.TabIndex = 3;
            this.SO2txt.DragDrop += new System.Windows.Forms.DragEventHandler(this.AllTextBoxes_DragDrop);
            this.SO2txt.DragEnter += new System.Windows.Forms.DragEventHandler(this.AllTextBoxes_DragEnter);
            this.SO2txt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllTextBoxes_MouseDown);
            // 
            // SO4txt
            // 
            this.SO4txt.AllowDrop = true;
            this.SO4txt.Location = new System.Drawing.Point(72, 330);
            this.SO4txt.Name = "SO4txt";
            this.SO4txt.Size = new System.Drawing.Size(100, 20);
            this.SO4txt.TabIndex = 5;
            this.SO4txt.DragDrop += new System.Windows.Forms.DragEventHandler(this.AllTextBoxes_DragDrop);
            this.SO4txt.DragEnter += new System.Windows.Forms.DragEventHandler(this.AllTextBoxes_DragEnter);
            this.SO4txt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllTextBoxes_MouseDown);
            // 
            // SO5txt
            // 
            this.SO5txt.AllowDrop = true;
            this.SO5txt.Location = new System.Drawing.Point(260, 330);
            this.SO5txt.Name = "SO5txt";
            this.SO5txt.Size = new System.Drawing.Size(100, 20);
            this.SO5txt.TabIndex = 6;
            this.SO5txt.DragDrop += new System.Windows.Forms.DragEventHandler(this.AllTextBoxes_DragDrop);
            this.SO5txt.DragEnter += new System.Windows.Forms.DragEventHandler(this.AllTextBoxes_DragEnter);
            this.SO5txt.MouseDown += new System.Windows.Forms.MouseEventHandler(this.AllTextBoxes_MouseDown);
            // 
            // Savebtn
            // 
            this.Savebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Savebtn.Location = new System.Drawing.Point(302, 132);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(134, 36);
            this.Savebtn.TabIndex = 9;
            this.Savebtn.Text = "Save Lines";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // Clearbtn
            // 
            this.Clearbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Clearbtn.Location = new System.Drawing.Point(157, 132);
            this.Clearbtn.Name = "Clearbtn";
            this.Clearbtn.Size = new System.Drawing.Size(134, 36);
            this.Clearbtn.TabIndex = 8;
            this.Clearbtn.Text = "Clear Lines";
            this.Clearbtn.UseVisualStyleBackColor = true;
            this.Clearbtn.Click += new System.EventHandler(this.Clearbtn_Click);
            // 
            // Loadbtn
            // 
            this.Loadbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Loadbtn.Location = new System.Drawing.Point(12, 132);
            this.Loadbtn.Name = "Loadbtn";
            this.Loadbtn.Size = new System.Drawing.Size(134, 36);
            this.Loadbtn.TabIndex = 7;
            this.Loadbtn.Text = "Load Lines";
            this.Loadbtn.UseVisualStyleBackColor = true;
            this.Loadbtn.Click += new System.EventHandler(this.Loadbtn_Click);
            // 
            // SOEAform
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(448, 367);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Clearbtn);
            this.Controls.Add(this.Loadbtn);
            this.Controls.Add(this.SO5txt);
            this.Controls.Add(this.SO4txt);
            this.Controls.Add(this.SO2txt);
            this.Controls.Add(this.SO3txt);
            this.Controls.Add(this.SO1txt);
            this.Controls.Add(this.EA2txt);
            this.Controls.Add(this.EA1txt);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SOEAform";
            this.Text = "SOEAform";
            this.Load += new System.EventHandler(this.SOEAform_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EA1txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EA2txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SO1txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SO3txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SO2txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SO4txt.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SO5txt.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private DevExpress.XtraEditors.TextEdit EA1txt;
        private DevExpress.XtraEditors.TextEdit EA2txt;
        private DevExpress.XtraEditors.TextEdit SO1txt;
        private DevExpress.XtraEditors.TextEdit SO3txt;
        private DevExpress.XtraEditors.TextEdit SO2txt;
        private DevExpress.XtraEditors.TextEdit SO4txt;
        private DevExpress.XtraEditors.TextEdit SO5txt;
        private Button Savebtn;
        private Button Clearbtn;
        private Button Loadbtn;
    }
}