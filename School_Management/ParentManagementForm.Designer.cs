namespace School_Management
{
    partial class ParentManagementForm
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
            this.btnAddParent = new System.Windows.Forms.Button();
            this.btnEditParent = new System.Windows.Forms.Button();
            this.btnDeleteParent = new System.Windows.Forms.Button();
            this.btnSaveParent = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.txtParentID = new System.Windows.Forms.TextBox();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.dgvParents = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParents)).BeginInit();
            this.SuspendLayout();
            // 
            // btnAddParent
            // 
            this.btnAddParent.Location = new System.Drawing.Point(94, 89);
            this.btnAddParent.Name = "btnAddParent";
            this.btnAddParent.Size = new System.Drawing.Size(75, 23);
            this.btnAddParent.TabIndex = 0;
            this.btnAddParent.Text = "Add Parent";
            this.btnAddParent.UseVisualStyleBackColor = true;
            this.btnAddParent.Click += new System.EventHandler(this.btnAddParent_Click);
            // 
            // btnEditParent
            // 
            this.btnEditParent.Location = new System.Drawing.Point(94, 138);
            this.btnEditParent.Name = "btnEditParent";
            this.btnEditParent.Size = new System.Drawing.Size(75, 23);
            this.btnEditParent.TabIndex = 1;
            this.btnEditParent.Text = "Edit Parent";
            this.btnEditParent.UseVisualStyleBackColor = true;
            this.btnEditParent.Click += new System.EventHandler(this.btnEditParent_Click);
            // 
            // btnDeleteParent
            // 
            this.btnDeleteParent.Location = new System.Drawing.Point(94, 179);
            this.btnDeleteParent.Name = "btnDeleteParent";
            this.btnDeleteParent.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteParent.TabIndex = 2;
            this.btnDeleteParent.Text = "Delete Parent";
            this.btnDeleteParent.UseVisualStyleBackColor = true;
            this.btnDeleteParent.Click += new System.EventHandler(this.btnDeleteParent_Click);
            // 
            // btnSaveParent
            // 
            this.btnSaveParent.Location = new System.Drawing.Point(94, 221);
            this.btnSaveParent.Name = "btnSaveParent";
            this.btnSaveParent.Size = new System.Drawing.Size(75, 23);
            this.btnSaveParent.TabIndex = 3;
            this.btnSaveParent.Text = "Save";
            this.btnSaveParent.UseVisualStyleBackColor = true;
            this.btnSaveParent.Click += new System.EventHandler(this.btnSaveParent_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(94, 263);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 23);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // txtParentID
            // 
            this.txtParentID.Location = new System.Drawing.Point(335, 6);
            this.txtParentID.Name = "txtParentID";
            this.txtParentID.Size = new System.Drawing.Size(100, 20);
            this.txtParentID.TabIndex = 5;
            // 
            // txtParentName
            // 
            this.txtParentName.Location = new System.Drawing.Point(335, 32);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.Size = new System.Drawing.Size(100, 20);
            this.txtParentName.TabIndex = 6;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Location = new System.Drawing.Point(335, 63);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(100, 20);
            this.txtPhoneNumber.TabIndex = 7;
            // 
            // dgvParents
            // 
            this.dgvParents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParents.Location = new System.Drawing.Point(175, 89);
            this.dgvParents.Name = "dgvParents";
            this.dgvParents.Size = new System.Drawing.Size(389, 224);
            this.dgvParents.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(473, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "معرف ولي الامر";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(473, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "اسم ولي الامر";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(484, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "رقم الهاتف";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(229, 15);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "البريد الالكتروني";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(106, 12);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 12;
            // 
            // ParentManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvParents);
            this.Controls.Add(this.txtPhoneNumber);
            this.Controls.Add(this.txtParentName);
            this.Controls.Add(this.txtParentID);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSaveParent);
            this.Controls.Add(this.btnDeleteParent);
            this.Controls.Add(this.btnEditParent);
            this.Controls.Add(this.btnAddParent);
            this.Name = "ParentManagementForm";
            this.Text = "ParentManagementForm";
            this.Load += new System.EventHandler(this.ParentManagementForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParents)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddParent;
        private System.Windows.Forms.Button btnEditParent;
        private System.Windows.Forms.Button btnDeleteParent;
        private System.Windows.Forms.Button btnSaveParent;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.TextBox txtParentID;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.DataGridView dgvParents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
    }
}