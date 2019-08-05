namespace WindowsFormsApplication
{
    partial class StockRecord
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
            this.DomBtn = new System.Windows.Forms.Button();
            this.CommBtn = new System.Windows.Forms.Button();
            this.StockLabel = new System.Windows.Forms.Label();
            this.StockLb = new System.Windows.Forms.Label();
            this.OrderDomBtn = new System.Windows.Forms.Button();
            this.DeliveredDomBtn = new System.Windows.Forms.Button();
            this.DeliveredComBtn = new System.Windows.Forms.Button();
            this.OrderComBtn = new System.Windows.Forms.Button();
            this.PriceLb = new System.Windows.Forms.Label();
            this.DomLb = new System.Windows.Forms.Label();
            this.CommLb = new System.Windows.Forms.Label();
            this.DomBox = new System.Windows.Forms.TextBox();
            this.CommBox = new System.Windows.Forms.TextBox();
            this.PriceBtn = new System.Windows.Forms.Button();
            this.SetPriceBtn1 = new System.Windows.Forms.Button();
            this.backBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DomBtn
            // 
            this.DomBtn.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DomBtn.Location = new System.Drawing.Point(203, 30);
            this.DomBtn.Name = "DomBtn";
            this.DomBtn.Size = new System.Drawing.Size(277, 35);
            this.DomBtn.TabIndex = 0;
            this.DomBtn.Text = "Domestic Stock";
            this.DomBtn.UseVisualStyleBackColor = true;
            this.DomBtn.Click += new System.EventHandler(this.DomBtn_Click);
            // 
            // CommBtn
            // 
            this.CommBtn.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommBtn.Location = new System.Drawing.Point(486, 30);
            this.CommBtn.Name = "CommBtn";
            this.CommBtn.Size = new System.Drawing.Size(286, 35);
            this.CommBtn.TabIndex = 1;
            this.CommBtn.Text = "Commercial Stock";
            this.CommBtn.UseVisualStyleBackColor = true;
            this.CommBtn.Click += new System.EventHandler(this.CommBtn_Click);
            // 
            // StockLabel
            // 
            this.StockLabel.AutoSize = true;
            this.StockLabel.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockLabel.Location = new System.Drawing.Point(12, 30);
            this.StockLabel.Name = "StockLabel";
            this.StockLabel.Size = new System.Drawing.Size(185, 35);
            this.StockLabel.TabIndex = 2;
            this.StockLabel.Text = "Check Stock :";
            // 
            // StockLb
            // 
            this.StockLb.AutoSize = true;
            this.StockLb.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockLb.Location = new System.Drawing.Point(21, 111);
            this.StockLb.Name = "StockLb";
            this.StockLb.Size = new System.Drawing.Size(100, 35);
            this.StockLb.TabIndex = 11;
            this.StockLb.Text = "Stock :";
            this.StockLb.Click += new System.EventHandler(this.StockLb_Click);
            // 
            // OrderDomBtn
            // 
            this.OrderDomBtn.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderDomBtn.Location = new System.Drawing.Point(90, 178);
            this.OrderDomBtn.Name = "OrderDomBtn";
            this.OrderDomBtn.Size = new System.Drawing.Size(320, 35);
            this.OrderDomBtn.TabIndex = 12;
            this.OrderDomBtn.Text = "Order Domestic Stock";
            this.OrderDomBtn.UseVisualStyleBackColor = true;
            this.OrderDomBtn.Click += new System.EventHandler(this.OrderBtn_Click);
            // 
            // DeliveredDomBtn
            // 
            this.DeliveredDomBtn.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveredDomBtn.Location = new System.Drawing.Point(416, 178);
            this.DeliveredDomBtn.Name = "DeliveredDomBtn";
            this.DeliveredDomBtn.Size = new System.Drawing.Size(320, 35);
            this.DeliveredDomBtn.TabIndex = 13;
            this.DeliveredDomBtn.Text = "Domestic Stock Delivered";
            this.DeliveredDomBtn.UseVisualStyleBackColor = true;
            this.DeliveredDomBtn.Click += new System.EventHandler(this.DeliveredDomBtn_Click);
            // 
            // DeliveredComBtn
            // 
            this.DeliveredComBtn.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeliveredComBtn.Location = new System.Drawing.Point(416, 219);
            this.DeliveredComBtn.Name = "DeliveredComBtn";
            this.DeliveredComBtn.Size = new System.Drawing.Size(320, 35);
            this.DeliveredComBtn.TabIndex = 14;
            this.DeliveredComBtn.Text = "Commercial Stock Delivered";
            this.DeliveredComBtn.UseVisualStyleBackColor = true;
            this.DeliveredComBtn.Click += new System.EventHandler(this.DeliveredComBtn_Click);
            // 
            // OrderComBtn
            // 
            this.OrderComBtn.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OrderComBtn.Location = new System.Drawing.Point(90, 219);
            this.OrderComBtn.Name = "OrderComBtn";
            this.OrderComBtn.Size = new System.Drawing.Size(320, 35);
            this.OrderComBtn.TabIndex = 15;
            this.OrderComBtn.Text = "Order Commercial Stock";
            this.OrderComBtn.UseVisualStyleBackColor = true;
            this.OrderComBtn.Click += new System.EventHandler(this.OrderComBtn_Click);
            // 
            // PriceLb
            // 
            this.PriceLb.AutoSize = true;
            this.PriceLb.Font = new System.Drawing.Font("Maiandra GD", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceLb.Location = new System.Drawing.Point(21, 288);
            this.PriceLb.Name = "PriceLb";
            this.PriceLb.Size = new System.Drawing.Size(138, 35);
            this.PriceLb.TabIndex = 16;
            this.PriceLb.Text = "Set Price :";
            this.PriceLb.Click += new System.EventHandler(this.PriceLb_Click);
            // 
            // DomLb
            // 
            this.DomLb.AutoSize = true;
            this.DomLb.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DomLb.Location = new System.Drawing.Point(106, 368);
            this.DomLb.Name = "DomLb";
            this.DomLb.Size = new System.Drawing.Size(75, 15);
            this.DomLb.TabIndex = 17;
            this.DomLb.Text = "Domestic :";
            this.DomLb.Click += new System.EventHandler(this.DomLb_Click);
            // 
            // CommLb
            // 
            this.CommLb.AutoSize = true;
            this.CommLb.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommLb.Location = new System.Drawing.Point(402, 371);
            this.CommLb.Name = "CommLb";
            this.CommLb.Size = new System.Drawing.Size(88, 15);
            this.CommLb.TabIndex = 18;
            this.CommLb.Text = "Commercial :";
            // 
            // DomBox
            // 
            this.DomBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DomBox.Location = new System.Drawing.Point(187, 365);
            this.DomBox.Name = "DomBox";
            this.DomBox.Size = new System.Drawing.Size(189, 23);
            this.DomBox.TabIndex = 19;
            // 
            // CommBox
            // 
            this.CommBox.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CommBox.Location = new System.Drawing.Point(506, 365);
            this.CommBox.Name = "CommBox";
            this.CommBox.Size = new System.Drawing.Size(184, 23);
            this.CommBox.TabIndex = 20;
            // 
            // PriceBtn
            // 
            this.PriceBtn.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PriceBtn.Location = new System.Drawing.Point(187, 403);
            this.PriceBtn.Name = "PriceBtn";
            this.PriceBtn.Size = new System.Drawing.Size(189, 29);
            this.PriceBtn.TabIndex = 21;
            this.PriceBtn.Text = "SET PRICE";
            this.PriceBtn.UseVisualStyleBackColor = true;
            this.PriceBtn.Click += new System.EventHandler(this.PriceBtn_Click);
            // 
            // SetPriceBtn1
            // 
            this.SetPriceBtn1.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SetPriceBtn1.Location = new System.Drawing.Point(506, 403);
            this.SetPriceBtn1.Name = "SetPriceBtn1";
            this.SetPriceBtn1.Size = new System.Drawing.Size(184, 29);
            this.SetPriceBtn1.TabIndex = 22;
            this.SetPriceBtn1.Text = "SET PRICE";
            this.SetPriceBtn1.UseVisualStyleBackColor = true;
            this.SetPriceBtn1.Click += new System.EventHandler(this.SetPriceBtn1_Click);
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Lucida Sans", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(342, 441);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(201, 39);
            this.backBtn.TabIndex = 23;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // StockRecord
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 492);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.SetPriceBtn1);
            this.Controls.Add(this.PriceBtn);
            this.Controls.Add(this.CommBox);
            this.Controls.Add(this.DomBox);
            this.Controls.Add(this.CommLb);
            this.Controls.Add(this.DomLb);
            this.Controls.Add(this.PriceLb);
            this.Controls.Add(this.OrderComBtn);
            this.Controls.Add(this.DeliveredComBtn);
            this.Controls.Add(this.DeliveredDomBtn);
            this.Controls.Add(this.OrderDomBtn);
            this.Controls.Add(this.StockLb);
            this.Controls.Add(this.StockLabel);
            this.Controls.Add(this.CommBtn);
            this.Controls.Add(this.DomBtn);
            this.Name = "StockRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockRecord";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button DomBtn;
        private System.Windows.Forms.Button CommBtn;
        private System.Windows.Forms.Label StockLabel;
        private System.Windows.Forms.Label StockLb;
        private System.Windows.Forms.Button OrderDomBtn;
        private System.Windows.Forms.Button DeliveredDomBtn;
        private System.Windows.Forms.Button DeliveredComBtn;
        private System.Windows.Forms.Button OrderComBtn;
        private System.Windows.Forms.Label PriceLb;
        private System.Windows.Forms.Label DomLb;
        private System.Windows.Forms.Label CommLb;
        private System.Windows.Forms.TextBox DomBox;
        private System.Windows.Forms.TextBox CommBox;
        private System.Windows.Forms.Button PriceBtn;
        private System.Windows.Forms.Button SetPriceBtn1;
        private System.Windows.Forms.Button backBtn;
    }
}