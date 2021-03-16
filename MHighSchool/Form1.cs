using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace MHighSchool
{
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DEBA\\DEBA;Initial Catalog=NewSchool;Integrated Security=True");
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            username.Focus();
            bool login = false;
            con.Open();
            string sql = "Select * from login where username='" + username.Text + "'and pass= '" + pass.Text + "'";
            SqlCommand cmd = new SqlCommand(sql, con);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                login = true;

            }
            reader.Close();
            con.Close();
            if (login == true)
            {
                this.Hide();
                main mm = new main();
                mm.ShowDialog();
            
            }
            else
            {
                MessageBox.Show("Username or Password error!!.Please Try Again.");
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
