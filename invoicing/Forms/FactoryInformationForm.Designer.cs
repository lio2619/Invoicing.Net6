namespace invoicing.Forms
{
    partial class FactoryInformationForm
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
            factoryInformationData = new DataGridView();
            factoryBindingSource = new BindingSource(components);
            addButton = new Button();
            modifyButton = new Button();
            deleteButton = new Button();
            factoryNameText = new TextBox();
            label1 = new Label();
            choose = new DataGridViewCheckBoxColumn();
            factoryNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactPhoneNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            faxNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            deliveryAddressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            invoicePaymentDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            factorAbbreviationDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            uniformNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            responsiblePersonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            contactPersonDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            registeredAddressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            billingAddressDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            remarkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)factoryInformationData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)factoryBindingSource).BeginInit();
            SuspendLayout();
            // 
            // factoryInformationData
            // 
            factoryInformationData.AllowUserToAddRows = false;
            factoryInformationData.AllowUserToDeleteRows = false;
            factoryInformationData.AutoGenerateColumns = false;
            factoryInformationData.BackgroundColor = SystemColors.ButtonFace;
            factoryInformationData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            factoryInformationData.Columns.AddRange(new DataGridViewColumn[] { choose, factoryNameDataGridViewTextBoxColumn, contactPhoneNumberDataGridViewTextBoxColumn, faxNumberDataGridViewTextBoxColumn, deliveryAddressDataGridViewTextBoxColumn, invoicePaymentDataGridViewTextBoxColumn, factorAbbreviationDataGridViewTextBoxColumn, uniformNumberDataGridViewTextBoxColumn, responsiblePersonDataGridViewTextBoxColumn, contactPersonDataGridViewTextBoxColumn, registeredAddressDataGridViewTextBoxColumn, billingAddressDataGridViewTextBoxColumn, remarkDataGridViewTextBoxColumn });
            factoryInformationData.DataSource = factoryBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            factoryInformationData.DefaultCellStyle = dataGridViewCellStyle1;
            factoryInformationData.Location = new Point(37, 101);
            factoryInformationData.Name = "factoryInformationData";
            factoryInformationData.RowTemplate.Height = 25;
            factoryInformationData.Size = new Size(911, 431);
            factoryInformationData.TabIndex = 17;
            factoryInformationData.CellClick += factoryInformationData_CellClick;
            // 
            // factoryBindingSource
            // 
            factoryBindingSource.DataSource = typeof(Models.Factory);
            // 
            // addButton
            // 
            addButton.Location = new Point(508, 28);
            addButton.Name = "addButton";
            addButton.Size = new Size(118, 38);
            addButton.TabIndex = 16;
            addButton.Text = "新增";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // modifyButton
            // 
            modifyButton.Location = new Point(658, 28);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(118, 38);
            modifyButton.TabIndex = 15;
            modifyButton.Text = "修改";
            modifyButton.UseVisualStyleBackColor = true;
            modifyButton.Click += modifyButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(808, 28);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(118, 38);
            deleteButton.TabIndex = 14;
            deleteButton.Text = "刪除";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // factoryNameText
            // 
            factoryNameText.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            factoryNameText.Location = new Point(248, 28);
            factoryNameText.Name = "factoryNameText";
            factoryNameText.Size = new Size(214, 38);
            factoryNameText.TabIndex = 13;
            factoryNameText.TextChanged += factoryNameText_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(37, 31);
            label1.Name = "label1";
            label1.Size = new Size(205, 30);
            label1.TabIndex = 12;
            label1.Text = "請輸入廠商名稱：";
            // 
            // choose
            // 
            choose.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            choose.HeaderText = "選擇";
            choose.Name = "choose";
            choose.Width = 37;
            // 
            // factoryNameDataGridViewTextBoxColumn
            // 
            factoryNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            factoryNameDataGridViewTextBoxColumn.DataPropertyName = "FactoryName";
            factoryNameDataGridViewTextBoxColumn.HeaderText = "廠商全名";
            factoryNameDataGridViewTextBoxColumn.Name = "factoryNameDataGridViewTextBoxColumn";
            factoryNameDataGridViewTextBoxColumn.Width = 80;
            // 
            // contactPhoneNumberDataGridViewTextBoxColumn
            // 
            contactPhoneNumberDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            contactPhoneNumberDataGridViewTextBoxColumn.DataPropertyName = "ContactPhoneNumber";
            contactPhoneNumberDataGridViewTextBoxColumn.HeaderText = "聯絡電話";
            contactPhoneNumberDataGridViewTextBoxColumn.Name = "contactPhoneNumberDataGridViewTextBoxColumn";
            contactPhoneNumberDataGridViewTextBoxColumn.Width = 80;
            // 
            // faxNumberDataGridViewTextBoxColumn
            // 
            faxNumberDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            faxNumberDataGridViewTextBoxColumn.DataPropertyName = "FaxNumber";
            faxNumberDataGridViewTextBoxColumn.HeaderText = "傳真號碼";
            faxNumberDataGridViewTextBoxColumn.Name = "faxNumberDataGridViewTextBoxColumn";
            faxNumberDataGridViewTextBoxColumn.Width = 80;
            // 
            // deliveryAddressDataGridViewTextBoxColumn
            // 
            deliveryAddressDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            deliveryAddressDataGridViewTextBoxColumn.DataPropertyName = "DeliveryAddress";
            deliveryAddressDataGridViewTextBoxColumn.HeaderText = "送貨地址";
            deliveryAddressDataGridViewTextBoxColumn.Name = "deliveryAddressDataGridViewTextBoxColumn";
            deliveryAddressDataGridViewTextBoxColumn.Width = 80;
            // 
            // invoicePaymentDataGridViewTextBoxColumn
            // 
            invoicePaymentDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            invoicePaymentDataGridViewTextBoxColumn.DataPropertyName = "InvoicePayment";
            invoicePaymentDataGridViewTextBoxColumn.HeaderText = "發票抬頭";
            invoicePaymentDataGridViewTextBoxColumn.Name = "invoicePaymentDataGridViewTextBoxColumn";
            invoicePaymentDataGridViewTextBoxColumn.Width = 80;
            // 
            // factorAbbreviationDataGridViewTextBoxColumn
            // 
            factorAbbreviationDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            factorAbbreviationDataGridViewTextBoxColumn.DataPropertyName = "FactorAbbreviation";
            factorAbbreviationDataGridViewTextBoxColumn.HeaderText = "廠商簡稱";
            factorAbbreviationDataGridViewTextBoxColumn.Name = "factorAbbreviationDataGridViewTextBoxColumn";
            factorAbbreviationDataGridViewTextBoxColumn.Width = 80;
            // 
            // uniformNumberDataGridViewTextBoxColumn
            // 
            uniformNumberDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            uniformNumberDataGridViewTextBoxColumn.DataPropertyName = "UniformNumber";
            uniformNumberDataGridViewTextBoxColumn.HeaderText = "統一編號";
            uniformNumberDataGridViewTextBoxColumn.Name = "uniformNumberDataGridViewTextBoxColumn";
            uniformNumberDataGridViewTextBoxColumn.Width = 80;
            // 
            // responsiblePersonDataGridViewTextBoxColumn
            // 
            responsiblePersonDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            responsiblePersonDataGridViewTextBoxColumn.DataPropertyName = "ResponsiblePerson";
            responsiblePersonDataGridViewTextBoxColumn.HeaderText = "負責人";
            responsiblePersonDataGridViewTextBoxColumn.Name = "responsiblePersonDataGridViewTextBoxColumn";
            responsiblePersonDataGridViewTextBoxColumn.Width = 68;
            // 
            // contactPersonDataGridViewTextBoxColumn
            // 
            contactPersonDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            contactPersonDataGridViewTextBoxColumn.DataPropertyName = "ContactPerson";
            contactPersonDataGridViewTextBoxColumn.HeaderText = "聯絡人";
            contactPersonDataGridViewTextBoxColumn.Name = "contactPersonDataGridViewTextBoxColumn";
            contactPersonDataGridViewTextBoxColumn.Width = 68;
            // 
            // registeredAddressDataGridViewTextBoxColumn
            // 
            registeredAddressDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            registeredAddressDataGridViewTextBoxColumn.DataPropertyName = "RegisteredAddress";
            registeredAddressDataGridViewTextBoxColumn.HeaderText = "登記地址";
            registeredAddressDataGridViewTextBoxColumn.Name = "registeredAddressDataGridViewTextBoxColumn";
            registeredAddressDataGridViewTextBoxColumn.Width = 80;
            // 
            // billingAddressDataGridViewTextBoxColumn
            // 
            billingAddressDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            billingAddressDataGridViewTextBoxColumn.DataPropertyName = "BillingAddress";
            billingAddressDataGridViewTextBoxColumn.HeaderText = "帳單地址";
            billingAddressDataGridViewTextBoxColumn.Name = "billingAddressDataGridViewTextBoxColumn";
            billingAddressDataGridViewTextBoxColumn.Width = 80;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            remarkDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            remarkDataGridViewTextBoxColumn.HeaderText = "備註";
            remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            remarkDataGridViewTextBoxColumn.Width = 56;
            // 
            // FactoryInformationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(factoryInformationData);
            Controls.Add(addButton);
            Controls.Add(modifyButton);
            Controls.Add(deleteButton);
            Controls.Add(factoryNameText);
            Controls.Add(label1);
            Name = "FactoryInformationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "廠商資料";
            ((System.ComponentModel.ISupportInitialize)factoryInformationData).EndInit();
            ((System.ComponentModel.ISupportInitialize)factoryBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView factoryInformationData;
        private Button addButton;
        private Button modifyButton;
        private Button deleteButton;
        private TextBox factoryNameText;
        private Label label1;
        private BindingSource factoryBindingSource;
        private DataGridViewCheckBoxColumn choose;
        private DataGridViewTextBoxColumn factoryNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactPhoneNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn faxNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn deliveryAddressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn invoicePaymentDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn factorAbbreviationDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn uniformNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn responsiblePersonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn contactPersonDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn registeredAddressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn billingAddressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
    }
}