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
    public partial class BookingForm : Form
    {
        public BookingForm()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-90RIIDO;Initial Catalog=Gas_Booking;Integrated Security=True");

        private void ConNoBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                con.Open();

                String sqlSelect = "Select(max(B.Booking_no) + 1) as max, C.Consumer_Name,C.Consumer_address,C.Phone,S.Cylinder_type from Gas_Booking B, Consumer C,Subscription_Voucher S WHERE C.Dis_no = S.Dis_no and C.Consumer_no = S.Consumer_no and C.Consumer_no = " + int.Parse(ConNoBox.Text) + " group by C.Consumer_Name,C.Consumer_address,C.Phone,S.Cylinder_type";

                SqlCommand cmd = new SqlCommand(sqlSelect, con);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    BookingNoBox.Text = (dr["max"].ToString());
                    NameBox.Text = (dr["Consumer_Name"].ToString());
                    AddrBox.Text = (dr["Consumer_address"].ToString());
                    PhoneBox.Text = (dr["Phone"].ToString());
                    TypeBox.Text = (dr["Cylinder_type"].ToString());

                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Invalid Input");
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Bookbtn_Click(object sender, EventArgs e)
        {
            SqlCommand cmd = new SqlCommand("BookingSP", con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Booking_no",BookingNoBox.Text);
            cmd.Parameters.AddWithValue("@Cons_no",ConNoBox.Text);
            cmd.Parameters.AddWithValue("@Booking_date",DateBox.Text);
            cmd.Parameters.AddWithValue("@Cylinder_type", TypeBox.Text);

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

        private void Backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BillBtn_Click(object sender, EventArgs e)
        {
            
            String query = "select B.Booking_date,B.Due_date,C.Consumer_no,C.Consumer_Name,C.Consumer_address,C.Phone,C.Dis_no,S.Cylinder_type,R.Price from Consumer C, Subscription_Voucher S,Gas_Booking B, Stock_Registry R where B.Cons_no = C.Consumer_no AND S.Consumer_no = C.Consumer_no AND S.Cylinder_type = R.Cylinder_type AND B.Booking_no = " + int.Parse(BookingNoBox.Text);

            SqlCommand cmd = new SqlCommand(query, con);

            cmd.Parameters.AddWithValue("@Booking_no", BookingNoBox.Text);
            

            con.Open();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            con.Close();

            con.Open();
            try
            {
                cmd.ExecuteNonQuery();
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("          <<<INVALID SQL OPERATION>>>  \n" + ex);
            }
            con.Close();
        }
    }
}
