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
    public partial class CylinderDelivery : Form
    {
        public CylinderDelivery()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-90RIIDO;Initial Catalog=Gas_Booking;Integrated Security=True");

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("CheckStatusSP", con);
            cmd.Parameters.AddWithValue("@Booking_no", BookingBox1.Text);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter text = new SqlParameter("@Text", SqlDbType.NVarChar, 1000);
            text.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(text);

            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show(text.Value.ToString()); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("          <<<INVALID SQL OPERATION>>>  \n" + ex);
            }
            con.Close();
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("UpdateStatusSP", con);
            cmd.Parameters.AddWithValue("@Booking_no", BookingBox2.Text);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter text = new SqlParameter("@Text", SqlDbType.NVarChar, 1000);
            text.Direction = ParameterDirection.Output;
            cmd.Parameters.Add(text);

            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Status Updated"); ;
            }
            catch (Exception ex)
            {
                MessageBox.Show("          <<<INVALID SQL OPERATION>>>  \n" + ex);
            }
            con.Close();
        }
    }
}
