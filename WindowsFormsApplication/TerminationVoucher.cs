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
    public partial class TerminationVoucher : Form
    {
        public TerminationVoucher()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-90RIIDO;Initial Catalog=Gas_Booking;Integrated Security=True");

        private void amtBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void CylTypebox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DnoBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("TerminationVoucherSP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TV_no",TVnoBox.Text);
            cmd.Parameters.AddWithValue("@TV_date", dateBox.Text);
            cmd.Parameters.AddWithValue("@Consumer_no", conNoBox.Text);
            cmd.Parameters.AddWithValue("@SV_no", SVBox.Text);
            cmd.Parameters.AddWithValue("@Cylinder_type", CylTypebox.Text);
            cmd.Parameters.AddWithValue("@amt_paid", amtBox.Text);
            cmd.Parameters.AddWithValue("@Dis_no", DnoBox.Text);
            cmd.Parameters.AddWithValue("@Transferee_Dis_no", NewDnoBox.Text);
            cmd.Parameters.AddWithValue("@Remarks", RemarksBox.Text);

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

        private void conNoBox_TextChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                String sqlSelect = "Select(max(T.TV_no) + 1) as max, S.SV_no,S.Dis_no,S.Cylinder_type,S.deposit_amt from Termination_Voucher T,Subscription_Voucher S ,Consumer C WHERE C.Consumer_no=S.Consumer_no and C.Consumer_no = " + int.Parse(conNoBox.Text) + " group by  S.SV_no,S.Dis_no,S.deposit_amt,S.Cylinder_type";

                SqlCommand cmd = new SqlCommand(sqlSelect, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TVnoBox.Text = (dr["max"].ToString());
                    SVBox.Text = (dr["SV_no"].ToString());
                    DnoBox.Text = (dr["Dis_no"].ToString());
                    CylTypebox.Text = (dr["Cylinder_type"].ToString());
                    amtBox.Text = (dr["deposit_amt"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {

            TVnoBox.Text = "";
            SVBox.Text = "";
            DnoBox.Text = "";
            CylTypebox.Text = "";
            amtBox.Text = "";
            dateBox.Text = "";
            conNoBox.Text = "";
            NewDnoBox.Text = "";
            RemarksBox.Text = "";
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void conNoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void TerminationVoucher_Load(object sender, EventArgs e)
        {

        }
    }
}
