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
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvSubjects
            // 
            this.dgvSubjects.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSubjects.Location = new System.Drawing.Point(0, 0);
            this.dgvSubjects.Name = "dgvSubjects";
            this.dgvSubjects.Size = new System.Drawing.Size(240, 150);
            this.dgvSubjects.TabIndex = 0;
            this.dgvSubjects.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSubjects_CellContentClick);
            // 
            // txtSubjectName
            // 
            this.txtSubjectName.Location = new System.Drawing.Point(23, 189);
            this.txtSubjectName.Name = "txtSubjectName";
            this.txtSubjectName.Size = new System.Drawing.Size(100, 20);
            this.txtSubjectName.TabIndex = 1;
            // 
            // cmbTeachers
            // 
            this.cmbTeachers.FormattingEnabled = true;
            this.cmbTeachers.Location = new System.Drawing.Point(142, 188);
            this.cmbTeachers.Name = "cmbTeachers";
            this.cmbTeachers.Size = new System.Drawing.Size(121, 21);
            this.cmbTeachers.TabIndex = 2;
            // 
            // btnAddSubject
            // 
            this.btnAddSubject.Location = new System.Drawing.Point(86, 263);
            this.btnAddSubject.Name = "btnAddSubject";
            this.btnAddSubject.Size = new System.Drawing.Size(75, 23);
            this.btnAddSubject.TabIndex = 3;
            this.btnAddSubject.Text = "Add Subject";
            this.btnAddSubject.UseVisualStyleBackColor = true;
            // 
            // btnEditSubject
            // 
            this.btnEditSubject.Location = new System.Drawing.Point(12, 234);
            this.btnEditSubject.Name = "btnEditSubject";
            this.btnEditSubject.Size = new System.Drawing.Size(75, 23);
            this.btnEditSubject.TabIndex = 4;
            this.btnEditSubject.Text = "Edit Subject";
            this.btnEditSubject.UseVisualStyleBackColor = true;
            // 
            // btnDeleteSubject
            // 
            this.btnDeleteSubject.Location = new System.Drawing.Point(77, 298);
            this.btnDeleteSubject.Name = "btnDeleteSubject";
            this.btnDeleteSubject.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteSubject.TabIndex = 5;
            this.btnDeleteSubject.Text = "Delete Subject";
            this.btnDeleteSubject.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(-25, 298);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // SubjectManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteSubject);
            this.Controls.Add(this.btnEditSubject);
            this.Controls.Add(this.btnAddSubject);
            this.Controls.Add(this.cmbTeachers);
            this.Controls.Add(this.txtSubjectName);
            this.Controls.Add(this.dgvSubjects);
            this.Name = "SubjectManagementForm";
            this.Text = "SubjectManagementForm";
            this.Load += new System.EventHandler(this.SubjectManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSubjects)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvSubjects;
        private System.Windows.Forms.TextBox txtSubjectName;
        private System.Windows.Forms.ComboBox cmbTeachers;
        private System.Windows.Forms.Button btnAddSubject;
        private System.Windows.Forms.Button btnEditSubject;
        private System.Windows.Forms.Button btnDeleteSubject;
        private System.Windows.Forms.Button btnClose;
    }
}