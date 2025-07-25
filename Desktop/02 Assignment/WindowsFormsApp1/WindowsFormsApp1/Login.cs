using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class frm_Login : Form
    {
        public frm_Login()
        {
            InitializeComponent();
        }

        void Clear_Controls()
        {
            tb_User_Name.Text = "";
            tb_Password.Text = "";
        }
        private void frm_Login_Load(object sender, EventArgs e)
        {
            tb_User_Name.Focus();
        }
        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
        private void bt_Submit_Click(object sender, EventArgs e)
        {
            if (tb_User_Name.Text == "ARTI" && tb_Password.Text == "a"  || tb_User_Name.Text == "Admin" && tb_Password.Text == "a")
            {
                frm_Student_Details SDet = new frm_Student_Details();
                SDet.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed,Enter Correct User Name or Password", "Failure");
            }
            Clear_Controls();
        }

        private void tb_User_Name_TextChanged(object sender, EventArgs e)
        {
            tb_Password.Enabled = true;
            lbl_Error.Enabled = true;
        }
    }
}
