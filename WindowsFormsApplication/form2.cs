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
    public partial class form2 : Form
    {
        public form2()
        {
            InitializeComponent();
        }

        private void consumerBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.consumerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.customerDataSet);

        }

        private void form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'customerDataSet.Consumer' table. You can move, or remove it, as needed.
            this.consumerTableAdapter.Fill(this.customerDataSet.Consumer);

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void consumerBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Main ss = new Main();
            ss.Show();
        }
    }
}
