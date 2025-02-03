namespace School_Management
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
            this.btnClose = new System.Windows.Forms.Button();
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
            this.btnAddClass.FlatAppearance.BorderSize = 0;
            this.btnAddClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddClass.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClass.ForeColor = System.Drawing.Color.White;
            this.btnAddClass.Location = new System.Drawing.Point(202, 0);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddClass.Size = new System.Drawing.Size(102, 74);
            this.btnAddClass.TabIndex = 0;
            this.btnAddClass.Text = "اضافة صف";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click_1);
            // 
            // btnEditClass
            // 
            this.btnEditClass.FlatAppearance.BorderSize = 0;
            this.btnEditClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditClass.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditClass.ForeColor = System.Drawing.Color.White;
            this.btnEditClass.Location = new System.Drawing.Point(202, 80);
            this.btnEditClass.Name = "btnEditClass";
            this.btnEditClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEditClass.Size = new System.Drawing.Size(102, 74);
            this.btnEditClass.TabIndex = 1;
            this.btnEditClass.Text = "تعديل صف";
            this.btnEditClass.UseVisualStyleBackColor = true;
            this.btnEditClass.Click += new System.EventHandler(this.btnEditClass_Click_1);
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.FlatAppearance.BorderSize = 0;
            this.btnDeleteClass.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteClass.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClass.ForeColor = System.Drawing.Color.White;
            this.btnDeleteClass.Location = new System.Drawing.Point(51, 0);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDeleteClass.Size = new System.Drawing.Size(102, 74);
            this.btnDeleteClass.TabIndex = 2;
            this.btnDeleteClass.Text = "حذف الصف";
            this.btnDeleteClass.UseVisualStyleBackColor = true;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Location = new System.Drawing.Point(51, 85);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClose.Size = new System.Drawing.Size(102, 74);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "اغلاق";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // txtLevel
            // 
            this.txtLevel.Font = new System.Drawing.Font("Cairo", 10F);
            this.txtLevel.Location = new System.Drawing.Point(19, 85);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtLevel.Size = new System.Drawing.Size(285, 32);
            this.txtLevel.TabIndex = 4;
            // 
            // txtClassName
            // 
            this.txtClassName.Font = new System.Drawing.Font("Cairo", 10F);
            this.txtClassName.Location = new System.Drawing.Point(19, 40);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtClassName.Size = new System.Drawing.Size(285, 32);
            this.txtClassName.TabIndex = 5;
            // 
            // dgvClasses
            // 
            this.dgvClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClasses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClasses.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.dgvClasses.Location = new System.Drawing.Point(0, 167);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvClasses.Size = new System.Drawing.Size(726, 260);
            this.dgvClasses.TabIndex = 6;
            this.dgvClasses.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClasses_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 10F);
            this.label1.Location = new System.Drawing.Point(322, 43);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(47, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "الصف";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 10F);
            this.label2.Location = new System.Drawing.Point(316, 88);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(53, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "المرحلة";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtLevel);
            this.panel1.Controls.Add(this.txtClassName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(350, 0);
            this.panel1.Name = "panel1";
            this.panel1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel1.Size = new System.Drawing.Size(376, 167);
            this.panel1.TabIndex = 9;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // ClassManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(726, 427);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnAddClass);
            this.Controls.Add(this.btnDeleteClass);
            this.Controls.Add(this.btnEditClass);
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
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.DataGridView dgvClasses;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
    }
}