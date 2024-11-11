using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Group1_PRG282_Project;
using Group1_PRG282_Project.BusinessLayer;

namespace Group1_PRG282_Project.DataLayer
{
    public class StudentDataHandler
    {
        private readonly string fileName = @"..\..\students.txt";
        
        List<Student> students = new List<Student>();
        // Runs when grid needs to be updated or display student data
        public List<Student> GetAllStudents()
        {
            var lines = File.ReadAllLines(fileName);
            foreach (var line in lines)
            {
                var data = line.Split(',');

                students.Add(new Student
                {
                    ID = int.Parse(data[0].Trim()),
                    Name = data[1].Trim(),
                    Age = int.Parse(data[2].Trim()),
                    Course = data[3].Trim()
                });
            }
            return students;
        }

        public List<Student> GetAllStudents(List<Student> student)
        {
            var lines = File.ReadAllLines(fileName);
            foreach (var line in lines)
            {
                var data = line.Split(',');

                student.Add(new Student
                {
                    ID = int.Parse(data[0].Trim()),
                    Name = data[1].Trim(),
                    Age = int.Parse(data[2].Trim()),
                    Course = data[3].Trim()
                });
            }
            return student;
        }

        // Runs when "Add" is clicked on addForm
        public void SaveStudent(Student student)
        {
            // Format the student information as a comma-separated line
            string studentInfo = $"{student.ID},{student.Name},{student.Age},{student.Course}";

            // Write the student details to the text file
            try
            {
                using (FileStream fs = new FileStream(fileName, FileMode.Append, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine(studentInfo);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred: " + ex.Message);
            }
        }

        public void DeleteStudent(string studentId)
        {
            try
            {
                // Load all lines from the students.txt file
                var lines = File.ReadAllLines(fileName).ToList();

                // Filter out the line with the matching student ID
                lines = lines.Where(line => !line.StartsWith(studentId + ",")).ToList();

                // Write the updated lines back to the file
                File.WriteAllLines(fileName, lines);
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while deleting student: " + ex.Message);
            }
        }
    }
}
