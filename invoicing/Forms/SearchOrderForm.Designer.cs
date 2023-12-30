namespace invoicing.Forms
{
    partial class SearchOrderForm
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
            startDateTime = new DateTimePicker();
            endDateTime = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            loadOrderData = new DataGridView();
            allsheetstoragecustomerBindingSource = new BindingSource(components);
            searchButton = new Button();
            okButton = new Button();
            choose = new DataGridViewCheckBoxColumn();
            orderNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderTotalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            remarkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)loadOrderData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allsheetstoragecustomerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // startDateTime
            // 
            startDateTime.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            startDateTime.Location = new Point(150, 29);
            startDateTime.Name = "startDateTime";
            startDateTime.Size = new Size(212, 34);
            startDateTime.TabIndex = 0;
            // 
            // endDateTime
            // 
            endDateTime.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            endDateTime.Location = new Point(707, 29);
            endDateTime.Name = "endDateTime";
            endDateTime.Size = new Size(212, 34);
            endDateTime.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(27, 35);
            label1.Name = "label1";
            label1.Size = new Size(117, 26);
            label1.TabIndex = 2;
            label1.Text = "起始時間：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(570, 35);
            label2.Name = "label2";
            label2.Size = new Size(117, 26);
            label2.TabIndex = 3;
            label2.Text = "最終時間：";
            // 
            // loadOrderData
            // 
            loadOrderData.AutoGenerateColumns = false;
            loadOrderData.BackgroundColor = SystemColors.ButtonFace;
            loadOrderData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            loadOrderData.Columns.AddRange(new DataGridViewColumn[] { choose, orderNumberDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, customerDataGridViewTextBoxColumn, orderTotalPriceDataGridViewTextBoxColumn, remarkDataGridViewTextBoxColumn });
            loadOrderData.DataSource = allsheetstoragecustomerBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            loadOrderData.DefaultCellStyle = dataGridViewCellStyle1;
            loadOrderData.Location = new Point(26, 84);
            loadOrderData.Name = "loadOrderData";
            loadOrderData.RowTemplate.Height = 25;
            loadOrderData.Size = new Size(909, 399);
            loadOrderData.TabIndex = 4;
            loadOrderData.CellClick += loadOrderData_CellClick;
            // 
            // allsheetstoragecustomerBindingSource
            // 
            allsheetstoragecustomerBindingSource.DataSource = typeof(Models.Allsheetstoragecustomer);
            // 
            // searchButton
            // 
            searchButton.Location = new Point(64, 494);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(169, 55);
            searchButton.TabIndex = 5;
            searchButton.Text = "查詢";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // okButton
            // 
            okButton.Location = new Point(707, 494);
            okButton.Name = "okButton";
            okButton.Size = new Size(169, 55);
            okButton.TabIndex = 6;
            okButton.Text = "確定";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // choose
            // 
            choose.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            choose.HeaderText = "選擇";
            choose.Name = "choose";
            choose.Width = 37;
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            orderNumberDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
            orderNumberDataGridViewTextBoxColumn.HeaderText = "單子編號";
            orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            orderNumberDataGridViewTextBoxColumn.Width = 80;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "日期";
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            dateDataGridViewTextBoxColumn.Width = 56;
            // 
            // customerDataGridViewTextBoxColumn
            // 
            customerDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            customerDataGridViewTextBoxColumn.HeaderText = "客戶名稱";
            customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            customerDataGridViewTextBoxColumn.Width = 80;
            // 
            // orderTotalPriceDataGridViewTextBoxColumn
            // 
            orderTotalPriceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            orderTotalPriceDataGridViewTextBoxColumn.DataPropertyName = "OrderTotalPrice";
            orderTotalPriceDataGridViewTextBoxColumn.HeaderText = "總計";
            orderTotalPriceDataGridViewTextBoxColumn.Name = "orderTotalPriceDataGridViewTextBoxColumn";
            orderTotalPriceDataGridViewTextBoxColumn.Width = 56;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            remarkDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            remarkDataGridViewTextBoxColumn.HeaderText = "備註";
            remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            remarkDataGridViewTextBoxColumn.Width = 56;
            // 
            // SearchOrderForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(okButton);
            Controls.Add(searchButton);
            Controls.Add(loadOrderData);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(endDateTime);
            Controls.Add(startDateTime);
            Name = "SearchOrderForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "查詢單子";
            ((System.ComponentModel.ISupportInitialize)loadOrderData).EndInit();
            ((System.ComponentModel.ISupportInitialize)allsheetstoragecustomerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker startDateTime;
        private DateTimePicker endDateTime;
        private Label label1;
        private Label label2;
        private DataGridView loadOrderData;
        private BindingSource allsheetstoragecustomerBindingSource;
        private Button searchButton;
        private Button okButton;
        private DataGridViewCheckBoxColumn choose;
        private DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderTotalPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
    }
}