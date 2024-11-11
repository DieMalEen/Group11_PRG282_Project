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
        
        // Runs when "View" is clicked on mainForm
        public List<Student> GetAllStudents()
        {
            // Read all lines from the students file
            var rows = File.ReadAllLines(fileName);

            // Convert each line to a Student object, skipping empty lines
            var students = (from column in rows
                            where !string.IsNullOrWhiteSpace(column)
                            select new Student
                            {
                                ID = Int32.Parse(column.Split(new string[] { "," }, StringSplitOptions.None)[0]),
                                Name = column.Split(new string[] { "," }, StringSplitOptions.None)[1],
                                Age = Int32.Parse(column.Split(new string[] { "," }, StringSplitOptions.None)[2]),
                                Course = column.Split(new string[] { "," }, StringSplitOptions.None)[3]
                            }).ToList();

            return students;
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
