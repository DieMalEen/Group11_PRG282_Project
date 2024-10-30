using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group1_PRG282_Project
{
    public partial class addForm : Form
    {
        public addForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e) //Add button
        {
            string fileName = (@"..\..\students.txt"); //Defines the students textfile

            //Capturing and storing data from textboxes
            string studentId = txbID.Text.Trim();      //Trim() added to remove any extra whitespace
            string studentName = txbName.Text.Trim();
            string studentAge = txbAge.Text.Trim();
            string studentCourse = txbCourse.Text.Trim();

            //Adding in extra validation to check if the input fields are empty
            if(string.IsNullOrEmpty(studentId) || string.IsNullOrEmpty(studentName) || string.IsNullOrEmpty(studentAge) || string.IsNullOrEmpty(studentCourse))
            {
                MessageBox.Show("Please ensure all fields are filled out before submission");
                return;
            }

            //Formatting the strudent informarmation so it is stored nexto one another in a single line
            string studentInfo = $"{studentId},{studentName},{studentAge},{studentCourse}";

            //Adding the student details into the text file
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine(studentInfo);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured: " + ex.Message);
            }
        
            Close();
        }
    }
}
