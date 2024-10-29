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
            this.lblAdd = new System.Windows.Forms.Label();
            this.txbID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblAdd
            // 
            this.lblAdd.AutoSize = true;
            this.lblAdd.Location = new System.Drawing.Point(0, 0);
            this.lblAdd.Name = "lblAdd";
            this.lblAdd.Size = new System.Drawing.Size(153, 13);
            this.lblAdd.TabIndex = 0;
            this.lblAdd.Text = "Add Student Information Below";
            // 
            // txbID
            // 
            this.txbID.Location = new System.Drawing.Point(3, 38);
            this.txbID.Name = "txbID";
            this.txbID.Size = new System.Drawing.Size(100, 20);
            this.txbID.TabIndex = 1;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Location = new System.Drawing.Point(0, 22);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(58, 13);
            this.lblID.TabIndex = 2;
            this.lblID.Text = "Student ID";
            // 
            // addForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(216, 301);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.txbID);
            this.Controls.Add(this.lblAdd);
            this.Name = "addForm";
            this.Text = "Add Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAdd;
        private System.Windows.Forms.TextBox txbID;
        private System.Windows.Forms.Label lblID;
    }
}