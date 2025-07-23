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

namespace WindowsFormsApp1
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

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
            {
                e.Handled = true;
            }
        }
        void Clear_Controls()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mobile_No.Clear();
            cmb_Course.SelectedIndex = -1;
            dtp_DOB.Text = "01-Jan-2005";
        }

        private void bt_Refresh_Click(object sender, EventArgs e)
        {
            Clear_Controls();
            tb_Roll_No.Focus();
        }

        private void bt_Search_Click(object sender, EventArgs e)
        {
            FCon_Start();

            if (tb_Roll_No.Text != "")
            {
                SqlCommand Cmd = new SqlCommand();

                Cmd.CommandText = "Select * From Student_Details Where Roll_No = @Rno";

                Cmd.Connection = FCon;

                Cmd.Parameters.Add("Rno", SqlDbType.Int).Value = tb_Roll_No.Text;

                SqlDataReader DR = Cmd.ExecuteReader();

                if (DR.Read())
                {
                    tb_Name.Text = DR.GetString(DR.GetOrdinal("Name"));
                    dtp_DOB.Text = DR["DOB"].ToString();
                    tb_Mobile_No.Text = (DR["Mobile_No"].ToString());
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

        private void bt_Student_List_Click(object sender, EventArgs e)
        {
            frm_Student_List SList = new frm_Student_List();
            SList.Show();
            this.Hide();
        }

        private void bt_Logout_Click(object sender, EventArgs e)
        {
            frm_Login FLogin = new frm_Login();
            FLogin.Show();
            this.Hide();
        }
        private void bt_Add_Student_Click(object sender, EventArgs e)
        {
            frm_Student_Details AddStud = new frm_Student_Details();
            AddStud.Show();
            this.Hide();
        }
    }
}
