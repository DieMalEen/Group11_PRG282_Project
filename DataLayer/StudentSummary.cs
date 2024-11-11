using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group1_PRG282_Project.DataLayer
{
    public class StudentSummary
    {
        private readonly string studentFile = @"..\..\students.txt"; // File used for read operations
        private readonly string summaryFile = @"..\..\summary.txt";   // File used for write operations

        public void GenerateSummary()
        {
            try
            {
                // Read all lines from the students file
                var rows = File.ReadAllLines(studentFile);

                // Finding the count of students
                int studentCount = rows.Count(line => !string.IsNullOrWhiteSpace(line));

                // Calculating the average age
                double averageAge = rows
                    .Where(row => !string.IsNullOrWhiteSpace(row))  // Skip empty lines
                    .Select(row => row.Split(new string[] { "," }, StringSplitOptions.None)[2]) // Select Age field
                    .Where(age => int.TryParse(age, out _))  // Filter valid ages
                    .Average(age => int.Parse(age));  // Calculate average

                // Writing the summary to summary.txt
                WriteSummary(studentCount, averageAge);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while generating summary: " + ex.Message);
            }
        }

        private void WriteSummary(int studentCount, double averageAge)
        {
            try
            {
                using (FileStream fs = new FileStream(summaryFile, FileMode.Append, FileAccess.Write))
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine($"Student count: {studentCount}");
                    sw.WriteLine($"Student Avg Age: {averageAge:F2}");
                    sw.WriteLine($"Date and time of summary print: {DateTime.Now}");
                    sw.WriteLine();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occurred while writing summary: " + ex.Message);
            }
        }
    }
}
