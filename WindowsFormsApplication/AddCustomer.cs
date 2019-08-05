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
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-90RIIDO;Initial Catalog=Gas_Booking;Integrated Security=True");

        private void AddCustomer_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDataSet.Consumer' table. You can move, or remove it, as needed.
           

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("CustomerAddSP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@LPG_id",LPGidTxtbox.Text);
            cmd.Parameters.AddWithValue("@Consumer_no",conNoTxtbox.Text);
            cmd.Parameters.AddWithValue("@Consumer_Name",nameTxtbox.Text);
            cmd.Parameters.AddWithValue("@Consumer_address",addrTxtbox.Text);
            cmd.Parameters.AddWithValue("@Phone",phoneTxtBox.Text);
            cmd.Parameters.AddWithValue("@email",emailTxtbox.Text);
            cmd.Parameters.AddWithValue("@Dis_no",dnoTxtbox.Text);
            cmd.Parameters.AddWithValue("@No_of_cylinders",NoCylTxtBox.Text);
            cmd.Parameters.AddWithValue("@Date_of_connection",dateOfConnBox.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Succesfully entered");
            }
            catch (Exception ex)
            {
                MessageBox.Show("          <<<INVALID SQL OPERATION>>>  \n" + ex);
            }
            con.Close();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SVbtn_Click(object sender, EventArgs e)
        {

        }

        private void SVbtn_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            SubscriptionVoucher S = new SubscriptionVoucher();
            S.Show();
        }

        private void BackBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Savebtn_Click_1(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("CustomerAddSP", con);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@LPG_id", LPGidTxtbox.Text);
            cmd.Parameters.AddWithValue("@Consumer_no", conNoTxtbox.Text);
            cmd.Parameters.AddWithValue("@Consumer_Name", nameTxtbox.Text);
            cmd.Parameters.AddWithValue("@Consumer_address", addrTxtbox.Text);
            cmd.Parameters.AddWithValue("@Phone", phoneTxtBox.Text);
            cmd.Parameters.AddWithValue("@email", emailTxtbox.Text);
            cmd.Parameters.AddWithValue("@Dis_no", dnoTxtbox.Text);
            cmd.Parameters.AddWithValue("@No_of_cylinders", NoCylTxtBox.Text);
            cmd.Parameters.AddWithValue("@Date_of_connection", dateOfConnBox.Text);

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Succesfully entered");
            }
            catch (Exception ex)
            {
                MessageBox.Show("          <<<INVALID SQL OPERATION>>>  \n" + ex);
            }
            con.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            LPGidTxtbox.Text = "";
            conNoTxtbox.Text = "";
            nameTxtbox.Text = "";
            addrTxtbox.Text = "";
            phoneTxtBox.Text = "";
            emailTxtbox.Text = "";
            dnoTxtbox.Text = "";
            NoCylTxtBox.Text = "";
            dateOfConnBox.Text = "";
        }
    }
}
