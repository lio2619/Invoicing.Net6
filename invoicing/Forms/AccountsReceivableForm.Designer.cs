namespace invoicing.Forms
{
    partial class AccountsReceivableForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccountsReceivableForm));
            totalManey = new Label();
            label4 = new Label();
            printButton = new Button();
            totalPurchaseData = new DataGridView();
            orderNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            customerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            orderTotalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            allsheetstoragecustomerBindingSource = new BindingSource(components);
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            customerName = new ComboBox();
            endDateTime = new DateTimePicker();
            beginDateTime = new DateTimePicker();
            label5 = new Label();
            taxesTextBox = new TextBox();
            printPreviewDialog1 = new PrintPreviewDialog();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)totalPurchaseData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)allsheetstoragecustomerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // totalManey
            // 
            totalManey.AutoSize = true;
            totalManey.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            totalManey.Location = new Point(152, 504);
            totalManey.Name = "totalManey";
            totalManey.Size = new Size(0, 26);
            totalManey.TabIndex = 29;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(46, 504);
            label4.Name = "label4";
            label4.Size = new Size(117, 26);
            label4.TabIndex = 28;
            label4.Text = "本期合計：";
            // 
            // printButton
            // 
            printButton.Location = new Point(750, 491);
            printButton.Name = "printButton";
            printButton.Size = new Size(210, 58);
            printButton.TabIndex = 27;
            printButton.Text = "列印";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click;
            // 
            // totalPurchaseData
            // 
            totalPurchaseData.AutoGenerateColumns = false;
            totalPurchaseData.BackgroundColor = SystemColors.ButtonFace;
            totalPurchaseData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            totalPurchaseData.Columns.AddRange(new DataGridViewColumn[] { orderNumberDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, customerDataGridViewTextBoxColumn, orderDataGridViewTextBoxColumn, orderTotalPriceDataGridViewTextBoxColumn });
            totalPurchaseData.DataSource = allsheetstoragecustomerBindingSource;
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
            totalPurchaseData.TabIndex = 26;
            // 
            // orderNumberDataGridViewTextBoxColumn
            // 
            orderNumberDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            orderNumberDataGridViewTextBoxColumn.DataPropertyName = "OrderNumber";
            orderNumberDataGridViewTextBoxColumn.HeaderText = "單子編號";
            orderNumberDataGridViewTextBoxColumn.Name = "orderNumberDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "日期";
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // customerDataGridViewTextBoxColumn
            // 
            customerDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            customerDataGridViewTextBoxColumn.DataPropertyName = "Customer";
            customerDataGridViewTextBoxColumn.HeaderText = "客戶";
            customerDataGridViewTextBoxColumn.Name = "customerDataGridViewTextBoxColumn";
            // 
            // orderDataGridViewTextBoxColumn
            // 
            orderDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            orderDataGridViewTextBoxColumn.DataPropertyName = "Order";
            orderDataGridViewTextBoxColumn.HeaderText = "單子";
            orderDataGridViewTextBoxColumn.Name = "orderDataGridViewTextBoxColumn";
            // 
            // orderTotalPriceDataGridViewTextBoxColumn
            // 
            orderTotalPriceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            orderTotalPriceDataGridViewTextBoxColumn.DataPropertyName = "OrderTotalPrice";
            orderTotalPriceDataGridViewTextBoxColumn.HeaderText = "總金額";
            orderTotalPriceDataGridViewTextBoxColumn.Name = "orderTotalPriceDataGridViewTextBoxColumn";
            // 
            // allsheetstoragecustomerBindingSource
            // 
            allsheetstoragecustomerBindingSource.DataSource = typeof(Models.Allsheetstoragecustomer);
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(333, 45);
            label3.Name = "label3";
            label3.Size = new Size(117, 26);
            label3.TabIndex = 25;
            label3.Text = "結束時間：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(15, 45);
            label2.Name = "label2";
            label2.Size = new Size(117, 26);
            label2.TabIndex = 24;
            label2.Text = "起始時間：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(655, 45);
            label1.Name = "label1";
            label1.Size = new Size(75, 26);
            label1.TabIndex = 23;
            label1.Text = "客戶：";
            // 
            // customerName
            // 
            customerName.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            customerName.FormattingEnabled = true;
            customerName.Location = new Point(736, 42);
            customerName.Name = "customerName";
            customerName.Size = new Size(224, 34);
            customerName.TabIndex = 22;
            customerName.TextChanged += customerName_TextChanged;
            // 
            // endDateTime
            // 
            endDateTime.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            endDateTime.Location = new Point(452, 42);
            endDateTime.Name = "endDateTime";
            endDateTime.Size = new Size(200, 34);
            endDateTime.TabIndex = 21;
            endDateTime.ValueChanged += endDateTime_ValueChanged;
            // 
            // beginDateTime
            // 
            beginDateTime.CalendarFont = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            beginDateTime.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            beginDateTime.Location = new Point(133, 42);
            beginDateTime.Name = "beginDateTime";
            beginDateTime.Size = new Size(200, 34);
            beginDateTime.TabIndex = 20;
            beginDateTime.ValueChanged += beginDateTime_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(323, 504);
            label5.Name = "label5";
            label5.Size = new Size(96, 26);
            label5.TabIndex = 30;
            label5.Text = "營業稅：";
            // 
            // taxesTextBox
            // 
            taxesTextBox.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            taxesTextBox.Location = new Point(412, 504);
            taxesTextBox.Name = "taxesTextBox";
            taxesTextBox.Size = new Size(194, 34);
            taxesTextBox.TabIndex = 31;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // AccountsReceivableForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(taxesTextBox);
            Controls.Add(label5);
            Controls.Add(totalManey);
            Controls.Add(label4);
            Controls.Add(printButton);
            Controls.Add(totalPurchaseData);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(customerName);
            Controls.Add(endDateTime);
            Controls.Add(beginDateTime);
            Name = "AccountsReceivableForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "應收帳款";
            ((System.ComponentModel.ISupportInitialize)totalPurchaseData).EndInit();
            ((System.ComponentModel.ISupportInitialize)allsheetstoragecustomerBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label totalManey;
        private Label label4;
        private Button printButton;
        private DataGridView totalPurchaseData;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox customerName;
        private DateTimePicker endDateTime;
        private DateTimePicker beginDateTime;
        private Label label5;
        private TextBox taxesTextBox;
        private BindingSource allsheetstoragecustomerBindingSource;
        private PrintPreviewDialog printPreviewDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private DataGridViewTextBoxColumn orderNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn customerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn orderTotalPriceDataGridViewTextBoxColumn;
    }
}