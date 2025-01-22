namespace School_Management
{
    partial class SubjectManagementForm
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
            this.dgvSubjects = new System.Windows.Forms.DataGridView();
            this.txtSubjectName = new System.Windows.Forms.TextBox();
            this.cmbTeachers = new System.Windows.Forms.ComboBox();
            this.btnAddSubject = new System.Windows.Forms.Button();
            this.btnEditSubject = new System.Windows.Forms.Button();
            this.btnDeleteSubject = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSubjects.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.Location = new System.Drawing.Point(0, -1);
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvSubjects.Size = new System.Drawing.Size(800, 313);
            this.dgvSubjects.TabIndex = 0;
            this.dgvSubjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubjects_CellContentClick);
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Font = new System.Drawing.Font("Cairo", 10F);
            this.txtSubjectName.Location = new System.Drawing.Point(107, 9);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSubjectName.Size = new System.Drawing.Size(249, 32);
            this.txtSubjectName.TabIndex = 1;
            // 
            // cmbTeachers
            // 
            this.cmbTeachers.Font = new System.Drawing.Font("Cairo", 10F);
            this.cmbTeachers.FormattingEnabled = true;
            this.cmbTeachers.Location = new System.Drawing.Point(107, 55);
            this.cmbTeachers.Name = "cmbTeachers";
            this.cmbTeachers.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbTeachers.Size = new System.Drawing.Size(249, 32);
            this.cmbTeachers.TabIndex = 2;
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnAddSubject.Location = new System.Drawing.Point(112, 9);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddSubject.Size = new System.Drawing.Size(97, 38);
            this.btnAddSubject.TabIndex = 3;
            this.btnAddSubject.Text = "إضافة مادة";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            this.btnAddSubject.Click += new System.EventHandler(this.btnAddSubject_Click_1);
            // 
            // btnEditSubject
            // 
            this.btnEditSubject.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnEditSubject.Location = new System.Drawing.Point(-1, 9);
            this.btnEditSubject.Name = "btnEditSubject";
            this.btnEditSubject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEditSubject.Size = new System.Drawing.Size(98, 38);
            this.btnEditSubject.TabIndex = 4;
            this.btnEditSubject.Text = "تعديل مادة";
            this.btnEditSubject.UseVisualStyleBackColor = true;
            this.btnEditSubject.Click += new System.EventHandler(this.btnEditSubject_Click);
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnDeleteSubject.Location = new System.Drawing.Point(112, 53);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDeleteSubject.Size = new System.Drawing.Size(97, 38);
            this.btnDeleteSubject.TabIndex = 5;
            this.btnDeleteSubject.Text = "حذف";
            this.btnDeleteSubject.UseVisualStyleBackColor = true;
            this.btnDeleteSubject.Click += new System.EventHandler(this.btnDeleteSubject_Click);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnClose.Location = new System.Drawing.Point(-1, 53);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClose.Size = new System.Drawing.Size(98, 38);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 10F);
            this.label1.Location = new System.Drawing.Point(389, 12);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(76, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "اسم المادة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 10F);
            this.label2.Location = new System.Drawing.Point(385, 55);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(80, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "اسم الاستاذ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.btnDeleteSubject);
            this.panel1.Controls.Add(this.btnEditSubject);
            this.panel1.Controls.Add(this.btnAddSubject);
            this.panel1.Location = new System.Drawing.Point(56, 322);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(220, 104);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.cmbTeachers);
            this.panel2.Controls.Add(this.txtSubjectName);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(331, 322);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(469, 116);
            this.panel2.TabIndex = 10;
            // 
            // SubjectManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvSubjects);
            this.Name = "SubjectManagementForm";
            this.Text = "SubjectManagementForm";
            this.Load += new System.EventHandler(this.SubjectManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.ComboBox cmbTeachers;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Button btnEditSubject;
        private System.Windows.Forms.Button btnDeleteSubject;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}