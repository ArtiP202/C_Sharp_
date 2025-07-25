
namespace WindowsFormsApp1
{
    partial class frm_Student_Details
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
            this.lbl_Student_Details = new System.Windows.Forms.Label();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.lbl_Name = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.bt_Refresh = new System.Windows.Forms.Button();
            this.bt_Save = new System.Windows.Forms.Button();
            this.bt_Student_List = new System.Windows.Forms.Button();
            this.bt_Logout = new System.Windows.Forms.Button();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Mob_No = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Student_Details
            // 
            this.lbl_Student_Details.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_Student_Details.Font = new System.Drawing.Font("Georgia", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Student_Details.Location = new System.Drawing.Point(357, 19);
            this.lbl_Student_Details.Name = "lbl_Student_Details";
            this.lbl_Student_Details.Size = new System.Drawing.Size(490, 85);
            this.lbl_Student_Details.TabIndex = 0;
            this.lbl_Student_Details.Text = "Student Details";
            this.lbl_Student_Details.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roll_No.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Roll_No.Location = new System.Drawing.Point(135, 182);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(308, 45);
            this.lbl_Roll_No.TabIndex = 1;
            this.lbl_Roll_No.Text = "Roll No";
            this.lbl_Roll_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Name
            // 
            this.lbl_Name.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_Name.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Name.Location = new System.Drawing.Point(135, 281);
            this.lbl_Name.Name = "lbl_Name";
            this.lbl_Name.Size = new System.Drawing.Size(308, 45);
            this.lbl_Name.TabIndex = 2;
            this.lbl_Name.Text = "Name";
            this.lbl_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(135, 495);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(308, 45);
            this.lbl_Mobile_No.TabIndex = 3;
            this.lbl_Mobile_No.Text = "Mobile No";
            this.lbl_Mobile_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_DOB.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.ForeColor = System.Drawing.Color.Navy;
            this.lbl_DOB.Location = new System.Drawing.Point(135, 390);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(308, 45);
            this.lbl_DOB.TabIndex = 4;
            this.lbl_DOB.Text = "DOB";
            this.lbl_DOB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Course
            // 
            this.lbl_Course.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_Course.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Course.Location = new System.Drawing.Point(135, 590);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(308, 45);
            this.lbl_Course.TabIndex = 5;
            this.lbl_Course.Text = "Course";
            this.lbl_Course.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_Refresh
            // 
            this.bt_Refresh.BackColor = System.Drawing.Color.LightBlue;
            this.bt_Refresh.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Refresh.Location = new System.Drawing.Point(156, 714);
            this.bt_Refresh.Name = "bt_Refresh";
            this.bt_Refresh.Size = new System.Drawing.Size(173, 50);
            this.bt_Refresh.TabIndex = 6;
            this.bt_Refresh.Text = "Refresh";
            this.bt_Refresh.UseVisualStyleBackColor = false;
            this.bt_Refresh.Click += new System.EventHandler(this.bt_Refresh_Click_1);
            // 
            // bt_Save
            // 
            this.bt_Save.BackColor = System.Drawing.Color.LightBlue;
            this.bt_Save.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Save.Location = new System.Drawing.Point(491, 714);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(145, 50);
            this.bt_Save.TabIndex = 7;
            this.bt_Save.Text = "Save";
            this.bt_Save.UseVisualStyleBackColor = false;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // bt_Student_List
            // 
            this.bt_Student_List.BackColor = System.Drawing.Color.LightBlue;
            this.bt_Student_List.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Student_List.Location = new System.Drawing.Point(782, 714);
            this.bt_Student_List.Name = "bt_Student_List";
            this.bt_Student_List.Size = new System.Drawing.Size(252, 50);
            this.bt_Student_List.TabIndex = 8;
            this.bt_Student_List.Text = "Student List";
            this.bt_Student_List.UseVisualStyleBackColor = false;
            this.bt_Student_List.Click += new System.EventHandler(this.bt_Student_List_Click);
            // 
            // bt_Logout
            // 
            this.bt_Logout.BackColor = System.Drawing.Color.LightBlue;
            this.bt_Logout.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Logout.Location = new System.Drawing.Point(1025, 19);
            this.bt_Logout.Name = "bt_Logout";
            this.bt_Logout.Size = new System.Drawing.Size(145, 50);
            this.bt_Logout.TabIndex = 9;
            this.bt_Logout.Text = "Logout";
            this.bt_Logout.UseVisualStyleBackColor = false;
            this.bt_Logout.Click += new System.EventHandler(this.bt_Logout_Click);
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Roll_No.Location = new System.Drawing.Point(694, 182);
            this.tb_Roll_No.MaxLength = 4;
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(375, 45);
            this.tb_Roll_No.TabIndex = 1;
            this.tb_Roll_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(694, 281);
            this.tb_Name.MaxLength = 25;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(375, 45);
            this.tb_Name.TabIndex = 2;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // tb_Mob_No
            // 
            this.tb_Mob_No.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mob_No.Location = new System.Drawing.Point(694, 495);
            this.tb_Mob_No.MaxLength = 10;
            this.tb_Mob_No.Name = "tb_Mob_No";
            this.tb_Mob_No.Size = new System.Drawing.Size(375, 45);
            this.tb_Mob_No.TabIndex = 4;
            this.tb_Mob_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lbl_Student_Details);
            this.panel1.Controls.Add(this.bt_Logout);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 137);
            this.panel1.TabIndex = 13;
            // 
            // cmb_Course
            // 
            this.cmb_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Course.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Items.AddRange(new object[] {
            "BCS",
            "BCOM IT",
            "BCA",
            "BSC"});
            this.cmb_Course.Location = new System.Drawing.Point(694, 590);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(375, 46);
            this.cmb_Course.TabIndex = 5;
            this.cmb_Course.DropDownStyleChanged += new System.EventHandler(this.bt_Logout_Click);
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(694, 388);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(375, 45);
            this.dtp_DOB.TabIndex = 3;
            this.dtp_DOB.Value = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            // 
            // frm_Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1192, 803);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.tb_Mob_No);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.tb_Roll_No);
            this.Controls.Add(this.bt_Student_List);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.bt_Refresh);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_Mobile_No);
            this.Controls.Add(this.lbl_Name);
            this.Controls.Add(this.lbl_Roll_No);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "frm_Student_Details";
            this.Text = "Student Details";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Student_Details;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.Label lbl_Name;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Button bt_Refresh;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Button bt_Student_List;
        private System.Windows.Forms.Button bt_Logout;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Mob_No;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
    }
}