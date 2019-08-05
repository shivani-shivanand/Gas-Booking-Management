namespace WindowsFormsApplication
{
    partial class Main
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.SlidingPanelTimer = new System.Windows.Forms.Timer(this.components);
            this.ContentPanel = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Slidingpanel = new System.Windows.Forms.Panel();
            this.DistributorBtn = new System.Windows.Forms.Button();
            this.CustomerTabbtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.LogOutBtn = new System.Windows.Forms.Button();
            this.ReportstabBtn = new System.Windows.Forms.Button();
            this.AboutUstabBtn = new System.Windows.Forms.Button();
            this.StocktabBtn = new System.Windows.Forms.Button();
            this.SlidingpToggleBtn = new System.Windows.Forms.Button();
            this.ContentPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Slidingpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SlidingPanelTimer
            // 
            this.SlidingPanelTimer.Tick += new System.EventHandler(this.SlidingPanelTimer_Tick);
            // 
            // ContentPanel
            // 
            this.ContentPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ContentPanel.Controls.Add(this.label3);
            this.ContentPanel.Controls.Add(this.label2);
            this.ContentPanel.Controls.Add(this.label1);
            this.ContentPanel.Controls.Add(this.pictureBox1);
            this.ContentPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.ContentPanel.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ContentPanel.Location = new System.Drawing.Point(299, 0);
            this.ContentPanel.Name = "ContentPanel";
            this.ContentPanel.Size = new System.Drawing.Size(695, 556);
            this.ContentPanel.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(440, 514);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Contact Us : 9854120012";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 200);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(536, 192);
            this.label2.TabIndex = 2;
            this.label2.Text = resources.GetString("label2.Text");
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(85, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(323, 77);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome ";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::WindowsFormsApplication.Properties.Resources.indane_gas;
            this.pictureBox1.Location = new System.Drawing.Point(523, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(172, 148);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Slidingpanel
            // 
            this.Slidingpanel.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Slidingpanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Slidingpanel.Controls.Add(this.DistributorBtn);
            this.Slidingpanel.Controls.Add(this.CustomerTabbtn);
            this.Slidingpanel.Controls.Add(this.ExitBtn);
            this.Slidingpanel.Controls.Add(this.LogOutBtn);
            this.Slidingpanel.Controls.Add(this.ReportstabBtn);
            this.Slidingpanel.Controls.Add(this.AboutUstabBtn);
            this.Slidingpanel.Controls.Add(this.StocktabBtn);
            this.Slidingpanel.Controls.Add(this.SlidingpToggleBtn);
            this.Slidingpanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.Slidingpanel.Location = new System.Drawing.Point(0, 0);
            this.Slidingpanel.Name = "Slidingpanel";
            this.Slidingpanel.Size = new System.Drawing.Size(300, 556);
            this.Slidingpanel.TabIndex = 0;
            // 
            // DistributorBtn
            // 
            this.DistributorBtn.BackColor = System.Drawing.Color.Transparent;
            this.DistributorBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DistributorBtn.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistributorBtn.ForeColor = System.Drawing.Color.White;
            this.DistributorBtn.Image = global::WindowsFormsApplication.Properties.Resources.seller;
            this.DistributorBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DistributorBtn.Location = new System.Drawing.Point(0, 145);
            this.DistributorBtn.Name = "DistributorBtn";
            this.DistributorBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.DistributorBtn.Size = new System.Drawing.Size(300, 72);
            this.DistributorBtn.TabIndex = 0;
            this.DistributorBtn.Text = "DISTRIBUTOR";
            this.DistributorBtn.UseVisualStyleBackColor = false;
            this.DistributorBtn.Click += new System.EventHandler(this.DistributorBtn_Click);
            // 
            // CustomerTabbtn
            // 
            this.CustomerTabbtn.BackColor = System.Drawing.Color.Transparent;
            this.CustomerTabbtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CustomerTabbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CustomerTabbtn.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerTabbtn.ForeColor = System.Drawing.Color.White;
            this.CustomerTabbtn.Image = global::WindowsFormsApplication.Properties.Resources.user2;
            this.CustomerTabbtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CustomerTabbtn.Location = new System.Drawing.Point(0, 75);
            this.CustomerTabbtn.Name = "CustomerTabbtn";
            this.CustomerTabbtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.CustomerTabbtn.Size = new System.Drawing.Size(300, 73);
            this.CustomerTabbtn.TabIndex = 6;
            this.CustomerTabbtn.Text = "Customer";
            this.CustomerTabbtn.UseVisualStyleBackColor = false;
            this.CustomerTabbtn.Click += new System.EventHandler(this.CustomerTabbtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Transparent;
            this.ExitBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ExitBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExitBtn.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.ForeColor = System.Drawing.Color.White;
            this.ExitBtn.Image = global::WindowsFormsApplication.Properties.Resources.exit;
            this.ExitBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ExitBtn.Location = new System.Drawing.Point(0, 493);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ExitBtn.Size = new System.Drawing.Size(300, 63);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // LogOutBtn
            // 
            this.LogOutBtn.BackColor = System.Drawing.Color.Transparent;
            this.LogOutBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.LogOutBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogOutBtn.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogOutBtn.ForeColor = System.Drawing.Color.White;
            this.LogOutBtn.Image = global::WindowsFormsApplication.Properties.Resources.logout;
            this.LogOutBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LogOutBtn.Location = new System.Drawing.Point(0, 425);
            this.LogOutBtn.Name = "LogOutBtn";
            this.LogOutBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.LogOutBtn.Size = new System.Drawing.Size(300, 71);
            this.LogOutBtn.TabIndex = 3;
            this.LogOutBtn.Text = "Log In Page";
            this.LogOutBtn.UseVisualStyleBackColor = false;
            this.LogOutBtn.Click += new System.EventHandler(this.LogOutBtn_Click);
            // 
            // ReportstabBtn
            // 
            this.ReportstabBtn.BackColor = System.Drawing.Color.Transparent;
            this.ReportstabBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ReportstabBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ReportstabBtn.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReportstabBtn.ForeColor = System.Drawing.Color.White;
            this.ReportstabBtn.Image = global::WindowsFormsApplication.Properties.Resources.report;
            this.ReportstabBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ReportstabBtn.Location = new System.Drawing.Point(0, 285);
            this.ReportstabBtn.Name = "ReportstabBtn";
            this.ReportstabBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.ReportstabBtn.Size = new System.Drawing.Size(300, 75);
            this.ReportstabBtn.TabIndex = 5;
            this.ReportstabBtn.Text = "Reports";
            this.ReportstabBtn.UseVisualStyleBackColor = false;
            this.ReportstabBtn.Click += new System.EventHandler(this.ReportstabBtn_Click);
            // 
            // AboutUstabBtn
            // 
            this.AboutUstabBtn.BackColor = System.Drawing.Color.Transparent;
            this.AboutUstabBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.AboutUstabBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AboutUstabBtn.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AboutUstabBtn.ForeColor = System.Drawing.Color.White;
            this.AboutUstabBtn.Image = global::WindowsFormsApplication.Properties.Resources.information;
            this.AboutUstabBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AboutUstabBtn.Location = new System.Drawing.Point(0, 355);
            this.AboutUstabBtn.Name = "AboutUstabBtn";
            this.AboutUstabBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.AboutUstabBtn.Size = new System.Drawing.Size(300, 73);
            this.AboutUstabBtn.TabIndex = 2;
            this.AboutUstabBtn.Text = "About ";
            this.AboutUstabBtn.UseVisualStyleBackColor = false;
            this.AboutUstabBtn.Click += new System.EventHandler(this.AboutUstabBtn_Click);
            // 
            // StocktabBtn
            // 
            this.StocktabBtn.BackColor = System.Drawing.Color.Transparent;
            this.StocktabBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StocktabBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StocktabBtn.Font = new System.Drawing.Font("Maiandra GD", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StocktabBtn.ForeColor = System.Drawing.Color.White;
            this.StocktabBtn.Image = global::WindowsFormsApplication.Properties.Resources.stock__1_;
            this.StocktabBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.StocktabBtn.Location = new System.Drawing.Point(0, 214);
            this.StocktabBtn.Name = "StocktabBtn";
            this.StocktabBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.StocktabBtn.Size = new System.Drawing.Size(300, 74);
            this.StocktabBtn.TabIndex = 4;
            this.StocktabBtn.Text = "Stock";
            this.StocktabBtn.UseVisualStyleBackColor = false;
            this.StocktabBtn.Click += new System.EventHandler(this.StocktabBtn_Click);
            // 
            // SlidingpToggleBtn
            // 
            this.SlidingpToggleBtn.BackColor = System.Drawing.Color.Transparent;
            this.SlidingpToggleBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.SlidingpToggleBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SlidingpToggleBtn.Image = global::WindowsFormsApplication.Properties.Resources.right_arrow_circular_button1;
            this.SlidingpToggleBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SlidingpToggleBtn.Location = new System.Drawing.Point(0, 0);
            this.SlidingpToggleBtn.Name = "SlidingpToggleBtn";
            this.SlidingpToggleBtn.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.SlidingpToggleBtn.Size = new System.Drawing.Size(300, 69);
            this.SlidingpToggleBtn.TabIndex = 0;
            this.SlidingpToggleBtn.UseVisualStyleBackColor = false;
            this.SlidingpToggleBtn.Click += new System.EventHandler(this.SlidingpToggleBtn_Click);
            // 
            // Main
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(994, 556);
            this.Controls.Add(this.ContentPanel);
            this.Controls.Add(this.Slidingpanel);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ContentPanel.ResumeLayout(false);
            this.ContentPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Slidingpanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Slidingpanel;
        private System.Windows.Forms.Button SlidingpToggleBtn;
        private System.Windows.Forms.Timer SlidingPanelTimer;
        private System.Windows.Forms.Button CustomerTabbtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button LogOutBtn;
        private System.Windows.Forms.Button ReportstabBtn;
        private System.Windows.Forms.Button AboutUstabBtn;
        private System.Windows.Forms.Button StocktabBtn;
        private System.Windows.Forms.Panel ContentPanel;
        private System.Windows.Forms.Button DistributorBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}