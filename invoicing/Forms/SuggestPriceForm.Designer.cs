namespace invoicing.Forms
{
    partial class SuggestPriceForm
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
            suggestPriceData = new DataGridView();
            standardPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            recommendedPriceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            suggestpriceBindingSource = new BindingSource(components);
            standardPriceTextBox = new TextBox();
            standardPriceLabel = new Label();
            recommendedPriceLabel = new Label();
            recommendedPriceTextBox = new TextBox();
            addButton = new Button();
            ((System.ComponentModel.ISupportInitialize)suggestPriceData).BeginInit();
            ((System.ComponentModel.ISupportInitialize)suggestpriceBindingSource).BeginInit();
            SuspendLayout();
            // 
            // suggestPriceData
            // 
            suggestPriceData.AutoGenerateColumns = false;
            suggestPriceData.BackgroundColor = SystemColors.ButtonFace;
            suggestPriceData.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            suggestPriceData.Columns.AddRange(new DataGridViewColumn[] { standardPriceDataGridViewTextBoxColumn, recommendedPriceDataGridViewTextBoxColumn });
            suggestPriceData.DataSource = suggestpriceBindingSource;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = SystemColors.Window;
            dataGridViewCellStyle1.Font = new Font("Microsoft JhengHei UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            suggestPriceData.DefaultCellStyle = dataGridViewCellStyle1;
            suggestPriceData.Location = new Point(12, 34);
            suggestPriceData.Name = "suggestPriceData";
            suggestPriceData.RowTemplate.Height = 25;
            suggestPriceData.Size = new Size(960, 434);
            suggestPriceData.TabIndex = 7;
            // 
            // standardPriceDataGridViewTextBoxColumn
            // 
            standardPriceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            standardPriceDataGridViewTextBoxColumn.DataPropertyName = "StandardPrice";
            standardPriceDataGridViewTextBoxColumn.HeaderText = "標準售價";
            standardPriceDataGridViewTextBoxColumn.Name = "standardPriceDataGridViewTextBoxColumn";
            // 
            // recommendedPriceDataGridViewTextBoxColumn
            // 
            recommendedPriceDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            recommendedPriceDataGridViewTextBoxColumn.DataPropertyName = "RecommendedPrice";
            recommendedPriceDataGridViewTextBoxColumn.HeaderText = "建議售價";
            recommendedPriceDataGridViewTextBoxColumn.Name = "recommendedPriceDataGridViewTextBoxColumn";
            // 
            // suggestpriceBindingSource
            // 
            suggestpriceBindingSource.DataSource = typeof(Models.Suggestprice);
            // 
            // standardPriceTextBox
            // 
            standardPriceTextBox.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            standardPriceTextBox.Location = new Point(142, 487);
            standardPriceTextBox.Name = "standardPriceTextBox";
            standardPriceTextBox.Size = new Size(169, 38);
            standardPriceTextBox.TabIndex = 8;
            // 
            // standardPriceLabel
            // 
            standardPriceLabel.AutoSize = true;
            standardPriceLabel.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            standardPriceLabel.Location = new Point(19, 493);
            standardPriceLabel.Name = "standardPriceLabel";
            standardPriceLabel.Size = new Size(117, 26);
            standardPriceLabel.TabIndex = 9;
            standardPriceLabel.Text = "標準售價：";
            // 
            // recommendedPriceLabel
            // 
            recommendedPriceLabel.AutoSize = true;
            recommendedPriceLabel.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            recommendedPriceLabel.Location = new Point(399, 493);
            recommendedPriceLabel.Name = "recommendedPriceLabel";
            recommendedPriceLabel.Size = new Size(117, 26);
            recommendedPriceLabel.TabIndex = 11;
            recommendedPriceLabel.Text = "建議售價：";
            // 
            // recommendedPriceTextBox
            // 
            recommendedPriceTextBox.Font = new Font("Microsoft JhengHei UI", 18F, FontStyle.Regular, GraphicsUnit.Point);
            recommendedPriceTextBox.Location = new Point(522, 487);
            recommendedPriceTextBox.Name = "recommendedPriceTextBox";
            recommendedPriceTextBox.Size = new Size(169, 38);
            recommendedPriceTextBox.TabIndex = 10;
            // 
            // addButton
            // 
            addButton.Location = new Point(781, 487);
            addButton.Name = "addButton";
            addButton.Size = new Size(173, 38);
            addButton.TabIndex = 12;
            addButton.Text = "新增";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // SuggestPriceForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(addButton);
            Controls.Add(recommendedPriceLabel);
            Controls.Add(recommendedPriceTextBox);
            Controls.Add(standardPriceLabel);
            Controls.Add(standardPriceTextBox);
            Controls.Add(suggestPriceData);
            Name = "SuggestPriceForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "建議售價";
            ((System.ComponentModel.ISupportInitialize)suggestPriceData).EndInit();
            ((System.ComponentModel.ISupportInitialize)suggestpriceBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView suggestPriceData;
        private DataGridViewTextBoxColumn standardPriceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn recommendedPriceDataGridViewTextBoxColumn;
        private BindingSource suggestpriceBindingSource;
        private TextBox standardPriceTextBox;
        private Label standardPriceLabel;
        private Label recommendedPriceLabel;
        private TextBox recommendedPriceTextBox;
        private Button addButton;
    }
}