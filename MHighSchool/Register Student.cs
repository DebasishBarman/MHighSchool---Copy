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
    public partial class Register_Student : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DEBA\\DEBA;Initial Catalog=NewSchool;Integrated Security=True");
     
        public Register_Student()
        {
            InitializeComponent();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Student_Main sm = new Student_Main();
            sm.Show();
        }

       private void Register_Student_Load(object sender, EventArgs e)
        {
            /*datadisplayincombobox();//display data in combobox
            con.Open();//autoid open
            string qry = "Select Count(*) from Students";
            SqlCommand cmd = new SqlCommand(qry, con);
            int get = (int)cmd.ExecuteScalar() + 1;
            regno.Text = "STID" + get;
            con.Close();//autoid close */
             ids();

        }
       public void ids()
        {
            con.Open();//autoid open
            string qry = "SELECT    TOP (1) Slno  FROM   Students  ORDER BY Slno DESC";
            SqlCommand cmd = new SqlCommand(qry, con);
            int get = (int)cmd.ExecuteScalar() + 1;
            regno.Text = "STID" + get;
            con.Close();//autoid close
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

        private void register_Click(object sender, EventArgs e)
        {
          con.Open();

            string ck = "Select Count(*)from Students where Class_name='" + classname.Text + "'and SNAme='" + stname.Text + "'and SGender='" + stgender.Text + "'and SFather='" + stfat.Text + "'and SMother='" + stmot.Text + "'and SPhno='" + stphone.Text + "'and SEmail='" + stemail.Text + "'and SAdress='" + stadress.Text + "'";
            SqlCommand cmd2 = new SqlCommand(ck,con);
            int rec = (int)cmd2.ExecuteScalar();
            if (rec == 0)
            {
                string insert = "Insert into Students(SReg_no,SReg_date,Class_name,SName,SGender,SFather,SMother,SPhno,SEmail,SAdress) values('" + regno.Text + "','" + regdate.Value.ToString() + "','" + classname.Text + "','" + stname.Text + "','" + stgender.Text + "','" + stfat.Text + "','" + stmot.Text + "','" + stphone.Text + "','" + stemail.Text + "','" + stadress.Text + "')";//on DUPLICATE KEY Update(SReg_no,SReg_date,Class_name,SName,SGender,SFather,SMother,SPhno,SEmail,SAdress)=('" + regno.Text + "','" + regdate.Value.ToString() + "','" + classname.Text + "','" + stname.Text + "','" + stgender.Text + "','" + stfat.Text + "','" + stmot.Text + "','" + stphone.Text + "','" + stemail.Text + "','" + stadress.Text + "')";
                SqlCommand cmd = new SqlCommand(insert, con);
                cmd.ExecuteNonQuery();
                con.Close();


                MessageBox.Show("Data Saved");
               
            }
            else{
                MessageBox.Show("Data Exist");
         
            }
            
        }

        private void stphone_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(stphone.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers!!");
                stphone.Text = stphone.Text.Remove(stphone.Text.Length - 1);
            }
        }
    }
}
