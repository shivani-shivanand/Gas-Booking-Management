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
    public partial class DistributorUserControl : UserControl
    {

        private static DistributorUserControl _instance;

        public static DistributorUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new DistributorUserControl();
                }
                return _instance;
            }
        }

        public DistributorUserControl()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-90RIIDO;Initial Catalog=Gas_Booking;Integrated Security=True");

        void FillcityCombo()
        {

            String sqlSelect = "Select Area_Name from Area_Offices where State_no in (Select State_no from State_Offices where State_name='" + (stateBox.Text) + "')";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr;

            con.Open();
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String area = dr.GetString(dr.GetOrdinal("Area_Name"));
                    cityBox.Items.Add(area);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("          <<<INVALID SQL OPERATION>>>  \n" + ex);
            }
            con.Close();

        }

        void FillAreaCombo()
        {
            String sqlSelect = "Select Address from Distributor where Area_no in (Select Area_no from Area_Offices where Area_Name='" + (cityBox.Text) + "')";
            SqlCommand cmd = new SqlCommand(sqlSelect, con);
            SqlDataReader dr;

            con.Open();
            try
            {
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    String area = dr.GetString(dr.GetOrdinal("Address"));
                    areaBox.Items.Add(area);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("          <<<INVALID SQL OPERATION>>>  \n" + ex);
            }
            con.Close();

        }

        private void locateBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                String sqlSelect = "SELECT D.Dis_no,D.Name from Distributor D,Area_Offices A, State_Offices S where S.State_no = A.State_no and A.Area_no = D.Area_no and D.Dis_no in (select Dis_no from Distributor where Address = '" + areaBox.Text + "' and Area_no in (select Area_no from Area_Offices where Area_Name = '" + cityBox.Text + "' and State_no in (select State_no from State_Offices where State_name = '" + stateBox.Text + "')) )";
                SqlCommand cmd = new SqlCommand(sqlSelect, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DistributorBox.Text = (dr["Name"].ToString());
                    disNoBox.Text = (dr["Dis_no"].ToString());
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input");
            }
            con.Close();
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                String sqlSelect = "select count(*) as Domestic from Subscription_Voucher S,Distributor D where S.Dis_no = D.Dis_no and S.Cylinder_type = 'Domestic' and D.Dis_no =" + int.Parse(DisNoBox2.Text);
                SqlCommand cmd = new SqlCommand(sqlSelect, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DomBox.Text = (dr["Domestic"].ToString());
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input");
            }
            con.Close();
        }

        private void ComBtn_Click(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                String sqlSelect = "select count(*) as Commercial from Subscription_Voucher S,Distributor D where S.Dis_no = D.Dis_no and S.Cylinder_type = 'Commercial' and D.Dis_no =" + int.Parse(DisNoBox2.Text);
                SqlCommand cmd = new SqlCommand(sqlSelect, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CommBox.Text = (dr["Commercial"].ToString());
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input");
            }
            con.Close();
        }

        private void cityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillAreaCombo();
        }

        private void stateBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            FillcityCombo();
        }

        private void DisNoBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                String sqlSelect = "Select Name from Distributor where Dis_no=" + int.Parse(DisNoBox2.Text);

                SqlCommand cmd = new SqlCommand(sqlSelect, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    DisNameBox.Text = (dr["Name"].ToString());
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void locateBtn_Click_1(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                String sqlSelect = "SELECT D.Dis_no,D.Name from Distributor D,Area_Offices A, State_Offices S where S.State_no = A.State_no and A.Area_no = D.Area_no and D.Dis_no in (select Dis_no from Distributor where Address = '" + areaBox.Text + "' and Area_no in (select Area_no from Area_Offices where Area_Name = '" + cityBox.Text + "' and State_no in (select State_no from State_Offices where State_name = '" + stateBox.Text + "')) )";
                SqlCommand cmd = new SqlCommand(sqlSelect, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DistributorBox.Text = (dr["Name"].ToString());
                    disNoBox.Text = (dr["Dis_no"].ToString());
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input");
            }
            con.Close();
        }

        private void EnterBtn_Click_1(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                String sqlSelect = "select count(*) as Domestic from Subscription_Voucher S,Distributor D where S.Dis_no = D.Dis_no and S.Cylinder_type = 'Domestic' and D.Dis_no =" + int.Parse(DisNoBox2.Text);
                SqlCommand cmd = new SqlCommand(sqlSelect, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DomBox.Text = (dr["Domestic"].ToString());
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input");
            }
            con.Close();
        }

        private void ComBtn_Click_1(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                String sqlSelect = "select count(*) as Commercial from Subscription_Voucher S,Distributor D where S.Dis_no = D.Dis_no and S.Cylinder_type = 'Commercial' and D.Dis_no =" + int.Parse(DisNoBox2.Text);
                SqlCommand cmd = new SqlCommand(sqlSelect, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    CommBox.Text = (dr["Commercial"].ToString());
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input");
            }
            con.Close();
        }

        private void NOlB_Click(object sender, EventArgs e)
        {

        }

        private void cityBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            FillAreaCombo();
        }

        private void areaBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void DisNoBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            con.Open();
            try
            {
                String sqlSelect = "Select Name from Distributor where Dis_no =" + int.Parse(DisNoBox2.Text);
                SqlCommand cmd = new SqlCommand(sqlSelect, con);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    DisNameBox.Text = (dr["Name"].ToString());
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input");
            }
            con.Close();
        }

        private void stateBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            FillcityCombo();
        }
    }
}
