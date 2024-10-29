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
            this.txbID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.lblAddHeading = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.txbAge = new System.Windows.Forms.TextBox();
            this.lblAge = new System.Windows.Forms.Label();
            this.txbCourse = new System.Windows.Forms.TextBox();
            this.lblCourse = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(12, 36);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(136, 20);
            this.txbID.TabIndex = 0;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(9, 20);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(61, 13);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Student ID:";
            // 
            // lblAddHeading
            // 
            this.lblAddHeading.AutoSize = true;
            this.lblAddHeading.Location = new System.Drawing.Point(9, 7);
            this.lblAddHeading.Name = "lblAddHeading";
            this.lblAddHeading.Size = new System.Drawing.Size(139, 13);
            this.lblAddHeading.TabIndex = 2;
            this.lblAddHeading.Text = "Fill in Student Details to Add";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(9, 68);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(78, 13);
            this.lblName.TabIndex = 3;
            this.lblName.Text = "Student Name:";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(12, 84);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(136, 20);
            this.txbName.TabIndex = 4;
            // 
            // txbAge
            // 
            this.txbAge.Location = new System.Drawing.Point(12, 132);
            this.txbAge.Name = "txbAge";
            this.txbAge.Size = new System.Drawing.Size(136, 20);
            this.txbAge.TabIndex = 5;
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Location = new System.Drawing.Point(9, 116);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(69, 13);
            this.lblAge.TabIndex = 6;
            this.lblAge.Text = "Student Age:";
            // 
            // txbCourse
            // 
            this.txbCourse.Location = new System.Drawing.Point(12, 181);
            this.txbCourse.Name = "txbCourse";
            this.txbCourse.Size = new System.Drawing.Size(136, 20);
            this.txbCourse.TabIndex = 7;
            // 
            // lblCourse
            // 
            this.lblCourse.AutoSize = true;
            this.lblCourse.Location = new System.Drawing.Point(9, 165);
            this.lblCourse.Name = "lblCourse";
            this.lblCourse.Size = new System.Drawing.Size(83, 13);
            this.lblCourse.TabIndex = 8;
            this.lblCourse.Text = "Student Course:";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(12, 213);
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
            this.ClientSize = new System.Drawing.Size(161, 248);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lblCourse);
            this.Controls.Add(this.txbCourse);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.txbAge);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblAddHeading);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txbID);
            this.Name = "addForm";
            this.Text = "Student Add";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblAddHeading;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txbName;
        private System.Windows.Forms.TextBox txbAge;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.TextBox txbCourse;
        private System.Windows.Forms.Label lblCourse;
        private System.Windows.Forms.Button btnAdd;
    }
}