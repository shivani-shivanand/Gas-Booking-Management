namespace WindowsFormsApplication
{
    partial class TerminationVoucher
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
            this.ClearBtn = new System.Windows.Forms.Button();
            this.TVLabel = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.CylTypebox = new System.Windows.Forms.ComboBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.amtBox = new System.Windows.Forms.TextBox();
            this.DnoBox = new System.Windows.Forms.TextBox();
            this.TVnoBox = new System.Windows.Forms.TextBox();
            this.amtLabel = new System.Windows.Forms.Label();
            this.CylTypelabel = new System.Windows.Forms.Label();
            this.DNoLabel = new System.Windows.Forms.Label();
            this.ConNoLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.tvNoLb = new System.Windows.Forms.Label();
            this.SVNoLB = new System.Windows.Forms.Label();
            this.NewDisNoLb = new System.Windows.Forms.Label();
            this.SVBox = new System.Windows.Forms.TextBox();
            this.NewDnoBox = new System.Windows.Forms.TextBox();
            this.RemarkLb = new System.Windows.Forms.Label();
            this.RemarksBox = new System.Windows.Forms.TextBox();
            this.conNoBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(354, 420);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(155, 43);
            this.ClearBtn.TabIndex = 47;
            this.ClearBtn.Text = "CLEAR";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // TVLabel
            // 
            this.TVLabel.AutoSize = true;
            this.TVLabel.Font = new System.Drawing.Font("Maiandra GD", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVLabel.Location = new System.Drawing.Point(12, 19);
            this.TVLabel.Name = "TVLabel";
            this.TVLabel.Size = new System.Drawing.Size(315, 39);
            this.TVLabel.TabIndex = 46;
            this.TVLabel.Text = "Termination Voucher";
            // 
            // dateBox
            // 
            this.dateBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBox.Location = new System.Drawing.Point(185, 234);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(205, 23);
            this.dateBox.TabIndex = 45;
            // 
            // CylTypebox
            // 
            this.CylTypebox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CylTypebox.FormattingEnabled = true;
            this.CylTypebox.Items.AddRange(new object[] {
            "Domestic",
            "Commercial"});
            this.CylTypebox.Location = new System.Drawing.Point(594, 234);
            this.CylTypebox.Name = "CylTypebox";
            this.CylTypebox.Size = new System.Drawing.Size(205, 23);
            this.CylTypebox.TabIndex = 44;
            this.CylTypebox.SelectedIndexChanged += new System.EventHandler(this.CylTypebox_SelectedIndexChanged);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(515, 420);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(155, 43);
            this.ExitBtn.TabIndex = 43;
            this.ExitBtn.Text = "BACK";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.Location = new System.Drawing.Point(193, 420);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(155, 43);
            this.Savebtn.TabIndex = 42;
            this.Savebtn.Text = "ISSUE";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // amtBox
            // 
            this.amtBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtBox.Location = new System.Drawing.Point(594, 300);
            this.amtBox.Name = "amtBox";
            this.amtBox.Size = new System.Drawing.Size(205, 23);
            this.amtBox.TabIndex = 41;
            this.amtBox.TextChanged += new System.EventHandler(this.amtBox_TextChanged);
            // 
            // DnoBox
            // 
            this.DnoBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DnoBox.Location = new System.Drawing.Point(594, 105);
            this.DnoBox.Name = "DnoBox";
            this.DnoBox.Size = new System.Drawing.Size(205, 23);
            this.DnoBox.TabIndex = 39;
            this.DnoBox.TextChanged += new System.EventHandler(this.DnoBox_TextChanged);
            // 
            // TVnoBox
            // 
            this.TVnoBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVnoBox.Location = new System.Drawing.Point(183, 109);
            this.TVnoBox.Name = "TVnoBox";
            this.TVnoBox.Size = new System.Drawing.Size(205, 23);
            this.TVnoBox.TabIndex = 38;
            // 
            // amtLabel
            // 
            this.amtLabel.AutoSize = true;
            this.amtLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtLabel.Location = new System.Drawing.Point(446, 300);
            this.amtLabel.Name = "amtLabel";
            this.amtLabel.Size = new System.Drawing.Size(119, 15);
            this.amtLabel.TabIndex = 37;
            this.amtLabel.Text = "Deposit Amount :";
            // 
            // CylTypelabel
            // 
            this.CylTypelabel.AutoSize = true;
            this.CylTypelabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CylTypelabel.Location = new System.Drawing.Point(446, 234);
            this.CylTypelabel.Name = "CylTypelabel";
            this.CylTypelabel.Size = new System.Drawing.Size(100, 15);
            this.CylTypelabel.TabIndex = 36;
            this.CylTypelabel.Text = "Cylinder Type :";
            // 
            // DNoLabel
            // 
            this.DNoLabel.AutoSize = true;
            this.DNoLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNoLabel.Location = new System.Drawing.Point(430, 111);
            this.DNoLabel.Name = "DNoLabel";
            this.DNoLabel.Size = new System.Drawing.Size(158, 15);
            this.DNoLabel.TabIndex = 35;
            this.DNoLabel.Text = "Current Distributor NO :";
            // 
            // ConNoLabel
            // 
            this.ConNoLabel.AutoSize = true;
            this.ConNoLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConNoLabel.Location = new System.Drawing.Point(42, 170);
            this.ConNoLabel.Name = "ConNoLabel";
            this.ConNoLabel.Size = new System.Drawing.Size(133, 15);
            this.ConNoLabel.TabIndex = 34;
            this.ConNoLabel.Text = "Consumer Number :";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(44, 241);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(45, 15);
            this.dateLabel.TabIndex = 33;
            this.dateLabel.Text = "Date :";
            // 
            // tvNoLb
            // 
            this.tvNoLb.AutoSize = true;
            this.tvNoLb.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tvNoLb.Location = new System.Drawing.Point(42, 111);
            this.tvNoLb.Name = "tvNoLb";
            this.tvNoLb.Size = new System.Drawing.Size(83, 15);
            this.tvNoLb.TabIndex = 32;
            this.tvNoLb.Text = "TV number :";
            // 
            // SVNoLB
            // 
            this.SVNoLB.AutoSize = true;
            this.SVNoLB.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SVNoLB.Location = new System.Drawing.Point(47, 300);
            this.SVNoLB.Name = "SVNoLB";
            this.SVNoLB.Size = new System.Drawing.Size(85, 15);
            this.SVNoLB.TabIndex = 48;
            this.SVNoLB.Text = "SV Number :";
            // 
            // NewDisNoLb
            // 
            this.NewDisNoLb.AutoSize = true;
            this.NewDisNoLb.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewDisNoLb.Location = new System.Drawing.Point(435, 172);
            this.NewDisNoLb.Name = "NewDisNoLb";
            this.NewDisNoLb.Size = new System.Drawing.Size(137, 15);
            this.NewDisNoLb.TabIndex = 49;
            this.NewDisNoLb.Text = "New Distributor No :";
            // 
            // SVBox
            // 
            this.SVBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SVBox.Location = new System.Drawing.Point(183, 300);
            this.SVBox.Name = "SVBox";
            this.SVBox.Size = new System.Drawing.Size(207, 23);
            this.SVBox.TabIndex = 50;
            // 
            // NewDnoBox
            // 
            this.NewDnoBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewDnoBox.Location = new System.Drawing.Point(594, 169);
            this.NewDnoBox.Name = "NewDnoBox";
            this.NewDnoBox.Size = new System.Drawing.Size(205, 23);
            this.NewDnoBox.TabIndex = 51;
            this.NewDnoBox.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // RemarkLb
            // 
            this.RemarkLb.AutoSize = true;
            this.RemarkLb.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemarkLb.Location = new System.Drawing.Point(278, 366);
            this.RemarkLb.Name = "RemarkLb";
            this.RemarkLb.Size = new System.Drawing.Size(70, 15);
            this.RemarkLb.TabIndex = 52;
            this.RemarkLb.Text = "Remarks :";
            // 
            // RemarksBox
            // 
            this.RemarksBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RemarksBox.Location = new System.Drawing.Point(365, 363);
            this.RemarksBox.Name = "RemarksBox";
            this.RemarksBox.Size = new System.Drawing.Size(223, 23);
            this.RemarksBox.TabIndex = 53;
            // 
            // conNoBox
            // 
            this.conNoBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conNoBox.Location = new System.Drawing.Point(183, 168);
            this.conNoBox.Name = "conNoBox";
            this.conNoBox.Size = new System.Drawing.Size(205, 23);
            this.conNoBox.TabIndex = 54;
            // 
            // TerminationVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(852, 491);
            this.Controls.Add(this.conNoBox);
            this.Controls.Add(this.RemarksBox);
            this.Controls.Add(this.RemarkLb);
            this.Controls.Add(this.NewDnoBox);
            this.Controls.Add(this.SVBox);
            this.Controls.Add(this.NewDisNoLb);
            this.Controls.Add(this.SVNoLB);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.TVLabel);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.CylTypebox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.amtBox);
            this.Controls.Add(this.DnoBox);
            this.Controls.Add(this.TVnoBox);
            this.Controls.Add(this.amtLabel);
            this.Controls.Add(this.CylTypelabel);
            this.Controls.Add(this.DNoLabel);
            this.Controls.Add(this.ConNoLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.tvNoLb);
            this.Name = "TerminationVoucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TerminationVoucher";
            this.Load += new System.EventHandler(this.TerminationVoucher_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClearBtn;
        private System.Windows.Forms.Label TVLabel;
        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.ComboBox CylTypebox;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.TextBox amtBox;
        private System.Windows.Forms.TextBox DnoBox;
        private System.Windows.Forms.TextBox TVnoBox;
        private System.Windows.Forms.Label amtLabel;
        private System.Windows.Forms.Label CylTypelabel;
        private System.Windows.Forms.Label DNoLabel;
        private System.Windows.Forms.Label ConNoLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label tvNoLb;
        private System.Windows.Forms.Label SVNoLB;
        private System.Windows.Forms.Label NewDisNoLb;
        private System.Windows.Forms.TextBox SVBox;
        private System.Windows.Forms.TextBox NewDnoBox;
        private System.Windows.Forms.Label RemarkLb;
        private System.Windows.Forms.TextBox RemarksBox;
        private System.Windows.Forms.TextBox conNoBox;
    }
}