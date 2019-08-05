namespace WindowsFormsApplication
{
    partial class EditCustomer
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
            this.conNo = new System.Windows.Forms.Label();
            this.conNoTxtBox = new System.Windows.Forms.TextBox();
            this.Deletebtn = new System.Windows.Forms.Button();
            this.Searchbtn = new System.Windows.Forms.Button();
            this.IDlabel = new System.Windows.Forms.Label();
            this.DateConLabel = new System.Windows.Forms.Label();
            this.Namelabel = new System.Windows.Forms.Label();
            this.Addrlabel = new System.Windows.Forms.Label();
            this.Phonelabel = new System.Windows.Forms.Label();
            this.emaillabel = new System.Windows.Forms.Label();
            this.Dnolabel = new System.Windows.Forms.Label();
            this.CylNolabel = new System.Windows.Forms.Label();
            this.IDBox = new System.Windows.Forms.TextBox();
            this.DateConBox = new System.Windows.Forms.TextBox();
            this.PhoneBox = new System.Windows.Forms.TextBox();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.NameBox = new System.Windows.Forms.TextBox();
            this.AddrBox = new System.Windows.Forms.TextBox();
            this.DnoBox = new System.Windows.Forms.TextBox();
            this.CylNoBox = new System.Windows.Forms.TextBox();
            this.Clear = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.TVBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // conNo
            // 
            this.conNo.AutoSize = true;
            this.conNo.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conNo.Location = new System.Drawing.Point(261, 46);
            this.conNo.Name = "conNo";
            this.conNo.Size = new System.Drawing.Size(133, 15);
            this.conNo.TabIndex = 0;
            this.conNo.Text = "Consumer Number :";
            // 
            // conNoTxtBox
            // 
            this.conNoTxtBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.conNoTxtBox.Location = new System.Drawing.Point(400, 43);
            this.conNoTxtBox.Name = "conNoTxtBox";
            this.conNoTxtBox.Size = new System.Drawing.Size(225, 23);
            this.conNoTxtBox.TabIndex = 1;
            // 
            // Deletebtn
            // 
            this.Deletebtn.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebtn.Location = new System.Drawing.Point(352, 95);
            this.Deletebtn.Name = "Deletebtn";
            this.Deletebtn.Size = new System.Drawing.Size(87, 33);
            this.Deletebtn.TabIndex = 2;
            this.Deletebtn.Text = "DELETE";
            this.Deletebtn.UseVisualStyleBackColor = true;
            this.Deletebtn.Click += new System.EventHandler(this.Deletebtn_Click);
            // 
            // Searchbtn
            // 
            this.Searchbtn.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Searchbtn.Location = new System.Drawing.Point(445, 94);
            this.Searchbtn.Name = "Searchbtn";
            this.Searchbtn.Size = new System.Drawing.Size(87, 33);
            this.Searchbtn.TabIndex = 3;
            this.Searchbtn.Text = "SEARCH";
            this.Searchbtn.UseVisualStyleBackColor = true;
            this.Searchbtn.Click += new System.EventHandler(this.Searchbtn_Click);
            // 
            // IDlabel
            // 
            this.IDlabel.AutoSize = true;
            this.IDlabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDlabel.Location = new System.Drawing.Point(73, 224);
            this.IDlabel.Name = "IDlabel";
            this.IDlabel.Size = new System.Drawing.Size(47, 15);
            this.IDlabel.TabIndex = 4;
            this.IDlabel.Text = "LPG ID";
            this.IDlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // DateConLabel
            // 
            this.DateConLabel.AutoSize = true;
            this.DateConLabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateConLabel.Location = new System.Drawing.Point(456, 412);
            this.DateConLabel.Name = "DateConLabel";
            this.DateConLabel.Size = new System.Drawing.Size(133, 15);
            this.DateConLabel.TabIndex = 5;
            this.DateConLabel.Text = "Date Of Connection";
            // 
            // Namelabel
            // 
            this.Namelabel.AutoSize = true;
            this.Namelabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Namelabel.Location = new System.Drawing.Point(73, 287);
            this.Namelabel.Name = "Namelabel";
            this.Namelabel.Size = new System.Drawing.Size(42, 15);
            this.Namelabel.TabIndex = 6;
            this.Namelabel.Text = "Name";
            this.Namelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Addrlabel
            // 
            this.Addrlabel.AutoSize = true;
            this.Addrlabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addrlabel.Location = new System.Drawing.Point(73, 347);
            this.Addrlabel.Name = "Addrlabel";
            this.Addrlabel.Size = new System.Drawing.Size(59, 15);
            this.Addrlabel.TabIndex = 7;
            this.Addrlabel.Text = "Address";
            this.Addrlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Phonelabel
            // 
            this.Phonelabel.AutoSize = true;
            this.Phonelabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Phonelabel.Location = new System.Drawing.Point(73, 409);
            this.Phonelabel.Name = "Phonelabel";
            this.Phonelabel.Size = new System.Drawing.Size(47, 15);
            this.Phonelabel.TabIndex = 8;
            this.Phonelabel.Text = "Phone";
            this.Phonelabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillabel.Location = new System.Drawing.Point(452, 222);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(42, 15);
            this.emaillabel.TabIndex = 9;
            this.emaillabel.Text = "E-Mail";
            // 
            // Dnolabel
            // 
            this.Dnolabel.AutoSize = true;
            this.Dnolabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dnolabel.Location = new System.Drawing.Point(452, 282);
            this.Dnolabel.Name = "Dnolabel";
            this.Dnolabel.Size = new System.Drawing.Size(128, 15);
            this.Dnolabel.TabIndex = 10;
            this.Dnolabel.Text = "Distributor Number";
            // 
            // CylNolabel
            // 
            this.CylNolabel.AutoSize = true;
            this.CylNolabel.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CylNolabel.Location = new System.Drawing.Point(452, 347);
            this.CylNolabel.Name = "CylNolabel";
            this.CylNolabel.Size = new System.Drawing.Size(136, 15);
            this.CylNolabel.TabIndex = 11;
            this.CylNolabel.Text = "Number Of Cylinders";
            // 
            // IDBox
            // 
            this.IDBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IDBox.Location = new System.Drawing.Point(166, 221);
            this.IDBox.Name = "IDBox";
            this.IDBox.Size = new System.Drawing.Size(205, 23);
            this.IDBox.TabIndex = 12;
            // 
            // DateConBox
            // 
            this.DateConBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DateConBox.Location = new System.Drawing.Point(597, 409);
            this.DateConBox.Name = "DateConBox";
            this.DateConBox.Size = new System.Drawing.Size(205, 23);
            this.DateConBox.TabIndex = 13;
            // 
            // PhoneBox
            // 
            this.PhoneBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneBox.Location = new System.Drawing.Point(166, 409);
            this.PhoneBox.Name = "PhoneBox";
            this.PhoneBox.Size = new System.Drawing.Size(205, 23);
            this.PhoneBox.TabIndex = 14;
            // 
            // emailBox
            // 
            this.emailBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailBox.Location = new System.Drawing.Point(597, 219);
            this.emailBox.Name = "emailBox";
            this.emailBox.Size = new System.Drawing.Size(205, 23);
            this.emailBox.TabIndex = 15;
            // 
            // NameBox
            // 
            this.NameBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameBox.Location = new System.Drawing.Point(166, 284);
            this.NameBox.Name = "NameBox";
            this.NameBox.Size = new System.Drawing.Size(205, 23);
            this.NameBox.TabIndex = 16;
            // 
            // AddrBox
            // 
            this.AddrBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AddrBox.Location = new System.Drawing.Point(166, 344);
            this.AddrBox.Name = "AddrBox";
            this.AddrBox.Size = new System.Drawing.Size(205, 23);
            this.AddrBox.TabIndex = 17;
            // 
            // DnoBox
            // 
            this.DnoBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DnoBox.Location = new System.Drawing.Point(597, 279);
            this.DnoBox.Name = "DnoBox";
            this.DnoBox.Size = new System.Drawing.Size(205, 23);
            this.DnoBox.TabIndex = 18;
            // 
            // CylNoBox
            // 
            this.CylNoBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CylNoBox.Location = new System.Drawing.Point(597, 344);
            this.CylNoBox.Name = "CylNoBox";
            this.CylNoBox.Size = new System.Drawing.Size(205, 23);
            this.CylNoBox.TabIndex = 19;
            // 
            // Clear
            // 
            this.Clear.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.Location = new System.Drawing.Point(538, 94);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(87, 33);
            this.Clear.TabIndex = 20;
            this.Clear.Text = "CLEAR";
            this.Clear.UseVisualStyleBackColor = true;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateBtn.Location = new System.Drawing.Point(255, 94);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(91, 34);
            this.UpdateBtn.TabIndex = 21;
            this.UpdateBtn.Text = "UPDATE";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // TVBtn
            // 
            this.TVBtn.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TVBtn.Location = new System.Drawing.Point(304, 133);
            this.TVBtn.Name = "TVBtn";
            this.TVBtn.Size = new System.Drawing.Size(277, 41);
            this.TVBtn.TabIndex = 22;
            this.TVBtn.Text = "Issue Termination Voucher";
            this.TVBtn.UseVisualStyleBackColor = true;
            this.TVBtn.Click += new System.EventHandler(this.TVBtn_Click);
            // 
            // EditCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 504);
            this.Controls.Add(this.TVBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.CylNoBox);
            this.Controls.Add(this.DnoBox);
            this.Controls.Add(this.AddrBox);
            this.Controls.Add(this.NameBox);
            this.Controls.Add(this.emailBox);
            this.Controls.Add(this.PhoneBox);
            this.Controls.Add(this.DateConBox);
            this.Controls.Add(this.IDBox);
            this.Controls.Add(this.CylNolabel);
            this.Controls.Add(this.Dnolabel);
            this.Controls.Add(this.emaillabel);
            this.Controls.Add(this.Phonelabel);
            this.Controls.Add(this.Addrlabel);
            this.Controls.Add(this.Namelabel);
            this.Controls.Add(this.DateConLabel);
            this.Controls.Add(this.IDlabel);
            this.Controls.Add(this.Searchbtn);
            this.Controls.Add(this.Deletebtn);
            this.Controls.Add(this.conNoTxtBox);
            this.Controls.Add(this.conNo);
            this.Name = "EditCustomer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "EditCustomer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label conNo;
        private System.Windows.Forms.TextBox conNoTxtBox;
        private System.Windows.Forms.Button Deletebtn;
        private System.Windows.Forms.Button Searchbtn;
        private System.Windows.Forms.Label IDlabel;
        private System.Windows.Forms.Label DateConLabel;
        private System.Windows.Forms.Label Namelabel;
        private System.Windows.Forms.Label Addrlabel;
        private System.Windows.Forms.Label Phonelabel;
        private System.Windows.Forms.Label emaillabel;
        private System.Windows.Forms.Label Dnolabel;
        private System.Windows.Forms.Label CylNolabel;
        private System.Windows.Forms.TextBox IDBox;
        private System.Windows.Forms.TextBox DateConBox;
        private System.Windows.Forms.TextBox PhoneBox;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.TextBox NameBox;
        private System.Windows.Forms.TextBox AddrBox;
        private System.Windows.Forms.TextBox DnoBox;
        private System.Windows.Forms.TextBox CylNoBox;
        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button TVBtn;
    }
}