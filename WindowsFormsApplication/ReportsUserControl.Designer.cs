namespace WindowsFormsApplication
{
    partial class ReportsUserControl
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
            this.DeliveryReporybtn = new System.Windows.Forms.Button();
            this.Stockreportbtn = new System.Windows.Forms.Button();
            this.Custreportbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DeliveryReporybtn
            // 
            this.DeliveryReporybtn.BackColor = System.Drawing.Color.Transparent;
            this.DeliveryReporybtn.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.bluepurple;
            this.DeliveryReporybtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.DeliveryReporybtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeliveryReporybtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveryReporybtn.Location = new System.Drawing.Point(0, 279);
            this.DeliveryReporybtn.Name = "DeliveryReporybtn";
            this.DeliveryReporybtn.Size = new System.Drawing.Size(695, 277);
            this.DeliveryReporybtn.TabIndex = 1;
            this.DeliveryReporybtn.Text = "DELIVERY REPORT";
            this.DeliveryReporybtn.UseVisualStyleBackColor = false;
            this.DeliveryReporybtn.Click += new System.EventHandler(this.DeliveryReporybtn_Click);
            // 
            // Stockreportbtn
            // 
            this.Stockreportbtn.BackColor = System.Drawing.Color.Transparent;
            this.Stockreportbtn.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.tealgreen;
            this.Stockreportbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Stockreportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Stockreportbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Stockreportbtn.Location = new System.Drawing.Point(348, 0);
            this.Stockreportbtn.Name = "Stockreportbtn";
            this.Stockreportbtn.Size = new System.Drawing.Size(347, 280);
            this.Stockreportbtn.TabIndex = 2;
            this.Stockreportbtn.Text = "STOCK REPORT";
            this.Stockreportbtn.UseVisualStyleBackColor = false;
            this.Stockreportbtn.Click += new System.EventHandler(this.Stockreportbtn_Click);
            // 
            // Custreportbtn
            // 
            this.Custreportbtn.BackColor = System.Drawing.Color.Transparent;
            this.Custreportbtn.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.pinkpurple;
            this.Custreportbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Custreportbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Custreportbtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Custreportbtn.Location = new System.Drawing.Point(0, 0);
            this.Custreportbtn.Name = "Custreportbtn";
            this.Custreportbtn.Size = new System.Drawing.Size(351, 280);
            this.Custreportbtn.TabIndex = 0;
            this.Custreportbtn.Text = "CUSTOMER REPORT";
            this.Custreportbtn.UseVisualStyleBackColor = false;
            this.Custreportbtn.Click += new System.EventHandler(this.Custreportbtn_Click);
            // 
            // ReportsUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.Stockreportbtn);
            this.Controls.Add(this.DeliveryReporybtn);
            this.Controls.Add(this.Custreportbtn);
            this.Name = "ReportsUserControl";
            this.Size = new System.Drawing.Size(695, 556);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Custreportbtn;
        private System.Windows.Forms.Button DeliveryReporybtn;
        private System.Windows.Forms.Button Stockreportbtn;
    }
}
