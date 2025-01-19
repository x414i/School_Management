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
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddClass
            // 
            this.btnAddClass.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddClass.Location = new System.Drawing.Point(238, 0);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(102, 74);
            this.btnAddClass.TabIndex = 0;
            this.btnAddClass.Text = "Add Class";
            this.btnAddClass.UseVisualStyleBackColor = true;
            this.btnAddClass.Click += new System.EventHandler(this.btnAddClass_Click_1);
            // 
            // btnEditClass
            // 
            this.btnEditClass.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditClass.Location = new System.Drawing.Point(38, 3);
            this.btnEditClass.Name = "btnEditClass";
            this.btnEditClass.Size = new System.Drawing.Size(102, 74);
            this.btnEditClass.TabIndex = 1;
            this.btnEditClass.Text = "Edit Class";
            this.btnEditClass.UseVisualStyleBackColor = true;
            this.btnEditClass.Click += new System.EventHandler(this.btnEditClass_Click_1);
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClass.Location = new System.Drawing.Point(38, 83);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(102, 74);
            this.btnDeleteClass.TabIndex = 2;
            this.btnDeleteClass.Text = "Delete Class";
            this.btnDeleteClass.UseVisualStyleBackColor = true;
            this.btnDeleteClass.Click += new System.EventHandler(this.btnDeleteClass_Click_1);
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Cairo", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(238, 83);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(102, 74);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click_1);
            // 
            // txtLevel
            // 
            this.txtLevel.Font = new System.Drawing.Font("Cairo", 10F);
            this.txtLevel.Location = new System.Drawing.Point(19, 85);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(285, 32);
            this.txtLevel.TabIndex = 4;
            // 
            // txtClassName
            // 
            this.txtClassName.Font = new System.Drawing.Font("Cairo", 10F);
            this.txtClassName.Location = new System.Drawing.Point(19, 40);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(285, 32);
            this.txtClassName.TabIndex = 5;
            // 
            // dgvClasses
            // 
            this.dgvClasses.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClasses.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Location = new System.Drawing.Point(-1, 174);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.Size = new System.Drawing.Size(799, 282);
            this.dgvClasses.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 10F);
            this.label1.Location = new System.Drawing.Point(322, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 26);
            this.label1.TabIndex = 7;
            this.label1.Text = "Grade";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 10F);
            this.label2.Location = new System.Drawing.Point(326, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 26);
            this.label2.TabIndex = 8;
            this.label2.Text = "Level";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtLevel);
            this.panel1.Controls.Add(this.txtClassName);
            this.panel1.Location = new System.Drawing.Point(412, 8);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(376, 160);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnClose);
            this.panel2.Controls.Add(this.btnDeleteClass);
            this.panel2.Controls.Add(this.btnEditClass);
            this.panel2.Controls.Add(this.btnAddClass);
            this.panel2.Location = new System.Drawing.Point(12, 8);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(385, 160);
            this.panel2.TabIndex = 10;
            // 
            // ClassManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dgvClasses);
            this.Name = "ClassManagementForm";
            this.Text = "ClassManagementForm";
            this.Load += new System.EventHandler(this.ClassManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel2;
    }
}