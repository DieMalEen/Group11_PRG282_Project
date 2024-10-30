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
            // Makes grid view visible
            dataStudents.Visible = true;

            // Read data in student.txt
            var rows = File.ReadAllLines(@"..\..\students.txt");

            var list = (from column in rows.ToList()
                        where !string.IsNullOrWhiteSpace(column) // Skip empty lines
                        select new gridHeadings
                        {
                            ID = column.Split(new string[] {","}, StringSplitOptions.None)[0],
                            Name = column.Split(new string[] {","}, StringSplitOptions.None)[1],
                            Age = column.Split(new string[] {","}, StringSplitOptions.None)[2],
                            Course = column.Split(new string[] {","}, StringSplitOptions.None)[3]
                        }).ToList();

            // Add data from text to grid
            dataStudents.DataSource = list;
        }

        private void btnSummary_Click(object sender, EventArgs e)
        {
            string studentFile = @"..\..\students.txt"; //File used for read operations
            string summaryFile = @"..\..\summary.txt"; //File used for write operations

            var rows = File.ReadAllLines(studentFile);


            //Finding the amount of students
            int studentCount =  rows.Count(line => !string.IsNullOrWhiteSpace(line)); //Reading from students.txt file


            //Finding the average age of students
            double averageAge = rows
            .Where(row => !string.IsNullOrWhiteSpace(row)) // Skip empty lines
            .Select(row => row.Split(new string[] { "," }, StringSplitOptions.None)[2]) // Select Age field
            .Where(age => int.TryParse(age, out _)) // Filter valid ages
            .Average(age => int.Parse(age)); // Calculate average

            //Writes the information to the summary.txt file

            try
            {
                using (FileStream fs = new FileStream(summaryFile, FileMode.Append, FileAccess.Write))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine($"Student count: {studentCount}");
                        sw.WriteLine($"Studnt Avg Age: {averageAge}");
                        sw.WriteLine($"Date and time of summary print: {DateTime.Now}");
                        sw.WriteLine(); 
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured: " + ex.Message);
            }

        }

    }

    public class gridHeadings
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Course { get; set; }
    }
}
