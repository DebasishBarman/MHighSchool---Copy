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
    public partial class ADD_SUBJECTS : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DEBA\\DEBA;Initial Catalog=NewSchool;Integrated Security=True");
      
        public ADD_SUBJECTS()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Masters mm = new Masters();
            mm.Show();
        }
        public void datadisplayincombobox()
        {
            con.Open();
            DataSet ds = new DataSet();
            string getclass = "Select Class_name from Class";
            SqlCommand cd = new SqlCommand(getclass, con);
            SqlDataAdapter sda = new SqlDataAdapter(getclass, con);
            sda.Fill(ds);
            cd.ExecuteNonQuery();
            con.Close();
            classname.DisplayMember = "Class_name";
            classname.ValueMember = "Class_name";
            classname.DataSource = ds.Tables[0];
            classname.Enabled = true;

        }
        public void datadisplayincombobox2()
        {
            con.Open();
            DataSet ds = new DataSet();
            string getclass = "Select Stfname from Staff";
            SqlCommand cd = new SqlCommand(getclass, con);
            SqlDataAdapter sda = new SqlDataAdapter(getclass, con);
            sda.Fill(ds);
            cd.ExecuteNonQuery();
            con.Close();
            teachername.DisplayMember = "Stfname";
            teachername.ValueMember = "Stfname";
            teachername.DataSource = ds.Tables[0];
            teachername.Enabled = true;

        }


        private void savesub_Click(object sender, EventArgs e)
        {
            con.Open();
            string check = "Select Count(*) from Subjects where Sub_code='" + subcode.Text + "'and Sub_name='" + subname.Text + "'and Class_ID='"+classname.Text+"'";
            SqlCommand cmd = new SqlCommand(check, con);
            int rec = Convert.ToInt16(cmd.ExecuteScalar());
            con.Close();
            if (rec == 0)
            {
                con.Open();
                string insert = "Insert into Subjects(Sub_code,Sub_name,Class_ID,Stfname) values('" + subcode.Text + "','" + subname.Text + "','"+classname.Text+"','"+teachername.Text+"')";
                SqlCommand cmd2 = new SqlCommand(insert, con);
                cmd2.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("DATA SAVED");
            }
            else
            {
                MessageBox.Show("ERROR");
            }
            
        }

        private void ADD_SUBJECTS_Load(object sender, EventArgs e)
        {
            datadisplayincombobox();
            datadisplayincombobox2();
            con.Open();
            string qry = "Select Top(1) Slno from Subjects order by Slno desc";
            SqlCommand cmd = new SqlCommand(qry,con);
            int get = (int)cmd.ExecuteScalar() + 1;
            subcode.Text = "SUB" + get;
            con.Close();
        }
    }
}
