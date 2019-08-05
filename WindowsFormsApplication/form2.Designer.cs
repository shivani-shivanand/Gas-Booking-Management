namespace WindowsFormsApplication
{
    partial class form2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(form2));
            System.Windows.Forms.Label lPG_idLabel;
            System.Windows.Forms.Label consumer_noLabel;
            System.Windows.Forms.Label consumer_NameLabel;
            System.Windows.Forms.Label consumer_addressLabel;
            System.Windows.Forms.Label phoneLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label dis_noLabel;
            System.Windows.Forms.Label no_of_cylindersLabel;
            System.Windows.Forms.Label date_of_connectionLabel;
            this.customerDataSet = new WindowsFormsApplication.CustomerDataSet();
            this.consumerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.consumerTableAdapter = new WindowsFormsApplication.CustomerDataSetTableAdapters.ConsumerTableAdapter();
            this.tableAdapterManager = new WindowsFormsApplication.CustomerDataSetTableAdapters.TableAdapterManager();
            this.consumerBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.lPG_idTextBox = new System.Windows.Forms.TextBox();
            this.consumer_noTextBox = new System.Windows.Forms.TextBox();
            this.consumer_NameTextBox = new System.Windows.Forms.TextBox();
            this.consumer_addressTextBox = new System.Windows.Forms.TextBox();
            this.phoneTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.dis_noTextBox = new System.Windows.Forms.TextBox();
            this.no_of_cylindersTextBox = new System.Windows.Forms.TextBox();
            this.date_of_connectionDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            lPG_idLabel = new System.Windows.Forms.Label();
            consumer_noLabel = new System.Windows.Forms.Label();
            consumer_NameLabel = new System.Windows.Forms.Label();
            consumer_addressLabel = new System.Windows.Forms.Label();
            phoneLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            dis_noLabel = new System.Windows.Forms.Label();
            no_of_cylindersLabel = new System.Windows.Forms.Label();
            date_of_connectionLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumerBindingNavigator)).BeginInit();
            this.consumerBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // customerDataSet
            // 
            this.customerDataSet.DataSetName = "CustomerDataSet";
            this.customerDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // consumerBindingSource
            // 
            this.consumerBindingSource.DataMember = "Consumer";
            this.consumerBindingSource.DataSource = this.customerDataSet;
            // 
            // consumerTableAdapter
            // 
            this.consumerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ConsumerTableAdapter = this.consumerTableAdapter;
            this.tableAdapterManager.UpdateOrder = WindowsFormsApplication.CustomerDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // consumerBindingNavigator
            // 
            this.consumerBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.consumerBindingNavigator.BindingSource = this.consumerBindingSource;
            this.consumerBindingNavigator.CountItem = null;
            this.consumerBindingNavigator.DeleteItem = null;
            this.consumerBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorAddNewItem});
            this.consumerBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.consumerBindingNavigator.MoveFirstItem = null;
            this.consumerBindingNavigator.MoveLastItem = null;
            this.consumerBindingNavigator.MoveNextItem = null;
            this.consumerBindingNavigator.MovePreviousItem = null;
            this.consumerBindingNavigator.Name = "consumerBindingNavigator";
            this.consumerBindingNavigator.PositionItem = null;
            this.consumerBindingNavigator.Size = new System.Drawing.Size(677, 25);
            this.consumerBindingNavigator.TabIndex = 0;
            this.consumerBindingNavigator.Text = "bindingNavigator1";
            this.consumerBindingNavigator.RefreshItems += new System.EventHandler(this.consumerBindingNavigator_RefreshItems);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
            // 
            // lPG_idLabel
            // 
            lPG_idLabel.AutoSize = true;
            lPG_idLabel.Location = new System.Drawing.Point(189, 105);
            lPG_idLabel.Name = "lPG_idLabel";
            lPG_idLabel.Size = new System.Drawing.Size(42, 13);
            lPG_idLabel.TabIndex = 1;
            lPG_idLabel.Text = "LPG id:";
            // 
            // lPG_idTextBox
            // 
            this.lPG_idTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consumerBindingSource, "LPG_id", true));
            this.lPG_idTextBox.Location = new System.Drawing.Point(296, 102);
            this.lPG_idTextBox.Name = "lPG_idTextBox";
            this.lPG_idTextBox.Size = new System.Drawing.Size(200, 20);
            this.lPG_idTextBox.TabIndex = 2;
            // 
            // consumer_noLabel
            // 
            consumer_noLabel.AutoSize = true;
            consumer_noLabel.Location = new System.Drawing.Point(189, 131);
            consumer_noLabel.Name = "consumer_noLabel";
            consumer_noLabel.Size = new System.Drawing.Size(72, 13);
            consumer_noLabel.TabIndex = 3;
            consumer_noLabel.Text = "Consumer no:";
            // 
            // consumer_noTextBox
            // 
            this.consumer_noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consumerBindingSource, "Consumer_no", true));
            this.consumer_noTextBox.Location = new System.Drawing.Point(296, 128);
            this.consumer_noTextBox.Name = "consumer_noTextBox";
            this.consumer_noTextBox.Size = new System.Drawing.Size(200, 20);
            this.consumer_noTextBox.TabIndex = 4;
            // 
            // consumer_NameLabel
            // 
            consumer_NameLabel.AutoSize = true;
            consumer_NameLabel.Location = new System.Drawing.Point(189, 157);
            consumer_NameLabel.Name = "consumer_NameLabel";
            consumer_NameLabel.Size = new System.Drawing.Size(88, 13);
            consumer_NameLabel.TabIndex = 5;
            consumer_NameLabel.Text = "Consumer Name:";
            // 
            // consumer_NameTextBox
            // 
            this.consumer_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consumerBindingSource, "Consumer_Name", true));
            this.consumer_NameTextBox.Location = new System.Drawing.Point(296, 154);
            this.consumer_NameTextBox.Name = "consumer_NameTextBox";
            this.consumer_NameTextBox.Size = new System.Drawing.Size(200, 20);
            this.consumer_NameTextBox.TabIndex = 6;
            // 
            // consumer_addressLabel
            // 
            consumer_addressLabel.AutoSize = true;
            consumer_addressLabel.Location = new System.Drawing.Point(189, 183);
            consumer_addressLabel.Name = "consumer_addressLabel";
            consumer_addressLabel.Size = new System.Drawing.Size(97, 13);
            consumer_addressLabel.TabIndex = 7;
            consumer_addressLabel.Text = "Consumer address:";
            // 
            // consumer_addressTextBox
            // 
            this.consumer_addressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consumerBindingSource, "Consumer_address", true));
            this.consumer_addressTextBox.Location = new System.Drawing.Point(296, 180);
            this.consumer_addressTextBox.Name = "consumer_addressTextBox";
            this.consumer_addressTextBox.Size = new System.Drawing.Size(200, 20);
            this.consumer_addressTextBox.TabIndex = 8;
            // 
            // phoneLabel
            // 
            phoneLabel.AutoSize = true;
            phoneLabel.Location = new System.Drawing.Point(189, 209);
            phoneLabel.Name = "phoneLabel";
            phoneLabel.Size = new System.Drawing.Size(41, 13);
            phoneLabel.TabIndex = 9;
            phoneLabel.Text = "Phone:";
            // 
            // phoneTextBox
            // 
            this.phoneTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consumerBindingSource, "Phone", true));
            this.phoneTextBox.Location = new System.Drawing.Point(296, 206);
            this.phoneTextBox.Name = "phoneTextBox";
            this.phoneTextBox.Size = new System.Drawing.Size(200, 20);
            this.phoneTextBox.TabIndex = 10;
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(189, 235);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(34, 13);
            emailLabel.TabIndex = 11;
            emailLabel.Text = "email:";
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consumerBindingSource, "email", true));
            this.emailTextBox.Location = new System.Drawing.Point(296, 232);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(200, 20);
            this.emailTextBox.TabIndex = 12;
            // 
            // dis_noLabel
            // 
            dis_noLabel.AutoSize = true;
            dis_noLabel.Location = new System.Drawing.Point(189, 261);
            dis_noLabel.Name = "dis_noLabel";
            dis_noLabel.Size = new System.Drawing.Size(40, 13);
            dis_noLabel.TabIndex = 13;
            dis_noLabel.Text = "Dis no:";
            // 
            // dis_noTextBox
            // 
            this.dis_noTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consumerBindingSource, "Dis_no", true));
            this.dis_noTextBox.Location = new System.Drawing.Point(296, 258);
            this.dis_noTextBox.Name = "dis_noTextBox";
            this.dis_noTextBox.Size = new System.Drawing.Size(200, 20);
            this.dis_noTextBox.TabIndex = 14;
            // 
            // no_of_cylindersLabel
            // 
            no_of_cylindersLabel.AutoSize = true;
            no_of_cylindersLabel.Location = new System.Drawing.Point(189, 287);
            no_of_cylindersLabel.Name = "no_of_cylindersLabel";
            no_of_cylindersLabel.Size = new System.Drawing.Size(80, 13);
            no_of_cylindersLabel.TabIndex = 15;
            no_of_cylindersLabel.Text = "No of cylinders:";
            // 
            // no_of_cylindersTextBox
            // 
            this.no_of_cylindersTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.consumerBindingSource, "No_of_cylinders", true));
            this.no_of_cylindersTextBox.Location = new System.Drawing.Point(296, 284);
            this.no_of_cylindersTextBox.Name = "no_of_cylindersTextBox";
            this.no_of_cylindersTextBox.Size = new System.Drawing.Size(200, 20);
            this.no_of_cylindersTextBox.TabIndex = 16;
            // 
            // date_of_connectionLabel
            // 
            date_of_connectionLabel.AutoSize = true;
            date_of_connectionLabel.Location = new System.Drawing.Point(189, 314);
            date_of_connectionLabel.Name = "date_of_connectionLabel";
            date_of_connectionLabel.Size = new System.Drawing.Size(101, 13);
            date_of_connectionLabel.TabIndex = 17;
            date_of_connectionLabel.Text = "Date of connection:";
            // 
            // date_of_connectionDateTimePicker
            // 
            this.date_of_connectionDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.consumerBindingSource, "Date_of_connection", true));
            this.date_of_connectionDateTimePicker.Location = new System.Drawing.Point(296, 310);
            this.date_of_connectionDateTimePicker.Name = "date_of_connectionDateTimePicker";
            this.date_of_connectionDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.date_of_connectionDateTimePicker.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(160, 25);
            this.label1.TabIndex = 19;
            this.label1.Text = "Add Customer";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(569, 365);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 20;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(677, 412);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(lPG_idLabel);
            this.Controls.Add(this.lPG_idTextBox);
            this.Controls.Add(consumer_noLabel);
            this.Controls.Add(this.consumer_noTextBox);
            this.Controls.Add(consumer_NameLabel);
            this.Controls.Add(this.consumer_NameTextBox);
            this.Controls.Add(consumer_addressLabel);
            this.Controls.Add(this.consumer_addressTextBox);
            this.Controls.Add(phoneLabel);
            this.Controls.Add(this.phoneTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(dis_noLabel);
            this.Controls.Add(this.dis_noTextBox);
            this.Controls.Add(no_of_cylindersLabel);
            this.Controls.Add(this.no_of_cylindersTextBox);
            this.Controls.Add(date_of_connectionLabel);
            this.Controls.Add(this.date_of_connectionDateTimePicker);
            this.Controls.Add(this.consumerBindingNavigator);
            this.Name = "form2";
            this.Text = "form2";
            this.Load += new System.EventHandler(this.form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.customerDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.consumerBindingNavigator)).EndInit();
            this.consumerBindingNavigator.ResumeLayout(false);
            this.consumerBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CustomerDataSet customerDataSet;
        private System.Windows.Forms.BindingSource consumerBindingSource;
        private CustomerDataSetTableAdapters.ConsumerTableAdapter consumerTableAdapter;
        private CustomerDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator consumerBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.TextBox lPG_idTextBox;
        private System.Windows.Forms.TextBox consumer_noTextBox;
        private System.Windows.Forms.TextBox consumer_NameTextBox;
        private System.Windows.Forms.TextBox consumer_addressTextBox;
        private System.Windows.Forms.TextBox phoneTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox dis_noTextBox;
        private System.Windows.Forms.TextBox no_of_cylindersTextBox;
        private System.Windows.Forms.DateTimePicker date_of_connectionDateTimePicker;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}