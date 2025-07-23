
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Logout = new System.Windows.Forms.Button();
            this.lbl_Student_Details = new System.Windows.Forms.Label();
            this.lbl_Roll_No = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_DOB = new System.Windows.Forms.Label();
            this.lbl_Mobile_No = new System.Windows.Forms.Label();
            this.lbl_Course = new System.Windows.Forms.Label();
            this.bt_Refresh = new System.Windows.Forms.Button();
            this.bt_Save = new System.Windows.Forms.Button();
            this.bt_Student_List = new System.Windows.Forms.Button();
            this.tb_Roll_No = new System.Windows.Forms.TextBox();
            this.cmb_Course = new System.Windows.Forms.ComboBox();
            this.dtp_DOB = new System.Windows.Forms.DateTimePicker();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.tb_Mobile_No = new System.Windows.Forms.TextBox();
            this.bt_Search = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.bt_Logout);
            this.panel1.Controls.Add(this.lbl_Student_Details);
            this.panel1.Location = new System.Drawing.Point(0, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1190, 141);
            this.panel1.TabIndex = 4;
            // 
            // bt_Logout
            // 
            this.bt_Logout.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_Logout.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Logout.ForeColor = System.Drawing.Color.Navy;
            this.bt_Logout.Location = new System.Drawing.Point(1015, 3);
            this.bt_Logout.Name = "bt_Logout";
            this.bt_Logout.Size = new System.Drawing.Size(175, 45);
            this.bt_Logout.TabIndex = 10;
            this.bt_Logout.Text = "Logout";
            this.bt_Logout.UseVisualStyleBackColor = false;
            this.bt_Logout.Click += new System.EventHandler(this.bt_Logout_Click);
            // 
            // lbl_Student_Details
            // 
            this.lbl_Student_Details.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_Student_Details.Font = new System.Drawing.Font("Georgia", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Student_Details.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Student_Details.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lbl_Student_Details.Location = new System.Drawing.Point(343, 32);
            this.lbl_Student_Details.Name = "lbl_Student_Details";
            this.lbl_Student_Details.Size = new System.Drawing.Size(514, 74);
            this.lbl_Student_Details.TabIndex = 1;
            this.lbl_Student_Details.Text = "Student Details";
            this.lbl_Student_Details.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Roll_No
            // 
            this.lbl_Roll_No.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_Roll_No.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Roll_No.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Roll_No.Location = new System.Drawing.Point(33, 186);
            this.lbl_Roll_No.Name = "lbl_Roll_No";
            this.lbl_Roll_No.Size = new System.Drawing.Size(320, 50);
            this.lbl_Roll_No.TabIndex = 5;
            this.lbl_Roll_No.Text = "Roll No";
            this.lbl_Roll_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.LightCoral;
            this.label1.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(33, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(320, 50);
            this.label1.TabIndex = 6;
            this.label1.Text = "User Name";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_DOB
            // 
            this.lbl_DOB.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_DOB.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_DOB.ForeColor = System.Drawing.Color.Navy;
            this.lbl_DOB.Location = new System.Drawing.Point(33, 375);
            this.lbl_DOB.Name = "lbl_DOB";
            this.lbl_DOB.Size = new System.Drawing.Size(320, 50);
            this.lbl_DOB.TabIndex = 7;
            this.lbl_DOB.Text = "DOB";
            this.lbl_DOB.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Mobile_No
            // 
            this.lbl_Mobile_No.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_Mobile_No.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Mobile_No.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Mobile_No.Location = new System.Drawing.Point(33, 475);
            this.lbl_Mobile_No.Name = "lbl_Mobile_No";
            this.lbl_Mobile_No.Size = new System.Drawing.Size(320, 50);
            this.lbl_Mobile_No.TabIndex = 8;
            this.lbl_Mobile_No.Text = "Mobile No";
            this.lbl_Mobile_No.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Course
            // 
            this.lbl_Course.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_Course.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Course.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Course.Location = new System.Drawing.Point(33, 571);
            this.lbl_Course.Name = "lbl_Course";
            this.lbl_Course.Size = new System.Drawing.Size(320, 50);
            this.lbl_Course.TabIndex = 9;
            this.lbl_Course.Text = "Course";
            this.lbl_Course.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_Refresh
            // 
            this.bt_Refresh.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_Refresh.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Refresh.ForeColor = System.Drawing.Color.Navy;
            this.bt_Refresh.Location = new System.Drawing.Point(124, 712);
            this.bt_Refresh.Name = "bt_Refresh";
            this.bt_Refresh.Size = new System.Drawing.Size(175, 45);
            this.bt_Refresh.TabIndex = 7;
            this.bt_Refresh.Text = "Refresh";
            this.bt_Refresh.UseVisualStyleBackColor = false;
            this.bt_Refresh.Click += new System.EventHandler(this.bt_Refresh_Click);
            // 
            // bt_Save
            // 
            this.bt_Save.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_Save.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Save.ForeColor = System.Drawing.Color.Navy;
            this.bt_Save.Location = new System.Drawing.Point(493, 712);
            this.bt_Save.Name = "bt_Save";
            this.bt_Save.Size = new System.Drawing.Size(175, 45);
            this.bt_Save.TabIndex = 8;
            this.bt_Save.Text = "Save";
            this.bt_Save.UseVisualStyleBackColor = false;
            this.bt_Save.Click += new System.EventHandler(this.bt_Save_Click);
            // 
            // bt_Student_List
            // 
            this.bt_Student_List.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_Student_List.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Student_List.ForeColor = System.Drawing.Color.Navy;
            this.bt_Student_List.Location = new System.Drawing.Point(837, 712);
            this.bt_Student_List.Name = "bt_Student_List";
            this.bt_Student_List.Size = new System.Drawing.Size(256, 45);
            this.bt_Student_List.TabIndex = 9;
            this.bt_Student_List.Text = "Student List";
            this.bt_Student_List.UseVisualStyleBackColor = false;
            this.bt_Student_List.Click += new System.EventHandler(this.bt_Student_List_Click);
            // 
            // tb_Roll_No
            // 
            this.tb_Roll_No.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Roll_No.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_Roll_No.Location = new System.Drawing.Point(554, 191);
            this.tb_Roll_No.MaxLength = 4;
            this.tb_Roll_No.Name = "tb_Roll_No";
            this.tb_Roll_No.Size = new System.Drawing.Size(369, 45);
            this.tb_Roll_No.TabIndex = 1;
            this.tb_Roll_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // cmb_Course
            // 
            this.cmb_Course.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_Course.ForeColor = System.Drawing.SystemColors.WindowText;
            this.cmb_Course.FormattingEnabled = true;
            this.cmb_Course.Items.AddRange(new object[] {
            "BCS",
            "BCOM IT",
            "BCA",
            "BSC"});
            this.cmb_Course.Location = new System.Drawing.Point(554, 571);
            this.cmb_Course.Margin = new System.Windows.Forms.Padding(0, 0, 0, 0);
            this.cmb_Course.Name = "cmb_Course";
            this.cmb_Course.Size = new System.Drawing.Size(369, 46);
            this.cmb_Course.TabIndex = 6;
            // 
            // dtp_DOB
            // 
            this.dtp_DOB.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_DOB.Location = new System.Drawing.Point(554, 375);
            this.dtp_DOB.Name = "dtp_DOB";
            this.dtp_DOB.Size = new System.Drawing.Size(369, 45);
            this.dtp_DOB.TabIndex = 4;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_Name.Location = new System.Drawing.Point(554, 280);
            this.tb_Name.MaxLength = 30;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(369, 45);
            this.tb_Name.TabIndex = 3;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // tb_Mobile_No
            // 
            this.tb_Mobile_No.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Mobile_No.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_Mobile_No.Location = new System.Drawing.Point(554, 475);
            this.tb_Mobile_No.MaxLength = 10;
            this.tb_Mobile_No.Name = "tb_Mobile_No";
            this.tb_Mobile_No.Size = new System.Drawing.Size(369, 45);
            this.tb_Mobile_No.TabIndex = 5;
            this.tb_Mobile_No.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Numeric);
            // 
            // bt_Search
            // 
            this.bt_Search.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_Search.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Search.ForeColor = System.Drawing.Color.Navy;
            this.bt_Search.Location = new System.Drawing.Point(991, 191);
            this.bt_Search.Name = "bt_Search";
            this.bt_Search.Size = new System.Drawing.Size(175, 45);
            this.bt_Search.TabIndex = 2;
            this.bt_Search.Text = "Search";
            this.bt_Search.UseVisualStyleBackColor = false;
            this.bt_Search.Click += new System.EventHandler(this.bt_Search_Click);
            // 
            // frm_Student_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1192, 808);
            this.Controls.Add(this.bt_Search);
            this.Controls.Add(this.tb_Mobile_No);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.dtp_DOB);
            this.Controls.Add(this.cmb_Course);
            this.Controls.Add(this.tb_Roll_No);
            this.Controls.Add(this.bt_Student_List);
            this.Controls.Add(this.bt_Save);
            this.Controls.Add(this.bt_Refresh);
            this.Controls.Add(this.lbl_Course);
            this.Controls.Add(this.lbl_Mobile_No);
            this.Controls.Add(this.lbl_DOB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbl_Roll_No);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Student_Details";
            this.Text = "Student Details";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Student_Details;
        private System.Windows.Forms.Label lbl_Roll_No;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_DOB;
        private System.Windows.Forms.Label lbl_Mobile_No;
        private System.Windows.Forms.Label lbl_Course;
        private System.Windows.Forms.Button bt_Logout;
        private System.Windows.Forms.Button bt_Refresh;
        private System.Windows.Forms.Button bt_Save;
        private System.Windows.Forms.Button bt_Student_List;
        private System.Windows.Forms.TextBox tb_Roll_No;
        private System.Windows.Forms.ComboBox cmb_Course;
        private System.Windows.Forms.DateTimePicker dtp_DOB;
        private System.Windows.Forms.TextBox tb_Name;
        private System.Windows.Forms.TextBox tb_Mobile_No;
        private System.Windows.Forms.Button bt_Search;
    }
}