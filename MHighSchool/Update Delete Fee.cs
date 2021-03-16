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
    public partial class Update_Delete_Fee : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DEBA\\DEBA;Initial Catalog=NewSchool;Integrated Security=True");
        public Update_Delete_Fee()
        {
            InitializeComponent();
        }
        public void combobox()
        {
            con.Open();
            DataSet dt = new DataSet();
            string disp = "select Class_name from Class";
            SqlCommand cmd1 = new SqlCommand(disp, con);
            SqlDataAdapter sda = new SqlDataAdapter(disp, con);
            sda.Fill(dt);
            cmd1.ExecuteNonQuery();
            classname.DisplayMember = "Class_name";
            classname.ValueMember = "Class_name";
            classname.DataSource = dt.Tables[0];
            classname.Enabled = true;
            con.Close();
        }

        private void feeid_TextChanged(object sender, EventArgs e)
        {
            con.Open();
            string get = "Select Fee_name,Class_name,Fee_amt from FeeTypes where Fee_id='" + feeid.Text + "'";
            SqlCommand cmd = new SqlCommand(get, con);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                feename.Text = dr["Fee_name"].ToString();
                cls.Text = dr["Class_name"].ToString();
                famt.Text = dr["Fee_amt"].ToString();
            }
            dr.Close();
            con.Close();
        }

        private void Update_Delete_Fee_Load(object sender, EventArgs e)
        {
            combobox();
        }

        private void update_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                if (feeid.Text == "" || feename.Text == "" || famt.Text == "")
                {
                    MessageBox.Show("empty");
                    con.Close();
                }
                else
                {
                    string upd = "Update FeeTypes Set Class_name='"+classname.Text+"',Fee_amt='"+famt.Text+"',Fee_name='"+feename.Text+"' where Fee_id='"+feeid.Text+"'";
                    SqlCommand cmd = new SqlCommand(upd,con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Updated");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("error");
                con.Close();
            }
        }

        private void delete_Click(object sender, EventArgs e)
        {
            try
            {

                con.Open();
                if (feeid.Text == "" || feename.Text == "" || famt.Text == "")
                {
                    MessageBox.Show("empty");
                    con.Close();
                }
                else
                {
                    string upd = "Delete from FeeTypes where Fee_id='" + feeid.Text + "'";
                    SqlCommand cmd = new SqlCommand(upd, con);
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("Deleted");
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("error");
                con.Close();
            }
        }
    }
}
