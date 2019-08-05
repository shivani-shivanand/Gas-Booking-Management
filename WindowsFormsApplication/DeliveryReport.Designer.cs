namespace WindowsFormsApplication
{
    partial class DeliveryReport
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
            this.backBtn = new System.Windows.Forms.Button();
            this.delLb = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bookingnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consnoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.duedateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gasBookingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gas_BookingDataSet2 = new WindowsFormsApplication.Gas_BookingDataSet2();
            this.gas_BookingTableAdapter = new WindowsFormsApplication.Gas_BookingDataSet2TableAdapters.Gas_BookingTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasBookingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gas_BookingDataSet2)).BeginInit();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Location = new System.Drawing.Point(296, 344);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(181, 53);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "BACK";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // delLb
            // 
            this.delLb.AutoSize = true;
            this.delLb.Font = new System.Drawing.Font("Maiandra GD", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delLb.Location = new System.Drawing.Point(12, 23);
            this.delLb.Name = "delLb";
            this.delLb.Size = new System.Drawing.Size(276, 42);
            this.delLb.TabIndex = 1;
            this.delLb.Text = "Delivery Report";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingnoDataGridViewTextBoxColumn,
            this.consnoDataGridViewTextBoxColumn,
            this.bookingdateDataGridViewTextBoxColumn,
            this.duedateDataGridViewTextBoxColumn,
            this.statusDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.gasBookingBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 126);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 150);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // bookingnoDataGridViewTextBoxColumn
            // 
            this.bookingnoDataGridViewTextBoxColumn.DataPropertyName = "Booking_no";
            this.bookingnoDataGridViewTextBoxColumn.HeaderText = "Booking_no";
            this.bookingnoDataGridViewTextBoxColumn.Name = "bookingnoDataGridViewTextBoxColumn";
            // 
            // consnoDataGridViewTextBoxColumn
            // 
            this.consnoDataGridViewTextBoxColumn.DataPropertyName = "Cons_no";
            this.consnoDataGridViewTextBoxColumn.HeaderText = "Cons_no";
            this.consnoDataGridViewTextBoxColumn.Name = "consnoDataGridViewTextBoxColumn";
            // 
            // bookingdateDataGridViewTextBoxColumn
            // 
            this.bookingdateDataGridViewTextBoxColumn.DataPropertyName = "Booking_date";
            this.bookingdateDataGridViewTextBoxColumn.HeaderText = "Booking_date";
            this.bookingdateDataGridViewTextBoxColumn.Name = "bookingdateDataGridViewTextBoxColumn";
            // 
            // duedateDataGridViewTextBoxColumn
            // 
            this.duedateDataGridViewTextBoxColumn.DataPropertyName = "Due_date";
            this.duedateDataGridViewTextBoxColumn.HeaderText = "Due_date";
            this.duedateDataGridViewTextBoxColumn.Name = "duedateDataGridViewTextBoxColumn";
            // 
            // statusDataGridViewTextBoxColumn
            // 
            this.statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            this.statusDataGridViewTextBoxColumn.HeaderText = "Status";
            this.statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            // 
            // gasBookingBindingSource
            // 
            this.gasBookingBindingSource.DataMember = "Gas_Booking";
            this.gasBookingBindingSource.DataSource = this.gas_BookingDataSet2;
            // 
            // gas_BookingDataSet2
            // 
            this.gas_BookingDataSet2.DataSetName = "Gas_BookingDataSet2";
            this.gas_BookingDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // gas_BookingTableAdapter
            // 
            this.gas_BookingTableAdapter.ClearBeforeFill = true;
            // 
            // DeliveryReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delLb);
            this.Controls.Add(this.backBtn);
            this.Name = "DeliveryReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeliveryReport";
            this.Load += new System.EventHandler(this.DeliveryReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gasBookingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gas_BookingDataSet2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Label delLb;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Gas_BookingDataSet2 gas_BookingDataSet2;
        private System.Windows.Forms.BindingSource gasBookingBindingSource;
        private Gas_BookingDataSet2TableAdapters.Gas_BookingTableAdapter gas_BookingTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn consnoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookingdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn duedateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
    }
}