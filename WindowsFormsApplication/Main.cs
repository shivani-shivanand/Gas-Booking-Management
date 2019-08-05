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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            IsSlidingPanelExpanded = true;
            expandSlidingPanelGUI();
        }

        public void expandSlidingPanelGUI()
        {
            CustomerTabbtn.Text = "CUSTOMER";
            DistributorBtn.Text = "DISTRIBUTOR";
            StocktabBtn.Text = "STOCK";
            ReportstabBtn.Text = "REPORTS";
            AboutUstabBtn.Text = "ABOUT";
            LogOutBtn.Text = "LOG IN PAGE";
            ExitBtn.Text = "EXIT";
            SlidingpToggleBtn.Image = Properties.Resources.left_arrow_angle_in_circular_button;

            CustomerTabbtn.Image = null;
            DistributorBtn.Image = null;
            StocktabBtn.Image = null;
            ReportstabBtn.Image = null;
            AboutUstabBtn.Image = null;
            LogOutBtn.Image = null;
            ExitBtn.Image = null;


        }

        public void retractSlidingPanelGUI()
        {
            CustomerTabbtn.Text = "";
            DistributorBtn.Text = "";
            StocktabBtn.Text = "";
            ReportstabBtn.Text = "";
            AboutUstabBtn.Text = "";
            LogOutBtn.Text = "";
            ExitBtn.Text = "";
            SlidingpToggleBtn.Image = Properties.Resources.right_arrow_circular_button1;

            CustomerTabbtn.Image = Properties.Resources.user2;
            DistributorBtn.Image = Properties.Resources.seller;
            StocktabBtn.Image = Properties.Resources.stock__1_;
            ReportstabBtn.Image = Properties.Resources.report;
            AboutUstabBtn.Image = Properties.Resources.information;
            LogOutBtn.Image = Properties.Resources.logout;
            ExitBtn.Image = Properties.Resources.exit;


        }

        bool IsSlidingPanelExpanded;
        const int MaxSliderWidth = 300;
        const int MinSliderWidth = 100;

        private void SlidingpToggleBtn_Click(object sender, EventArgs e)
        {
            if (IsSlidingPanelExpanded)
            {
                retractSlidingPanelGUI();
            }
            SlidingPanelTimer.Start();
        }

        private void SlidingPanelTimer_Tick(object sender, EventArgs e)
        {
            if (IsSlidingPanelExpanded)
            {
                //retract panel
                Slidingpanel.Width -= 30;
                if (Slidingpanel.Width<=MinSliderWidth)
                {
                    //stop retract
                    IsSlidingPanelExpanded = false;
                    SlidingPanelTimer.Stop();

                    this.Refresh();
                }
            }
            else
            {
                //expand the panel
                Slidingpanel.Width += 30;
                if (Slidingpanel.Width >= MaxSliderWidth)
                {
                    //stop expanding
                    IsSlidingPanelExpanded = true;
                    SlidingPanelTimer.Stop();
                    expandSlidingPanelGUI();

                    this.Refresh();
                }
            }
        }

        private void CustomerTabbtn_Click(object sender, EventArgs e)
        {
            if (! ContentPanel.Controls.Contains(CustomerUserControl.Instance))
            {
                ContentPanel.Controls.Add(CustomerUserControl.Instance);
                CustomerUserControl.Instance.Dock = DockStyle.Fill;
                CustomerUserControl.Instance.BringToFront();
            }
            else
            {
                CustomerUserControl.Instance.BringToFront();
            }
        }

        private void StocktabBtn_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(StockUserControl.Instance))
            {
                ContentPanel.Controls.Add(StockUserControl.Instance);
                StockUserControl.Instance.Dock = DockStyle.Fill;
                StockUserControl.Instance.BringToFront();
            }
            else
            {
                StockUserControl.Instance.BringToFront();
            }
        }

        private void ReportstabBtn_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(ReportsUserControl.Instance))
            {
                ContentPanel.Controls.Add(ReportsUserControl.Instance);
                ReportsUserControl.Instance.Dock = DockStyle.Fill;
                ReportsUserControl.Instance.BringToFront();
            }
            else
            {
                ReportsUserControl.Instance.BringToFront();
            }
        }

        private void AboutUstabBtn_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(AboutUserControl.Instance))
            {
                ContentPanel.Controls.Add(AboutUserControl.Instance);
                AboutUserControl.Instance.Dock = DockStyle.Fill;
                AboutUserControl.Instance.BringToFront();
            }
            else
            {
                AboutUserControl.Instance.BringToFront();
            }
        }

        private void LogOutBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 ss = new Form1();
            ss.Show();
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DistributorBtn_Click(object sender, EventArgs e)
        {
            if (!ContentPanel.Controls.Contains(DistributorUserControl.Instance))
            {
                ContentPanel.Controls.Add(DistributorUserControl.Instance);
                DistributorUserControl.Instance.Dock = DockStyle.Fill;
                DistributorUserControl.Instance.BringToFront();
            }
            else
            {
                DistributorUserControl.Instance.BringToFront();
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
