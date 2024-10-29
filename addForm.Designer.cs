namespace Group1_PRG282_Project
{
    partial class addForm
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
            this.lblAddHeading = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txbAge = new System.Windows.Forms.TextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.txbCourse = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblAddHeading
            // 
            this.lblAddHeading.AutoSize = true;
            this.lblAddHeading.Location = new System.Drawing.Point(12, 9);
            this.lblAddHeading.Name = "lblAddHeading";
            this.lblAddHeading.Size = new System.Drawing.Size(179, 13);
            this.lblAddHeading.TabIndex = 0;
            this.lblAddHeading.Text = "Add new student\'s information below";
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(15, 38);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(176, 20);
            this.txbID.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(12, 22);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(61, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Student ID:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(12, 71);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Student Name:";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(15, 87);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(176, 20);
            this.txbName.TabIndex = 4;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(14, 119);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(69, 13);
            this.lblAge.TabIndex = 5;
            this.lblAge.Text = "Student Age:";
            // 
            // txbAge
            // 
            this.txbAge.Location = new System.Drawing.Point(15, 135);
            this.txbAge.Name = "txbAge";
            this.txbAge.Size = new System.Drawing.Size(176, 20);
            this.txbAge.TabIndex = 6;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(12, 168);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(83, 13);
            this.lblCourse.TabIndex = 7;
            this.lblCourse.Text = "Student Course:";
            // 
            // txbCourse
            // 
            this.txbCourse.Location = new System.Drawing.Point(15, 184);
            this.txbCourse.Name = "txbCourse";
            this.txbCourse.Size = new System.Drawing.Size(176, 20);
            this.txbCourse.TabIndex = 8;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(15, 210);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // addForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(207, 245);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.txbCourse);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.txbAge);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.lblAddHeading);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "addForm";
            this.ShowIcon = false;
            this.Text = "Add New Student";
            this.Load += new System.EventHandler(this.addForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAddHeading;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txbAge;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.TextBox txbCourse;
        private System.Windows.Forms.Button btnAdd;
    }
}