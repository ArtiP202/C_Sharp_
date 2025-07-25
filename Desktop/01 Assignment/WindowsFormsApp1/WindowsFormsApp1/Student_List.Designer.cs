
namespace WindowsFormsApp1
{
    partial class frm_Student_List
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bt_Logout = new System.Windows.Forms.Button();
            this.lbl_Student_List = new System.Windows.Forms.Label();
            this.bt_Add_Student = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fork_Student_Addmission_System_DBDataSet = new WindowsFormsApp1.Fork_Student_Addmission_System_DBDataSet();
            this.student_DetailsTableAdapter = new WindowsFormsApp1.Fork_Student_Addmission_System_DBDataSetTableAdapters.Student_DetailsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_Student_Addmission_System_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.bt_Logout);
            this.panel1.Controls.Add(this.lbl_Student_List);
            this.panel1.Location = new System.Drawing.Point(2, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1192, 139);
            this.panel1.TabIndex = 14;
            // 
            // bt_Logout
            // 
            this.bt_Logout.BackColor = System.Drawing.Color.LightBlue;
            this.bt_Logout.Font = new System.Drawing.Font("Georgia", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Logout.Location = new System.Drawing.Point(985, 23);
            this.bt_Logout.Name = "bt_Logout";
            this.bt_Logout.Size = new System.Drawing.Size(145, 50);
            this.bt_Logout.TabIndex = 16;
            this.bt_Logout.Text = "Logout";
            this.bt_Logout.UseVisualStyleBackColor = false;
            this.bt_Logout.Click += new System.EventHandler(this.bt_Logout_Click);
            // 
            // lbl_Student_List
            // 
            this.lbl_Student_List.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_Student_List.Font = new System.Drawing.Font("Georgia", 30F, System.Drawing.FontStyle.Bold);
            this.lbl_Student_List.Location = new System.Drawing.Point(361, 23);
            this.lbl_Student_List.Name = "lbl_Student_List";
            this.lbl_Student_List.Size = new System.Drawing.Size(490, 85);
            this.lbl_Student_List.TabIndex = 15;
            this.lbl_Student_List.Text = "Student List";
            this.lbl_Student_List.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bt_Add_Student
            // 
            this.bt_Add_Student.BackColor = System.Drawing.Color.LightCoral;
            this.bt_Add_Student.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_Add_Student.Location = new System.Drawing.Point(494, 716);
            this.bt_Add_Student.Name = "bt_Add_Student";
            this.bt_Add_Student.Size = new System.Drawing.Size(263, 64);
            this.bt_Add_Student.TabIndex = 0;
            this.bt_Add_Student.Text = "Add Student";
            this.bt_Add_Student.UseVisualStyleBackColor = false;
            this.bt_Add_Student.Click += new System.EventHandler(this.bt_Add_Student_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.studentDetailsBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(39, 188);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1109, 500);
            this.dataGridView1.TabIndex = 15;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            this.rollNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            this.mobileNoDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            this.dOBDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
            this.courseDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // studentDetailsBindingSource
            // 
            this.studentDetailsBindingSource.DataMember = "Student_Details";
            this.studentDetailsBindingSource.DataSource = this.fork_Student_Addmission_System_DBDataSet;
            // 
            // fork_Student_Addmission_System_DBDataSet
            // 
            this.fork_Student_Addmission_System_DBDataSet.DataSetName = "Fork_Student_Addmission_System_DBDataSet";
            this.fork_Student_Addmission_System_DBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Honeydew;
            this.ClientSize = new System.Drawing.Size(1192, 803);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.bt_Add_Student);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.Color.Navy;
            this.Name = "frm_Student_List";
            this.Text = "Student List";
            this.Load += new System.EventHandler(this.frm_Student_List_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_Student_Addmission_System_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Student_List;
        private System.Windows.Forms.Button bt_Add_Student;
        private System.Windows.Forms.Button bt_Logout;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Fork_Student_Addmission_System_DBDataSet fork_Student_Addmission_System_DBDataSet;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private Fork_Student_Addmission_System_DBDataSetTableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
    }
}