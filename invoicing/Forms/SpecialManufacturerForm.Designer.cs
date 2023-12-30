namespace invoicing.Forms
{
    partial class SpecialManufacturerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SpecialManufacturerForm));
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            refreshOrderButton = new Button();
            printButton = new Button();
            saveOrderButton = new Button();
            searchOrderButton = new Button();
            createExcelButton = new Button();
            remarkTextBox = new TextBox();
            label4 = new Label();
            orderNumber = new Label();
            label3 = new Label();
            customerName = new ComboBox();
            dateTime = new DateTimePicker();
            storeTypeLabel = new Label();
            label1 = new Label();
            totalMoney = new Label();
            label6 = new Label();
            printDocument = new System.Drawing.Printing.PrintDocument();
            printPreviewDialog = new PrintPreviewDialog();
            allsheetstorageBindingSource = new BindingSource(components);
            productDetailData = new DataGridView();
            itemNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itemNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            totalPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            remarkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)allsheetstorageBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productDetailData).BeginInit();
            SuspendLayout();
            // 
            // refreshOrderButton
            // 
            refreshOrderButton.Location = new Point(857, 418);
            refreshOrderButton.Name = "refreshOrderButton";
            refreshOrderButton.Size = new Size(115, 44);
            refreshOrderButton.TabIndex = 43;
            refreshOrderButton.Text = "刷新";
            refreshOrderButton.UseVisualStyleBackColor = true;
            refreshOrderButton.Click += refreshOrderButton_Click;
            // 
            // printButton
            // 
            printButton.Location = new Point(857, 326);
            printButton.Name = "printButton";
            printButton.Size = new Size(115, 44);
            printButton.TabIndex = 42;
            printButton.Text = "預覽列印";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click;
            // 
            // saveOrderButton
            // 
            saveOrderButton.Location = new Point(857, 234);
            saveOrderButton.Name = "saveOrderButton";
            saveOrderButton.Size = new Size(115, 44);
            saveOrderButton.TabIndex = 41;
            saveOrderButton.Text = "儲存";
            saveOrderButton.UseVisualStyleBackColor = true;
            saveOrderButton.Click += saveOrderButton_Click;
            // 
            // searchOrderButton
            // 
            searchOrderButton.Location = new Point(857, 142);
            searchOrderButton.Name = "searchOrderButton";
            searchOrderButton.Size = new Size(115, 44);
            searchOrderButton.TabIndex = 40;
            searchOrderButton.Text = "查詢";
            searchOrderButton.UseVisualStyleBackColor = true;
            searchOrderButton.Click += searchOrderButton_Click;
            // 
            // createExcelButton
            // 
            createExcelButton.Location = new Point(857, 510);
            createExcelButton.Name = "createExcelButton";
            createExcelButton.Size = new Size(115, 44);
            createExcelButton.TabIndex = 39;
            createExcelButton.Text = "創建excel";
            createExcelButton.UseVisualStyleBackColor = true;
            createExcelButton.Click += createExcelButton_Click;
            // 
            // remarkTextBox
            // 
            remarkTextBox.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            remarkTextBox.Location = new Point(88, 566);
            remarkTextBox.Name = "remarkTextBox";
            remarkTextBox.Size = new Size(441, 34);
            remarkTextBox.TabIndex = 38;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(17, 565);
            label4.Name = "label4";
            label4.Size = new Size(75, 26);
            label4.TabIndex = 37;
            label4.Text = "備註：";
            // 
            // orderNumber
            // 
            orderNumber.AutoSize = true;
            orderNumber.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            orderNumber.Location = new Point(635, 92);
            orderNumber.Name = "orderNumber";
            orderNumber.Size = new Size(0, 26);
            orderNumber.TabIndex = 35;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(513, 92);
            label3.Name = "label3";
            label3.Size = new Size(117, 26);
            label3.TabIndex = 34;
            label3.Text = "單子編號：";
            // 
            // customerName
            // 
            customerName.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            customerName.FormattingEnabled = true;
            customerName.Location = new Point(97, 89);
            customerName.Name = "customerName";
            customerName.Size = new Size(346, 34);
            customerName.TabIndex = 33;
            // 
            // dateTime
            // 
            dateTime.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            dateTime.Location = new Point(98, 35);
            dateTime.Name = "dateTime";
            dateTime.Size = new Size(345, 34);
            dateTime.TabIndex = 32;
            // 
            // storeTypeLabel
            // 
            storeTypeLabel.AutoSize = true;
            storeTypeLabel.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            storeTypeLabel.Location = new Point(16, 92);
            storeTypeLabel.Name = "storeTypeLabel";
            storeTypeLabel.Size = new Size(75, 26);
            storeTypeLabel.TabIndex = 31;
            storeTypeLabel.Text = "客戶：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(17, 35);
            label1.Name = "label1";
            label1.Size = new Size(75, 26);
            label1.TabIndex = 30;
            label1.Text = "日期：";
            // 
            // totalMoney
            // 
            totalMoney.AutoSize = true;
            totalMoney.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            totalMoney.Location = new Point(757, 569);
            totalMoney.Name = "totalMoney";
            totalMoney.Size = new Size(0, 26);
            totalMoney.TabIndex = 45;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(635, 569);
            label6.Name = "label6";
            label6.Size = new Size(75, 26);
            label6.TabIndex = 44;
            label6.Text = "總計：";
            // 
            // printDocument
            // 
            printDocument.PrintPage += printDocument_PrintPage;
            // 
            // printPreviewDialog
            // 
            printPreviewDialog.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog.ClientSize = new Size(400, 300);
            printPreviewDialog.Enabled = true;
            printPreviewDialog.Icon = (Icon)resources.GetObject("printPreviewDialog.Icon");
            printPreviewDialog.Name = "printPreviewDialog";
            printPreviewDialog.Visible = false;
            // 
            // allsheetstorageBindingSource
            // 
            allsheetstorageBindingSource.DataSource = typeof(Models.Allsheetstorage);
            // 
            // productDetailData
            // 
            productDetailData.AutoGenerateColumns = false;
            productDetailData.BackgroundColor = SystemColors.ButtonFace;
            productDetailData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDetailData.Columns.AddRange(new DataGridViewColumn[] { itemNumberDataGridViewTextBoxColumn, itemNameDataGridViewTextBoxColumn, unitDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, totalPriceDataGridViewTextBoxColumn, remarkDataGridViewTextBoxColumn });
            productDetailData.DataSource = allsheetstorageBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            productDetailData.DefaultCellStyle = dataGridViewCellStyle1;
            productDetailData.EditMode = DataGridViewEditMode.EditOnEnter;
            productDetailData.Location = new Point(17, 142);
            productDetailData.Name = "productDetailData";
            productDetailData.RowTemplate.Height = 25;
            productDetailData.Size = new Size(821, 413);
            productDetailData.TabIndex = 46;
            productDetailData.RowPostPaint += productDetailData_RowPostPaint;
            // 
            // itemNumberDataGridViewTextBoxColumn
            // 
            itemNumberDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            itemNumberDataGridViewTextBoxColumn.DataPropertyName = "ItemNumber";
            itemNumberDataGridViewTextBoxColumn.HeaderText = "貨品編號";
            itemNumberDataGridViewTextBoxColumn.Name = "itemNumberDataGridViewTextBoxColumn";
            itemNumberDataGridViewTextBoxColumn.Width = 80;
            // 
            // itemNameDataGridViewTextBoxColumn
            // 
            itemNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            itemNameDataGridViewTextBoxColumn.HeaderText = "品名";
            itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            itemNameDataGridViewTextBoxColumn.Width = 56;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            unitDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            unitDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            unitDataGridViewTextBoxColumn.HeaderText = "數量";
            unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            unitDataGridViewTextBoxColumn.Width = 56;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            quantityDataGridViewTextBoxColumn.HeaderText = "基本單位";
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.Width = 80;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "單價";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            priceDataGridViewTextBoxColumn.Width = 56;
            // 
            // totalPriceDataGridViewTextBoxColumn
            // 
            totalPriceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            totalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice";
            totalPriceDataGridViewTextBoxColumn.HeaderText = "金額";
            totalPriceDataGridViewTextBoxColumn.Name = "totalPriceDataGridViewTextBoxColumn";
            totalPriceDataGridViewTextBoxColumn.Width = 56;
            // 
            // remarkDataGridViewTextBoxColumn
            // 
            remarkDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            remarkDataGridViewTextBoxColumn.DataPropertyName = "Remark";
            remarkDataGridViewTextBoxColumn.HeaderText = "備註";
            remarkDataGridViewTextBoxColumn.Name = "remarkDataGridViewTextBoxColumn";
            remarkDataGridViewTextBoxColumn.Width = 56;
            // 
            // SpecialManufacturerForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 611);
            Controls.Add(productDetailData);
            Controls.Add(totalMoney);
            Controls.Add(label6);
            Controls.Add(refreshOrderButton);
            Controls.Add(printButton);
            Controls.Add(saveOrderButton);
            Controls.Add(searchOrderButton);
            Controls.Add(createExcelButton);
            Controls.Add(remarkTextBox);
            Controls.Add(label4);
            Controls.Add(orderNumber);
            Controls.Add(label3);
            Controls.Add(customerName);
            Controls.Add(dateTime);
            Controls.Add(storeTypeLabel);
            Controls.Add(label1);
            Name = "SpecialManufacturerForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "唐詣";
            ((System.ComponentModel.ISupportInitialize)allsheetstorageBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productDetailData).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button refreshOrderButton;
        private Button printButton;
        private Button saveOrderButton;
        private Button searchOrderButton;
        private Button createExcelButton;
        private TextBox remarkTextBox;
        private Label label4;
        private Label orderNumber;
        private Label label3;
        private ComboBox customerName;
        private DateTimePicker dateTime;
        private Label storeTypeLabel;
        private Label label1;
        private Label totalMoney;
        private Label label6;
        private System.Drawing.Printing.PrintDocument printDocument;
        private PrintPreviewDialog printPreviewDialog;
        private BindingSource allsheetstorageBindingSource;
        private DataGridView productDetailData;
        private DataGridViewTextBoxColumn itemNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn totalPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn remarkDataGridViewTextBoxColumn;
    }
}