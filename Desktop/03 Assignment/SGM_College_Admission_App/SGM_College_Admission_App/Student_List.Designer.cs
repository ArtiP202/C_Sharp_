
namespace SGM_College_Admission_App
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
            this.btn_Logout = new System.Windows.Forms.Button();
            this.lbl_Student_List = new System.Windows.Forms.Label();
            this.dgv_Student_List = new System.Windows.Forms.DataGridView();
            this.rollNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dOBDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mobileNoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.courseDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.studentDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fork_Student_Addmission_System_DBDataSet = new SGM_College_Admission_App.Fork_Student_Addmission_System_DBDataSet();
            this.btn_Add_Student = new System.Windows.Forms.Button();
            this.student_DetailsTableAdapter = new SGM_College_Admission_App.Fork_Student_Addmission_System_DBDataSetTableAdapters.Student_DetailsTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_List)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_Student_Addmission_System_DBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panel1.Controls.Add(this.btn_Logout);
            this.panel1.Controls.Add(this.lbl_Student_List);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1141, 130);
            this.panel1.TabIndex = 9;
            // 
            // btn_Logout
            // 
            this.btn_Logout.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Logout.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_Logout.ForeColor = System.Drawing.Color.Navy;
            this.btn_Logout.Location = new System.Drawing.Point(970, 0);
            this.btn_Logout.Name = "btn_Logout";
            this.btn_Logout.Size = new System.Drawing.Size(171, 42);
            this.btn_Logout.TabIndex = 2;
            this.btn_Logout.Text = "Logout";
            this.btn_Logout.UseVisualStyleBackColor = false;
            this.btn_Logout.Click += new System.EventHandler(this.btn_Logout_Click);
            // 
            // lbl_Student_List
            // 
            this.lbl_Student_List.BackColor = System.Drawing.Color.LightCoral;
            this.lbl_Student_List.Font = new System.Drawing.Font("Georgia", 26.2F, System.Drawing.FontStyle.Bold);
            this.lbl_Student_List.ForeColor = System.Drawing.Color.Navy;
            this.lbl_Student_List.Location = new System.Drawing.Point(357, 26);
            this.lbl_Student_List.Name = "lbl_Student_List";
            this.lbl_Student_List.Size = new System.Drawing.Size(384, 70);
            this.lbl_Student_List.TabIndex = 0;
            this.lbl_Student_List.Text = "Student List";
            this.lbl_Student_List.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dgv_Student_List
            // 
            this.dgv_Student_List.AutoGenerateColumns = false;
            this.dgv_Student_List.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Student_List.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Student_List.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.rollNoDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dOBDataGridViewTextBoxColumn,
            this.mobileNoDataGridViewTextBoxColumn,
            this.courseDataGridViewTextBoxColumn});
            this.dgv_Student_List.DataSource = this.studentDetailsBindingSource;
            this.dgv_Student_List.Location = new System.Drawing.Point(1, 128);
            this.dgv_Student_List.Name = "dgv_Student_List";
            this.dgv_Student_List.RowHeadersWidth = 51;
            this.dgv_Student_List.RowTemplate.Height = 24;
            this.dgv_Student_List.Size = new System.Drawing.Size(1141, 537);
            this.dgv_Student_List.TabIndex = 10;
            // 
            // rollNoDataGridViewTextBoxColumn
            // 
            this.rollNoDataGridViewTextBoxColumn.DataPropertyName = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.HeaderText = "Roll_No";
            this.rollNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.rollNoDataGridViewTextBoxColumn.Name = "rollNoDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dOBDataGridViewTextBoxColumn
            // 
            this.dOBDataGridViewTextBoxColumn.DataPropertyName = "DOB";
            this.dOBDataGridViewTextBoxColumn.HeaderText = "DOB";
            this.dOBDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dOBDataGridViewTextBoxColumn.Name = "dOBDataGridViewTextBoxColumn";
            // 
            // mobileNoDataGridViewTextBoxColumn
            // 
            this.mobileNoDataGridViewTextBoxColumn.DataPropertyName = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.HeaderText = "Mobile_No";
            this.mobileNoDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.mobileNoDataGridViewTextBoxColumn.Name = "mobileNoDataGridViewTextBoxColumn";
            // 
            // courseDataGridViewTextBoxColumn
            // 
            this.courseDataGridViewTextBoxColumn.DataPropertyName = "Course";
            this.courseDataGridViewTextBoxColumn.HeaderText = "Course";
            this.courseDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.courseDataGridViewTextBoxColumn.Name = "courseDataGridViewTextBoxColumn";
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
            // btn_Add_Student
            // 
            this.btn_Add_Student.BackColor = System.Drawing.Color.SkyBlue;
            this.btn_Add_Student.Font = new System.Drawing.Font("Georgia", 16.2F, System.Drawing.FontStyle.Bold);
            this.btn_Add_Student.ForeColor = System.Drawing.Color.Navy;
            this.btn_Add_Student.Location = new System.Drawing.Point(412, 681);
            this.btn_Add_Student.Name = "btn_Add_Student";
            this.btn_Add_Student.Size = new System.Drawing.Size(300, 49);
            this.btn_Add_Student.TabIndex = 1;
            this.btn_Add_Student.Text = "Add Student";
            this.btn_Add_Student.UseVisualStyleBackColor = false;
            this.btn_Add_Student.Click += new System.EventHandler(this.btn_Add_Student_Click);
            // 
            // student_DetailsTableAdapter
            // 
            this.student_DetailsTableAdapter.ClearBeforeFill = true;
            // 
            // frm_Student_List
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 753);
            this.Controls.Add(this.btn_Add_Student);
            this.Controls.Add(this.dgv_Student_List);
            this.Controls.Add(this.panel1);
            this.Name = "frm_Student_List";
            this.Text = "Student List";
            this.Load += new System.EventHandler(this.frm_Student_List_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Student_List)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fork_Student_Addmission_System_DBDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_Student_List;
        private System.Windows.Forms.DataGridView dgv_Student_List;
        private System.Windows.Forms.Button btn_Add_Student;
        private System.Windows.Forms.Button btn_Logout;
        private Fork_Student_Addmission_System_DBDataSet fork_Student_Addmission_System_DBDataSet;
        private System.Windows.Forms.BindingSource studentDetailsBindingSource;
        private Fork_Student_Addmission_System_DBDataSetTableAdapters.Student_DetailsTableAdapter student_DetailsTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn rollNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dOBDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn mobileNoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn courseDataGridViewTextBoxColumn;
    }
}