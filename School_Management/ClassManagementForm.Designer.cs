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
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddClass
            // 
            this.btnAddClass.Location = new System.Drawing.Point(27, 112);
            this.btnAddClass.Name = "btnAddClass";
            this.btnAddClass.Size = new System.Drawing.Size(75, 23);
            this.btnAddClass.TabIndex = 0;
            this.btnAddClass.Text = "Add Class";
            this.btnAddClass.UseVisualStyleBackColor = true;
            // 
            // btnEditClass
            // 
            this.btnEditClass.Location = new System.Drawing.Point(27, 166);
            this.btnEditClass.Name = "btnEditClass";
            this.btnEditClass.Size = new System.Drawing.Size(75, 23);
            this.btnEditClass.TabIndex = 1;
            this.btnEditClass.Text = "Edit Class";
            this.btnEditClass.UseVisualStyleBackColor = true;
            // 
            // btnDeleteClass
            // 
            this.btnDeleteClass.Location = new System.Drawing.Point(27, 226);
            this.btnDeleteClass.Name = "btnDeleteClass";
            this.btnDeleteClass.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteClass.TabIndex = 2;
            this.btnDeleteClass.Text = "Delete Class";
            this.btnDeleteClass.UseVisualStyleBackColor = true;
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(27, 274);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 3;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            // 
            // txtLevel
            // 
            this.txtLevel.Location = new System.Drawing.Point(261, 74);
            this.txtLevel.Name = "txtLevel";
            this.txtLevel.Size = new System.Drawing.Size(100, 20);
            this.txtLevel.TabIndex = 4;
            // 
            // txtClassName
            // 
            this.txtClassName.Location = new System.Drawing.Point(261, 29);
            this.txtClassName.Name = "txtClassName";
            this.txtClassName.Size = new System.Drawing.Size(100, 20);
            this.txtClassName.TabIndex = 5;
            // 
            // dgvClasses
            // 
            this.dgvClasses.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClasses.Location = new System.Drawing.Point(244, 166);
            this.dgvClasses.Name = "dgvClasses";
            this.dgvClasses.Size = new System.Drawing.Size(240, 150);
            this.dgvClasses.TabIndex = 6;
            // 
            // ClassManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dgvClasses);
            this.Controls.Add(this.txtClassName);
            this.Controls.Add(this.txtLevel);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnDeleteClass);
            this.Controls.Add(this.btnEditClass);
            this.Controls.Add(this.btnAddClass);
            this.Name = "ClassManagementForm";
            this.Text = "ClassManagementForm";
            this.Load += new System.EventHandler(this.ClassManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClasses)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddClass;
        private System.Windows.Forms.Button btnEditClass;
        private System.Windows.Forms.Button btnDeleteClass;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtLevel;
        private System.Windows.Forms.TextBox txtClassName;
        private System.Windows.Forms.DataGridView dgvClasses;
    }
}