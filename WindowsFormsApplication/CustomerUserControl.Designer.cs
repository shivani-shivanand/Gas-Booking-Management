namespace WindowsFormsApplication
{
    partial class CustomerUserControl
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
            this.EditCustomer = new System.Windows.Forms.Button();
            this.Addcustomer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // EditCustomer
            // 
            this.EditCustomer.BackColor = System.Drawing.Color.Transparent;
            this.EditCustomer.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.wallpaper2you_161531;
            this.EditCustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.EditCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.EditCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EditCustomer.Location = new System.Drawing.Point(0, 277);
            this.EditCustomer.Name = "EditCustomer";
            this.EditCustomer.Size = new System.Drawing.Size(695, 279);
            this.EditCustomer.TabIndex = 1;
            this.EditCustomer.Text = "EDIT CUSTOMER";
            this.EditCustomer.UseVisualStyleBackColor = false;
            this.EditCustomer.Click += new System.EventHandler(this.EditCustomer_Click);
            // 
            // Addcustomer
            // 
            this.Addcustomer.BackColor = System.Drawing.Color.Transparent;
            this.Addcustomer.BackgroundImage = global::WindowsFormsApplication.Properties.Resources.Deep_Peach_Solid_Color_Background_Wallpaper_5120x2880;
            this.Addcustomer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Addcustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Addcustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addcustomer.Location = new System.Drawing.Point(0, 0);
            this.Addcustomer.Name = "Addcustomer";
            this.Addcustomer.Size = new System.Drawing.Size(695, 279);
            this.Addcustomer.TabIndex = 0;
            this.Addcustomer.Text = "ADD CUSTOMER";
            this.Addcustomer.UseVisualStyleBackColor = false;
            this.Addcustomer.Click += new System.EventHandler(this.Addcustomer_Click);
            // 
            // CustomerUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.EditCustomer);
            this.Controls.Add(this.Addcustomer);
            this.Name = "CustomerUserControl";
            this.Size = new System.Drawing.Size(695, 556);
            this.Load += new System.EventHandler(this.CustomerUserControl_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Addcustomer;
        private System.Windows.Forms.Button EditCustomer;
    }
}
