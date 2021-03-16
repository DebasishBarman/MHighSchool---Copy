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
    public partial class Masters : Form
    {
        public Masters()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            this.Hide();
            main mm = new main();
            mm.ShowDialog();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            ADD_SUBJECTS asub = new ADD_SUBJECTS();
            asub.Show();
        }


        private void addclass_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_Class adc = new Add_Class();
            adc.Show();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Add_FeeTypes adf = new Add_FeeTypes();
            adf.Show();
        }

        private void Record_Click(object sender, EventArgs e)
        {
            Master_Records mr = new Master_Records();
            mr.Show();
        }

        private void updatedeletesub_Click(object sender, EventArgs e)
        {
            Update_Delete_Subjects uds = new Update_Delete_Subjects();
            uds.Show();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Update_delete_Class udc = new Update_delete_Class();
            udc.Show();
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {
            Update_Delete_Fee udf = new Update_Delete_Fee();
            udf.Show();
        }
    }
}
