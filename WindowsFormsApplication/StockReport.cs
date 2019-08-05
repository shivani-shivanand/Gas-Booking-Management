using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication
{
    public partial class StockReport : Form
    {
        public StockReport()
        {
            InitializeComponent();
        }

        private void StockReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gas_BookingDataSet1.Stock_Registry' table. You can move, or remove it, as needed.
            this.stock_RegistryTableAdapter.Fill(this.gas_BookingDataSet1.Stock_Registry);

        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.Refresh();
        }
    }
}
