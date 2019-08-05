namespace WindowsFormsApplication
{
    partial class SubscriptionVoucher
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
            this.CylTypebox = new System.Windows.Forms.ComboBox();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.amtBox = new System.Windows.Forms.TextBox();
            this.conNoBox = new System.Windows.Forms.TextBox();
            this.DnoBox = new System.Windows.Forms.TextBox();
            this.svnoBox = new System.Windows.Forms.TextBox();
            this.amtLabel = new System.Windows.Forms.Label();
            this.CylTypelabel = new System.Windows.Forms.Label();
            this.DNoLabel = new System.Windows.Forms.Label();
            this.ConNoLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.svNoLabel = new System.Windows.Forms.Label();
            this.dateBox = new System.Windows.Forms.DateTimePicker();
            this.SVLabel = new System.Windows.Forms.Label();
            this.ClearBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CylTypebox
            // 
            this.CylTypebox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CylTypebox.FormattingEnabled = true;
            this.CylTypebox.Items.AddRange(new object[] {
            "Domestic",
            "Commercial"});
            this.CylTypebox.Location = new System.Drawing.Point(554, 182);
            this.CylTypebox.Name = "CylTypebox";
            this.CylTypebox.Size = new System.Drawing.Size(205, 23);
            this.CylTypebox.TabIndex = 28;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExitBtn.Location = new System.Drawing.Point(497, 365);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(155, 43);
            this.ExitBtn.TabIndex = 27;
            this.ExitBtn.Text = "BACK";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Savebtn.Location = new System.Drawing.Point(175, 365);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(155, 43);
            this.Savebtn.TabIndex = 26;
            this.Savebtn.Text = "SAVE";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // amtBox
            // 
            this.amtBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtBox.Location = new System.Drawing.Point(554, 278);
            this.amtBox.Name = "amtBox";
            this.amtBox.Size = new System.Drawing.Size(205, 23);
            this.amtBox.TabIndex = 25;
            // 
            // conNoBox
            // 
            this.conNoBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conNoBox.Location = new System.Drawing.Point(177, 278);
            this.conNoBox.Name = "conNoBox";
            this.conNoBox.Size = new System.Drawing.Size(205, 23);
            this.conNoBox.TabIndex = 24;
            // 
            // DnoBox
            // 
            this.DnoBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DnoBox.Location = new System.Drawing.Point(554, 99);
            this.DnoBox.Name = "DnoBox";
            this.DnoBox.Size = new System.Drawing.Size(205, 23);
            this.DnoBox.TabIndex = 23;
            // 
            // svnoBox
            // 
            this.svnoBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.svnoBox.Location = new System.Drawing.Point(177, 103);
            this.svnoBox.Name = "svnoBox";
            this.svnoBox.Size = new System.Drawing.Size(205, 23);
            this.svnoBox.TabIndex = 21;
            // 
            // amtLabel
            // 
            this.amtLabel.AutoSize = true;
            this.amtLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amtLabel.Location = new System.Drawing.Point(429, 281);
            this.amtLabel.Name = "amtLabel";
            this.amtLabel.Size = new System.Drawing.Size(119, 15);
            this.amtLabel.TabIndex = 20;
            this.amtLabel.Text = "Deposit Amount :";
            // 
            // CylTypelabel
            // 
            this.CylTypelabel.AutoSize = true;
            this.CylTypelabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CylTypelabel.Location = new System.Drawing.Point(429, 185);
            this.CylTypelabel.Name = "CylTypelabel";
            this.CylTypelabel.Size = new System.Drawing.Size(100, 15);
            this.CylTypelabel.TabIndex = 19;
            this.CylTypelabel.Text = "Cylinder Type :";
            // 
            // DNoLabel
            // 
            this.DNoLabel.AutoSize = true;
            this.DNoLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNoLabel.Location = new System.Drawing.Point(418, 106);
            this.DNoLabel.Name = "DNoLabel";
            this.DNoLabel.Size = new System.Drawing.Size(136, 15);
            this.DNoLabel.TabIndex = 18;
            this.DNoLabel.Text = "Distributor Number :";
            // 
            // ConNoLabel
            // 
            this.ConNoLabel.AutoSize = true;
            this.ConNoLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConNoLabel.Location = new System.Drawing.Point(38, 281);
            this.ConNoLabel.Name = "ConNoLabel";
            this.ConNoLabel.Size = new System.Drawing.Size(133, 15);
            this.ConNoLabel.TabIndex = 17;
            this.ConNoLabel.Text = "Consumer Number :";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.Location = new System.Drawing.Point(53, 190);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(45, 15);
            this.dateLabel.TabIndex = 16;
            this.dateLabel.Text = "Date :";
            // 
            // svNoLabel
            // 
            this.svNoLabel.AutoSize = true;
            this.svNoLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.svNoLabel.Location = new System.Drawing.Point(38, 106);
            this.svNoLabel.Name = "svNoLabel";
            this.svNoLabel.Size = new System.Drawing.Size(84, 15);
            this.svNoLabel.TabIndex = 15;
            this.svNoLabel.Text = "SV number :";
            this.svNoLabel.Click += new System.EventHandler(this.svNoLabel_Click);
            // 
            // dateBox
            // 
            this.dateBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateBox.Location = new System.Drawing.Point(177, 185);
            this.dateBox.Name = "dateBox";
            this.dateBox.Size = new System.Drawing.Size(200, 23);
            this.dateBox.TabIndex = 29;
            this.dateBox.ValueChanged += new System.EventHandler(this.dateBox_ValueChanged);
            // 
            // SVLabel
            // 
            this.SVLabel.AutoSize = true;
            this.SVLabel.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SVLabel.Location = new System.Drawing.Point(12, 9);
            this.SVLabel.Name = "SVLabel";
            this.SVLabel.Size = new System.Drawing.Size(279, 35);
            this.SVLabel.TabIndex = 30;
            this.SVLabel.Text = "Subscription Voucher";
            // 
            // ClearBtn
            // 
            this.ClearBtn.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ClearBtn.Location = new System.Drawing.Point(336, 365);
            this.ClearBtn.Name = "ClearBtn";
            this.ClearBtn.Size = new System.Drawing.Size(155, 43);
            this.ClearBtn.TabIndex = 31;
            this.ClearBtn.Text = "CLEAR";
            this.ClearBtn.UseVisualStyleBackColor = true;
            this.ClearBtn.Click += new System.EventHandler(this.ClearBtn_Click);
            // 
            // SubscriptionVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ClearBtn);
            this.Controls.Add(this.SVLabel);
            this.Controls.Add(this.dateBox);
            this.Controls.Add(this.CylTypebox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.amtBox);
            this.Controls.Add(this.conNoBox);
            this.Controls.Add(this.DnoBox);
            this.Controls.Add(this.svnoBox);
            this.Controls.Add(this.amtLabel);
            this.Controls.Add(this.CylTypelabel);
            this.Controls.Add(this.DNoLabel);
            this.Controls.Add(this.ConNoLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.svNoLabel);
            this.Name = "SubscriptionVoucher";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SubscriptionVoucher";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CylTypebox;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.TextBox amtBox;
        private System.Windows.Forms.TextBox conNoBox;
        private System.Windows.Forms.TextBox DnoBox;
        private System.Windows.Forms.TextBox svnoBox;
        private System.Windows.Forms.Label amtLabel;
        private System.Windows.Forms.Label CylTypelabel;
        private System.Windows.Forms.Label DNoLabel;
        private System.Windows.Forms.Label ConNoLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label svNoLabel;
        private System.Windows.Forms.DateTimePicker dateBox;
        private System.Windows.Forms.Label SVLabel;
        private System.Windows.Forms.Button ClearBtn;
    }
}