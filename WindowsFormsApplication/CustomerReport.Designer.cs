namespace WindowsFormsApplication
{
    partial class CustomerReport
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
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.logDataDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.consumerLogBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.gas_BookingDataSet = new WindowsFormsApplication.Gas_BookingDataSet();
            this.consumer_LogTableAdapter = new WindowsFormsApplication.Gas_BookingDataSetTableAdapters.Consumer_LogTableAdapter();
            this.backbtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumerLogBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gas_BookingDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Maiandra GD", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(280, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Report";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.logDataDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.consumerLogBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(12, 149);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(776, 90);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "Id";
            this.idDataGridViewTextBoxColumn.HeaderText = "Id";
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // logDataDataGridViewTextBoxColumn
            // 
            this.logDataDataGridViewTextBoxColumn.DataPropertyName = "Log_Data";
            this.logDataDataGridViewTextBoxColumn.HeaderText = "Log_Data";
            this.logDataDataGridViewTextBoxColumn.Name = "logDataDataGridViewTextBoxColumn";
            // 
            // consumerLogBindingSource
            // 
            this.consumerLogBindingSource.DataMember = "Consumer_Log";
            this.consumerLogBindingSource.DataSource = this.gas_BookingDataSet;
            // 
            // gas_BookingDataSet
            // 
            this.gas_BookingDataSet.DataSetName = "Gas_BookingDataSet";
            this.gas_BookingDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consumer_LogTableAdapter
            // 
            this.consumer_LogTableAdapter.ClearBeforeFill = true;
            // 
            // backbtn
            // 
            this.backbtn.Location = new System.Drawing.Point(336, 363);
            this.backbtn.Name = "backbtn";
            this.backbtn.Size = new System.Drawing.Size(149, 38);
            this.backbtn.TabIndex = 2;
            this.backbtn.Text = "BACK";
            this.backbtn.UseVisualStyleBackColor = true;
            this.backbtn.Click += new System.EventHandler(this.backbtn_Click);
            // 
            // CustomerReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.backbtn);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.Name = "CustomerReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CustomerReport";
            this.Load += new System.EventHandler(this.CustomerReport_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumerLogBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gas_BookingDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private Gas_BookingDataSet gas_BookingDataSet;
        private System.Windows.Forms.BindingSource consumerLogBindingSource;
        private Gas_BookingDataSetTableAdapters.Consumer_LogTableAdapter consumer_LogTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn logDataDataGridViewTextBoxColumn;
        private System.Windows.Forms.Button backbtn;
    }
}