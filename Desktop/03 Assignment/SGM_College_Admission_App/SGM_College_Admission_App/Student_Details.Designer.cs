
namespace SGM_College_Admission_App
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Student_Details = new System.Windows.Forms.Label();
            this.lbl_User_Name = new System.Windows.Forms.Label();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.tb_User_Name = new System.Windows.Forms.TextBox();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Save = new System.Windows.Forms.Button();
            this.btn_Student_List = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btn_Update = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.lbl_Student_Details);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 130);
            this.panel1.TabIndex = 9;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Logout.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_Logout.ForeColor = System.Drawing.Color.Navy;
            this.btn_Logout.Location = new System.Drawing.Point(970, 3);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(171, 42);
            this.btn_Logout.TabIndex = 11;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_Student_Details
            // 
            this.lbl_Student_Details.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_Student_Details.Font = new System.Drawing.Font("Georgia", 26.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Student_Details.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Student_Details.Location = new System.Drawing.Point(340, 23);
            this.lbl_Student_Details.Name = "lbl_Student_Details";
            this.lbl_Student_Details.Size = new System.Drawing.Size(465, 70);
            this.lbl_Student_Details.TabIndex = 0;
            this.lbl_Student_Details.Text = "Student Details";
            this.lbl_Student_Details.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_User_Name
            // 
            this.lbl_User_Name.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_User_Name.Font = new System.Drawing.Font("Georgia", 18.2F, System.Drawing.FontStyle.Bold);
            this.lbl_User_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_User_Name.Location = new System.Drawing.Point(112, 279);
            this.lbl_User_Name.Name = "lbl_User_Name";
            this.lbl_User_Name.Size = new System.Drawing.Size(280, 45);
            this.lbl_User_Name.TabIndex = 11;
            this.lbl_User_Name.Text = "User Name";
            this.lbl_User_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Georgia", 18.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Roll_No.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Roll_No.Location = new System.Drawing.Point(112, 163);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(280, 45);
            this.lbl_Roll_No.TabIndex = 10;
            this.lbl_Roll_No.Text = "Roll No";
            this.lbl_Roll_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Georgia", 18.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(112, 484);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(280, 45);
            this.lbl_Mobile_No.TabIndex = 13;
            this.lbl_Mobile_No.Text = "Mobile No";
            this.lbl_Mobile_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Course
            // 
            this.lbl_Course.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_Course.Font = new System.Drawing.Font("Georgia", 18.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Course.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Course.Location = new System.Drawing.Point(112, 579);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(280, 45);
            this.lbl_Course.TabIndex = 15;
            this.lbl_Course.Text = "Course";
            this.lbl_Course.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_DOB.Font = new System.Drawing.Font("Georgia", 18.2F, System.Drawing.FontStyle.Bold);
            this.lbl_DOB.ForeColor = System.Drawing.Color.Navy;
            this.lbl_DOB.Location = new System.Drawing.Point(112, 386);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(280, 45);
            this.lbl_DOB.TabIndex = 14;
            this.lbl_DOB.Text = "DOB";
            this.lbl_DOB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_User_Name
            // 
            this.tb_User_Name.Font = new System.Drawing.Font("Georgia", 18.2F, System.Drawing.FontStyle.Bold);
            this.tb_User_Name.Location = new System.Drawing.Point(656, 279);
            this.tb_User_Name.MaxLength = 20;
            this.tb_User_Name.Multiline = true;
            this.tb_User_Name.Name = "tb_User_Name";
            this.tb_User_Name.Size = new System.Drawing.Size(347, 45);
            this.tb_User_Name.TabIndex = 2;
            this.tb_User_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Font = new System.Drawing.Font("Georgia", 18.2F, System.Drawing.FontStyle.Bold);
            this.tb_Roll_No.Location = new System.Drawing.Point(656, 164);
            this.tb_Roll_No.MaxLength = 4;
            this.tb_Roll_No.Multiline = true;
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(347, 45);
            this.tb_Roll_No.TabIndex = 1;
            this.tb_Roll_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Georgia", 18.2F, System.Drawing.FontStyle.Bold);
            this.tb_Mobile_No.Location = new System.Drawing.Point(656, 483);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Multiline = true;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(347, 45);
            this.tb_Mobile_No.TabIndex = 4;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Georgia", 18.2F, System.Drawing.FontStyle.Bold);
            this.dtp_DOB.Location = new System.Drawing.Point(656, 385);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(347, 42);
            this.dtp_DOB.TabIndex = 3;
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
            this.cmb_Course.Location = new System.Drawing.Point(656, 579);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(347, 43);
            this.cmb_Course.TabIndex = 5;
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Refresh.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_Refresh.ForeColor = System.Drawing.Color.Navy;
            this.btn_Refresh.Location = new System.Drawing.Point(12, 682);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(181, 45);
            this.btn_Refresh.TabIndex = 6;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Save
            // 
            this.btn_Save.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Save.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_Save.ForeColor = System.Drawing.Color.Navy;
            this.btn_Save.Location = new System.Drawing.Point(242, 682);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(167, 45);
            this.btn_Save.TabIndex = 7;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = false;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Student_List
            // 
            this.btn_Student_List.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Student_List.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_Student_List.ForeColor = System.Drawing.Color.Navy;
            this.btn_Student_List.Location = new System.Drawing.Point(888, 682);
            this.btn_Student_List.Name = "btn_Student_List";
            this.btn_Student_List.Size = new System.Drawing.Size(242, 45);
            this.btn_Student_List.TabIndex = 10;
            this.btn_Student_List.Text = "Student List";
            this.btn_Student_List.UseVisualStyleBackColor = false;
            this.btn_Student_List.Click += new System.EventHandler(this.btn_Student_List_Click);
            // 
            // btn_Search
            // 
            this.btn_Search.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Search.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_Search.ForeColor = System.Drawing.Color.Navy;
            this.btn_Search.Location = new System.Drawing.Point(443, 682);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(185, 45);
            this.btn_Search.TabIndex = 8;
            this.btn_Search.Text = "Search";
            this.btn_Search.UseVisualStyleBackColor = false;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btn_Update
            // 
            this.btn_Update.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Update.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_Update.ForeColor = System.Drawing.Color.Navy;
            this.btn_Update.Location = new System.Drawing.Point(674, 682);
            this.btn_Update.Name = "btn_Update";
            this.btn_Update.Size = new System.Drawing.Size(168, 45);
            this.btn_Update.TabIndex = 9;
            this.btn_Update.Text = "Update";
            this.btn_Update.UseVisualStyleBackColor = false;
            this.btn_Update.Click += new System.EventHandler(this.btn_Update_Click);
            // 
            // frm_Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 753);
            this.Controls.Add(this.btn_Update);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Student_List);
            this.Controls.Add(this.btn_Save);
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
            this.Name = "frm_Student_Details";
            this.Text = "Student Details";
            this.Load += new System.EventHandler(this.frm_Student_Details_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Student_Details;
        private System.Windows.Forms.Label lbl_User_Name;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.TextBox tb_User_Name;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Logout;
        private System.Windows.Forms.Button btn_Save;
        private System.Windows.Forms.Button btn_Student_List;
        private System.Windows.Forms.Button btn_Search;
        private System.Windows.Forms.Button btn_Update;
    }
}