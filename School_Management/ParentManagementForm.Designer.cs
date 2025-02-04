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
            this.txtParentID = new System.Windows.Forms.TextBox();
            this.txtParentName = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.dgvParents = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParents)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAddParent
            // 
            this.btnAddParent.BackColor = System.Drawing.Color.White;
            this.btnAddParent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnAddParent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddParent.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnAddParent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnAddParent.Image = global::School_Management.Properties.Resources.icons8_add_30;
            this.btnAddParent.Location = new System.Drawing.Point(206, 12);
            this.btnAddParent.Name = "btnAddParent";
            this.btnAddParent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnAddParent.Size = new System.Drawing.Size(122, 87);
            this.btnAddParent.TabIndex = 0;
            this.btnAddParent.Text = "اضافة";
            this.btnAddParent.UseVisualStyleBackColor = false;
            this.btnAddParent.Click += new System.EventHandler(this.btnAddParent_Click);
            // 
            // btnEditParent
            // 
            this.btnEditParent.BackColor = System.Drawing.Color.White;
            this.btnEditParent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnEditParent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditParent.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnEditParent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnEditParent.Image = global::School_Management.Properties.Resources.icons8_update_30;
            this.btnEditParent.Location = new System.Drawing.Point(40, 12);
            this.btnEditParent.Name = "btnEditParent";
            this.btnEditParent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnEditParent.Size = new System.Drawing.Size(113, 87);
            this.btnEditParent.TabIndex = 1;
            this.btnEditParent.Text = "تعديل";
            this.btnEditParent.UseVisualStyleBackColor = false;
            this.btnEditParent.Click += new System.EventHandler(this.btnEditParent_Click);
            // 
            // btnDeleteParent
            // 
            this.btnDeleteParent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnDeleteParent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteParent.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnDeleteParent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnDeleteParent.Image = global::School_Management.Properties.Resources.icons8_delete_32;
            this.btnDeleteParent.Location = new System.Drawing.Point(28, 126);
            this.btnDeleteParent.Name = "btnDeleteParent";
            this.btnDeleteParent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnDeleteParent.Size = new System.Drawing.Size(125, 87);
            this.btnDeleteParent.TabIndex = 2;
            this.btnDeleteParent.Text = "حذف";
            this.btnDeleteParent.UseVisualStyleBackColor = true;
            this.btnDeleteParent.Click += new System.EventHandler(this.btnDeleteParent_Click);
            // 
            // btnSaveParent
            // 
            this.btnSaveParent.BackColor = System.Drawing.Color.White;
            this.btnSaveParent.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnSaveParent.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveParent.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnSaveParent.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnSaveParent.Image = global::School_Management.Properties.Resources.icons8_save_30;
            this.btnSaveParent.Location = new System.Drawing.Point(219, 126);
            this.btnSaveParent.Name = "btnSaveParent";
            this.btnSaveParent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSaveParent.Size = new System.Drawing.Size(109, 87);
            this.btnSaveParent.TabIndex = 3;
            this.btnSaveParent.Text = "حفظ";
            this.btnSaveParent.UseVisualStyleBackColor = false;
            this.btnSaveParent.Click += new System.EventHandler(this.btnSaveParent_Click);
            // 
            // txtParentID
            // 
            this.txtParentID.Font = new System.Drawing.Font("Cairo", 10F);
            this.txtParentID.Location = new System.Drawing.Point(829, 51);
            this.txtParentID.Name = "txtParentID";
            this.txtParentID.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtParentID.Size = new System.Drawing.Size(195, 32);
            this.txtParentID.TabIndex = 5;
            this.txtParentID.TextChanged += new System.EventHandler(this.txtParentID_TextChanged);
            // 
            // txtParentName
            // 
            this.txtParentName.Font = new System.Drawing.Font("Cairo", 10F);
            this.txtParentName.Location = new System.Drawing.Point(829, 107);
            this.txtParentName.Name = "txtParentName";
            this.txtParentName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtParentName.Size = new System.Drawing.Size(195, 32);
            this.txtParentName.TabIndex = 6;
            this.txtParentName.TextChanged += new System.EventHandler(this.txtParentName_TextChanged);
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Cairo", 10F);
            this.txtPhoneNumber.Location = new System.Drawing.Point(398, 107);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtPhoneNumber.Size = new System.Drawing.Size(215, 32);
            this.txtPhoneNumber.TabIndex = 7;
            this.txtPhoneNumber.TextChanged += new System.EventHandler(this.txtPhoneNumber_TextChanged);
            // 
            // dgvParents
            // 
            this.dgvParents.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvParents.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvParents.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(223)))), ((int)(((byte)(222)))));
            this.dgvParents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParents.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvParents.Location = new System.Drawing.Point(0, 0);
            this.dgvParents.Name = "dgvParents";
            this.dgvParents.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dgvParents.Size = new System.Drawing.Size(1152, 568);
            this.dgvParents.TabIndex = 8;
            this.dgvParents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvParents_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cairo", 10F);
            this.label1.Location = new System.Drawing.Point(1030, 54);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(102, 26);
            this.label1.TabIndex = 9;
            this.label1.Text = "معرف ولي الامر";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cairo", 10F);
            this.label2.Location = new System.Drawing.Point(1041, 110);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(91, 26);
            this.label2.TabIndex = 10;
            this.label2.Text = "اسم ولي الامر";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cairo", 10F);
            this.label3.Location = new System.Drawing.Point(644, 110);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(77, 26);
            this.label3.TabIndex = 11;
            this.label3.Text = "رقم الهاتف";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cairo", 10F);
            this.label4.Location = new System.Drawing.Point(618, 54);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(101, 26);
            this.label4.TabIndex = 13;
            this.label4.Text = "البريد الالكتروني";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Cairo", 10F);
            this.txtEmail.Location = new System.Drawing.Point(398, 51);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmail.Size = new System.Drawing.Size(215, 32);
            this.txtEmail.TabIndex = 12;
            this.txtEmail.TextChanged += new System.EventHandler(this.txtEmail_TextChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.White;
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Cairo", 10F);
            this.btnSearch.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(140)))), ((int)(((byte)(126)))));
            this.btnSearch.Image = global::School_Management.Properties.Resources.icons8_search_30;
            this.btnSearch.Location = new System.Drawing.Point(378, 168);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSearch.Size = new System.Drawing.Size(97, 53);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "بحث";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click_1);
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Cairo", 10F);
            this.txtSearch.Location = new System.Drawing.Point(490, 179);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtSearch.Size = new System.Drawing.Size(310, 32);
            this.txtSearch.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cairo", 10F);
            this.label5.Location = new System.Drawing.Point(843, 187);
            this.label5.Name = "label5";
            this.label5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label5.Size = new System.Drawing.Size(35, 26);
            this.label5.TabIndex = 16;
            this.label5.Text = "بحث";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnSearch);
            this.panel3.Controls.Add(this.btnDeleteParent);
            this.panel3.Controls.Add(this.btnSaveParent);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.btnEditParent);
            this.panel3.Controls.Add(this.txtSearch);
            this.panel3.Controls.Add(this.txtParentID);
            this.panel3.Controls.Add(this.btnAddParent);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtEmail);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.txtPhoneNumber);
            this.panel3.Controls.Add(this.txtParentName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Font = new System.Drawing.Font("Cairo", 10F);
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.panel3.Size = new System.Drawing.Size(1152, 245);
            this.panel3.TabIndex = 19;
            // 
            // ParentManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 568);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.dgvParents);
            this.Name = "ParentManagementForm";
            this.Text = "ولي الامر";
            this.Load += new System.EventHandler(this.ParentManagementForm_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvParents)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnAddParent;
        private System.Windows.Forms.Button btnEditParent;
        private System.Windows.Forms.Button btnDeleteParent;
        private System.Windows.Forms.Button btnSaveParent;
        private System.Windows.Forms.TextBox txtParentID;
        private System.Windows.Forms.TextBox txtParentName;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.DataGridView dgvParents;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
    }
}