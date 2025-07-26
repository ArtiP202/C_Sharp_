
namespace Employee_Details
{
    partial class frm_Use_Windows_Control
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
            this.lbl_Employe_Details = new System.Windows.Forms.Label();
            this.lbl_Employe_Name = new System.Windows.Forms.Label();
            this.lbl_Employe_Department = new System.Windows.Forms.Label();
            this.lbl_Gender = new System.Windows.Forms.Label();
            this.lbl_Shift_Time = new System.Windows.Forms.Label();
            this.bt_Reset = new System.Windows.Forms.Button();
            this.bt_Submit = new System.Windows.Forms.Button();
            this.tb_Employe_Name = new System.Windows.Forms.TextBox();
            this.gb_Gender = new System.Windows.Forms.GroupBox();
            this.rb_Male = new System.Windows.Forms.RadioButton();
            this.rb_Female = new System.Windows.Forms.RadioButton();
            this.gb_Shift_Time = new System.Windows.Forms.GroupBox();
            this.rb_Evening = new System.Windows.Forms.RadioButton();
            this.rb_Night = new System.Windows.Forms.RadioButton();
            this.rb_Morning = new System.Windows.Forms.RadioButton();
            this.lbl_Output = new System.Windows.Forms.Label();
            this.tb_Output = new System.Windows.Forms.TextBox();
            this.cmb_Department = new System.Windows.Forms.ComboBox();
            this.gb_Gender.SuspendLayout();
            this.gb_Shift_Time.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Employe_Details
            // 
            this.lbl_Employe_Details.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.lbl_Employe_Details.Font = new System.Drawing.Font("Georgia", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employe_Details.Location = new System.Drawing.Point(428, 19);
            this.lbl_Employe_Details.Name = "lbl_Employe_Details";
            this.lbl_Employe_Details.Size = new System.Drawing.Size(554, 101);
            this.lbl_Employe_Details.TabIndex = 0;
            this.lbl_Employe_Details.Text = "Employe Details";
            this.lbl_Employe_Details.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Employe_Name
            // 
            this.lbl_Employe_Name.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employe_Name.Location = new System.Drawing.Point(122, 167);
            this.lbl_Employe_Name.Name = "lbl_Employe_Name";
            this.lbl_Employe_Name.Size = new System.Drawing.Size(302, 65);
            this.lbl_Employe_Name.TabIndex = 1;
            this.lbl_Employe_Name.Text = "Employe Name";
            this.lbl_Employe_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Employe_Department
            // 
            this.lbl_Employe_Department.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Employe_Department.Location = new System.Drawing.Point(122, 280);
            this.lbl_Employe_Department.Name = "lbl_Employe_Department";
            this.lbl_Employe_Department.Size = new System.Drawing.Size(386, 65);
            this.lbl_Employe_Department.TabIndex = 2;
            this.lbl_Employe_Department.Text = "Employe Department";
            this.lbl_Employe_Department.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Gender
            // 
            this.lbl_Gender.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Gender.Location = new System.Drawing.Point(122, 394);
            this.lbl_Gender.Name = "lbl_Gender";
            this.lbl_Gender.Size = new System.Drawing.Size(190, 65);
            this.lbl_Gender.TabIndex = 3;
            this.lbl_Gender.Text = "Gender";
            this.lbl_Gender.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Shift_Time
            // 
            this.lbl_Shift_Time.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Shift_Time.Location = new System.Drawing.Point(138, 530);
            this.lbl_Shift_Time.Name = "lbl_Shift_Time";
            this.lbl_Shift_Time.Size = new System.Drawing.Size(190, 65);
            this.lbl_Shift_Time.TabIndex = 4;
            this.lbl_Shift_Time.Text = "Shift Time";
            this.lbl_Shift_Time.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_Reset
            // 
            this.bt_Reset.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bt_Reset.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Reset.Location = new System.Drawing.Point(351, 670);
            this.bt_Reset.Name = "bt_Reset";
            this.bt_Reset.Size = new System.Drawing.Size(183, 51);
            this.bt_Reset.TabIndex = 5;
            this.bt_Reset.Text = "Reset";
            this.bt_Reset.UseVisualStyleBackColor = false;
            this.bt_Reset.Click += new System.EventHandler(this.bt_Reset_Click);
            // 
            // bt_Submit
            // 
            this.bt_Submit.BackColor = System.Drawing.SystemColors.ControlLight;
            this.bt_Submit.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Submit.Location = new System.Drawing.Point(847, 670);
            this.bt_Submit.Name = "bt_Submit";
            this.bt_Submit.Size = new System.Drawing.Size(183, 51);
            this.bt_Submit.TabIndex = 6;
            this.bt_Submit.Text = "Submit";
            this.bt_Submit.UseVisualStyleBackColor = false;
            this.bt_Submit.Click += new System.EventHandler(this.bt_Submit_Click);
            // 
            // tb_Employe_Name
            // 
            this.tb_Employe_Name.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Employe_Name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.tb_Employe_Name.Location = new System.Drawing.Point(835, 181);
            this.tb_Employe_Name.Multiline = true;
            this.tb_Employe_Name.Name = "tb_Employe_Name";
            this.tb_Employe_Name.Size = new System.Drawing.Size(375, 51);
            this.tb_Employe_Name.TabIndex = 7;
            this.tb_Employe_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_text);
            // 
            // gb_Gender
            // 
            this.gb_Gender.BackColor = System.Drawing.Color.LavenderBlush;
            this.gb_Gender.Controls.Add(this.rb_Male);
            this.gb_Gender.Controls.Add(this.rb_Female);
            this.gb_Gender.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Gender.Location = new System.Drawing.Point(841, 394);
            this.gb_Gender.Name = "gb_Gender";
            this.gb_Gender.Size = new System.Drawing.Size(322, 63);
            this.gb_Gender.TabIndex = 9;
            this.gb_Gender.TabStop = false;
            this.gb_Gender.Text = "Gender";
            // 
            // rb_Male
            // 
            this.rb_Male.AutoSize = true;
            this.rb_Male.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Male.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rb_Male.Location = new System.Drawing.Point(19, 30);
            this.rb_Male.Name = "rb_Male";
            this.rb_Male.Size = new System.Drawing.Size(66, 22);
            this.rb_Male.TabIndex = 12;
            this.rb_Male.TabStop = true;
            this.rb_Male.Text = "Male";
            this.rb_Male.UseVisualStyleBackColor = true;
            // 
            // rb_Female
            // 
            this.rb_Female.AutoSize = true;
            this.rb_Female.Font = new System.Drawing.Font("Georgia", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Female.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rb_Female.Location = new System.Drawing.Point(197, 30);
            this.rb_Female.Name = "rb_Female";
            this.rb_Female.Size = new System.Drawing.Size(84, 22);
            this.rb_Female.TabIndex = 11;
            this.rb_Female.TabStop = true;
            this.rb_Female.Text = "Female";
            this.rb_Female.UseVisualStyleBackColor = true;
            // 
            // gb_Shift_Time
            // 
            this.gb_Shift_Time.BackColor = System.Drawing.Color.LavenderBlush;
            this.gb_Shift_Time.Controls.Add(this.rb_Evening);
            this.gb_Shift_Time.Controls.Add(this.rb_Night);
            this.gb_Shift_Time.Controls.Add(this.rb_Morning);
            this.gb_Shift_Time.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gb_Shift_Time.Location = new System.Drawing.Point(841, 508);
            this.gb_Shift_Time.Name = "gb_Shift_Time";
            this.gb_Shift_Time.Size = new System.Drawing.Size(369, 87);
            this.gb_Shift_Time.TabIndex = 10;
            this.gb_Shift_Time.TabStop = false;
            this.gb_Shift_Time.Text = "Shift Time";
            // 
            // rb_Evening
            // 
            this.rb_Evening.AutoSize = true;
            this.rb_Evening.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Evening.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rb_Evening.Location = new System.Drawing.Point(259, 47);
            this.rb_Evening.Name = "rb_Evening";
            this.rb_Evening.Size = new System.Drawing.Size(104, 24);
            this.rb_Evening.TabIndex = 14;
            this.rb_Evening.TabStop = true;
            this.rb_Evening.Text = "Evening";
            this.rb_Evening.UseVisualStyleBackColor = true;
            // 
            // rb_Night
            // 
            this.rb_Night.AutoSize = true;
            this.rb_Night.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Night.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rb_Night.Location = new System.Drawing.Point(148, 47);
            this.rb_Night.Name = "rb_Night";
            this.rb_Night.Size = new System.Drawing.Size(80, 24);
            this.rb_Night.TabIndex = 13;
            this.rb_Night.TabStop = true;
            this.rb_Night.Text = "Night";
            this.rb_Night.UseVisualStyleBackColor = true;
            // 
            // rb_Morning
            // 
            this.rb_Morning.AutoSize = true;
            this.rb_Morning.Font = new System.Drawing.Font("Georgia", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rb_Morning.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.rb_Morning.Location = new System.Drawing.Point(6, 47);
            this.rb_Morning.Name = "rb_Morning";
            this.rb_Morning.Size = new System.Drawing.Size(109, 24);
            this.rb_Morning.TabIndex = 12;
            this.rb_Morning.TabStop = true;
            this.rb_Morning.Text = "Morning";
            this.rb_Morning.UseVisualStyleBackColor = true;
            // 
            // lbl_Output
            // 
            this.lbl_Output.BackColor = System.Drawing.Color.MistyRose;
            this.lbl_Output.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Output.Location = new System.Drawing.Point(12, 770);
            this.lbl_Output.Name = "lbl_Output";
            this.lbl_Output.Size = new System.Drawing.Size(139, 56);
            this.lbl_Output.TabIndex = 11;
            this.lbl_Output.Text = "Output";
            this.lbl_Output.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Output
            // 
            this.tb_Output.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Output.Location = new System.Drawing.Point(180, 775);
            this.tb_Output.Name = "tb_Output";
            this.tb_Output.Size = new System.Drawing.Size(1215, 38);
            this.tb_Output.TabIndex = 12;
            // 
            // cmb_Department
            // 
            this.cmb_Department.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Department.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Department.FormattingEnabled = true;
            this.cmb_Department.Items.AddRange(new object[] {
            "Tester",
            "Developer",
            "Manager"});
            this.cmb_Department.Location = new System.Drawing.Point(835, 280);
            this.cmb_Department.Name = "cmb_Department";
            this.cmb_Department.Size = new System.Drawing.Size(375, 39);
            this.cmb_Department.TabIndex = 13;
            // 
            // frm_Use_Windows_Control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.ClientSize = new System.Drawing.Size(1438, 835);
            this.Controls.Add(this.cmb_Department);
            this.Controls.Add(this.tb_Output);
            this.Controls.Add(this.lbl_Output);
            this.Controls.Add(this.gb_Shift_Time);
            this.Controls.Add(this.gb_Gender);
            this.Controls.Add(this.tb_Employe_Name);
            this.Controls.Add(this.bt_Submit);
            this.Controls.Add(this.bt_Reset);
            this.Controls.Add(this.lbl_Shift_Time);
            this.Controls.Add(this.lbl_Gender);
            this.Controls.Add(this.lbl_Employe_Department);
            this.Controls.Add(this.lbl_Employe_Name);
            this.Controls.Add(this.lbl_Employe_Details);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "frm_Use_Windows_Control";
            this.Text = "Use Windows Control";
            this.Load += new System.EventHandler(this.frm_Use_Windows_Control_Load);
            this.gb_Gender.ResumeLayout(false);
            this.gb_Gender.PerformLayout();
            this.gb_Shift_Time.ResumeLayout(false);
            this.gb_Shift_Time.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Employe_Details;
        private System.Windows.Forms.Label lbl_Employe_Name;
        private System.Windows.Forms.Label lbl_Employe_Department;
        private System.Windows.Forms.Label lbl_Gender;
        private System.Windows.Forms.Label lbl_Shift_Time;
        private System.Windows.Forms.Button bt_Reset;
        private System.Windows.Forms.Button bt_Submit;
        private System.Windows.Forms.TextBox tb_Employe_Name;
        private System.Windows.Forms.GroupBox gb_Gender;
        private System.Windows.Forms.RadioButton rb_Male;
        private System.Windows.Forms.RadioButton rb_Female;
        private System.Windows.Forms.GroupBox gb_Shift_Time;
        private System.Windows.Forms.RadioButton rb_Evening;
        private System.Windows.Forms.RadioButton rb_Night;
        private System.Windows.Forms.RadioButton rb_Morning;
        private System.Windows.Forms.Label lbl_Output;
        private System.Windows.Forms.TextBox tb_Output;
        private System.Windows.Forms.ComboBox cmb_Department;
    }
}

