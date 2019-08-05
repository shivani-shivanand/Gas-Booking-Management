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
    public partial class StockRecord : Form
    {
        public StockRecord()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-90RIIDO;Initial Catalog=Gas_Booking;Integrated Security=True");

        private void DomBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("DomesticStockSP", con);
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

        private void CommBtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("CommercialStockSP", con);
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

        private void CheckBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void OrderBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("   Request for Domestic Stock has been placed   ");
        }

        private void OrderComBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("   Request for Commercial Stock has been placed   ");
        }

        private void DeliveredDomBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                String sqlSelect = "Update Stock_Registry set Quantity=Quantity + 10 where Cylinder_type='Domestic'";
                SqlCommand cmd = new SqlCommand(sqlSelect, con);

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
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void DeliveredComBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                String sqlSelect = "Update Stock_Registry set Quantity=Quantity + 10 where Cylinder_type='Commercial'";
                SqlCommand cmd = new SqlCommand(sqlSelect, con);

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
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void PriceBtn_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                String sqlSelect = "Update Stock_Registry set Price = "+ int.Parse(DomBox.Text) +" where Cylinder_type='Domestic'";
                SqlCommand cmd = new SqlCommand(sqlSelect, con);

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
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void SetPriceBtn1_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                String sqlSelect = "Update Stock_Registry set Price = " + int.Parse(CommBox.Text) + " where Cylinder_type='Commercial'";
                SqlCommand cmd = new SqlCommand(sqlSelect, con);

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
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void PriceLb_Click(object sender, EventArgs e)
        {

        }

        private void DomLb_Click(object sender, EventArgs e)
        {

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void StockLb_Click(object sender, EventArgs e)
        {

        }
    }
}
