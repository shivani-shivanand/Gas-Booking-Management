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
    public partial class CustomerReport : Form
    {
        public CustomerReport()
        {
            InitializeComponent();
        }

        private void CustomerReport_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'gas_BookingDataSet.Consumer_Log' table. You can move, or remove it, as needed.
            this.consumer_LogTableAdapter.Fill(this.gas_BookingDataSet.Consumer_Log);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            this.dataGridView1.Refresh();


        }

        private void backbtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
