using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace WindowsFormsApplication
{
    public partial class AboutUserControl : UserControl
    {
        private static AboutUserControl _instance;

        public static AboutUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new AboutUserControl();
                }
                return _instance;
            }
        }
        public AboutUserControl()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-90RIIDO;Initial Catalog=Gas_Booking;Integrated Security=True");

        private void AreaBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("CountAreaOfficesSP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("State_name", StateBox.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    TotalAreaBox.Text = (dr["Total_no_of_Ar_offices"].ToString());
                }
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("          Invalid Entry        \n");
            }
            con.Close();
        }

        private void DistributorBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("CountDistributorsSP", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Area_Name", CityBox.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    DisBox.Text = (dr["Total_distributors"].ToString());
                }
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("          Invalid Entry        \n");
            }
            con.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void ConsBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                SqlCommand cmd = new SqlCommand("TotalCustomers", con);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("Dis_no", DisBox2.Text);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    ConBox.Text = (dr["Count"].ToString());
                }
                con.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show("          Invalid Entry        \n");
            }
            con.Close();
        }

        private void AboutUserControl_Load(object sender, EventArgs e)
        {

        }
    }
}
