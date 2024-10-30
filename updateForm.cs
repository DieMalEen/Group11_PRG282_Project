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
            if (int.TryParse(StudentID.Text, out int id))
            {
                var studentToUpdate = students.FirstOrDefault(s => s.ID == id);
                if (studentToUpdate != null)
                {
                    studentToUpdate.Name = Name.Text;
                    studentToUpdate.Age = int.Parse(Age.Text);
                    studentToUpdate.Course = Course.Text;

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

        private void SaveStudentsToFile()
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
            StudentID.Clear();
            Name.Clear();
            Age.Clear();
            Course.Clear();
        }

        private void SearchBT_Click(object sender, EventArgs e)
        {
            int id;
            var filteredStudents = students.Where(s =>
                (int.TryParse(StudentIDSearch.Text, out id) && s.ID == id) ||
                (!string.IsNullOrWhiteSpace(NameSearch.Text) && s.Name.IndexOf(NameSearch.Text, StringComparison.OrdinalIgnoreCase) >= 0)
            ).ToList();

            DisplayStudentsInGrid(filteredStudents);

            if (filteredStudents.Count == 1)
            {
                var student = filteredStudents[0];
                StudentID.Text = student.ID.ToString();
                Name.Text = student.Name;
                Age.Text = student.Age.ToString();
                Course.Text = student.Course;
            }
            else
            {
                ClearTextBoxes();
            }
        }

        private void DisplayStudentsInGrid(List<Student> studentList)
        {
            dataGridViewUpdate.DataSource = null;
            dataGridViewUpdate.DataSource = studentList;
        }
        private void dataGridViewUpdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
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
