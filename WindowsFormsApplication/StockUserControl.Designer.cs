namespace WindowsFormsApplication
{
    partial class StockUserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.StockPanel = new System.Windows.Forms.Panel();
            this.Deliverybtn = new System.Windows.Forms.Button();
            this.Bookingbtn = new System.Windows.Forms.Button();
            this.Recordbtn = new System.Windows.Forms.Button();
            this.StockPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // StockPanel
            // 
            this.StockPanel.Controls.Add(this.Deliverybtn);
            this.StockPanel.Controls.Add(this.Bookingbtn);
            this.StockPanel.Controls.Add(this.Recordbtn);
            this.StockPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StockPanel.Location = new System.Drawing.Point(0, 0);
            this.StockPanel.Name = "StockPanel";
            this.StockPanel.Size = new System.Drawing.Size(695, 556);
            this.StockPanel.TabIndex = 0;
            // 
            // Deliverybtn
            // 
            this.Deliverybtn.BackColor = System.Drawing.Color.Transparent;
            this.Deliverybtn.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.ffff7e_background;
            this.Deliverybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Deliverybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deliverybtn.Location = new System.Drawing.Point(0, 372);
            this.Deliverybtn.Name = "Deliverybtn";
            this.Deliverybtn.Size = new System.Drawing.Size(695, 184);
            this.Deliverybtn.TabIndex = 2;
            this.Deliverybtn.Text = "Cylinder Delivery";
            this.Deliverybtn.UseVisualStyleBackColor = false;
            this.Deliverybtn.Click += new System.EventHandler(this.Deliverybtn_Click);
            // 
            // Bookingbtn
            // 
            this.Bookingbtn.BackColor = System.Drawing.Color.Transparent;
            this.Bookingbtn.BackgroundImage = global::WindowsFormsApplication.Properties.Resources._236593_2880x1800_light_green_solid_color_background_jpg_2880x1800_h1;
            this.Bookingbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Bookingbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bookingbtn.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Bookingbtn.Location = new System.Drawing.Point(0, 181);
            this.Bookingbtn.Name = "Bookingbtn";
            this.Bookingbtn.Size = new System.Drawing.Size(695, 194);
            this.Bookingbtn.TabIndex = 1;
            this.Bookingbtn.Text = "Cylinder Booking";
            this.Bookingbtn.UseVisualStyleBackColor = false;
            this.Bookingbtn.Click += new System.EventHandler(this.Bookingbtn_Click);
            // 
            // Recordbtn
            // 
            this.Recordbtn.BackColor = System.Drawing.Color.Transparent;
            this.Recordbtn.BackgroundImage = global::WindowsFormsApplication.Properties.Resources._0728ee4eb445c6f76bffc0222865fd2d;
            this.Recordbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Recordbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Recordbtn.Location = new System.Drawing.Point(0, 0);
            this.Recordbtn.Name = "Recordbtn";
            this.Recordbtn.Size = new System.Drawing.Size(695, 185);
            this.Recordbtn.TabIndex = 0;
            this.Recordbtn.Text = "Stock Record";
            this.Recordbtn.UseVisualStyleBackColor = false;
            this.Recordbtn.Click += new System.EventHandler(this.Recordbtn_Click);
            // 
            // StockUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.StockPanel);
            this.Name = "StockUserControl";
            this.Size = new System.Drawing.Size(695, 556);
            this.StockPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel StockPanel;
        private System.Windows.Forms.Button Deliverybtn;
        private System.Windows.Forms.Button Bookingbtn;
        private System.Windows.Forms.Button Recordbtn;
    }
}
