using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            dataStudents.Visible = true;
        }
    }
}
