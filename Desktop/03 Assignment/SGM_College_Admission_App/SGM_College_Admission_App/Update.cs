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
    public partial class frm_Update : Form
    {
        public frm_Update()
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
            dtp_DOB.Text = "20-08-2005";
        }

        void Enable_Contols()
        {
            tb_User_Name.Enabled = true;
            tb_Mobile_No.Enabled = true;
            dtp_DOB.Enabled = true;
            cmb_Course.Enabled = true;

            tb_Roll_No.Enabled = false;
        }

        void Disable_Controls()
        {
            tb_User_Name.Enabled = false;
            tb_Mobile_No.Enabled = false;
            dtp_DOB.Enabled = false;
            cmb_Course.Enabled = false;

            tb_Roll_No.Enabled = true;
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
            if (!(char.IsLetter (e.KeyChar) || ( e.KeyChar == (char)Keys.Back) ||(e.KeyChar ==(char)Keys.Space)))
            {
                e.Handled = true;
            }
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            Disable_Controls();
            tb_Roll_No.Focus();
        }
        private void btn_Update_Click(object sender, EventArgs e)
        {
            FCon_Start();

                if (tb_Roll_No.Text != "" && tb_User_Name.Text != "" && dtp_DOB.Text != "" && tb_Mobile_No.Text != "" && cmb_Course.Text != "")
                {

                    SqlCommand cmd = new SqlCommand();

                    cmd.Connection = FCon;
                    cmd.CommandText = "Update Student_details set Name = @Nm, DOB = @Db, Mobile_No =@Mobile, Course = @Course  where Roll_No = @RNo";

                    cmd.Parameters.Add("RNo", SqlDbType.Int).Value = tb_Roll_No.Text;
                    cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_User_Name.Text;
                    cmd.Parameters.Add("Db", SqlDbType.Date).Value = dtp_DOB.Text;
                    cmd.Parameters.Add("mobile", SqlDbType.Decimal).Value = tb_Mobile_No.Text;
                    cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;


                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Record Updated Successful..", "Succress", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
                }
                else
                {
                    MessageBox.Show("No Such student", "No record Found", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    tb_Roll_No.Clear();
                    tb_Roll_No.Focus();

   
                }


                FCon_Stop();
            
        }
        private void btn_Add_Stud_Click(object sender, EventArgs e)
        {
            frm_Student_Details ADD = new frm_Student_Details();
            ADD.Show();
            this.Hide();
        }
        private void btn_Search_Click(object sender, EventArgs e)
        {
            frm_Search_Student SearchStud = new frm_Search_Student();
            SearchStud.Show();
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
    }
}
