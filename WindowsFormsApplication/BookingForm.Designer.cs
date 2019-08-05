namespace WindowsFormsApplication
{
    partial class BookingForm
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
            this.Heading = new System.Windows.Forms.Label();
            this.ConNoLabel = new System.Windows.Forms.Label();
            this.ConNoBox = new System.Windows.Forms.ComboBox();
            this.bookingNoLb = new System.Windows.Forms.Label();
            this.NameLb = new System.Windows.Forms.Label();
            this.Tyelb = new System.Windows.Forms.Label();
            this.addrLb = new System.Windows.Forms.Label();
            this.Phonelb = new System.Windows.Forms.Label();
            this.dateLb = new System.Windows.Forms.Label();
            this.BookingNoBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AddrBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.TypeBox = new System.Windows.Forms.TextBox();
            this.DateBox = new System.Windows.Forms.DateTimePicker();
            this.Bookbtn = new System.Windows.Forms.Button();
            this.Backbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Heading
            // 
            this.Heading.AutoSize = true;
            this.Heading.Font = new System.Drawing.Font("Maiandra GD", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Heading.Location = new System.Drawing.Point(12, 23);
            this.Heading.Name = "Heading";
            this.Heading.Size = new System.Drawing.Size(276, 39);
            this.Heading.TabIndex = 0;
            this.Heading.Text = "Cylinder Booking";
            // 
            // ConNoLabel
            // 
            this.ConNoLabel.AutoSize = true;
            this.ConNoLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConNoLabel.Location = new System.Drawing.Point(111, 139);
            this.ConNoLabel.Name = "ConNoLabel";
            this.ConNoLabel.Size = new System.Drawing.Size(133, 15);
            this.ConNoLabel.TabIndex = 1;
            this.ConNoLabel.Text = "Consumer Number :";
            // 
            // ConNoBox
            // 
            this.ConNoBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConNoBox.FormattingEnabled = true;
            this.ConNoBox.Items.AddRange(new object[] {
            "5189",
            "5238",
            "5241",
            "5256",
            "5282",
            "5289"});
            this.ConNoBox.Location = new System.Drawing.Point(251, 138);
            this.ConNoBox.Name = "ConNoBox";
            this.ConNoBox.Size = new System.Drawing.Size(242, 23);
            this.ConNoBox.TabIndex = 2;
            this.ConNoBox.SelectedIndexChanged += new System.EventHandler(this.ConNoBox_SelectedIndexChanged);
            // 
            // bookingNoLb
            // 
            this.bookingNoLb.AutoSize = true;
            this.bookingNoLb.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bookingNoLb.Location = new System.Drawing.Point(111, 95);
            this.bookingNoLb.Name = "bookingNoLb";
            this.bookingNoLb.Size = new System.Drawing.Size(121, 15);
            this.bookingNoLb.TabIndex = 3;
            this.bookingNoLb.Text = "Booking Number :";
            // 
            // NameLb
            // 
            this.NameLb.AutoSize = true;
            this.NameLb.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLb.Location = new System.Drawing.Point(111, 190);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(50, 15);
            this.NameLb.TabIndex = 4;
            this.NameLb.Text = "Name :";
            // 
            // Tyelb
            // 
            this.Tyelb.AutoSize = true;
            this.Tyelb.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tyelb.Location = new System.Drawing.Point(111, 353);
            this.Tyelb.Name = "Tyelb";
            this.Tyelb.Size = new System.Drawing.Size(100, 15);
            this.Tyelb.TabIndex = 5;
            this.Tyelb.Text = "Cylinder Type :";
            // 
            // addrLb
            // 
            this.addrLb.AutoSize = true;
            this.addrLb.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addrLb.Location = new System.Drawing.Point(111, 242);
            this.addrLb.Name = "addrLb";
            this.addrLb.Size = new System.Drawing.Size(67, 15);
            this.addrLb.TabIndex = 6;
            this.addrLb.Text = "Address :";
            // 
            // Phonelb
            // 
            this.Phonelb.AutoSize = true;
            this.Phonelb.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phonelb.Location = new System.Drawing.Point(111, 298);
            this.Phonelb.Name = "Phonelb";
            this.Phonelb.Size = new System.Drawing.Size(55, 15);
            this.Phonelb.TabIndex = 7;
            this.Phonelb.Text = "Phone :";
            this.Phonelb.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateLb
            // 
            this.dateLb.AutoSize = true;
            this.dateLb.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLb.Location = new System.Drawing.Point(111, 411);
            this.dateLb.Name = "dateLb";
            this.dateLb.Size = new System.Drawing.Size(102, 15);
            this.dateLb.TabIndex = 8;
            this.dateLb.Text = "Booking Date :";
            // 
            // BookingNoBox
            // 
            this.BookingNoBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BookingNoBox.Location = new System.Drawing.Point(251, 97);
            this.BookingNoBox.Name = "BookingNoBox";
            this.BookingNoBox.Size = new System.Drawing.Size(242, 23);
            this.BookingNoBox.TabIndex = 9;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(251, 192);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(242, 23);
            this.NameBox.TabIndex = 10;
            // 
            // AddrBox
            // 
            this.AddrBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddrBox.Location = new System.Drawing.Point(251, 236);
            this.AddrBox.Name = "AddrBox";
            this.AddrBox.Size = new System.Drawing.Size(242, 23);
            this.AddrBox.TabIndex = 11;
            this.AddrBox.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // PhoneBox
            // 
            this.PhoneBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneBox.Location = new System.Drawing.Point(251, 292);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(242, 23);
            this.PhoneBox.TabIndex = 12;
            // 
            // TypeBox
            // 
            this.TypeBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TypeBox.Location = new System.Drawing.Point(251, 347);
            this.TypeBox.Name = "TypeBox";
            this.TypeBox.Size = new System.Drawing.Size(242, 23);
            this.TypeBox.TabIndex = 13;
            // 
            // DateBox
            // 
            this.DateBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateBox.Location = new System.Drawing.Point(251, 405);
            this.DateBox.Name = "DateBox";
            this.DateBox.Size = new System.Drawing.Size(242, 23);
            this.DateBox.TabIndex = 14;
            // 
            // Bookbtn
            // 
            this.Bookbtn.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Bookbtn.Location = new System.Drawing.Point(570, 288);
            this.Bookbtn.Name = "Bookbtn";
            this.Bookbtn.Size = new System.Drawing.Size(200, 51);
            this.Bookbtn.TabIndex = 15;
            this.Bookbtn.Text = "BOOK";
            this.Bookbtn.UseVisualStyleBackColor = true;
            this.Bookbtn.Click += new System.EventHandler(this.Bookbtn_Click);
            // 
            // Backbtn
            // 
            this.Backbtn.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Backbtn.Location = new System.Drawing.Point(570, 345);
            this.Backbtn.Name = "Backbtn";
            this.Backbtn.Size = new System.Drawing.Size(200, 52);
            this.Backbtn.TabIndex = 16;
            this.Backbtn.Text = "BACK";
            this.Backbtn.UseVisualStyleBackColor = true;
            this.Backbtn.Click += new System.EventHandler(this.Backbtn_Click);
            // 
            // BookingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 493);
            this.Controls.Add(this.Backbtn);
            this.Controls.Add(this.Bookbtn);
            this.Controls.Add(this.DateBox);
            this.Controls.Add(this.TypeBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.AddrBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.BookingNoBox);
            this.Controls.Add(this.dateLb);
            this.Controls.Add(this.Phonelb);
            this.Controls.Add(this.addrLb);
            this.Controls.Add(this.Tyelb);
            this.Controls.Add(this.NameLb);
            this.Controls.Add(this.bookingNoLb);
            this.Controls.Add(this.ConNoBox);
            this.Controls.Add(this.ConNoLabel);
            this.Controls.Add(this.Heading);
            this.Name = "BookingForm";
            this.Text = "BookingForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Heading;
        private System.Windows.Forms.Label ConNoLabel;
        private System.Windows.Forms.ComboBox ConNoBox;
        private System.Windows.Forms.Label bookingNoLb;
        private System.Windows.Forms.Label NameLb;
        private System.Windows.Forms.Label Tyelb;
        private System.Windows.Forms.Label addrLb;
        private System.Windows.Forms.Label Phonelb;
        private System.Windows.Forms.Label dateLb;
        private System.Windows.Forms.TextBox BookingNoBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox AddrBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox TypeBox;
        private System.Windows.Forms.DateTimePicker DateBox;
        private System.Windows.Forms.Button Bookbtn;
        private System.Windows.Forms.Button Backbtn;
    }
}