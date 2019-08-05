namespace WindowsFormsApplication
{
    partial class StockReport
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
            this.StockLb = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.cylindertypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stockRegistryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gas_BookingDataSet1 = new WindowsFormsApplication.Gas_BookingDataSet1();
            this.stock_RegistryTableAdapter = new WindowsFormsApplication.Gas_BookingDataSet1TableAdapters.Stock_RegistryTableAdapter();
            this.backBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockRegistryBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gas_BookingDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // StockLb
            // 
            this.StockLb.AutoSize = true;
            this.StockLb.Font = new System.Drawing.Font("Maiandra GD", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StockLb.Location = new System.Drawing.Point(26, 27);
            this.StockLb.Name = "StockLb";
            this.StockLb.Size = new System.Drawing.Size(226, 42);
            this.StockLb.TabIndex = 0;
            this.StockLb.Text = "Stock Report";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.cylindertypeDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.stockRegistryBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 84);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // cylindertypeDataGridViewTextBoxColumn
            // 
            this.cylindertypeDataGridViewTextBoxColumn.DataPropertyName = "Cylinder_type";
            this.cylindertypeDataGridViewTextBoxColumn.HeaderText = "Cylinder_type";
            this.cylindertypeDataGridViewTextBoxColumn.Name = "cylindertypeDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // stockRegistryBindingSource
            // 
            this.stockRegistryBindingSource.DataMember = "Stock_Registry";
            this.stockRegistryBindingSource.DataSource = this.gas_BookingDataSet1;
            // 
            // gas_BookingDataSet1
            // 
            this.gas_BookingDataSet1.DataSetName = "Gas_BookingDataSet1";
            this.gas_BookingDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // stock_RegistryTableAdapter
            // 
            this.stock_RegistryTableAdapter.ClearBeforeFill = true;
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(293, 325);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(177, 44);
            this.backBtn.TabIndex = 2;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // StockReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backBtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.StockLb);
            this.Name = "StockReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StockReport";
            this.Load += new System.EventHandler(this.StockReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.stockRegistryBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gas_BookingDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label StockLb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Gas_BookingDataSet1 gas_BookingDataSet1;
        private System.Windows.Forms.BindingSource stockRegistryBindingSource;
        private Gas_BookingDataSet1TableAdapters.Stock_RegistryTableAdapter stock_RegistryTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn cylindertypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button backBtn;
    }
}