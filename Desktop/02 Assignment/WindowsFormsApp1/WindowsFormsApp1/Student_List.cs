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
    public partial class frm_Student_List : Form
    {
        public frm_Student_List()
        {
            InitializeComponent();
        }

        private void lbl_Add_Student_Click(object sender, EventArgs e)
        {
            frm_Student_Details AddStud = new frm_Student_Details();
            AddStud.Show();
            this.Hide();
        }

        private void bt_Logout_Click(object sender, EventArgs e)
        {
            frm_Login FLogin = new frm_Login();
            FLogin.Show();
            this.Hide();
        }

        private void frm_Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fork_Student_Addmission_System_DBDataSet1.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.fork_Student_Addmission_System_DBDataSet1.Student_Details);

        }

        private void bt_Add_Student_Click(object sender, EventArgs e)
        {
            frm_Student_Details AddStud = new frm_Student_Details();
            AddStud.Show();
            this.Hide();
        }
    }
}
