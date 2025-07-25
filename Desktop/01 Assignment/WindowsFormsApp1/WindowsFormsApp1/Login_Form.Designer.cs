
namespace WindowsFormsApp1
{
    partial class frm_Login_Form
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
            this.lbl_Login_Form = new System.Windows.Forms.Label();
            this.bt_Login = new System.Windows.Forms.Button();
            this.bt_Refresh = new System.Windows.Forms.Button();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.lbl_User_Name = new System.Windows.Forms.Label();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.tb_Name = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.lbl_Login_Form);
            this.panel1.Location = new System.Drawing.Point(2, 1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 130);
            this.panel1.TabIndex = 14;
            // 
            // lbl_Login_Form
            // 
            this.lbl_Login_Form.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_Login_Form.Font = new System.Drawing.Font("Georgia", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login_Form.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Login_Form.Location = new System.Drawing.Point(332, 19);
            this.lbl_Login_Form.Name = "lbl_Login_Form";
            this.lbl_Login_Form.Size = new System.Drawing.Size(411, 80);
            this.lbl_Login_Form.TabIndex = 19;
            this.lbl_Login_Form.Text = "Login Form";
            this.lbl_Login_Form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_Login
            // 
            this.bt_Login.BackColor = System.Drawing.Color.LightBlue;
            this.bt_Login.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Login.ForeColor = System.Drawing.Color.Navy;
            this.bt_Login.Location = new System.Drawing.Point(632, 509);
            this.bt_Login.Name = "bt_Login";
            this.bt_Login.Size = new System.Drawing.Size(200, 60);
            this.bt_Login.TabIndex = 4;
            this.bt_Login.Text = "Login";
            this.bt_Login.UseVisualStyleBackColor = false;
            this.bt_Login.Click += new System.EventHandler(this.bt_Login_Click);
            // 
            // bt_Refresh
            // 
            this.bt_Refresh.BackColor = System.Drawing.Color.LightBlue;
            this.bt_Refresh.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Refresh.ForeColor = System.Drawing.Color.Navy;
            this.bt_Refresh.Location = new System.Drawing.Point(158, 509);
            this.bt_Refresh.Name = "bt_Refresh";
            this.bt_Refresh.Size = new System.Drawing.Size(200, 60);
            this.bt_Refresh.TabIndex = 3;
            this.bt_Refresh.Text = "Refresh";
            this.bt_Refresh.UseVisualStyleBackColor = false;
            this.bt_Refresh.Click += new System.EventHandler(this.bt_Refresh_Click);
            // 
            // lbl_Password
            // 
            this.lbl_Password.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_Password.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Password.Location = new System.Drawing.Point(119, 378);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(281, 50);
            this.lbl_Password.TabIndex = 17;
            this.lbl_Password.Text = "Password";
            this.lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_User_Name
            // 
            this.lbl_User_Name.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_User_Name.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_User_Name.Location = new System.Drawing.Point(119, 228);
            this.lbl_User_Name.Name = "lbl_User_Name";
            this.lbl_User_Name.Size = new System.Drawing.Size(281, 49);
            this.lbl_User_Name.TabIndex = 18;
            this.lbl_User_Name.Text = "User Name";
            this.lbl_User_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tb_Password
            // 
            this.tb_Password.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(668, 378);
            this.tb_Password.MaxLength = 6;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '$';
            this.tb_Password.Size = new System.Drawing.Size(336, 45);
            this.tb_Password.TabIndex = 2;
            // 
            // tb_Name
            // 
            this.tb_Name.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Name.Location = new System.Drawing.Point(668, 228);
            this.tb_Name.MaxLength = 25;
            this.tb_Name.Name = "tb_Name";
            this.tb_Name.Size = new System.Drawing.Size(336, 45);
            this.tb_Name.TabIndex = 1;
            this.tb_Name.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Only_Text);
            // 
            // frm_Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1068, 657);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_Name);
            this.Controls.Add(this.lbl_User_Name);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.bt_Refresh);
            this.Controls.Add(this.bt_Login);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Login_Form";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Login;
        private System.Windows.Forms.Button bt_Refresh;
        private System.Windows.Forms.Label lbl_Login_Form;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Label lbl_User_Name;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.TextBox tb_Name;
    }
}

