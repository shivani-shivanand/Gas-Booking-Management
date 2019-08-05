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
    public partial class CustomerUserControl : UserControl
    {
        private static CustomerUserControl _instance;
         
        public static CustomerUserControl Instance
        {
            get
            {
                if (_instance==null)
                {
                    _instance = new CustomerUserControl();
                }
                return _instance;
            }
        }

        public CustomerUserControl()
        {
            InitializeComponent();
        }

        private void Addcustomer_Click(object sender, EventArgs e)
        {
            Main s = new Main();
            s.Hide();
            AddCustomer ss = new AddCustomer();
            ss.Show();
        }

        private void EditCustomer_Click(object sender, EventArgs e)
        {
            Main s = new Main();
            s.Hide();
            EditCustomer ss = new EditCustomer();
            ss.Show();
        }

        private void CustomerUserControl_Load(object sender, EventArgs e)
        {
           
        }
    }
}
