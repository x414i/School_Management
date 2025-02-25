﻿namespace School_Management
{
    partial class ClassManagementForm
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
            this.btnAddClass = new System.Windows.Forms.Button();
            this.btnEditClass = new System.Windows.Forms.Button();
            this.btnDeleteClass = new System.Windows.Forms.Button();
            this.txtLevel = new System.Windows.Forms.TextBox();
            this.txtClassName = new System.Windows.Forms.TextBox();
            this.dgvClasses = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddClass
            // 
            this.btnAddClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.btnAddClass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClass.Font = new System.Drawing.Font("Cairo ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnAddClass.Image = global::School_Management.Properties.Resources.icons8_add_30;
            this.btnAddClass.Location = new System.Drawing.Point(517, 87);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddClass.Size = new System.Drawing.Size(119, 55);
            this.btnAddClass.TabIndex = 0;
            this.btnAddClass.Text = "اضافة صف";
            this.btnAddClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAddClass.UseVisualStyleBackColor = false;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click_1);
            // 
            // btnEditClass
            // 
            this.btnEditClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.btnEditClass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnEditClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClass.Font = new System.Drawing.Font("Cairo ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnEditClass.Image = global::School_Management.Properties.Resources.icons8_save_30;
            this.btnEditClass.Location = new System.Drawing.Point(385, 87);
            this.btnEditClass.Name = "btnEditClass";
            this.btnEditClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEditClass.Size = new System.Drawing.Size(119, 55);
            this.btnEditClass.TabIndex = 1;
            this.btnEditClass.Text = "تعديل صف";
            this.btnEditClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEditClass.UseVisualStyleBackColor = false;
            this.btnEditClass.Click += new System.EventHandler(this.btnEditClass_Click_1);
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.btnDeleteClass.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnDeleteClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClass.Font = new System.Drawing.Font("Cairo ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnDeleteClass.Image = global::School_Management.Properties.Resources.icons8_delete_32;
            this.btnDeleteClass.Location = new System.Drawing.Point(250, 87);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDeleteClass.Size = new System.Drawing.Size(119, 55);
            this.btnDeleteClass.TabIndex = 2;
            this.btnDeleteClass.Text = "حذف الصف";
            this.btnDeleteClass.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnDeleteClass.UseVisualStyleBackColor = false;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click_1);
            // 
            // txtLevel
            // 
            this.txtLevel.Font = new System.Drawing.Font("Cairo", 10F);
            this.txtLevel.Location = new System.Drawing.Point(747, 113);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLevel.Size = new System.Drawing.Size(285, 32);
            this.txtLevel.TabIndex = 4;
            // 
            // txtClassName
            // 
            this.txtClassName.Font = new System.Drawing.Font("Cairo", 10F);
            this.txtClassName.Location = new System.Drawing.Point(747, 68);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtClassName.Size = new System.Drawing.Size(285, 32);
            this.txtClassName.TabIndex = 5;
            // 
            // dgvClasses
            // 
            this.dgvClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClasses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClasses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvClasses.Location = new System.Drawing.Point(0, 180);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvClasses.Size = new System.Drawing.Size(1152, 388);
            this.dgvClasses.TabIndex = 6;
            this.dgvClasses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasses_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.label1.Location = new System.Drawing.Point(1050, 71);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(44, 24);
            this.label1.TabIndex = 7;
            this.label1.Text = "الصف";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo ExtraBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.label2.Location = new System.Drawing.Point(1044, 116);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(53, 24);
            this.label2.TabIndex = 8;
            this.label2.Text = "المرحلة";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(171)))));
            this.panel1.Controls.Add(this.btnAddClass);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnDeleteClass);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.btnEditClass);
            this.panel1.Controls.Add(this.txtLevel);
            this.panel1.Controls.Add(this.txtClassName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(1152, 183);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ClassManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(171)))));
            this.ClientSize = new System.Drawing.Size(1152, 568);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvClasses);
            this.Name = "ClassManagementForm";
            this.Text = "الصفوف";
            this.Load += new System.EventHandler(this.ClassManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Button btnEditClass;
        private System.Windows.Forms.Button btnDeleteClass;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}