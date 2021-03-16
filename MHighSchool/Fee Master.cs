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
    public partial class Fee_Master : Form
    {
        public Fee_Master()
        {
            InitializeComponent();
        }

        private void payfee_Click(object sender, EventArgs e)
        {
            this.Hide();
            Pay_Fees pf = new Pay_Fees();
            pf.Show();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            main mm = new main();
            mm.Show();
        }

        private void feerecord_Click(object sender, EventArgs e)
        {
            Payment_Records pr = new Payment_Records();
            pr.Show();
        }
    }
}
