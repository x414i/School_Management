namespace School_Management
{
    partial class GradesEntryForm
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
            this.btnSaveGrade = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.dtpExamDate = new System.Windows.Forms.DateTimePicker();
            this.SuspendLayout();
            // 
            // btnSaveGrade
            // 
            this.btnSaveGrade.Location = new System.Drawing.Point(12, 22);
            this.btnSaveGrade.Name = "btnSaveGrade";
            this.btnSaveGrade.Size = new System.Drawing.Size(75, 23);
            this.btnSaveGrade.TabIndex = 0;
            this.btnSaveGrade.Text = "Save Grade";
            this.btnSaveGrade.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(120, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // cmbStudents
            // 
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Location = new System.Drawing.Point(211, 128);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.Size = new System.Drawing.Size(121, 21);
            this.cmbStudents.TabIndex = 2;
            // 
            // cmbSubjects
            // 
            this.cmbSubjects.FormattingEnabled = true;
            this.cmbSubjects.Location = new System.Drawing.Point(202, 74);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.Size = new System.Drawing.Size(121, 21);
            this.cmbSubjects.TabIndex = 3;
            // 
            // txtGrade
            // 
            this.txtGrade.Location = new System.Drawing.Point(24, 74);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.Size = new System.Drawing.Size(100, 20);
            this.txtGrade.TabIndex = 4;
            // 
            // dtpExamDate
            // 
            this.dtpExamDate.Location = new System.Drawing.Point(47, 155);
            this.dtpExamDate.Name = "dtpExamDate";
            this.dtpExamDate.Size = new System.Drawing.Size(200, 20);
            this.dtpExamDate.TabIndex = 5;
            // 
            // GradesEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtpExamDate);
            this.Controls.Add(this.txtGrade);
            this.Controls.Add(this.cmbSubjects);
            this.Controls.Add(this.cmbStudents);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveGrade);
            this.Name = "GradesEntryForm";
            this.Text = "GradesEntryForm";
            this.Load += new System.EventHandler(this.GradesEntryForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveGrade;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.ComboBox cmbSubjects;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.DateTimePicker dtpExamDate;
    }
}