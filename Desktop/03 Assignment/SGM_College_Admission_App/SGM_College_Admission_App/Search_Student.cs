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
    public partial class frm_Search_Student : Form
    {
        public frm_Search_Student()
        {
            InitializeComponent();
        }
        SqlConnection FCon = new SqlConnection(@"Data Source=DESKTOP-K7OJKVI;Initial Catalog=Fork_Student_Addmission_System_DB;Integrated Security=True");

        void FCon_Start()
        {
            if(FCon.State != ConnectionState.Open)
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
            dtp_DOB.Text = "1-12-2009";
            tb_Mobile_No.Clear();
            cmb_Course.SelectedIndex = -1;
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
        private void btn_Search_Click(object sender, EventArgs e)
        {
            FCon_Start();
            if(tb_Roll_No .Text !="")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.CommandText = "Select * From Student_Details Where Roll_No = @Rno";

                Cmd.Connection = FCon;

                Cmd.Parameters.Add("Rno", SqlDbType.Int).Value = tb_Roll_No.Text;

                SqlDataReader DR = Cmd.ExecuteReader();

                if(DR.Read())
                {
                    tb_User_Name.Text = DR.GetString(DR.GetOrdinal("Name"));
                    dtp_DOB.Text = DR["DOB"].ToString();
                    tb_Mobile_No.Text = (DR["Mobile_No"].ToString()) ;
                    cmb_Course.Text = DR.GetString(DR.GetOrdinal("Course"));
                }
                else
                {
                    MessageBox.Show("Invalid Roll No", "No Data Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    tb_Roll_No.Clear();
                }
            }
            FCon_Stop();     
        }
        private void btn_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
        }
        private void btn_UpdateStud_Click(object sender, EventArgs e)
        {
            frm_Update Update = new frm_Update();
            Update.Show();
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
