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

            //KeyPress event Handlers
            txbID.KeyPress += new KeyPressEventHandler(OnlyNumbers);
            txbAge.KeyPress += new KeyPressEventHandler(OnlyNumbers);
            txbName.KeyPress += new KeyPressEventHandler(OnlyLetters);
            txbName.KeyPress += new KeyPressEventHandler(OnlyLetters);
        }

        //Event handler to allow only numbers to be entered
        private void OnlyNumbers(object sender, KeyPressEventArgs e)
        {
            //Ipout validation only allowing for digits; no letters
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; //Dissalow the key press
            } 
        }

        //Event handler to allow only letters
        private void OnlyLetters(object sender, KeyPressEventArgs e)
        {
            //Input validation only allowing letters; no digits
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && e.KeyChar != ' ')
            {
                e.Handled = true;  //Disallow the key press
            }
        }

        private void btnAdd_Click(object sender, EventArgs e) //Add button
        {
            string fileName = (@"..\..\students.txt"); //Defines the students textfile

            //Capturing and storing data from textboxes
            string studentId = txbID.Text.Trim();      //Trim() added to remove any extra whitespace
            string studentName = txbName.Text.Trim();
            string studentAge = txbAge.Text.Trim();
            string studentCourse = txbCourse.Text.Trim();



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
