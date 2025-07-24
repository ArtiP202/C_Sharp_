using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Employeee_Application
{
    public partial class frm_Employee : Form
    {
        public frm_Employee()
        {
            InitializeComponent();
        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            string Result = "";
            bool Flag = true, LFlag = true;

            ////////////////////////////////////////////////
            
            if(tb_Employe_Name.Text != "")
            {
                Result += tb_Employe_Name.Text + " is From Departmen";
                lbl_Name_Error.Visible = false;
            }
            else
            {
                lbl_Name_Error.Text = "Enter Employe Name";
                lbl_Name_Error.Visible = true;
                Flag = false;
            }
           
            //////////////////////////////////////////////
            

            if(cmb_Department.Text != "")
            {
                Result += cmb_Department.Text;
                lbl_Department_Error.Visible = false;
            }
            else
            {
                lbl_Department_Error.Text = "Select Department";
                lbl_Department_Error.Visible = true;
                Flag = false;
            }

            //////////////////////////////////////////////
            
            if(rb_Male.Checked ==  true)
            {
                Result += " , is " + rb_Male.Text + " And He Knows ";
                lbl_Gender_Error.Visible = false;
            }
            else if (rb_Female.Checked == true)
            {
                Result += " , is " + rb_Female.Text + " And He Knows ";
                lbl_Gender_Error.Visible = false;
            }
            else
            {
                lbl_Gender_Error.Text = " Select Gender ";
                lbl_Gender_Error.Visible = true;
                Flag = false;
            }

            //////////////////////////////////////////////
            
            if(cb_Marathi.Checked == true)
            {
                Result += cb_Marathi.Text + ",";
                lbl_Language_Error.Visible = false;
                LFlag = false;
            }

            if (cb_Hindi.Checked == true)
            {
                Result += cb_Hindi.Text + ",";
                lbl_Language_Error.Visible = false;
                LFlag = false;
            }

            if (cb_English.Checked == true)
            {
                Result += cb_English.Text + ",";
                lbl_Language_Error.Visible = false;
                LFlag = false;
            }

            if (cb_Franch.Checked == true)
            {
                Result += cb_Franch.Text + ",";
                lbl_Language_Error.Visible = false;
                LFlag = false;
            }

            if(LFlag == true)
            {
                lbl_Language_Error.Text = " Select Known Language ";
                lbl_Language_Error.Visible = true;
                Flag = false;
            }

            //////////////////////////////////////////////

            int Cnt = clb_Hobbies.CheckedItems.Count;

            if(Cnt > 0)
            {
                lbl_Hobbies_Error.Visible = false;
                Result += " And Has Hobbies as ";

                for(int i =0; i<clb_Hobbies.Items.Count;i++)
                {
                    if (clb_Hobbies.GetItemChecked(i))
                    {
                        if(Cnt > 1)
                        {
                            Result += clb_Hobbies.Items[i] + ",";
                        }
                        else
                        {
                            Result += clb_Hobbies.Items[i] + ".";
                            break;
                        }
                        Cnt--;
                    }
                }
            }
            else
            {
                lbl_Hobbies_Error.Text = " Select Atleast 1 Hobby ";
                lbl_Hobbies_Error.Visible = true;
                Flag = false;
            }

            /////////////////////////////////////////////////
            
            if(Flag == false)
            {
                // MessageBox.Show(" Incomplete Data", "Fill Required Details ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                tb_Result.Visible = false;
            }
            else
            {
                tb_Result.Text = Result;
                tb_Result.Visible = true;
            }
        }
        private void btn_Reset_Click(object sender, EventArgs e)
        {
            tb_Employe_Name.Clear();
            cmb_Department.SelectedIndex = -1;

            rb_Female.Checked = false;
            rb_Male.Checked = false;

            cb_English.Checked = false;
            cb_Franch.Checked = false;
            cb_Hindi.Checked = false;
            cb_Marathi.Checked = false;

            for(int i= 0;i<clb_Hobbies.Items.Count;i++)
            {
                clb_Hobbies.SetItemChecked(i, false);
            }
            tb_Result.Visible = false;
        }

        private void btn_Submit_MouseHover(object sender, EventArgs e)
        {
            btn_Submit.BackColor = Color.HotPink;
            btn_Submit.ForeColor = Color.Indigo;
        }

        private void btn_Submit_MouseLeave(object sender, EventArgs e)
        {
            btn_Submit.BackColor = Color.LightSeaGreen;
            btn_Submit.ForeColor = Color.Cyan;
        }

        private void btn_Submit_MouseDown(object sender, MouseEventArgs e)
        {
            btn_Submit.BackColor = Color.Crimson;
        }

        private void btn_Submit_MouseUp(object sender, MouseEventArgs e)
        {
            btn_Submit.ForeColor = Color.DimGray;
        }
    }
}
