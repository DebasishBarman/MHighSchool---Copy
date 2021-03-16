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
    public partial class Add_Class : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DEBA\\DEBA;Initial Catalog=NewSchool;Integrated Security=True");
    
        public Add_Class()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Masters ms = new Masters();
            ms.Show();
        }

        private void saveclass_Click(object sender, EventArgs e)
        {
            con.Open();
            string check = "Select Count(*) from Class where Class_ID='"+classcode.Text+"'and Class_name='"+classname.Text+"'";
            SqlCommand cmd = new SqlCommand(check,con);
            int rec = Convert.ToInt16(cmd.ExecuteScalar());
            con.Close();
            if (rec == 0)
            {
                con.Open();
                string insert = "Insert into Class(Class_ID,Class_name) values('" + classcode.Text + "','" + classname.Text + "')";
                SqlCommand cmd2 = new SqlCommand(insert, con);
                cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("dATA SAVED");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
            
        }

        private void Add_Class_Load(object sender, EventArgs e)
        {
            con.Open();
            string get = "Select Count(*) from Class";
            SqlCommand cmd = new SqlCommand(get,con);
            int autoid = (int)cmd.ExecuteScalar()+1;
            classcode.Text ="CLS"+ autoid.ToString();
            con.Close();


        }
    }
}
