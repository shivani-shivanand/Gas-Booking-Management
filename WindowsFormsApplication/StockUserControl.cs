using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class StockUserControl : UserControl
    {
        private static StockUserControl _instance;

        public static StockUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new StockUserControl();
                }
                return _instance;
            }
        }

        Main _current;
        public StockUserControl()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void Bookingbtn_Click(object sender, EventArgs e)
        {
            BookingForm b = new BookingForm();
            b.Show();
        }

        private void Recordbtn_Click(object sender, EventArgs e)
        {
            StockRecord s = new StockRecord();
            s.Show();
        }

        private void Deliverybtn_Click(object sender, EventArgs e)
        {
           
            CylinderDelivery c = new CylinderDelivery();
            c.Show();
        }
    }
}
