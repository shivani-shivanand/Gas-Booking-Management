using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication
{
    public partial class EditCustomer : Form
    {
        public EditCustomer()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-90RIIDO;Initial Catalog=Gas_Booking;Integrated Security=True");

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("CustomerDelSP", con);
                cmd.CommandType = CommandType.StoredProcedure;

                cmd.Parameters.AddWithValue("@Consumer_no", conNoTxtBox.Text);

                con.Open();

                try
                {
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Succesfully deleted");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("          <<<INVALID SQL OPERATION>>>  \n" + ex);
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }

        private void Searchbtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                String sqlSelect = "SELECT * FROM Consumer WHERE Consumer_no =" + int.Parse(conNoTxtBox.Text);
                SqlCommand cmd = new SqlCommand(sqlSelect, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    IDBox.Text = (dr["LPG_id"].ToString());
                    NameBox.Text = (dr["Consumer_Name"].ToString());
                    AddrBox.Text = (dr["Consumer_address"].ToString());
                    PhoneBox.Text = (dr["Phone"].ToString());
                    emailBox.Text = (dr["email"].ToString());
                    DnoBox.Text = (dr["Dis_no"].ToString());
                    CylNoBox.Text = (dr["No_of_cylinders"].ToString());
                    DateConBox.Text = (dr["Date_of_connection"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            IDBox.Text = "";
            NameBox.Text = "";
            AddrBox.Text = "";
            PhoneBox.Text = "";
            emailBox.Text = "";
            DnoBox.Text = "";
            CylNoBox.Text = "";
            DateConBox.Text = "";
            conNoTxtBox.Text = "";
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UpdateConsumerSP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Consumer_Name",NameBox.Text);
            cmd.Parameters.AddWithValue("@Consumer_address",AddrBox.Text);
            cmd.Parameters.AddWithValue("@Phone",PhoneBox.Text);
            cmd.Parameters.AddWithValue("@email",emailBox.Text);
            cmd.Parameters.AddWithValue("@No_of_cylinders",CylNoBox.Text);
            cmd.Parameters.AddWithValue("@LPG_id",IDBox.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Succesfully updated");
            }
            catch (Exception ex)
            {
                MessageBox.Show("          <<<INVALID SQL OPERATION>>>  \n" + ex);
            }
            con.Close();
        }

        private void TVBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            TerminationVoucher t = new TerminationVoucher();
            t.Show();
        }
    }
}
