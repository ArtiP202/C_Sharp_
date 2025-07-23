
namespace WindowsFormsApp1
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
            this.lbl_Login_Form = new System.Windows.Forms.Label();
            this.lbl_User_Name = new System.Windows.Forms.Label();
            this.lbl_Password = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Refresh = new System.Windows.Forms.Button();
            this.bt_Submit = new System.Windows.Forms.Button();
            this.tb_User_Name = new System.Windows.Forms.TextBox();
            this.tb_Password = new System.Windows.Forms.TextBox();
            this.lbl_Error = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_Login_Form
            // 
            this.lbl_Login_Form.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_Login_Form.Font = new System.Drawing.Font("Georgia", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Login_Form.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Login_Form.ImageAlign = System.Drawing.ContentAlignment.BottomRight;
            this.lbl_Login_Form.Location = new System.Drawing.Point(395, 36);
            this.lbl_Login_Form.Name = "lbl_Login_Form";
            this.lbl_Login_Form.Size = new System.Drawing.Size(383, 74);
            this.lbl_Login_Form.TabIndex = 0;
            this.lbl_Login_Form.Text = "Login Form";
            this.lbl_Login_Form.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_User_Name
            // 
            this.lbl_User_Name.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_User_Name.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_User_Name.ForeColor = System.Drawing.Color.Navy;
            this.lbl_User_Name.Location = new System.Drawing.Point(167, 261);
            this.lbl_User_Name.Name = "lbl_User_Name";
            this.lbl_User_Name.Size = new System.Drawing.Size(230, 51);
            this.lbl_User_Name.TabIndex = 1;
            this.lbl_User_Name.Text = "User Name";
            this.lbl_User_Name.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_Password
            // 
            this.lbl_Password.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_Password.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Password.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Password.Location = new System.Drawing.Point(167, 440);
            this.lbl_Password.Name = "lbl_Password";
            this.lbl_Password.Size = new System.Drawing.Size(230, 51);
            this.lbl_Password.TabIndex = 2;
            this.lbl_Password.Text = "Password";
            this.lbl_Password.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Honeydew;
            this.panel1.Controls.Add(this.lbl_Login_Form);
            this.panel1.Location = new System.Drawing.Point(2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 141);
            this.panel1.TabIndex = 3;
            // 
            // bt_Refresh
            // 
            this.bt_Refresh.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_Refresh.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Refresh.ForeColor = System.Drawing.Color.Navy;
            this.bt_Refresh.Location = new System.Drawing.Point(303, 631);
            this.bt_Refresh.Name = "bt_Refresh";
            this.bt_Refresh.Size = new System.Drawing.Size(175, 45);
            this.bt_Refresh.TabIndex = 3;
            this.bt_Refresh.Text = "Refresh";
            this.bt_Refresh.UseVisualStyleBackColor = false;
            this.bt_Refresh.Click += new System.EventHandler(this.bt_Refresh_Click);
            // 
            // bt_Submit
            // 
            this.bt_Submit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.bt_Submit.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Submit.ForeColor = System.Drawing.Color.Navy;
            this.bt_Submit.Location = new System.Drawing.Point(684, 631);
            this.bt_Submit.Name = "bt_Submit";
            this.bt_Submit.Size = new System.Drawing.Size(175, 45);
            this.bt_Submit.TabIndex = 4;
            this.bt_Submit.Text = "Submit";
            this.bt_Submit.UseVisualStyleBackColor = false;
            this.bt_Submit.Click += new System.EventHandler(this.bt_Submit_Click);
            // 
            // tb_User_Name
            // 
            this.tb_User_Name.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_User_Name.Location = new System.Drawing.Point(675, 264);
            this.tb_User_Name.MaxLength = 20;
            this.tb_User_Name.Name = "tb_User_Name";
            this.tb_User_Name.Size = new System.Drawing.Size(355, 45);
            this.tb_User_Name.TabIndex = 1;
            this.tb_User_Name.TextChanged += new System.EventHandler(this.tb_User_Name_TextChanged);
            // 
            // tb_Password
            // 
            this.tb_Password.Enabled = false;
            this.tb_Password.Font = new System.Drawing.Font("Georgia", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_Password.Location = new System.Drawing.Point(675, 440);
            this.tb_Password.MaxLength = 6;
            this.tb_Password.Name = "tb_Password";
            this.tb_Password.PasswordChar = '$';
            this.tb_Password.Size = new System.Drawing.Size(355, 45);
            this.tb_Password.TabIndex = 2;
            // 
            // lbl_Error
            // 
            this.lbl_Error.Enabled = false;
            this.lbl_Error.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Error.Location = new System.Drawing.Point(298, 543);
            this.lbl_Error.Name = "lbl_Error";
            this.lbl_Error.Size = new System.Drawing.Size(618, 34);
            this.lbl_Error.TabIndex = 5;
            this.lbl_Error.Text = "Note : Enter Correct User Name or Password";
            this.lbl_Error.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // frm_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1178, 727);
            this.Controls.Add(this.lbl_Error);
            this.Controls.Add(this.tb_Password);
            this.Controls.Add(this.tb_User_Name);
            this.Controls.Add(this.bt_Submit);
            this.Controls.Add(this.bt_Refresh);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lbl_Password);
            this.Controls.Add(this.lbl_User_Name);
            this.Name = "frm_Login";
            this.Text = "Login  Form";
            this.Load += new System.EventHandler(this.frm_Login_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_Login_Form;
        private System.Windows.Forms.Label lbl_User_Name;
        private System.Windows.Forms.Label lbl_Password;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button bt_Refresh;
        private System.Windows.Forms.Button bt_Submit;
        private System.Windows.Forms.TextBox tb_User_Name;
        private System.Windows.Forms.TextBox tb_Password;
        private System.Windows.Forms.Label lbl_Error;
    }
}

