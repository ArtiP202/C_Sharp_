using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SGM_College_Admission_App
{
    public partial class frm_Student_List : Form
    {
        public frm_Student_List()
        {
            InitializeComponent();
        }

        private void frm_Student_List_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'fork_Student_Addmission_System_DBDataSet.Student_Details' table. You can move, or remove it, as needed.
            this.student_DetailsTableAdapter.Fill(this.fork_Student_Addmission_System_DBDataSet.Student_Details);

        }

        private void btn_Logout_Click(object sender, EventArgs e)
        {
            frm_Login LOGIN = new frm_Login();
            LOGIN.Show();
            this.Hide();
        }

        private void btn_Add_Student_Click(object sender, EventArgs e)
        {
            frm_Student_Details ADD = new frm_Student_Details();
            ADD.Show();
            this.Hide();
        }
    }
}
