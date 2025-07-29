
namespace SGM_College_Admission_App
{
    partial class frm_Login
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
            this.lbl_Note = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_User_Name = new System.Windows.Forms.TextBox();
            this.btn_Refresh = new System.Windows.Forms.Button();
            this.btn_Submit = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_User_Name = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbl_Login = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Note
            // 
            this.lbl_Note.BackColor = System.Drawing.Color.Snow;
            this.lbl_Note.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Note.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Note.Location = new System.Drawing.Point(163, 520);
            this.lbl_Note.Name = "lbl_Note";
            this.lbl_Note.Size = new System.Drawing.Size(744, 39);
            this.lbl_Note.TabIndex = 15;
            this.lbl_Note.Text = "Note : Enter Correct User Name or Password";
            this.lbl_Note.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbl_Note.Visible = false;
            // 
            // tb_Password
            // 
            this.tb_Password.Enabled = false;
            this.tb_Password.Font = new System.Drawing.Font("Georgia", 18.2F, System.Drawing.FontStyle.Bold);
            this.tb_Password.Location = new System.Drawing.Point(592, 384);
            this.tb_Password.MaxLength = 6;
            this.tb_Password.Multiline = true;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '$';
            this.tb_Password.Size = new System.Drawing.Size(315, 45);
            this.tb_Password.TabIndex = 11;
            // 
            // tb_User_Name
            // 
            this.tb_User_Name.Font = new System.Drawing.Font("Georgia", 18.2F, System.Drawing.FontStyle.Bold);
            this.tb_User_Name.Location = new System.Drawing.Point(592, 233);
            this.tb_User_Name.MaxLength = 25;
            this.tb_User_Name.Multiline = true;
            this.tb_User_Name.Name = "tb_User_Name";
            this.tb_User_Name.Size = new System.Drawing.Size(315, 45);
            this.tb_User_Name.TabIndex = 9;
            this.tb_User_Name.TextChanged += new System.EventHandler(this.tb_User_Name_TextChanged);
            // 
            // btn_Refresh
            // 
            this.btn_Refresh.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Refresh.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_Refresh.ForeColor = System.Drawing.Color.Navy;
            this.btn_Refresh.Location = new System.Drawing.Point(138, 621);
            this.btn_Refresh.Name = "btn_Refresh";
            this.btn_Refresh.Size = new System.Drawing.Size(201, 49);
            this.btn_Refresh.TabIndex = 13;
            this.btn_Refresh.Text = "Refresh";
            this.btn_Refresh.UseVisualStyleBackColor = false;
            this.btn_Refresh.Click += new System.EventHandler(this.btn_Refresh_Click);
            // 
            // btn_Submit
            // 
            this.btn_Submit.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Submit.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_Submit.ForeColor = System.Drawing.Color.Navy;
            this.btn_Submit.Location = new System.Drawing.Point(706, 621);
            this.btn_Submit.Name = "btn_Submit";
            this.btn_Submit.Size = new System.Drawing.Size(201, 49);
            this.btn_Submit.TabIndex = 14;
            this.btn_Submit.Text = "Submit";
            this.btn_Submit.UseVisualStyleBackColor = false;
            this.btn_Submit.Click += new System.EventHandler(this.btn_Submit_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_Password.Font = new System.Drawing.Font("Georgia", 18.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Password.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Password.Location = new System.Drawing.Point(132, 384);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(280, 45);
            this.lbl_Password.TabIndex = 12;
            this.lbl_Password.Text = "Password";
            this.lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_User_Name
            // 
            this.lbl_User_Name.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_User_Name.Font = new System.Drawing.Font("Georgia", 18.2F, System.Drawing.FontStyle.Bold);
            this.lbl_User_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_User_Name.Location = new System.Drawing.Point(132, 233);
            this.lbl_User_Name.Name = "lbl_User_Name";
            this.lbl_User_Name.Size = new System.Drawing.Size(280, 45);
            this.lbl_User_Name.TabIndex = 10;
            this.lbl_User_Name.Text = "User Name";
            this.lbl_User_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbl_Login);
            this.panel1.Location = new System.Drawing.Point(3, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1100, 142);
            this.panel1.TabIndex = 16;
            // 
            // lbl_Login
            // 
            this.lbl_Login.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_Login.Font = new System.Drawing.Font("Georgia", 26.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Login.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Login.Location = new System.Drawing.Point(379, 35);
            this.lbl_Login.Name = "lbl_Login";
            this.lbl_Login.Size = new System.Drawing.Size(358, 70);
            this.lbl_Login.TabIndex = 1;
            this.lbl_Login.Text = "Login";
            this.lbl_Login.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 776);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Note);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_User_Name);
            this.Controls.Add(this.btn_Refresh);
            this.Controls.Add(this.btn_Submit);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_User_Name);
            this.Name = "frm_Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Note;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_User_Name;
        private System.Windows.Forms.Button btn_Refresh;
        private System.Windows.Forms.Button btn_Submit;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_User_Name;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Login;
    }
}