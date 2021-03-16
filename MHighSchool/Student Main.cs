using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MHighSchool
{
    public partial class Student_Main : Form
    {
        public Student_Main()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            main m = new main();
            m.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register_Student rs = new Register_Student();
            rs.Show();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Student us = new Update_Student();
            us.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Delete_Student ds = new Delete_Student();
            ds.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
           
            RecordofStudents ros = new RecordofStudents();
            ros.Show();
        }
    }
}
