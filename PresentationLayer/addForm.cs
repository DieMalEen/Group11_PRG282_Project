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
using Group1_PRG282_Project.BusinessLayer;
using Group1_PRG282_Project.DataLayer;

namespace Group1_PRG282_Project
{
    public partial class addForm : Form
    {
        public addForm()
        {
            InitializeComponent();

            // Add KeyPress EventHandlers
            EventHandlers addEvent = new EventHandlers();
            txbID.KeyPress += new KeyPressEventHandler(addEvent.OnlyNumbers);
            txbAge.KeyPress += new KeyPressEventHandler(addEvent.OnlyNumbers);
            txbName.KeyPress += new KeyPressEventHandler(addEvent.OnlyLetters);
            txbName.KeyPress += new KeyPressEventHandler(addEvent.OnlyLetters);
        }

        private void btnAdd_Click(object sender, EventArgs e) //Add button
        {
            // Capture and trim data from text boxes
            int studentId = Int32.Parse(txbID.Text.Trim());
            string studentName = txbName.Text.Trim();
            int studentAge = Int32.Parse(txbAge.Text.Trim());
            string studentCourse = txbCourse.Text.Trim();

            // Create a Student object
            Student student = new Student(studentId, studentName, studentAge, studentCourse);

            // Save the student using StudentFileHandler
            StudentDataHandler fileHandler = new StudentDataHandler();
            fileHandler.SaveStudent(student);

            MessageBox.Show("Student added successfully.");
            Close();
        }
    }
}
