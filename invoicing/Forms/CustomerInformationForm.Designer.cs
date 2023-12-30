namespace invoicing.Froms
{
    partial class CustomerInformationForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            label1 = new Label();
            customerNameText = new TextBox();
            deleteButton = new Button();
            modifyButton = new Button();
            addButton = new Button();
            customerInformationData = new DataGridView();
            customerBindingSource = new BindingSource(components);
            choose = new DataGridViewCheckBoxColumn();
            customerNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactPersonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactPhoneNumberOneDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactPhoneNumberTwoDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            faxNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            deliveryAddressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            invoicePaymentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            deliveryAddressZipCodeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uniformNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            registeredAddressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)customerInformationData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(29, 38);
            label1.Name = "label1";
            label1.Size = new Size(205, 30);
            label1.TabIndex = 0;
            label1.Text = "請輸入客戶名稱：";
            // 
            // customerNameText
            // 
            customerNameText.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            customerNameText.Location = new Point(221, 35);
            customerNameText.Name = "customerNameText";
            customerNameText.Size = new Size(255, 38);
            customerNameText.TabIndex = 1;
            customerNameText.TextChanged += customerNameText_TextChanged;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(821, 35);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(118, 38);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "刪除";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // modifyButton
            // 
            modifyButton.Location = new Point(666, 35);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(118, 38);
            modifyButton.TabIndex = 3;
            modifyButton.Text = "修改";
            modifyButton.UseVisualStyleBackColor = true;
            modifyButton.Click += modifyButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(511, 35);
            addButton.Name = "addButton";
            addButton.Size = new Size(118, 38);
            addButton.TabIndex = 4;
            addButton.Text = "新增";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // customerInformationData
            // 
            customerInformationData.AllowUserToAddRows = false;
            customerInformationData.AllowUserToDeleteRows = false;
            customerInformationData.AutoGenerateColumns = false;
            customerInformationData.BackgroundColor = SystemColors.ButtonFace;
            customerInformationData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            customerInformationData.Columns.AddRange(new DataGridViewColumn[] { choose, customerNameDataGridViewTextBoxColumn, contactPersonDataGridViewTextBoxColumn, contactPhoneNumberOneDataGridViewTextBoxColumn, contactPhoneNumberTwoDataGridViewTextBoxColumn, faxNumberDataGridViewTextBoxColumn, deliveryAddressDataGridViewTextBoxColumn, invoicePaymentDataGridViewTextBoxColumn, deliveryAddressZipCodeDataGridViewTextBoxColumn, uniformNumberDataGridViewTextBoxColumn, registeredAddressDataGridViewTextBoxColumn });
            customerInformationData.DataSource = customerBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            customerInformationData.DefaultCellStyle = dataGridViewCellStyle1;
            customerInformationData.Location = new Point(29, 108);
            customerInformationData.Name = "customerInformationData";
            customerInformationData.RowTemplate.Height = 25;
            customerInformationData.Size = new Size(911, 431);
            customerInformationData.TabIndex = 5;
            customerInformationData.CellClick += customerInformationData_CellClick;
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Models.Customer);
            // 
            // choose
            // 
            choose.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            choose.HeaderText = "選擇";
            choose.Name = "choose";
            choose.Width = 33;
            // 
            // customerNameDataGridViewTextBoxColumn
            // 
            customerNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            customerNameDataGridViewTextBoxColumn.DataPropertyName = "CustomerName";
            customerNameDataGridViewTextBoxColumn.HeaderText = "客戶名稱";
            customerNameDataGridViewTextBoxColumn.Name = "customerNameDataGridViewTextBoxColumn";
            customerNameDataGridViewTextBoxColumn.Width = 63;
            // 
            // contactPersonDataGridViewTextBoxColumn
            // 
            contactPersonDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            contactPersonDataGridViewTextBoxColumn.DataPropertyName = "ContactPerson";
            contactPersonDataGridViewTextBoxColumn.HeaderText = "聯絡人";
            contactPersonDataGridViewTextBoxColumn.Name = "contactPersonDataGridViewTextBoxColumn";
            contactPersonDataGridViewTextBoxColumn.Width = 63;
            // 
            // contactPhoneNumberOneDataGridViewTextBoxColumn
            // 
            contactPhoneNumberOneDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            contactPhoneNumberOneDataGridViewTextBoxColumn.DataPropertyName = "ContactPhoneNumberOne";
            contactPhoneNumberOneDataGridViewTextBoxColumn.HeaderText = "連絡電話一";
            contactPhoneNumberOneDataGridViewTextBoxColumn.Name = "contactPhoneNumberOneDataGridViewTextBoxColumn";
            contactPhoneNumberOneDataGridViewTextBoxColumn.Width = 74;
            // 
            // contactPhoneNumberTwoDataGridViewTextBoxColumn
            // 
            contactPhoneNumberTwoDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            contactPhoneNumberTwoDataGridViewTextBoxColumn.DataPropertyName = "ContactPhoneNumberTwo";
            contactPhoneNumberTwoDataGridViewTextBoxColumn.HeaderText = "連絡電話二";
            contactPhoneNumberTwoDataGridViewTextBoxColumn.Name = "contactPhoneNumberTwoDataGridViewTextBoxColumn";
            contactPhoneNumberTwoDataGridViewTextBoxColumn.Width = 74;
            // 
            // faxNumberDataGridViewTextBoxColumn
            // 
            faxNumberDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            faxNumberDataGridViewTextBoxColumn.DataPropertyName = "FaxNumber";
            faxNumberDataGridViewTextBoxColumn.HeaderText = "傳真號碼";
            faxNumberDataGridViewTextBoxColumn.Name = "faxNumberDataGridViewTextBoxColumn";
            faxNumberDataGridViewTextBoxColumn.Width = 63;
            // 
            // deliveryAddressDataGridViewTextBoxColumn
            // 
            deliveryAddressDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            deliveryAddressDataGridViewTextBoxColumn.DataPropertyName = "DeliveryAddress";
            deliveryAddressDataGridViewTextBoxColumn.HeaderText = "送貨地址";
            deliveryAddressDataGridViewTextBoxColumn.Name = "deliveryAddressDataGridViewTextBoxColumn";
            deliveryAddressDataGridViewTextBoxColumn.Width = 63;
            // 
            // invoicePaymentDataGridViewTextBoxColumn
            // 
            invoicePaymentDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            invoicePaymentDataGridViewTextBoxColumn.DataPropertyName = "InvoicePayment";
            invoicePaymentDataGridViewTextBoxColumn.HeaderText = "發票抬頭";
            invoicePaymentDataGridViewTextBoxColumn.Name = "invoicePaymentDataGridViewTextBoxColumn";
            invoicePaymentDataGridViewTextBoxColumn.Width = 63;
            // 
            // deliveryAddressZipCodeDataGridViewTextBoxColumn
            // 
            deliveryAddressZipCodeDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            deliveryAddressZipCodeDataGridViewTextBoxColumn.DataPropertyName = "DeliveryAddressZipCode";
            deliveryAddressZipCodeDataGridViewTextBoxColumn.HeaderText = "送貨地址郵遞區號";
            deliveryAddressZipCodeDataGridViewTextBoxColumn.Name = "deliveryAddressZipCodeDataGridViewTextBoxColumn";
            deliveryAddressZipCodeDataGridViewTextBoxColumn.Width = 85;
            // 
            // uniformNumberDataGridViewTextBoxColumn
            // 
            uniformNumberDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            uniformNumberDataGridViewTextBoxColumn.DataPropertyName = "UniformNumber";
            uniformNumberDataGridViewTextBoxColumn.HeaderText = "統一編號";
            uniformNumberDataGridViewTextBoxColumn.Name = "uniformNumberDataGridViewTextBoxColumn";
            uniformNumberDataGridViewTextBoxColumn.Width = 63;
            // 
            // registeredAddressDataGridViewTextBoxColumn
            // 
            registeredAddressDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            registeredAddressDataGridViewTextBoxColumn.DataPropertyName = "RegisteredAddress";
            registeredAddressDataGridViewTextBoxColumn.HeaderText = "登記地址";
            registeredAddressDataGridViewTextBoxColumn.Name = "registeredAddressDataGridViewTextBoxColumn";
            registeredAddressDataGridViewTextBoxColumn.Width = 63;
            // 
            // CustomerInformationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(customerInformationData);
            Controls.Add(addButton);
            Controls.Add(modifyButton);
            Controls.Add(deleteButton);
            Controls.Add(customerNameText);
            Controls.Add(label1);
            Name = "CustomerInformationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "客戶資料";
            ((System.ComponentModel.ISupportInitialize)customerInformationData).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox customerNameText;
        private Button deleteButton;
        private Button modifyButton;
        private Button addButton;
        private DataGridView customerInformationData;
        private BindingSource customerBindingSource;
        private DataGridViewCheckBoxColumn choose;
        private DataGridViewTextBoxColumn customerNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactPersonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactPhoneNumberOneDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactPhoneNumberTwoDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn faxNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn deliveryAddressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn invoicePaymentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn deliveryAddressZipCodeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uniformNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn registeredAddressDataGridViewTextBoxColumn;
    }
}