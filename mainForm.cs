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
    }

    public class gridHeadings
    {
        public string ID { get; set; }
        public string Name { get; set; }
        public string Age { get; set; }
        public string Course { get; set; }
    }
}
