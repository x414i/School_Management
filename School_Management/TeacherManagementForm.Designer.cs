namespace School_Management
{
    partial class TeacherManagementForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnEditTeacher = new System.Windows.Forms.Button();
            this.btnDeleteTeacher = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cmbSubject = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(329, 9);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(185, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "إدارة الاستاذة";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Cairo", 10F);
            this.txtName.Location = new System.Drawing.Point(329, 22);
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName.Size = new System.Drawing.Size(151, 32);
            this.txtName.TabIndex = 2;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.FlatAppearance.BorderSize = 0;
            this.btnAddTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeacher.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnAddTeacher.Location = new System.Drawing.Point(205, 77);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddTeacher.Size = new System.Drawing.Size(123, 83);
            this.btnAddTeacher.TabIndex = 3;
            this.btnAddTeacher.Text = "اضافة استاذ";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnEditTeacher
            // 
            this.btnEditTeacher.FlatAppearance.BorderSize = 0;
            this.btnEditTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTeacher.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnEditTeacher.Location = new System.Drawing.Point(30, 77);
            this.btnEditTeacher.Name = "btnEditTeacher";
            this.btnEditTeacher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEditTeacher.Size = new System.Drawing.Size(123, 83);
            this.btnEditTeacher.TabIndex = 4;
            this.btnEditTeacher.Text = "تعديل الاستاذ";
            this.btnEditTeacher.UseVisualStyleBackColor = true;
            this.btnEditTeacher.Click += new System.EventHandler(this.btnEditTeacher_Click_1);
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.FlatAppearance.BorderSize = 0;
            this.btnDeleteTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTeacher.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnDeleteTeacher.Location = new System.Drawing.Point(30, 180);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDeleteTeacher.Size = new System.Drawing.Size(123, 83);
            this.btnDeleteTeacher.TabIndex = 5;
            this.btnDeleteTeacher.Text = "حذف الاستاذ";
            this.btnDeleteTeacher.UseVisualStyleBackColor = true;
            this.btnDeleteTeacher.Click += new System.EventHandler(this.btnDeleteTeacher_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnClose.Location = new System.Drawing.Point(205, 181);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClose.Size = new System.Drawing.Size(123, 83);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "اغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeachers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Location = new System.Drawing.Point(2, 282);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTeachers.Size = new System.Drawing.Size(937, 252);
            this.dgvTeachers.TabIndex = 7;
            this.dgvTeachers.SelectionChanged += new System.EventHandler(this.dgvTeachers_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 10F);
            this.label2.Location = new System.Drawing.Point(490, 22);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(80, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "اسم الاستاذ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 10F);
            this.label3.Location = new System.Drawing.Point(494, 73);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(76, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "اسم المادة";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Cairo", 10F);
            this.txtPhone.Location = new System.Drawing.Point(24, 76);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPhone.Size = new System.Drawing.Size(159, 32);
            this.txtPhone.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Cairo", 10F);
            this.txtEmail.Location = new System.Drawing.Point(24, 25);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmail.Size = new System.Drawing.Size(159, 32);
            this.txtEmail.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo", 10F);
            this.label4.Location = new System.Drawing.Point(224, 79);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(77, 26);
            this.label4.TabIndex = 12;
            this.label4.Text = "رقم الهاتف";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo", 10F);
            this.label5.Location = new System.Drawing.Point(200, 28);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(101, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "البريد الالكتروني";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Cairo", 10F);
            this.txtSearch.Location = new System.Drawing.Point(205, 147);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(275, 32);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnSearch.Location = new System.Drawing.Point(48, 147);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSearch.Size = new System.Drawing.Size(100, 33);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cairo", 10F);
            this.label6.Location = new System.Drawing.Point(493, 154);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(35, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "بحث";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cmbSubject);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Location = new System.Drawing.Point(366, 78);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(573, 199);
            this.panel1.TabIndex = 17;
            // 
            // cmbSubject
            // 
            this.cmbSubject.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(329, 70);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(150, 32);
            this.cmbSubject.TabIndex = 17;
            // 
            // TeacherManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 536);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteTeacher);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.dgvTeachers);
            this.Controls.Add(this.btnEditTeacher);
            this.Controls.Add(this.label1);
            this.Name = "TeacherManagementForm";
            this.Text = "TeacherManagementForm";
            this.Load += new System.EventHandler(this.TeacherManagementForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnEditTeacher;
        private System.Windows.Forms.Button btnDeleteTeacher;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvTeachers;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbSubject;
    }
}