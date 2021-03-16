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
    public partial class Update_Delete_Subjects : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DEBA\\DEBA;Initial Catalog=NewSchool;Integrated Security=True");
        public Update_Delete_Subjects()
        {
            InitializeComponent();
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {
                if (subcode.Text == "" || subname.Text == "" || classname.Text == "" || teachername.Text == "")
                {
                    MessageBox.Show("textbox empty");
                    con.Close();
                }
                else
                {
                    con.Open();
                    string insert = "Update Subjects SET Sub_name='" + subname.Text + "',Class_ID='" + classname.Text + "',Stfname='" + teachername.Text + "' where Sub_code='" + subcode.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(insert, con);
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Update Successful");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Error");
                con.Close();
            }
        }

        private void subcode_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string get = "Select Sub_name,Class_ID,Stfname from Subjects where Sub_code='"+subcode.Text+"'";
            SqlCommand cmd = new SqlCommand(get,con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                subname.Text=dr["Sub_name"].ToString();
                pclass.Text=dr["Class_ID"].ToString();
                teachername.Text=dr["Stfname"].ToString();
            }
            dr.Close();
            con.Close();
        }
        public void combobox()
        {
            con.Open();
            DataSet dt = new DataSet();
            string disp = "select Class_name from Class";
            SqlCommand cmd1 = new SqlCommand(disp, con);
            SqlDataAdapter sda = new SqlDataAdapter(disp,con);
            sda.Fill(dt);
           cmd1.ExecuteNonQuery();
            classname.DisplayMember= "Class_name";
          classname.ValueMember = "Class_name";
           classname.DataSource=dt.Tables[0];
           classname.Enabled = true;
           con.Close();
        }
        private void tchr()
        {
            DataTable dt = new DataTable();
            string disp = "select Stfname from Subjects where Class_ID='"+classname.Text+"'";
            SqlCommand cmd1 = new SqlCommand(disp, con);
            SqlDataAdapter sda = new SqlDataAdapter(disp, con);
            sda.Fill(dt);
            teachername.DataSource = dt;
            teachername.DisplayMember = "Stfname";
         
        }

        private void Update_Delete_Subjects_Load(object sender, EventArgs e)
        {
            combobox();
            //con.Close();
        }

        private void classname_SelectedIndexChanged(object sender, EventArgs e)
        {
            tchr();
        }

        private void delete_Click(object sender, EventArgs e)
        {

            try
            {
                if (subcode.Text == "" || subname.Text == "" || classname.Text == "" || teachername.Text == "")
                {
                    MessageBox.Show("textbox empty");
                    con.Close();
                }
                else
                {
                    con.Open();
                    string insert = "Delete from Subjects where Sub_code='" + subcode.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(insert, con);
                    cmd2.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("deleted Successful");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Error");
                con.Close();
            }
        }
    }
}
