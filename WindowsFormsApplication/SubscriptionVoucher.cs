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
    public partial class SubscriptionVoucher : Form
    {
        public SubscriptionVoucher()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-90RIIDO;Initial Catalog=Gas_Booking;Integrated Security=True");

        private void Savebtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("addSVSP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@SV_no", svnoBox.Text);
            cmd.Parameters.AddWithValue("@SV_date", dateBox.Text);
            cmd.Parameters.AddWithValue("@Consumer_no", conNoBox.Text);
            cmd.Parameters.AddWithValue("@Dis_no", DnoBox.Text);
            cmd.Parameters.AddWithValue("@Cylinder_type", CylTypebox.Text);
            cmd.Parameters.AddWithValue("@deposit_amt", amtBox.Text);

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

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            AddCustomer a = new AddCustomer();
            a.Show();
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            svnoBox.Text = "";
            dateBox.Text = "";
            conNoBox.Text = "";
            DnoBox.Text = "";
            CylTypebox.Text = "";
            amtBox.Text = "";
        }

        private void dateBox_ValueChanged(object sender, EventArgs e)
        {

        }

        private void svNoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
