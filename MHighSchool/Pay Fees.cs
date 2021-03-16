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
    public partial class Pay_Fees : Form
    {
        SqlConnection con = new SqlConnection("Data Source=DEBA\\DEBA;Initial Catalog=NewSchool;Integrated Security=True");
        public Pay_Fees()
        {
            InitializeComponent();
        }

        private void back_Click(object sender, EventArgs e)
        {
            this.Hide();
            Fee_Master fmm = new Fee_Master();
            fmm.Show();
        }

        private void regno_TextChanged(object sender, EventArgs e)
        {
             
                    con.Open();
                    string get = "Select * from Students where SReg_no='"+regno.Text+"'";
                    SqlCommand cmd = new SqlCommand(get,con);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        sname.Text=dr["SName"].ToString();
                        classname.Text = dr["Class_name"].ToString();
                    }
                    con.Close();
           }
        public void autoid()
        {
            con.Open();
            string id = "Select Top(1) Slno from Fees order by Slno desc";
            SqlCommand cmd3 = new SqlCommand(id,con);
            int count = (int)cmd3.ExecuteScalar()+1;
            payid.Text = "PAYID" + count.ToString();
            con.Close();
        }

        public void datadisplayincombobox()
        {
            con.Open();
            DataSet ds = new DataSet();
            string getclass = "Select Fee_name from FeeTypes";
            SqlCommand cd = new SqlCommand(getclass, con);
            SqlDataAdapter sda = new SqlDataAdapter(getclass, con);
            sda.Fill(ds);
            cd.ExecuteNonQuery();
            con.Close();
            feetypes.DisplayMember = "Fee_name";
            feetypes.ValueMember = "Fee_name";
            feetypes.DataSource = ds.Tables[0];
            feetypes.Enabled = true;

        }
         
          private void Pay_Fees_Load(object sender, EventArgs e)
          {
              allfeetypes.Text = "";
              datadisplayincombobox();
              autoid();
          }

          private void savesub_Click(object sender, EventArgs e)
          {
              con.Open();
              string check = "Select Count(*) from Fees where Payid='"+payid.Text+"' and Paydate='"+paydate.Value.ToString()+"'and SReg_no='" + regno.Text + "'and SName='" + sname.Text + "' and Class_name='" + classname.Text + "' and Fee_name='" + feetypes.Text + "' and FeeDetails='" + allfeetypes.Text + "' and TotalAmount='" + txttotal.Text + "'";
              SqlCommand cmd = new SqlCommand(check, con);
              int rec = Convert.ToInt16(cmd.ExecuteScalar());
              con.Close();
              if (rec == 0)
              {
                  con.Open();
                  string insert = "Insert into Fees(Payid,Paydate,SReg_no,SName,Class_name,Fee_name,FeeDetails,TotalAmount) values('"+payid.Text+"','"+paydate.Value.ToString()+"','" + regno.Text + "','" + sname.Text + "','" + classname.Text + "','" + feetypes.Text + "','" + allfeetypes.Text + "','" + txttotal.Text + "')";
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

          private void add_Click(object sender, EventArgs e)
          {
              allfeetypes.Text += feetypes.SelectedValue.ToString() + ",,,";
              int row = 0;
              disp.Rows.Add();
              row = disp.Rows.Count-2;
              disp["feetype", row].Value = feetypes.Text;
              disp["feeamount",row].Value=amt.Text;
              disp["total", row].Value = amt.Text;
          }

          private void feetypes_SelectedIndexChanged(object sender, EventArgs e)
          {
              con.Open();
              string get = feetypes.SelectedItem.ToString();
              SqlCommand cmd = new SqlCommand("Select Fee_amt,Class_name from FeeTypes where Fee_name='"+feetypes.SelectedValue+"'",con);
              SqlDataReader dr = cmd.ExecuteReader();
              while (dr.Read())
              {
                  amt.Text=dr["Fee_amt"].ToString();
                  dis.Text=dr["Class_name"].ToString();
              }
              con.Close();
          }

          private void clear_Click(object sender, EventArgs e)
          {
              
              if (string.IsNullOrEmpty(disp.Rows[0].Cells[0].Value as string))
              {
                  MessageBox.Show("No data to delete");
              }
              else
              {
                  int rowindex = disp.CurrentCell.RowIndex;
                  disp.Rows.RemoveAt(rowindex);
              }

          }

          private void calc_Click(object sender, EventArgs e)
          {
              txttotal.Text = "0";
              for (int i = 0; i < disp.Rows.Count - 1; i++)
              {
                  txttotal.Text=Convert.ToString(int.Parse(txttotal.Text)+ int.Parse(disp.Rows[i].Cells[2].Value.ToString()));
              }

          }
    }
}
