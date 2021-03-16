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
    public partial class Staff_Master : Form
    {
        public Staff_Master()
        {
            InitializeComponent();
        }

       

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            main mm = new main();
            mm.Show();
        }

        private void addstaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Register_Staff rs = new Register_Staff();
            rs.Show();
        }

        private void removestaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Remove_Staff rms = new Remove_Staff();
            rms.Show();
        }

        private void updatestaff_Click(object sender, EventArgs e)
        {
            this.Hide();
            Update_Staff ups = new Update_Staff();
            ups.Show();
        }

        private void subjectsassigned_Click(object sender, EventArgs e)
        {
            this.Hide();
            Subjects_Assigned subas = new Subjects_Assigned();
            subas.Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Staff_records stf = new Staff_records();
            stf.Show();
        }
    }
}
