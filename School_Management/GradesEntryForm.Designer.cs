﻿namespace School_Management
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
            this.cmbStudents = new System.Windows.Forms.ComboBox();
            this.cmbSubjects = new System.Windows.Forms.ComboBox();
            this.txtGrade = new System.Windows.Forms.TextBox();
            this.dtpExamDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvGrades = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnEditGrade = new System.Windows.Forms.Button();
            this.btnDeleteGrade = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSaveGrade
            // 
            this.btnSaveGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.btnSaveGrade.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnSaveGrade.FlatAppearance.BorderSize = 2;
            this.btnSaveGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveGrade.Font = new System.Drawing.Font("Cairo ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnSaveGrade.Image = global::School_Management.Properties.Resources.icons8_save_30;
            this.btnSaveGrade.Location = new System.Drawing.Point(45, 15);
            this.btnSaveGrade.Name = "btnSaveGrade";
            this.btnSaveGrade.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSaveGrade.Size = new System.Drawing.Size(100, 40);
            this.btnSaveGrade.TabIndex = 0;
            this.btnSaveGrade.Text = "حفظ";
            this.btnSaveGrade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSaveGrade.UseVisualStyleBackColor = false;
            this.btnSaveGrade.Click += new System.EventHandler(this.btnSaveGrade_Click_1);
            // 
            // cmbStudents
            // 
            this.cmbStudents.Font = new System.Drawing.Font("Cairo", 10F);
            this.cmbStudents.FormattingEnabled = true;
            this.cmbStudents.Location = new System.Drawing.Point(679, 67);
            this.cmbStudents.Name = "cmbStudents";
            this.cmbStudents.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbStudents.Size = new System.Drawing.Size(351, 32);
            this.cmbStudents.TabIndex = 2;
            this.cmbStudents.SelectedIndexChanged += new System.EventHandler(this.cmbStudents_SelectedIndexChanged);
            // 
            // cmbSubjects
            // 
            this.cmbSubjects.Font = new System.Drawing.Font("Cairo", 10F);
            this.cmbSubjects.FormattingEnabled = true;
            this.cmbSubjects.Location = new System.Drawing.Point(215, 12);
            this.cmbSubjects.Name = "cmbSubjects";
            this.cmbSubjects.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.cmbSubjects.Size = new System.Drawing.Size(351, 32);
            this.cmbSubjects.TabIndex = 3;
            this.cmbSubjects.SelectedIndexChanged += new System.EventHandler(this.cmbSubjects_SelectedIndexChanged);
            // 
            // txtGrade
            // 
            this.txtGrade.Font = new System.Drawing.Font("Cairo", 10F);
            this.txtGrade.Location = new System.Drawing.Point(679, 15);
            this.txtGrade.Name = "txtGrade";
            this.txtGrade.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtGrade.Size = new System.Drawing.Size(351, 32);
            this.txtGrade.TabIndex = 4;
            this.txtGrade.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtpExamDate
            // 
            this.dtpExamDate.Font = new System.Drawing.Font("Cairo", 10F);
            this.dtpExamDate.Location = new System.Drawing.Point(215, 68);
            this.dtpExamDate.Name = "dtpExamDate";
            this.dtpExamDate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dtpExamDate.Size = new System.Drawing.Size(351, 32);
            this.dtpExamDate.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.label1.Location = new System.Drawing.Point(1078, 22);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(45, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "الدرجة";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.label2.Location = new System.Drawing.Point(1075, 67);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(50, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "الطالب";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.label3.Location = new System.Drawing.Point(613, 12);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(47, 24);
            this.label3.TabIndex = 8;
            this.label3.Text = "المادة";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.label4.Location = new System.Drawing.Point(579, 68);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(92, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "تاريخ الامتحان";
            // 
            // dgvGrades
            // 
            this.dgvGrades.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvGrades.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvGrades.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.dgvGrades.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGrades.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvGrades.Location = new System.Drawing.Point(0, 277);
            this.dgvGrades.Name = "dgvGrades";
            this.dgvGrades.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvGrades.Size = new System.Drawing.Size(1152, 291);
            this.dgvGrades.TabIndex = 10;
            this.dgvGrades.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvGrades_CellContentClick);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Cairo", 10F);
            this.txtSearch.Location = new System.Drawing.Point(541, 176);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(358, 32);
            this.txtSearch.TabIndex = 11;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnSearch.FlatAppearance.BorderSize = 2;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Cairo ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnSearch.Image = global::School_Management.Properties.Resources.icons8_search_30;
            this.btnSearch.Location = new System.Drawing.Point(390, 173);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSearch.Size = new System.Drawing.Size(100, 40);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "بحث";
            this.btnSearch.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.label5.Location = new System.Drawing.Point(963, 182);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(43, 24);
            this.label5.TabIndex = 10;
            this.label5.Text = "البحث";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(171)))));
            this.panel2.Controls.Add(this.btnEditGrade);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.btnDeleteGrade);
            this.panel2.Controls.Add(this.cmbStudents);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearch);
            this.panel2.Controls.Add(this.cmbSubjects);
            this.panel2.Controls.Add(this.btnSaveGrade);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.txtGrade);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.dtpExamDate);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Font = new System.Drawing.Font("Cairo", 10F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel2.Size = new System.Drawing.Size(1152, 280);
            this.panel2.TabIndex = 14;
            // 
            // btnEditGrade
            // 
            this.btnEditGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.btnEditGrade.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnEditGrade.FlatAppearance.BorderSize = 2;
            this.btnEditGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditGrade.Font = new System.Drawing.Font("Cairo ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnEditGrade.Image = global::School_Management.Properties.Resources.icons8_update_30;
            this.btnEditGrade.Location = new System.Drawing.Point(45, 182);
            this.btnEditGrade.Name = "btnEditGrade";
            this.btnEditGrade.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEditGrade.Size = new System.Drawing.Size(100, 40);
            this.btnEditGrade.TabIndex = 10;
            this.btnEditGrade.Text = "تعديل";
            this.btnEditGrade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditGrade.UseVisualStyleBackColor = false;
            this.btnEditGrade.Click += new System.EventHandler(this.btnEditGrade_Click);
            // 
            // btnDeleteGrade
            // 
            this.btnDeleteGrade.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.btnDeleteGrade.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnDeleteGrade.FlatAppearance.BorderSize = 2;
            this.btnDeleteGrade.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteGrade.Font = new System.Drawing.Font("Cairo ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteGrade.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnDeleteGrade.Image = global::School_Management.Properties.Resources.icons8_delete_32;
            this.btnDeleteGrade.Location = new System.Drawing.Point(45, 96);
            this.btnDeleteGrade.Name = "btnDeleteGrade";
            this.btnDeleteGrade.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDeleteGrade.Size = new System.Drawing.Size(100, 40);
            this.btnDeleteGrade.TabIndex = 11;
            this.btnDeleteGrade.Text = "حذف";
            this.btnDeleteGrade.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteGrade.UseVisualStyleBackColor = false;
            this.btnDeleteGrade.Click += new System.EventHandler(this.btnDeleteGrade_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cairo", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(403, 9);
            this.label6.Name = "label6";
            this.label6.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label6.Size = new System.Drawing.Size(0, 50);
            this.label6.TabIndex = 13;
            // 
            // GradesEntryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(1152, 568);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgvGrades);
            this.Name = "GradesEntryForm";
            this.Text = "الدرجات";
            this.Load += new System.EventHandler(this.GradesEntryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvGrades)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveGrade;
        private System.Windows.Forms.ComboBox cmbStudents;
        private System.Windows.Forms.ComboBox cmbSubjects;
        private System.Windows.Forms.TextBox txtGrade;
        private System.Windows.Forms.DateTimePicker dtpExamDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvGrades;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnEditGrade;
        private System.Windows.Forms.Button btnDeleteGrade;
    }
}