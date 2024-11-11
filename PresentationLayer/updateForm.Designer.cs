namespace Group1_PRG282_Project
{
    partial class updateForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewUpdate = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.NameSearch = new System.Windows.Forms.TextBox();
            this.StudentIDSearch = new System.Windows.Forms.TextBox();
            this.studentIDEnter = new System.Windows.Forms.TextBox();
            this.nameEnter = new System.Windows.Forms.TextBox();
            this.ageEnter = new System.Windows.Forms.TextBox();
            this.courseEnter = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.UpdateBT = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdate)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 154);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Search:";
            // 
            // dataGridViewUpdate
            // 
            this.dataGridViewUpdate.AllowUserToAddRows = false;
            this.dataGridViewUpdate.AllowUserToDeleteRows = false;
            this.dataGridViewUpdate.AllowUserToResizeColumns = false;
            this.dataGridViewUpdate.AllowUserToResizeRows = false;
            this.dataGridViewUpdate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewUpdate.Location = new System.Drawing.Point(74, 12);
            this.dataGridViewUpdate.MultiSelect = false;
            this.dataGridViewUpdate.Name = "dataGridViewUpdate";
            this.dataGridViewUpdate.ReadOnly = true;
            this.dataGridViewUpdate.RowHeadersVisible = false;
            this.dataGridViewUpdate.RowHeadersWidth = 51;
            this.dataGridViewUpdate.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewUpdate.Size = new System.Drawing.Size(422, 133);
            this.dataGridViewUpdate.TabIndex = 2;
            this.dataGridViewUpdate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewUpdate_CellContentClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 253);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "StudentID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(226, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(77, 174);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "StudentID";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(169, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(318, 253);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "Age";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(456, 253);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "Course";
            // 
            // NameSearch
            // 
            this.NameSearch.Location = new System.Drawing.Point(229, 190);
            this.NameSearch.Name = "NameSearch";
            this.NameSearch.Size = new System.Drawing.Size(100, 20);
            this.NameSearch.TabIndex = 9;
            this.NameSearch.TextChanged += new System.EventHandler(this.NameSearch_TextChanged);
            // 
            // StudentIDSearch
            // 
            this.StudentIDSearch.Location = new System.Drawing.Point(80, 190);
            this.StudentIDSearch.Name = "StudentIDSearch";
            this.StudentIDSearch.Size = new System.Drawing.Size(100, 20);
            this.StudentIDSearch.TabIndex = 10;
            this.StudentIDSearch.TextChanged += new System.EventHandler(this.StudentIDSearch_TextChanged);
            // 
            // studentIDEnter
            // 
            this.studentIDEnter.Location = new System.Drawing.Point(21, 283);
            this.studentIDEnter.Name = "studentIDEnter";
            this.studentIDEnter.Size = new System.Drawing.Size(86, 20);
            this.studentIDEnter.TabIndex = 11;
            // 
            // nameEnter
            // 
            this.nameEnter.Location = new System.Drawing.Point(172, 283);
            this.nameEnter.Name = "nameEnter";
            this.nameEnter.Size = new System.Drawing.Size(86, 20);
            this.nameEnter.TabIndex = 12;
            // 
            // ageEnter
            // 
            this.ageEnter.Location = new System.Drawing.Point(321, 283);
            this.ageEnter.Name = "ageEnter";
            this.ageEnter.Size = new System.Drawing.Size(86, 20);
            this.ageEnter.TabIndex = 13;
            // 
            // courseEnter
            // 
            this.courseEnter.Location = new System.Drawing.Point(459, 283);
            this.courseEnter.Name = "courseEnter";
            this.courseEnter.Size = new System.Drawing.Size(86, 20);
            this.courseEnter.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "DataView:";
            // 
            // UpdateBT
            // 
            this.UpdateBT.Location = new System.Drawing.Point(410, 182);
            this.UpdateBT.Name = "UpdateBT";
            this.UpdateBT.Size = new System.Drawing.Size(86, 35);
            this.UpdateBT.TabIndex = 16;
            this.UpdateBT.Text = "Update";
            this.UpdateBT.UseVisualStyleBackColor = true;
            this.UpdateBT.Click += new System.EventHandler(this.UpdateBT_Click);
            // 
            // updateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 329);
            this.Controls.Add(this.UpdateBT);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.courseEnter);
            this.Controls.Add(this.ageEnter);
            this.Controls.Add(this.nameEnter);
            this.Controls.Add(this.studentIDEnter);
            this.Controls.Add(this.StudentIDSearch);
            this.Controls.Add(this.NameSearch);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridViewUpdate);
            this.Controls.Add(this.label1);
            this.Name = "updateForm";
            this.ShowIcon = false;
            this.Text = "Update Student";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewUpdate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewUpdate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox NameSearch;
        private System.Windows.Forms.TextBox StudentIDSearch;
        private System.Windows.Forms.TextBox studentIDEnter;
        private System.Windows.Forms.TextBox nameEnter;
        private System.Windows.Forms.TextBox ageEnter;
        private System.Windows.Forms.TextBox courseEnter;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button UpdateBT;
    }
}