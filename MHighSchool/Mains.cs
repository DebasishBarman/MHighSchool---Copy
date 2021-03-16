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
    public partial class main : Form
    {
        public main()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Masters mm = new Masters();
            mm.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Main sm = new Student_Main();
            sm.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Master sm = new Staff_Master();
            sm.Show();
        }

       

        private void account_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fee_Master fm = new Fee_Master();
            fm.Show();
        }
    }
}
