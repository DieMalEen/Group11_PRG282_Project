using Group1_PRG282_Project.BusinessLayer;
using Group1_PRG282_Project.DataLayer;
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
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();

            dataStudents.Visible = false;
        }

        // Button Add click event
        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addStudent = new addForm();
            addStudent.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            updateForm updateFormInstance = new updateForm();
            updateFormInstance.ShowDialog();

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            // Makes the grid view visible
            dataStudents.Visible = true;

            // Use StudentDataHandler to get the list of students
            StudentDataHandler dataService = new StudentDataHandler();
            List<Student> students = dataService.GetAllStudents();

            // Bind the list of students to the DataGridView
            dataStudents.DataSource = students;
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            // Create an instance of StudentSummary and generate the summary
            StudentSummary summaryService = new StudentSummary();
            summaryService.GenerateSummary();

            MessageBox.Show("Summary generated successfully.");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataStudents.SelectedRows.Count > 0)
            {
                // Get the Student ID of the selected row
                var selectedStudentId = dataStudents.SelectedRows[0].Cells[0].Value.ToString();

                // Create an instance of StudentDataHandler and delete the student
                StudentDataHandler fileHandler = new StudentDataHandler();
                fileHandler.DeleteStudent(selectedStudentId);

                // Refresh DataGridView
                btnView_Click(null, null); // Reload data to reflect changes

                MessageBox.Show("Student record deleted successfully.");
            }
            else
            {
                MessageBox.Show("Please select a student to delete.");
            }
        }
    }
}
