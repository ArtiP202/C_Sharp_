
namespace SGM_College_Admission_App
{
    partial class frm_Update
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Update = new System.Windows.Forms.Label();
            this.btn_Student_List = new System.Windows.Forms.Button();
            this.btn_Add_Stud = new System.Windows.Forms.Button();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.tb_User_Name = new System.Windows.Forms.TextBox();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_User_Name = new System.Windows.Forms.Label();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.btn_Update = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.lbl_Update);
            this.panel1.Location = new System.Drawing.Point(1, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 130);
            this.panel1.TabIndex = 9;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Logout.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_Logout.ForeColor = System.Drawing.Color.Navy;
            this.btn_Logout.Location = new System.Drawing.Point(967, 0);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(171, 42);
            this.btn_Logout.TabIndex = 11;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_Update
            // 
            this.lbl_Update.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_Update.Font = new System.Drawing.Font("Georgia", 26.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Update.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Update.Location = new System.Drawing.Point(306, 21);
            this.lbl_Update.Name = "lbl_Update";
            this.lbl_Update.Size = new System.Drawing.Size(488, 70);
            this.lbl_Update.TabIndex = 0;
            this.lbl_Update.Text = "Update Student";
            this.lbl_Update.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Student_List
            // 
            this.btn_Student_List.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Student_List.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_Student_List.ForeColor = System.Drawing.Color.Navy;
            this.btn_Student_List.Location = new System.Drawing.Point(872, 677);
            this.btn_Student_List.Name = "btn_Student_List";
            this.btn_Student_List.Size = new System.Drawing.Size(242, 45);
            this.btn_Student_List.TabIndex = 10;
            this.btn_Student_List.Text = "Student List";
            this.btn_Student_List.UseVisualStyleBackColor = false;
            this.btn_Student_List.Click += new System.EventHandler(this.btn_Student_List_Click);
            // 
            // btn_Add_Stud
            // 
            this.btn_Add_Stud.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Add_Stud.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_Add_Stud.ForeColor = System.Drawing.Color.Navy;
            this.btn_Add_Stud.Location = new System.Drawing.Point(350, 677);
            this.btn_Add_Stud.Name = "btn_Add_Stud";
            this.btn_Add_Stud.Size = new System.Drawing.Size(242, 45);
            this.btn_Add_Stud.TabIndex = 8;
            this.btn_Add_Stud.Text = "Add";
            this.btn_Add_Stud.UseVisualStyleBackColor = false;
            this.btn_Add_Stud.Click += new System.EventHandler(this.btn_Add_Stud_Click);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Refresh.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_Refresh.ForeColor = System.Drawing.Color.Navy;
            this.btn_Refresh.Location = new System.Drawing.Point(70, 677);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(227, 45);
            this.btn_Refresh.TabIndex = 7;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // cmb_Course
            // 
            this.cmb_Course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_Course.Font = new System.Drawing.Font("Georgia", 18.2F, System.Drawing.FontStyle.Bold);
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Items.AddRange(new object[] {
            "MCS",
            "MSC",
            "BCS",
            "BCA",
            "BCOM IT"});
            this.cmb_Course.Location = new System.Drawing.Point(533, 576);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(347, 43);
            this.cmb_Course.TabIndex = 6;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Georgia", 18.2F, System.Drawing.FontStyle.Bold);
            this.dtp_DOB.Location = new System.Drawing.Point(533, 381);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(347, 42);
            this.dtp_DOB.TabIndex = 4;
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Georgia", 18.2F, System.Drawing.FontStyle.Bold);
            this.tb_Mobile_No.Location = new System.Drawing.Point(533, 479);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Multiline = true;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(347, 45);
            this.tb_Mobile_No.TabIndex = 5;
            // 
            // tb_User_Name
            // 
            this.tb_User_Name.Font = new System.Drawing.Font("Georgia", 18.2F, System.Drawing.FontStyle.Bold);
            this.tb_User_Name.Location = new System.Drawing.Point(533, 274);
            this.tb_User_Name.MaxLength = 25;
            this.tb_User_Name.Multiline = true;
            this.tb_User_Name.Name = "tb_User_Name";
            this.tb_User_Name.Size = new System.Drawing.Size(347, 45);
            this.tb_User_Name.TabIndex = 3;
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Font = new System.Drawing.Font("Georgia", 18.2F, System.Drawing.FontStyle.Bold);
            this.tb_Roll_No.Location = new System.Drawing.Point(533, 160);
            this.tb_Roll_No.MaxLength = 4;
            this.tb_Roll_No.Multiline = true;
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(347, 45);
            this.tb_Roll_No.TabIndex = 1;
            // 
            // lbl_Course
            // 
            this.lbl_Course.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_Course.Font = new System.Drawing.Font("Georgia", 18.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Course.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Course.Location = new System.Drawing.Point(64, 575);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(280, 45);
            this.lbl_Course.TabIndex = 28;
            this.lbl_Course.Text = "Course";
            this.lbl_Course.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_DOB.Font = new System.Drawing.Font("Georgia", 18.2F, System.Drawing.FontStyle.Bold);
            this.lbl_DOB.ForeColor = System.Drawing.Color.Navy;
            this.lbl_DOB.Location = new System.Drawing.Point(64, 382);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(280, 45);
            this.lbl_DOB.TabIndex = 27;
            this.lbl_DOB.Text = "DOB";
            this.lbl_DOB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Georgia", 18.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(64, 480);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(280, 45);
            this.lbl_Mobile_No.TabIndex = 26;
            this.lbl_Mobile_No.Text = "Mobile No";
            this.lbl_Mobile_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_User_Name
            // 
            this.lbl_User_Name.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_User_Name.Font = new System.Drawing.Font("Georgia", 18.2F, System.Drawing.FontStyle.Bold);
            this.lbl_User_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_User_Name.Location = new System.Drawing.Point(64, 275);
            this.lbl_User_Name.Name = "lbl_User_Name";
            this.lbl_User_Name.Size = new System.Drawing.Size(280, 45);
            this.lbl_User_Name.TabIndex = 25;
            this.lbl_User_Name.Text = "User Name";
            this.lbl_User_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Georgia", 18.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Roll_No.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Roll_No.Location = new System.Drawing.Point(64, 161);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(280, 45);
            this.lbl_Roll_No.TabIndex = 24;
            this.lbl_Roll_No.Text = "Roll No";
            this.lbl_Roll_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Update.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_Update.ForeColor = System.Drawing.Color.Navy;
            this.btn_Update.Location = new System.Drawing.Point(912, 159);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(202, 45);
            this.btn_Update.TabIndex = 2;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Search.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_Search.ForeColor = System.Drawing.Color.Navy;
            this.btn_Search.Location = new System.Drawing.Point(637, 677);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(210, 45);
            this.btn_Search.TabIndex = 9;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // frm_Update
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 753);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Student_List);
            this.Controls.Add(this.btn_Add_Stud);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.tb_Mobile_No);
            this.Controls.Add(this.tb_User_Name);
            this.Controls.Add(this.tb_Roll_No);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.lbl_Mobile_No);
            this.Controls.Add(this.lbl_User_Name);
            this.Controls.Add(this.lbl_Roll_No);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Update";
            this.Text = "Update ";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Update;
        private System.Windows.Forms.Button btn_Student_List;
        private System.Windows.Forms.Button btn_Add_Stud;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.TextBox tb_User_Name;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_User_Name;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.Button btn_Update;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Logout;
    }
}