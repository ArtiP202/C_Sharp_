using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGM_College_Admission_App
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        void Clear_Control()
        {
            tb_User_Name.Clear();
            tb_Password.Clear();
        }

        private void frm_Login_Load(object sender, EventArgs e)
        {
            tb_User_Name.Focus();
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Control();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            if (tb_User_Name.Text == "ARTI" && tb_Password.Text == "a" || tb_User_Name.Text == "Admin" && tb_Password.Text == "a")
            {
                frm_Student_Details AddStud = new frm_Student_Details();
                AddStud.Show();
                this.Hide();
            }
           else
            {
                MessageBox.Show("Login Failed,Enter Correct User Name or Password", "Failuer");
            }
            Clear_Control();
        }

        private void tb_User_Name_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
            lbl_Note.Visible = true;
        }
    }
}
