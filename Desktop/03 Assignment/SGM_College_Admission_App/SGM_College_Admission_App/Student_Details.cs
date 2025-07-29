using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SGM_College_Admission_App
{
    public partial class frm_Student_Details : Form
    {
        public frm_Student_Details()
        {
            InitializeComponent();
        }

       SqlConnection FCon = new SqlConnection(@"Data Source=DESKTOP-K7OJKVI;Initial Catalog=Fork_Student_Addmission_System_DB;Integrated Security=True");

        void FCon_Start()
        {
            if (FCon.State != ConnectionState.Open)
            {
                FCon.Open();
            }
        }
        void FCon_Stop()
        {
            if (FCon.State != ConnectionState.Closed)
            {
                FCon.Close();
            }
        }

        void Clear_Controls()
        {
            tb_Roll_No.Clear();
            tb_User_Name.Clear();
            tb_Mobile_No.Clear();
            cmb_Course.SelectedIndex = -1;
            dtp_DOB.Text = "02-Dec-2005";
        }


        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
        private void btn_Save_Click(object sender, EventArgs e)
        {
            FCon_Start();
            {
               if(tb_Roll_No.Text != "" && tb_User_Name.Text != "" && dtp_DOB.Text != "" && tb_Mobile_No.Text != "" && cmb_Course.SelectedIndex>=0 )
                {
                    SqlCommand cmd = new SqlCommand();
                    cmd.Connection = FCon;
                    cmd.CommandText = "Insert Into Student_Details Values(@RNo,@Nm,@Db,@Mno,@Course)";

                    cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                    cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_User_Name.Text;
                    cmd.Parameters.Add("Db", SqlDbType.Date).Value = dtp_DOB.Text;
                    cmd.Parameters.Add("Mno", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                    cmd.Parameters.Add("Course",SqlDbType.NVarChar).Value = cmb_Course.Text;

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Student Details Saved Succesfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Clear_Controls();
                }
                else
                {
                    MessageBox.Show("Fill All Information First");
                }

            }

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            frm_Search_Student SearchStud = new frm_Search_Student();
            SearchStud.Show();
            this.Hide();
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            frm_Update UpdateStud = new frm_Update();
            UpdateStud.Show();
            this.Hide();
        }

        private void btn_Student_List_Click(object sender, EventArgs e)
        {
            frm_Student_List SList = new frm_Student_List();
            SList.Show();
            this.Hide();
        }
        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login LOGIN = new frm_Login();
            LOGIN.Show();
            this.Hide();
        }

        private void frm_Student_Details_Load(object sender, EventArgs e)
        {

        }
    }
}
