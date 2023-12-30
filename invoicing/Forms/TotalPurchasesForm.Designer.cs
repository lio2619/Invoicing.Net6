namespace invoicing.Forms
{
    partial class TotalPurchasesForm
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
            beginDateTime = new DateTimePicker();
            endDateTime = new DateTimePicker();
            factoryName = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            totalPurchaseData = new DataGridView();
            nameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPurchaseSaleBindingSource = new BindingSource(components);
            searchButton = new Button();
            label4 = new Label();
            totalMoney = new Label();
            ((System.ComponentModel.ISupportInitialize)totalPurchaseData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)totalPurchaseSaleBindingSource).BeginInit();
            SuspendLayout();
            // 
            // beginDateTime
            // 
            beginDateTime.CalendarFont = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            beginDateTime.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            beginDateTime.Location = new Point(441, 42);
            beginDateTime.Name = "beginDateTime";
            beginDateTime.Size = new Size(200, 34);
            beginDateTime.TabIndex = 0;
            // 
            // endDateTime
            // 
            endDateTime.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            endDateTime.Location = new Point(760, 42);
            endDateTime.Name = "endDateTime";
            endDateTime.Size = new Size(200, 34);
            endDateTime.TabIndex = 1;
            // 
            // factoryName
            // 
            factoryName.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            factoryName.FormattingEnabled = true;
            factoryName.Location = new Point(93, 42);
            factoryName.Name = "factoryName";
            factoryName.Size = new Size(224, 34);
            factoryName.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(12, 45);
            label1.Name = "label1";
            label1.Size = new Size(75, 26);
            label1.TabIndex = 3;
            label1.Text = "廠商：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(323, 45);
            label2.Name = "label2";
            label2.Size = new Size(117, 26);
            label2.TabIndex = 4;
            label2.Text = "起始時間：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(641, 45);
            label3.Name = "label3";
            label3.Size = new Size(117, 26);
            label3.TabIndex = 5;
            label3.Text = "結束時間：";
            // 
            // totalPurchaseData
            // 
            totalPurchaseData.AutoGenerateColumns = false;
            totalPurchaseData.BackgroundColor = SystemColors.ButtonFace;
            totalPurchaseData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            totalPurchaseData.Columns.AddRange(new DataGridViewColumn[] { nameDataGridViewTextBoxColumn, orderDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn });
            totalPurchaseData.DataSource = totalPurchaseSaleBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            totalPurchaseData.DefaultCellStyle = dataGridViewCellStyle1;
            totalPurchaseData.Location = new Point(12, 99);
            totalPurchaseData.Name = "totalPurchaseData";
            totalPurchaseData.RowTemplate.Height = 25;
            totalPurchaseData.Size = new Size(948, 382);
            totalPurchaseData.TabIndex = 6;
            // 
            // nameDataGridViewTextBoxColumn
            // 
            nameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            nameDataGridViewTextBoxColumn.HeaderText = "廠商";
            nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // orderDataGridViewTextBoxColumn
            // 
            orderDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            orderDataGridViewTextBoxColumn.DataPropertyName = "Order";
            orderDataGridViewTextBoxColumn.HeaderText = "單子";
            orderDataGridViewTextBoxColumn.Name = "orderDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "金額";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // totalPurchaseSaleBindingSource
            // 
            totalPurchaseSaleBindingSource.DataSource = typeof(InsideModels.TotalPurchaseSale);
            // 
            // searchButton
            // 
            searchButton.Location = new Point(122, 491);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(210, 58);
            searchButton.TabIndex = 7;
            searchButton.Text = "查詢";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(612, 504);
            label4.Name = "label4";
            label4.Size = new Size(96, 26);
            label4.TabIndex = 8;
            label4.Text = "總金額：";
            // 
            // totalMoney
            // 
            totalMoney.AutoSize = true;
            totalMoney.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            totalMoney.Location = new Point(716, 504);
            totalMoney.Name = "totalMoney";
            totalMoney.Size = new Size(0, 26);
            totalMoney.TabIndex = 9;
            // 
            // TotalPurchasesForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(totalMoney);
            Controls.Add(label4);
            Controls.Add(searchButton);
            Controls.Add(totalPurchaseData);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(factoryName);
            Controls.Add(endDateTime);
            Controls.Add(beginDateTime);
            Name = "TotalPurchasesForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "總進貨額";
            ((System.ComponentModel.ISupportInitialize)totalPurchaseData).EndInit();
            ((System.ComponentModel.ISupportInitialize)totalPurchaseSaleBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker beginDateTime;
        private DateTimePicker endDateTime;
        private ComboBox factoryName;
        private Label label1;
        private Label label2;
        private Label label3;
        private DataGridView totalPurchaseData;
        private Button searchButton;
        private Label label4;
        private Label totalMoney;
        private DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private BindingSource totalPurchaseSaleBindingSource;
    }
}