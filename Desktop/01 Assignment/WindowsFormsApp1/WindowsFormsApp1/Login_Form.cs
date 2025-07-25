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
    public partial class frm_Login_Form : Form
    {
        public frm_Login_Form()
        {
            InitializeComponent();
        }
       void Clear_Controls()
        {
            tb_Name.Text = "";
            tb_Password.Text = "";
        }
        private void bt_Login_Click(object sender, EventArgs e)
        {
            if (tb_Name.Text == "ARTI" && tb_Password.Text == "a")
            {
                frm_Student_Details SDET = new frm_Student_Details();
                SDET.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Login Failed,Enter Correct user name or password", "Failure");
            }
            tb_Name.Clear();
            tb_Password.Clear();
        }

        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsLetter(e.KeyChar)|| (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }
    }
}
