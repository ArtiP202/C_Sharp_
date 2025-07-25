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
    public partial class frm_Student_Details : Form
    {
        public frm_Student_Details()
        {
            InitializeComponent();
        }

        SqlConnection FCon = new SqlConnection(@"Data Source=DESKTOP-K7OJKVI;Initial Catalog=Fork_Student_Addmission_System_DB;Integrated Security=True ");
        void Fcon_Start()
        {
            if (FCon.State != ConnectionState.Open)
            {
                FCon.Open();
            }
        }
        void Fcon_Stop()
        {
            if (FCon.State != ConnectionState.Closed)
            {
                FCon.Close();
            }
        }
        void Clear_Controls()
        {
            tb_Roll_No.Clear();
            tb_Name.Clear();
            tb_Mob_No.Clear();
            cmb_Course.SelectedIndex = -1;
            dtp_DOB.Text = "01-Jan-2005";
        }
        private void bt_Save_Click(object sender, EventArgs e)
        {

            Fcon_Start();
            if (tb_Roll_No.Text != "" && tb_Name.Text != "" && dtp_DOB.Text != ""&& tb_Mob_No.Text != "" && cmb_Course.SelectedIndex >= 0)
            {
                SqlCommand cmd = new SqlCommand();

                cmd.Connection = FCon;
                cmd.CommandText = "Insert Into Student_Details Values(@Rno,@Nm,@Db,@Mno,@Course)";

                cmd.Parameters.Add("Rno", SqlDbType.Int).Value = tb_Roll_No.Text;
                cmd.Parameters.Add("Nm", SqlDbType.VarChar).Value = tb_Name.Text;
                cmd.Parameters.Add("Db", SqlDbType.Date).Value = dtp_DOB.Text;
                cmd.Parameters.Add("Mno", SqlDbType.Decimal).Value = tb_Mob_No.Text;
                cmd.Parameters.Add("Course", SqlDbType.NVarChar).Value = cmb_Course.Text;

                cmd.ExecuteNonQuery();

                MessageBox.Show("Student Details Saved Successfully ", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Clear_Controls();
            }
            else
            {
                MessageBox.Show("First  Fill all Filds");
            }
            Fcon_Stop();
        }
         private void bt_Refresh_Click(object sender, EventArgs e)
            {
                Clear_Controls();
            }
        private void bt_Student_List_Click(object sender, EventArgs e)
        {
            frm_Student_List SLIST = new frm_Student_List();
            SLIST.Show();
            this.Hide();
        }
        private void bt_Logout_Click(object sender, EventArgs e)
        {
            frm_Login_Form LFRM = new frm_Login_Form();
            LFRM.Show();
            this.Hide();
        }

        private void Only_Text(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsLetter(e.KeyChar) || (e.KeyChar == (char)Keys.Back) || (e.KeyChar == (char)Keys.Space)))
            {
                e.Handled = true;
            }
        }

        private void Only_Numeric(object sender, KeyPressEventArgs e)
        {
            if(!(char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                {
                e.Handled = true;
                }
        }

        private void bt_Refresh_Click_1(object sender, EventArgs e)
        {
            Clear_Controls();
        }
    }
}
