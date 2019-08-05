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
    public partial class ReportsUserControl : UserControl
    {
        private static ReportsUserControl _instance;

        public static ReportsUserControl Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new ReportsUserControl();
                }
                return _instance;
            }
        }
        public ReportsUserControl()
        {
            InitializeComponent();
        }

        private void Custreportbtn_Click(object sender, EventArgs e)
        {
            
            CustomerReport s = new CustomerReport();
            s.Show();

        }

        private void Stockreportbtn_Click(object sender, EventArgs e)
        {
            
            StockReport s = new StockReport();
            s.Show();

        }

        private void DeliveryReporybtn_Click(object sender, EventArgs e)
        {
            
            DeliveryReport s = new DeliveryReport();
            s.Show();

        }
    }
}
