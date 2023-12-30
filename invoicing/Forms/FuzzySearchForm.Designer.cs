namespace invoicing.Forms
{
    partial class FuzzySearchForm
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
            productDetailData = new DataGridView();
            choose = new DataGridViewCheckBoxColumn();
            itemNumberDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            itemNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            unitDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceADataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            merchandisemasterfileBindingSource = new BindingSource(components);
            itemNumberText = new TextBox();
            label1 = new Label();
            okButton = new Button();
            search = new Button();
            ((System.ComponentModel.ISupportInitialize)productDetailData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)merchandisemasterfileBindingSource).BeginInit();
            SuspendLayout();
            // 
            // productDetailData
            // 
            productDetailData.AutoGenerateColumns = false;
            productDetailData.BackgroundColor = SystemColors.ButtonFace;
            productDetailData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            productDetailData.Columns.AddRange(new DataGridViewColumn[] { choose, itemNumberDataGridViewTextBoxColumn, itemNameDataGridViewTextBoxColumn, unitDataGridViewTextBoxColumn, priceADataGridViewTextBoxColumn });
            productDetailData.DataSource = merchandisemasterfileBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            productDetailData.DefaultCellStyle = dataGridViewCellStyle1;
            productDetailData.Location = new Point(21, 72);
            productDetailData.Name = "productDetailData";
            productDetailData.RowTemplate.Height = 25;
            productDetailData.Size = new Size(927, 426);
            productDetailData.TabIndex = 0;
            productDetailData.CellClick += productDetailData_CellClick;
            // 
            // choose
            // 
            choose.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            choose.HeaderText = "選擇";
            choose.Name = "choose";
            choose.Resizable = DataGridViewTriState.True;
            choose.SortMode = DataGridViewColumnSortMode.Automatic;
            choose.Width = 56;
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
            unitDataGridViewTextBoxColumn.DataPropertyName = "Unit";
            unitDataGridViewTextBoxColumn.HeaderText = "基本單位";
            unitDataGridViewTextBoxColumn.Name = "unitDataGridViewTextBoxColumn";
            unitDataGridViewTextBoxColumn.Width = 80;
            // 
            // priceADataGridViewTextBoxColumn
            // 
            priceADataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            priceADataGridViewTextBoxColumn.DataPropertyName = "PriceA";
            priceADataGridViewTextBoxColumn.HeaderText = "標準售價";
            priceADataGridViewTextBoxColumn.Name = "priceADataGridViewTextBoxColumn";
            priceADataGridViewTextBoxColumn.Width = 80;
            // 
            // merchandisemasterfileBindingSource
            // 
            merchandisemasterfileBindingSource.DataSource = typeof(Models.Merchandisemasterfile);
            // 
            // itemNumberText
            // 
            itemNumberText.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            itemNumberText.Location = new Point(175, 21);
            itemNumberText.Name = "itemNumberText";
            itemNumberText.Size = new Size(373, 38);
            itemNumberText.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(36, 24);
            label1.Name = "label1";
            label1.Size = new Size(133, 30);
            label1.TabIndex = 2;
            label1.Text = "貨品編號：";
            // 
            // okButton
            // 
            okButton.Location = new Point(275, 508);
            okButton.Name = "okButton";
            okButton.Size = new Size(368, 41);
            okButton.TabIndex = 3;
            okButton.Text = "確定";
            okButton.UseVisualStyleBackColor = true;
            okButton.Click += okButton_Click;
            // 
            // search
            // 
            search.Location = new Point(672, 18);
            search.Name = "search";
            search.Size = new Size(202, 41);
            search.TabIndex = 4;
            search.Text = "搜尋";
            search.UseVisualStyleBackColor = true;
            search.Click += search_Click;
            // 
            // FuzzySearchForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(search);
            Controls.Add(okButton);
            Controls.Add(label1);
            Controls.Add(itemNumberText);
            Controls.Add(productDetailData);
            Name = "FuzzySearchForm";
            RightToLeft = RightToLeft.No;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "模糊搜尋";
            ((System.ComponentModel.ISupportInitialize)productDetailData).EndInit();
            ((System.ComponentModel.ISupportInitialize)merchandisemasterfileBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView productDetailData;
        private TextBox itemNumberText;
        private Label label1;
        private Button okButton;
        private BindingSource merchandisemasterfileBindingSource;
        private Button search;
        private DataGridViewCheckBoxColumn choose;
        private DataGridViewTextBoxColumn itemNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn itemNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn unitDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceADataGridViewTextBoxColumn;
    }
}