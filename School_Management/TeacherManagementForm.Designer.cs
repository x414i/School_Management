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
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnAddTeacher = new System.Windows.Forms.Button();
            this.btnEditTeacher = new System.Windows.Forms.Button();
            this.btnDeleteTeacher = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.dgvTeachers = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(250, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(152, 93);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(100, 20);
            this.txtSubject.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(292, 93);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 2;
            // 
            // btnAddTeacher
            // 
            this.btnAddTeacher.Location = new System.Drawing.Point(33, 144);
            this.btnAddTeacher.Name = "btnAddTeacher";
            this.btnAddTeacher.Size = new System.Drawing.Size(75, 23);
            this.btnAddTeacher.TabIndex = 3;
            this.btnAddTeacher.Text = "Add Teacher";
            this.btnAddTeacher.UseVisualStyleBackColor = true;
            this.btnAddTeacher.Click += new System.EventHandler(this.btnAddTeacher_Click);
            // 
            // btnEditTeacher
            // 
            this.btnEditTeacher.Location = new System.Drawing.Point(33, 185);
            this.btnEditTeacher.Name = "btnEditTeacher";
            this.btnEditTeacher.Size = new System.Drawing.Size(75, 23);
            this.btnEditTeacher.TabIndex = 4;
            this.btnEditTeacher.Text = "Edit Teacher";
            this.btnEditTeacher.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTeacher
            // 
            this.btnDeleteTeacher.Location = new System.Drawing.Point(33, 223);
            this.btnDeleteTeacher.Name = "btnDeleteTeacher";
            this.btnDeleteTeacher.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTeacher.TabIndex = 5;
            this.btnDeleteTeacher.Text = "Delete Teacher";
            this.btnDeleteTeacher.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(33, 261);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // dgvTeachers
            // 
            this.dgvTeachers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTeachers.Location = new System.Drawing.Point(152, 134);
            this.dgvTeachers.Name = "dgvTeachers";
            this.dgvTeachers.Size = new System.Drawing.Size(240, 150);
            this.dgvTeachers.TabIndex = 7;
            // 
            // TeacherManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvTeachers);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteTeacher);
            this.Controls.Add(this.btnEditTeacher);
            this.Controls.Add(this.btnAddTeacher);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtSubject);
            this.Controls.Add(this.label1);
            this.Name = "TeacherManagementForm";
            this.Text = "TeacherManagementForm";
            this.Load += new System.EventHandler(this.TeacherManagementForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTeachers)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnAddTeacher;
        private System.Windows.Forms.Button btnEditTeacher;
        private System.Windows.Forms.Button btnDeleteTeacher;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.DataGridView dgvTeachers;
    }
}