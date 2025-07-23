using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employee_Details
{
    public partial class frm_Use_Windows_Control : Form
    {
        public frm_Use_Windows_Control()
        {
            InitializeComponent();
        }

        private void Only_text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space) || (e.KeyChar == (char)Keys.ShiftKey) || (e.KeyChar == (char)Keys.CapsLock)))
            {
                e.Handled = true;
            }
        }
        private void frm_Use_Windows_Control_Load(object sender, EventArgs e)
        {
            tb_Employe_Name.Focus();
        }
        private void bt_Submit_Click(object sender, EventArgs e)
        {
            //-Harry- from departmenr - Testing - is - Male - candidate,Prefers shift timming - Evening -.

            string Result = "";

            bool Flag = true;

            if (tb_Employe_Name.Text != "")
            {
                Result = tb_Employe_Name.Text + " from department ";

                if (cmb_Department.Text != "")
                {
                    Result += cmb_Department.Text + " is ";
                }
                if (rb_Male.Checked == true)
                {
                    Result += rb_Male.Text + "  candidate,Prefers shift timing";
                }
                else if (rb_Female.Checked == true)
                {
                    Result += rb_Female.Text + "  candidate,Prefers shift timing ";
                }
                else
                {
                    MessageBox.Show("Select Gender of Employee");
                    Flag = false;
                }

                if (rb_Morning.Checked == true)
                {
                    Result += rb_Morning.Text + " .";
                }
                else if (rb_Evening.Checked == true)
                {
                    Result += rb_Evening.Text + " .";
                }
                else if (rb_Night.Checked == true)
                {
                    Result += rb_Night.Text + " .";
                }
                else
                {
                    MessageBox.Show("Select Shift Time");
                    Flag = false;
                }
            }
            else
            {
                MessageBox.Show("Enter Name of Employeee");
                Flag = false;
            }
            if (Flag == true)
            {
                tb_Output.Text = Result;
            }
        }

        private void bt_Reset_Click(object sender, EventArgs e)
        {
            tb_Employe_Name.Clear();
            tb_Output.Clear();
            cmb_Department.SelectedIndex = -1;

            rb_Male.Checked = false;
            rb_Female.Checked = false;

            rb_Morning.Checked = false;
            rb_Night.Checked = false;
            rb_Evening.Checked = false;
        }
    }
}
