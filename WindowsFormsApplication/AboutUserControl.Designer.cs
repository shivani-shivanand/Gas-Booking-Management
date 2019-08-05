namespace WindowsFormsApplication
{
    partial class AboutUserControl
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
            this.AreaBtn = new System.Windows.Forms.Button();
            this.StateLb = new System.Windows.Forms.Label();
            this.AreaLb = new System.Windows.Forms.Label();
            this.TotalAreaBox = new System.Windows.Forms.TextBox();
            this.DisBox = new System.Windows.Forms.TextBox();
            this.DisLb = new System.Windows.Forms.Label();
            this.CityLb = new System.Windows.Forms.Label();
            this.DistributorBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.DistributorLB = new System.Windows.Forms.Label();
            this.ConsLb = new System.Windows.Forms.Label();
            this.ConBox = new System.Windows.Forms.TextBox();
            this.ConsBtn = new System.Windows.Forms.Button();
            this.StateBox = new System.Windows.Forms.ComboBox();
            this.CityBox = new System.Windows.Forms.ComboBox();
            this.DisBox2 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // AreaBtn
            // 
            this.AreaBtn.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaBtn.Location = new System.Drawing.Point(214, 133);
            this.AreaBtn.Name = "AreaBtn";
            this.AreaBtn.Size = new System.Drawing.Size(264, 45);
            this.AreaBtn.TabIndex = 0;
            this.AreaBtn.Text = "ENTER";
            this.AreaBtn.UseVisualStyleBackColor = true;
            this.AreaBtn.Click += new System.EventHandler(this.AreaBtn_Click);
            // 
            // StateLb
            // 
            this.StateLb.AutoSize = true;
            this.StateLb.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateLb.Location = new System.Drawing.Point(173, 60);
            this.StateLb.Name = "StateLb";
            this.StateLb.Size = new System.Drawing.Size(85, 15);
            this.StateLb.TabIndex = 2;
            this.StateLb.Text = "Enter State :";
            // 
            // AreaLb
            // 
            this.AreaLb.AutoSize = true;
            this.AreaLb.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AreaLb.Location = new System.Drawing.Point(158, 93);
            this.AreaLb.Name = "AreaLb";
            this.AreaLb.Size = new System.Drawing.Size(121, 15);
            this.AreaLb.TabIndex = 3;
            this.AreaLb.Text = "Total City Offices :";
            // 
            // TotalAreaBox
            // 
            this.TotalAreaBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAreaBox.Location = new System.Drawing.Point(294, 90);
            this.TotalAreaBox.Name = "TotalAreaBox";
            this.TotalAreaBox.Size = new System.Drawing.Size(226, 23);
            this.TotalAreaBox.TabIndex = 4;
            // 
            // DisBox
            // 
            this.DisBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisBox.Location = new System.Drawing.Point(294, 278);
            this.DisBox.Name = "DisBox";
            this.DisBox.Size = new System.Drawing.Size(226, 23);
            this.DisBox.TabIndex = 9;
            // 
            // DisLb
            // 
            this.DisLb.AutoSize = true;
            this.DisLb.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisLb.Location = new System.Drawing.Point(158, 281);
            this.DisLb.Name = "DisLb";
            this.DisLb.Size = new System.Drawing.Size(125, 15);
            this.DisLb.TabIndex = 8;
            this.DisLb.Text = "Total Distributors :";
            // 
            // CityLb
            // 
            this.CityLb.AutoSize = true;
            this.CityLb.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityLb.Location = new System.Drawing.Point(173, 248);
            this.CityLb.Name = "CityLb";
            this.CityLb.Size = new System.Drawing.Size(76, 15);
            this.CityLb.TabIndex = 7;
            this.CityLb.Text = "Enter City :";
            // 
            // DistributorBtn
            // 
            this.DistributorBtn.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistributorBtn.Location = new System.Drawing.Point(214, 317);
            this.DistributorBtn.Name = "DistributorBtn";
            this.DistributorBtn.Size = new System.Drawing.Size(264, 47);
            this.DistributorBtn.TabIndex = 5;
            this.DistributorBtn.Text = "ENTER";
            this.DistributorBtn.UseVisualStyleBackColor = true;
            this.DistributorBtn.Click += new System.EventHandler(this.DistributorBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "City Offices";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Maiandra GD", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 39);
            this.label2.TabIndex = 11;
            this.label2.Text = "Distributors";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Maiandra GD", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 374);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 39);
            this.label3.TabIndex = 12;
            this.label3.Text = "Consumers";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // DistributorLB
            // 
            this.DistributorLB.AutoSize = true;
            this.DistributorLB.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DistributorLB.Location = new System.Drawing.Point(109, 429);
            this.DistributorLB.Name = "DistributorLB";
            this.DistributorLB.Size = new System.Drawing.Size(173, 15);
            this.DistributorLB.TabIndex = 13;
            this.DistributorLB.Text = "Enter Distributor Number :";
            // 
            // ConsLb
            // 
            this.ConsLb.AutoSize = true;
            this.ConsLb.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsLb.Location = new System.Drawing.Point(136, 459);
            this.ConsLb.Name = "ConsLb";
            this.ConsLb.Size = new System.Drawing.Size(122, 15);
            this.ConsLb.TabIndex = 14;
            this.ConsLb.Text = "Total Consumers :";
            // 
            // ConBox
            // 
            this.ConBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConBox.Location = new System.Drawing.Point(294, 454);
            this.ConBox.Name = "ConBox";
            this.ConBox.Size = new System.Drawing.Size(226, 23);
            this.ConBox.TabIndex = 16;
            // 
            // ConsBtn
            // 
            this.ConsBtn.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsBtn.Location = new System.Drawing.Point(214, 494);
            this.ConsBtn.Name = "ConsBtn";
            this.ConsBtn.Size = new System.Drawing.Size(264, 44);
            this.ConsBtn.TabIndex = 17;
            this.ConsBtn.Text = "ENTER";
            this.ConsBtn.UseVisualStyleBackColor = true;
            this.ConsBtn.Click += new System.EventHandler(this.ConsBtn_Click);
            // 
            // StateBox
            // 
            this.StateBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StateBox.FormattingEnabled = true;
            this.StateBox.Items.AddRange(new object[] {
            "Andaman & Nicobar Is",
            "Andhra Pradesh",
            "Gujarat",
            "Haryana",
            "Karnataka",
            "Madhya Pradesh",
            "Maharashtra",
            "Rajasthan",
            "Tamil Nadu",
            "Uttar Pradesh"});
            this.StateBox.Location = new System.Drawing.Point(294, 58);
            this.StateBox.Name = "StateBox";
            this.StateBox.Size = new System.Drawing.Size(226, 23);
            this.StateBox.TabIndex = 18;
            // 
            // CityBox
            // 
            this.CityBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CityBox.FormattingEnabled = true;
            this.CityBox.Items.AddRange(new object[] {
            "SOUTH ANDAMANS",
            "NORTH MIDDLE ANDAMA",
            "ANANTAPUR",
            "CHITTOOR",
            "VISAKHAPATNAM",
            "AHMEDABAD",
            "GANDHINAGAR",
            "RAJKOT",
            "FARIDABAD",
            "GURGAON",
            "MEWAT",
            "BANGALORE",
            "DAVANGERE",
            "GULBARGA",
            "MYSORE",
            "TUMKUR",
            "BHOPAL",
            "INDORE",
            "UJJAIN",
            "MUMBAI",
            "NASIK",
            "PUNE",
            "THANA",
            "JAIPUR",
            "JAISALMER",
            "CHENNAI",
            "KANCHEEPURAM",
            "MADURAI",
            "SALEM",
            "AGRA",
            "KANPUR",
            "LUCKNOW",
            "VARANASI"});
            this.CityBox.Location = new System.Drawing.Point(294, 247);
            this.CityBox.Name = "CityBox";
            this.CityBox.Size = new System.Drawing.Size(226, 23);
            this.CityBox.TabIndex = 19;
            // 
            // DisBox2
            // 
            this.DisBox2.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DisBox2.FormattingEnabled = true;
            this.DisBox2.Items.AddRange(new object[] {
            "117914",
            "118018",
            "118026",
            "118034",
            "118116",
            "118122",
            "118219",
            "150133",
            "150258",
            "151189",
            "252147",
            "252266",
            "253123",
            "253288",
            "254111",
            "355121",
            "355212",
            "355389",
            "356145",
            "356259",
            "357122",
            "458133",
            "459151",
            "459262",
            "459363",
            "460185",
            "561121",
            "561251",
            "561319",
            "561412",
            "561578",
            "562151",
            "563113",
            "564154",
            "564221",
            "565125",
            "666114",
            "666212",
            "667158",
            "667214",
            "668142",
            "769151",
            "769235",
            "769345",
            "769411",
            "770112",
            "771188",
            "771252",
            "772196",
            "873184",
            "873269",
            "874164",
            "975154",
            "975286",
            "975339",
            "976158",
            "977189",
            "978177"});
            this.DisBox2.Location = new System.Drawing.Point(294, 423);
            this.DisBox2.Name = "DisBox2";
            this.DisBox2.Size = new System.Drawing.Size(226, 23);
            this.DisBox2.TabIndex = 20;
            // 
            // AboutUserControl
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.Controls.Add(this.DisBox2);
            this.Controls.Add(this.CityBox);
            this.Controls.Add(this.StateBox);
            this.Controls.Add(this.ConsBtn);
            this.Controls.Add(this.ConBox);
            this.Controls.Add(this.ConsLb);
            this.Controls.Add(this.DistributorLB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DisBox);
            this.Controls.Add(this.DisLb);
            this.Controls.Add(this.CityLb);
            this.Controls.Add(this.DistributorBtn);
            this.Controls.Add(this.TotalAreaBox);
            this.Controls.Add(this.AreaLb);
            this.Controls.Add(this.StateLb);
            this.Controls.Add(this.AreaBtn);
            this.Name = "AboutUserControl";
            this.Size = new System.Drawing.Size(695, 556);
            this.Load += new System.EventHandler(this.AboutUserControl_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AreaBtn;
        private System.Windows.Forms.Label StateLb;
        private System.Windows.Forms.Label AreaLb;
        private System.Windows.Forms.TextBox TotalAreaBox;
        private System.Windows.Forms.TextBox DisBox;
        private System.Windows.Forms.Label DisLb;
        private System.Windows.Forms.Label CityLb;
        private System.Windows.Forms.Button DistributorBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label DistributorLB;
        private System.Windows.Forms.Label ConsLb;
        private System.Windows.Forms.TextBox ConBox;
        private System.Windows.Forms.Button ConsBtn;
        private System.Windows.Forms.ComboBox StateBox;
        private System.Windows.Forms.ComboBox CityBox;
        private System.Windows.Forms.ComboBox DisBox2;
    }
}
