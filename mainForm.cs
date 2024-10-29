using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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
            studentGridView.Visible = false;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            studentGridView.Visible = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new addForm();
            addForm.Show();
        }
    }
}
