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

namespace Group1_PRG282_Project
{
    public partial class updateForm : Form
    {
        public List<Student> students = new List<Student>();
        public string fileName = @"..\..\students.txt";

        public updateForm()
        {
            InitializeComponent();
            LoadStudentData();
            DisplayStudentsInGrid(students);
        }
        public void LoadStudentData()
        {
            students.Clear();
            if (File.Exists(fileName))
            {
                var lines = File.ReadAllLines(fileName);
                foreach (var line in lines)
                {
                    var data = line.Split(',');
                    if (data.Length == 4)
                    {
                        students.Add(new Student
                        {
                            ID = int.Parse(data[0].Trim()),
                            Name = data[1].Trim(),
                            Age = int.Parse(data[2].Trim()),
                            Course = data[3].Trim()
                        });
                    }
                }
            }
        }

        private void UpdateBT_Click(object sender, EventArgs e)
        {
            if (int.TryParse(studentIDEnter.Text, out int id))
            {
                var studentToUpdate = students.FirstOrDefault(s => s.ID == id);
                if (studentToUpdate != null)
                {
                    studentToUpdate.Name = nameEnter.Text;
                    studentToUpdate.Age = int.Parse(ageEnter.Text);
                    studentToUpdate.Course = courseEnter.Text;

                    SaveStudentsToFile();
                    LoadStudentData();
                    DisplayStudentsInGrid(students);
                    MessageBox.Show("Student updated successfully!");
                }
                else
                {
                    MessageBox.Show("Student not found.");
                }
            }

        }

        public void SaveStudentsToFile()
        {
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                foreach (var student in students)
                {
                    writer.WriteLine($"{student.ID},{student.Name},{student.Age},{student.Course}");
                }
            }
        }

        private void ClearTextBoxes()
        {
            studentIDEnter.Clear();
            nameEnter.Clear();
            ageEnter.Clear();
            courseEnter.Clear();
        }

        private void DisplayStudentsInGrid(List<Student> studentList)
        {
            dataGridViewUpdate.DataSource = null;
            dataGridViewUpdate.DataSource = studentList;
        }
        private void dataGridViewUpdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // Get the DataGridView
                DataGridView dgv = sender as DataGridView;

                
                int selectedId = (int)dgv.Rows[e.RowIndex].Cells["ID"].Value;

                var filteredStudents = students.Where(s =>s.ID == selectedId).ToList(); //filter for name display when selecting a  name

                if (filteredStudents.Count == 1) // Enters studnet details when pressing on student on datagridview
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

        private void StudentIDSearch_TextChanged(object sender, EventArgs e)
        {
            DataGridView dgv = sender as DataGridView;


             string searchText = StudentIDSearch.Text;

            if (int.TryParse(searchText, out int selectedId))
            {

                var filteredStudents = students.Where(s => s.ID == selectedId).ToList();

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
                    ClearTextBoxes();
                }
            }
            else
            {
                var filteredStudents = students;

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
                    ClearTextBoxes();
                }
            }

            
        }

        private void NameSearch_TextChanged(object sender, EventArgs e)
        {
             
            var filteredStudents = students.Where(s =>
            (!string.IsNullOrWhiteSpace(NameSearch.Text)&& s.Name.IndexOf(NameSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0)
            ).ToList();

            DisplayStudentsInGrid(filteredStudents);

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
                DisplayStudentsInGrid(students);
                ClearTextBoxes();
            }
        }

        private void updateForm_Load(object sender, EventArgs e)
        {

        }
    }
    public class Student //object for list
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Course { get; set; }

        public override string ToString()
        {
            return $"{ID}, {Name}, {Age}, {Course}";
        }
    }
}
