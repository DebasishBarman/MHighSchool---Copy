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
    public partial class Register_Staff : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DEBA\\DEBA;Initial Catalog=NewSchool;Integrated Security=True");
        public Register_Staff()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Staff_Master sm = new Staff_Master();
            sm.Show();
        }
        public void autoid()
        {
            con.Open();
            string id = "Select Top(1) Slno from Staff order by Slno desc ";
            SqlCommand cmd = new SqlCommand(id,con);
            int auto = (int)cmd.ExecuteScalar() + 1;
            regno.Text = "STF"+auto.ToString();
            con.Close();
        }

        private void register_Click(object sender, EventArgs e)
        {
            try
            {
                if (regno.Text == "" || stname.Text == "" || stgender.Text == "" || stfat.Text == "" || stmot.Text == "" || stphone.Text == "" || stemail.Text == "" || stadress.Text == "")
                {
                    MessageBox.Show("Empty");
                }
                else
                {
                    con.Open();
                    string ck = "Select Count(*)from Staff where Stfid='" + regno.Text + "' and Stfname='" + stname.Text + "'and Stfgen='" + stgender.Text + "'and Stf_fat='" + stfat.Text + "'and Stf_mot='" + stmot.Text + "'and Stf_phno='" + stphone.Text + "'and Stf_email='" + stemail.Text + "'and Stfaddr='" + stadress.Text + "'";
                    SqlCommand cmd2 = new SqlCommand(ck, con);
                    int rec = (int)cmd2.ExecuteScalar();
                    if (rec == 0)
                    {
                        string insert = "Insert into Staff(Stfid,Stfdate,Stfq,Stfname,Stfgen,Stf_fat,Stf_mot,Stf_phno,Stf_email,Stfaddr) values('" + regno.Text + "','" + regdate.Value.ToString() + "','"+qual.Text+"','" + stname.Text + "','" + stgender.Text + "','" + stfat.Text + "','" + stmot.Text + "','" + stphone.Text + "','" + stemail.Text + "','" + stadress.Text + "')";//on DUPLICATE KEY Update(SReg_no,SReg_date,Class_name,SName,SGender,SFather,SMother,SPhno,SEmail,SAdress)=('" + regno.Text + "','" + regdate.Value.ToString() + "','" + classname.Text + "','" + stname.Text + "','" + stgender.Text + "','" + stfat.Text + "','" + stmot.Text + "','" + stphone.Text + "','" + stemail.Text + "','" + stadress.Text + "')";
                        SqlCommand cmd = new SqlCommand(insert, con);
                        cmd.ExecuteNonQuery();
                        con.Close();


                        MessageBox.Show("Data Saved");

                    }
                    else
                    {
                        MessageBox.Show("Data Exist");

                    }
                }
            }
            catch (SqlException)
            {
                MessageBox.Show("Error");
            }

        }

        private void Register_Staff_Load(object sender, EventArgs e)
        {
            autoid();
        }
    }
}
