namespace invoicing.Forms
{
    partial class FactoryDetailForm
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
            clearButton = new Button();
            deleteButton = new Button();
            searchButton = new Button();
            modifyButton = new Button();
            addButton = new Button();
            faxNumberTextBox = new TextBox();
            contactPhoneNumberTextBox = new TextBox();
            factoryAddressTextBox = new TextBox();
            factoryNameTextBox = new TextBox();
            label8 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            factoryIDLabel = new Label();
            SuspendLayout();
            // 
            // clearButton
            // 
            clearButton.Location = new Point(765, 473);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(176, 59);
            clearButton.TabIndex = 59;
            clearButton.Text = "清空";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(765, 364);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(176, 59);
            deleteButton.TabIndex = 58;
            deleteButton.Text = "刪除";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(765, 252);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(176, 59);
            searchButton.TabIndex = 57;
            searchButton.Text = "查詢";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // modifyButton
            // 
            modifyButton.Location = new Point(765, 140);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(176, 59);
            modifyButton.TabIndex = 56;
            modifyButton.Text = "修改";
            modifyButton.UseVisualStyleBackColor = true;
            modifyButton.Click += modifyButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(765, 28);
            addButton.Name = "addButton";
            addButton.Size = new Size(176, 59);
            addButton.TabIndex = 55;
            addButton.Text = "新增";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // faxNumberTextBox
            // 
            faxNumberTextBox.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            faxNumberTextBox.Location = new Point(182, 479);
            faxNumberTextBox.Name = "faxNumberTextBox";
            faxNumberTextBox.Size = new Size(472, 34);
            faxNumberTextBox.TabIndex = 54;
            // 
            // contactPhoneNumberTextBox
            // 
            contactPhoneNumberTextBox.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            contactPhoneNumberTextBox.Location = new Point(182, 359);
            contactPhoneNumberTextBox.Name = "contactPhoneNumberTextBox";
            contactPhoneNumberTextBox.Size = new Size(472, 34);
            contactPhoneNumberTextBox.TabIndex = 53;
            // 
            // factoryAddressTextBox
            // 
            factoryAddressTextBox.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            factoryAddressTextBox.Location = new Point(182, 239);
            factoryAddressTextBox.Name = "factoryAddressTextBox";
            factoryAddressTextBox.Size = new Size(472, 34);
            factoryAddressTextBox.TabIndex = 52;
            // 
            // factoryNameTextBox
            // 
            factoryNameTextBox.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            factoryNameTextBox.Location = new Point(182, 119);
            factoryNameTextBox.Name = "factoryNameTextBox";
            factoryNameTextBox.Size = new Size(472, 34);
            factoryNameTextBox.TabIndex = 51;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(43, 482);
            label8.Name = "label8";
            label8.Size = new Size(117, 26);
            label8.TabIndex = 50;
            label8.Text = "傳真號碼：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(43, 362);
            label6.Name = "label6";
            label6.Size = new Size(117, 26);
            label6.TabIndex = 49;
            label6.Text = "聯絡電話：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(43, 242);
            label4.Name = "label4";
            label4.Size = new Size(117, 26);
            label4.TabIndex = 48;
            label4.Text = "廠商地址：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(43, 122);
            label3.Name = "label3";
            label3.Size = new Size(117, 26);
            label3.TabIndex = 47;
            label3.Text = "廠商名稱：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(43, 41);
            label1.Name = "label1";
            label1.Size = new Size(117, 26);
            label1.TabIndex = 60;
            label1.Text = "廠商編號：";
            // 
            // factoryIDLabel
            // 
            factoryIDLabel.AutoSize = true;
            factoryIDLabel.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            factoryIDLabel.Location = new Point(182, 41);
            factoryIDLabel.Name = "factoryIDLabel";
            factoryIDLabel.Size = new Size(0, 26);
            factoryIDLabel.TabIndex = 61;
            // 
            // FactoryDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(factoryIDLabel);
            Controls.Add(label1);
            Controls.Add(clearButton);
            Controls.Add(deleteButton);
            Controls.Add(searchButton);
            Controls.Add(modifyButton);
            Controls.Add(addButton);
            Controls.Add(faxNumberTextBox);
            Controls.Add(contactPhoneNumberTextBox);
            Controls.Add(factoryAddressTextBox);
            Controls.Add(factoryNameTextBox);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "FactoryDetailForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "廠商明細";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button clearButton;
        private Button deleteButton;
        private Button searchButton;
        private Button modifyButton;
        private Button addButton;
        private TextBox faxNumberTextBox;
        private TextBox contactPhoneNumberTextBox;
        private TextBox factoryAddressTextBox;
        private TextBox factoryNameTextBox;
        private Label label8;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label factoryIDLabel;
    }
}