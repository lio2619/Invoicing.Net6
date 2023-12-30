namespace invoicing.Forms
{
    partial class ProductInformationForm
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
            productInformationData = new DataGridView();
            choose = new DataGridViewCheckBoxColumn();
            itemNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itemNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            standardPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceADataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceBDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceCDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceEDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            standardCostDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            existingCostDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            merchandisemasterfileBindingSource = new BindingSource(components);
            deleteButton = new Button();
            modifyButton = new Button();
            addButton = new Button();
            productTextBox = new TextBox();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)productInformationData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)merchandisemasterfileBindingSource).BeginInit();
            SuspendLayout();
            // 
            // productInformationData
            // 
            productInformationData.AllowUserToAddRows = false;
            productInformationData.AllowUserToDeleteRows = false;
            productInformationData.AutoGenerateColumns = false;
            productInformationData.BackgroundColor = SystemColors.ButtonFace;
            productInformationData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productInformationData.Columns.AddRange(new DataGridViewColumn[] { choose, itemNumberDataGridViewTextBoxColumn, itemNameDataGridViewTextBoxColumn, unitDataGridViewTextBoxColumn, standardPriceDataGridViewTextBoxColumn, priceADataGridViewTextBoxColumn, priceBDataGridViewTextBoxColumn, priceCDataGridViewTextBoxColumn, priceDDataGridViewTextBoxColumn, priceEDataGridViewTextBoxColumn, standardCostDataGridViewTextBoxColumn, existingCostDataGridViewTextBoxColumn });
            productInformationData.DataSource = merchandisemasterfileBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            productInformationData.DefaultCellStyle = dataGridViewCellStyle1;
            productInformationData.Location = new Point(37, 101);
            productInformationData.Name = "productInformationData";
            productInformationData.RowTemplate.Height = 25;
            productInformationData.Size = new Size(911, 431);
            productInformationData.TabIndex = 11;
            productInformationData.CellClick += productInformationData_CellClick;
            // 
            // choose
            // 
            choose.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            choose.HeaderText = "選擇";
            choose.Name = "choose";
            choose.Width = 37;
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
            itemNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            itemNameDataGridViewTextBoxColumn.DataPropertyName = "ItemName";
            itemNameDataGridViewTextBoxColumn.HeaderText = "品名";
            itemNameDataGridViewTextBoxColumn.Name = "itemNameDataGridViewTextBoxColumn";
            itemNameDataGridViewTextBoxColumn.Width = 56;
            // 
            // unitDataGridViewTextBoxColumn
            // 
            unitDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            unitDataGridViewTextBoxColumn.HeaderText = "基本單位";
            unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            unitDataGridViewTextBoxColumn.Width = 80;
            // 
            // standardPriceDataGridViewTextBoxColumn
            // 
            standardPriceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            standardPriceDataGridViewTextBoxColumn.DataPropertyName = "StandardPrice";
            standardPriceDataGridViewTextBoxColumn.HeaderText = "標準售價";
            standardPriceDataGridViewTextBoxColumn.Name = "standardPriceDataGridViewTextBoxColumn";
            standardPriceDataGridViewTextBoxColumn.Width = 80;
            // 
            // priceADataGridViewTextBoxColumn
            // 
            priceADataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            priceADataGridViewTextBoxColumn.DataPropertyName = "PriceA";
            priceADataGridViewTextBoxColumn.HeaderText = "售價A";
            priceADataGridViewTextBoxColumn.Name = "priceADataGridViewTextBoxColumn";
            priceADataGridViewTextBoxColumn.Width = 64;
            // 
            // priceBDataGridViewTextBoxColumn
            // 
            priceBDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            priceBDataGridViewTextBoxColumn.DataPropertyName = "PriceB";
            priceBDataGridViewTextBoxColumn.HeaderText = "售價B";
            priceBDataGridViewTextBoxColumn.Name = "priceBDataGridViewTextBoxColumn";
            priceBDataGridViewTextBoxColumn.Width = 63;
            // 
            // priceCDataGridViewTextBoxColumn
            // 
            priceCDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            priceCDataGridViewTextBoxColumn.DataPropertyName = "PriceC";
            priceCDataGridViewTextBoxColumn.HeaderText = "售價C";
            priceCDataGridViewTextBoxColumn.Name = "priceCDataGridViewTextBoxColumn";
            priceCDataGridViewTextBoxColumn.Width = 64;
            // 
            // priceDDataGridViewTextBoxColumn
            // 
            priceDDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            priceDDataGridViewTextBoxColumn.DataPropertyName = "PriceD";
            priceDDataGridViewTextBoxColumn.HeaderText = "售價D";
            priceDDataGridViewTextBoxColumn.Name = "priceDDataGridViewTextBoxColumn";
            priceDDataGridViewTextBoxColumn.Width = 65;
            // 
            // priceEDataGridViewTextBoxColumn
            // 
            priceEDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            priceEDataGridViewTextBoxColumn.DataPropertyName = "PriceE";
            priceEDataGridViewTextBoxColumn.HeaderText = "售價E";
            priceEDataGridViewTextBoxColumn.Name = "priceEDataGridViewTextBoxColumn";
            priceEDataGridViewTextBoxColumn.Width = 63;
            // 
            // standardCostDataGridViewTextBoxColumn
            // 
            standardCostDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            standardCostDataGridViewTextBoxColumn.DataPropertyName = "StandardCost";
            standardCostDataGridViewTextBoxColumn.HeaderText = "標準成本";
            standardCostDataGridViewTextBoxColumn.Name = "standardCostDataGridViewTextBoxColumn";
            standardCostDataGridViewTextBoxColumn.Width = 80;
            // 
            // existingCostDataGridViewTextBoxColumn
            // 
            existingCostDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
            existingCostDataGridViewTextBoxColumn.DataPropertyName = "ExistingCost";
            existingCostDataGridViewTextBoxColumn.HeaderText = "現行成本";
            existingCostDataGridViewTextBoxColumn.Name = "existingCostDataGridViewTextBoxColumn";
            existingCostDataGridViewTextBoxColumn.Width = 80;
            // 
            // merchandisemasterfileBindingSource
            // 
            merchandisemasterfileBindingSource.DataSource = typeof(Models.Merchandisemasterfile);
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(773, 28);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(118, 38);
            deleteButton.TabIndex = 10;
            deleteButton.Text = "刪除";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // modifyButton
            // 
            modifyButton.Location = new Point(628, 28);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(118, 38);
            modifyButton.TabIndex = 9;
            modifyButton.Text = "修改";
            modifyButton.UseVisualStyleBackColor = true;
            modifyButton.Click += modifyButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(483, 28);
            addButton.Name = "addButton";
            addButton.Size = new Size(118, 38);
            addButton.TabIndex = 8;
            addButton.Text = "新增";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // productTextBox
            // 
            productTextBox.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            productTextBox.Location = new Point(256, 28);
            productTextBox.Name = "productTextBox";
            productTextBox.Size = new Size(206, 38);
            productTextBox.TabIndex = 7;
            productTextBox.TextChanged += customerNameText_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(37, 31);
            label1.Name = "label1";
            label1.Size = new Size(229, 30);
            label1.TabIndex = 6;
            label1.Text = "請輸入商品或國碼：";
            // 
            // ProductInformationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(productInformationData);
            Controls.Add(deleteButton);
            Controls.Add(modifyButton);
            Controls.Add(addButton);
            Controls.Add(productTextBox);
            Controls.Add(label1);
            Name = "ProductInformationForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "商品資料";
            ((System.ComponentModel.ISupportInitialize)productInformationData).EndInit();
            ((System.ComponentModel.ISupportInitialize)merchandisemasterfileBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView productInformationData;
        private Button deleteButton;
        private Button modifyButton;
        private Button addButton;
        private TextBox productTextBox;
        private Label label1;
        private BindingSource merchandisemasterfileBindingSource;
        private DataGridViewCheckBoxColumn choose;
        private DataGridViewTextBoxColumn itemNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn standardPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceADataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceBDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceCDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceEDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn standardCostDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn existingCostDataGridViewTextBoxColumn;
    }
}