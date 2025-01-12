namespace School_Management
{
    partial class ActivitiesManagementForm
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
            this.dgvActivities = new System.Windows.Forms.DataGridView();
            this.btnSaveActivity = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnDeleteActivity = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cmbClass = new System.Windows.Forms.ComboBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.txtActivityID = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvActivities
            // 
            this.dgvActivities.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvActivities.Location = new System.Drawing.Point(12, 128);
            this.dgvActivities.Name = "dgvActivities";
            this.dgvActivities.Size = new System.Drawing.Size(776, 245);
            this.dgvActivities.TabIndex = 0;
            // 
            // btnSaveActivity
            // 
            this.btnSaveActivity.Location = new System.Drawing.Point(101, 62);
            this.btnSaveActivity.Name = "btnSaveActivity";
            this.btnSaveActivity.Size = new System.Drawing.Size(75, 23);
            this.btnSaveActivity.TabIndex = 1;
            this.btnSaveActivity.Text = "btnSaveActivity";
            this.btnSaveActivity.UseVisualStyleBackColor = true;
            this.btnSaveActivity.Click += new System.EventHandler(this.btnSaveActivity_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(101, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnDeleteActivity
            // 
            this.btnDeleteActivity.Location = new System.Drawing.Point(20, 62);
            this.btnDeleteActivity.Name = "btnDeleteActivity";
            this.btnDeleteActivity.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteActivity.TabIndex = 3;
            this.btnDeleteActivity.Text = "btnDeleteActivity";
            this.btnDeleteActivity.UseVisualStyleBackColor = true;
            this.btnDeleteActivity.Click += new System.EventHandler(this.btnDeleteActivity_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(20, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 4;
            this.button4.Text = "button4";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // cmbClass
            // 
            this.cmbClass.FormattingEnabled = true;
            this.cmbClass.Location = new System.Drawing.Point(327, 64);
            this.cmbClass.Name = "cmbClass";
            this.cmbClass.Size = new System.Drawing.Size(121, 21);
            this.cmbClass.TabIndex = 5;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(563, 53);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(100, 20);
            this.txtDescription.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(554, 27);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 7;
            // 
            // dtpDate
            // 
            this.dtpDate.Location = new System.Drawing.Point(248, 27);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(200, 20);
            this.dtpDate.TabIndex = 8;
            // 
            // txtActivityID
            // 
            this.txtActivityID.Location = new System.Drawing.Point(573, 89);
            this.txtActivityID.Name = "txtActivityID";
            this.txtActivityID.Size = new System.Drawing.Size(100, 20);
            this.txtActivityID.TabIndex = 9;
            // 
            // ActivitiesManagementForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtActivityID);
            this.Controls.Add(this.dtpDate);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.cmbClass);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.btnDeleteActivity);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnSaveActivity);
            this.Controls.Add(this.dgvActivities);
            this.Name = "ActivitiesManagementForm";
            this.Text = "ActivitiesManagementForm";
            this.Load += new System.EventHandler(this.ActivitiesManagementForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvActivities)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvActivities;
        private System.Windows.Forms.Button btnSaveActivity;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnDeleteActivity;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox cmbClass;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.TextBox txtActivityID;
    }
}