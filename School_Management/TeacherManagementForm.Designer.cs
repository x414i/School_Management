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
            this.label1.Size = new System.Drawing.Size(0, 50);
            this.label1.TabIndex = 0;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Cairo", 10F);
            this.txtName.Location = new System.Drawing.Point(661, 41);
            this.txtName.Name = "txtName";
            this.txtName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtName.Size = new System.Drawing.Size(347, 32);
            this.txtName.TabIndex = 2;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.BackColor = System.Drawing.Color.Transparent;
            this.btnAddTeacher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnAddTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddTeacher.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnAddTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnAddTeacher.Image = global::School_Management.Properties.Resources.icons8_add_30;
            this.btnAddTeacher.Location = new System.Drawing.Point(36, 27);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddTeacher.Size = new System.Drawing.Size(100, 40);
            this.btnAddTeacher.TabIndex = 3;
            this.btnAddTeacher.Text = "اضافة ";
            this.btnAddTeacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddTeacher.UseVisualStyleBackColor = false;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnEditTeacher
            // 
            this.btnEditTeacher.BackColor = System.Drawing.Color.Transparent;
            this.btnEditTeacher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnEditTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditTeacher.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnEditTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnEditTeacher.Image = global::School_Management.Properties.Resources.icons8_update_30;
            this.btnEditTeacher.Location = new System.Drawing.Point(36, 92);
            this.btnEditTeacher.Name = "btnEditTeacher";
            this.btnEditTeacher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEditTeacher.Size = new System.Drawing.Size(100, 40);
            this.btnEditTeacher.TabIndex = 4;
            this.btnEditTeacher.Text = "تعديل";
            this.btnEditTeacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditTeacher.UseVisualStyleBackColor = false;
            this.btnEditTeacher.Click += new System.EventHandler(this.btnEditTeacher_Click_1);
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.BackColor = System.Drawing.Color.Transparent;
            this.btnDeleteTeacher.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnDeleteTeacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteTeacher.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnDeleteTeacher.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnDeleteTeacher.Image = global::School_Management.Properties.Resources.icons8_delete_32;
            this.btnDeleteTeacher.Location = new System.Drawing.Point(36, 152);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDeleteTeacher.Size = new System.Drawing.Size(100, 40);
            this.btnDeleteTeacher.TabIndex = 5;
            this.btnDeleteTeacher.Text = "حذف ";
            this.btnDeleteTeacher.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteTeacher.UseVisualStyleBackColor = false;
            this.btnDeleteTeacher.Click += new System.EventHandler(this.btnDeleteTeacher_Click_1);
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTeachers.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvTeachers.Location = new System.Drawing.Point(0, 214);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvTeachers.Size = new System.Drawing.Size(1152, 354);
            this.dgvTeachers.TabIndex = 7;
            this.dgvTeachers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTeachers_CellContentClick);
            this.dgvTeachers.SelectionChanged += new System.EventHandler(this.dgvTeachers_SelectionChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 10F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.label2.Location = new System.Drawing.Point(1018, 41);
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
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.label3.Location = new System.Drawing.Point(1022, 92);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(76, 26);
            this.label3.TabIndex = 9;
            this.label3.Text = "اسم المادة";
            // 
            // txtPhone
            // 
            this.txtPhone.Font = new System.Drawing.Font("Cairo", 10F);
            this.txtPhone.Location = new System.Drawing.Point(175, 89);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPhone.Size = new System.Drawing.Size(334, 32);
            this.txtPhone.TabIndex = 10;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Cairo", 10F);
            this.txtEmail.Location = new System.Drawing.Point(175, 38);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmail.Size = new System.Drawing.Size(334, 32);
            this.txtEmail.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo", 10F);
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.label4.Location = new System.Drawing.Point(550, 92);
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
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.label5.Location = new System.Drawing.Point(526, 41);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(101, 26);
            this.label5.TabIndex = 13;
            this.label5.Text = "البريد الالكتروني";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Cairo", 10F);
            this.txtSearch.Location = new System.Drawing.Point(577, 152);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(275, 32);
            this.txtSearch.TabIndex = 14;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnSearch.Image = global::School_Management.Properties.Resources.icons8_search_30;
            this.btnSearch.Location = new System.Drawing.Point(451, 147);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSearch.Size = new System.Drawing.Size(100, 40);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "بحث";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cairo", 10F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.label6.Location = new System.Drawing.Point(908, 152);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(35, 26);
            this.label6.TabIndex = 16;
            this.label6.Text = "بحث";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.btnDeleteTeacher);
            this.panel1.Controls.Add(this.cmbSubject);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.txtPhone);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.btnAddTeacher);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.btnEditTeacher);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(1152, 216);
            this.panel1.TabIndex = 17;
            // 
            // cmbSubject
            // 
            this.cmbSubject.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSubject.FormattingEnabled = true;
            this.cmbSubject.Location = new System.Drawing.Point(661, 89);
            this.cmbSubject.Name = "cmbSubject";
            this.cmbSubject.Size = new System.Drawing.Size(346, 32);
            this.cmbSubject.TabIndex = 17;
            // 
            // TeacherManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 568);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvTeachers);
            this.Controls.Add(this.label1);
            this.Name = "TeacherManagementForm";
            this.Text = "إدارة الاستاذة";
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