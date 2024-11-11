using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml.Linq;
using Group1_PRG282_Project.BusinessLayer;
using Group1_PRG282_Project.DataLayer;

namespace Group1_PRG282_Project
{
    public partial class updateForm : Form
    {
        public List<Student> student = new List<Student>(); //list 
        public string fileName = @"..\..\students.txt";  // file location

        public updateForm()
        {
            InitializeComponent();    
            
            // Updates KeyPress EvenHandlers
            EventHandlers updateEvent = new EventHandlers();   
            StudentIDSearch.KeyPress += new KeyPressEventHandler(updateEvent.OnlyNumbers);
            NameSearch.KeyPress += new KeyPressEventHandler(updateEvent.OnlyLetters);
            studentIDEnter.KeyPress += new KeyPressEventHandler(updateEvent.OnlyNumbers);
            nameEnter.KeyPress += new KeyPressEventHandler(updateEvent.OnlyLetters);
            LoadStudentData();
        }

        public void LoadStudentData() // Stores student info into list 
        {
            student.Clear();
            StudentDataHandler studentDataHandler = new StudentDataHandler();
            List<Student> students = studentDataHandler.GetAllStudents(student);
            dataGridViewUpdate.DataSource = null;
            dataGridViewUpdate.DataSource = students;
        }

        private void UpdateBT_Click(object sender, EventArgs e) // Runs update 
        {
            if (int.TryParse(studentIDEnter.Text, out int id))
            {
                var studentToUpdate = student.FirstOrDefault(s => s.ID == id);
                if (studentToUpdate != null)
                {
                    studentToUpdate.Name = nameEnter.Text;
                    studentToUpdate.Age = int.Parse(ageEnter.Text);
                    studentToUpdate.Course = courseEnter.Text;

                    SaveStudentsToFile();
                    LoadStudentData();
                    MessageBox.Show("Student updated successfully!");
                }

                else
                {
                    MessageBox.Show("Student not found.");
                }
            }

        }

        public void SaveStudentsToFile() // Saves students to file 
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var student in student)
                {
                    writer.WriteLine($"{student.ID},{student.Name},{student.Age},{student.Course}");
                }
            }
        }

        private void ClearTextBoxes() // clears the boxes so no left over text 
        {
            studentIDEnter.Clear();
            nameEnter.Clear();
            ageEnter.Clear();
            courseEnter.Clear();
        }

        private void dataGridViewUpdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the DataGridView
                DataGridView dgv = sender as DataGridView;
               
                int selectedId = (int)dgv.Rows[e.RowIndex].Cells["ID"].Value;

                var filteredStudents = student.Where(s =>s.ID == selectedId).ToList(); //filter for name display when selecting a  name

                if (filteredStudents.Count == 1) // Enters student details when pressing on student on datagridview
                {
                    var student = filteredStudents[0];
                    studentIDEnter.Text = student.ID.ToString();
                    nameEnter.Text = student.Name;
                    ageEnter.Text = student.Age.ToString();
                    courseEnter.Text = student.Course;
                }
                else
                {
                    ClearTextBoxes();
                }
            }
        }

        private void StudentIDSearch_TextChanged(object sender, EventArgs e)  // search text for spefic student with ID 
        {
             string searchText = StudentIDSearch.Text;

            if (int.TryParse(searchText, out int selectedId))
            {

                var filteredStudents = student.Where(s => s.ID == selectedId).ToList();

                dataGridViewUpdate.DataSource = null;
                dataGridViewUpdate.DataSource = filteredStudents;

                if (filteredStudents.Count == 1) 
                {
                    var student = filteredStudents[0];
                    studentIDEnter.Text = student.ID.ToString();
                    nameEnter.Text = student.Name;
                    ageEnter.Text = student.Age.ToString();
                    courseEnter.Text = student.Course;
                }

                else
                {
                    LoadStudentData();
                    ClearTextBoxes();
                }
            }
        }

        private void NameSearch_TextChanged(object sender, EventArgs e) // search text for spefic student with name 
        {      
            var filteredStudents = student.Where(s =>
            (!string.IsNullOrWhiteSpace(NameSearch.Text)&& s.Name.IndexOf(NameSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0)
            ).ToList();

            dataGridViewUpdate.DataSource = null;
            dataGridViewUpdate.DataSource = filteredStudents;

            if (filteredStudents.Count == 1)
            {
                var student = filteredStudents[0];
                studentIDEnter.Text = student.ID.ToString();
                nameEnter.Text = student.Name;
                ageEnter.Text = student.Age.ToString();
                courseEnter.Text = student.Course;
            }

            else
            {
                LoadStudentData();
                ClearTextBoxes();
            }
        }
    }
}
