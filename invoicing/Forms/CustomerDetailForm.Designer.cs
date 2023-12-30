﻿namespace invoicing.Forms
{
    partial class CustomerDetailForm
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
            customerAddressTextBox = new TextBox();
            customerNameTextBox = new TextBox();
            label8 = new Label();
            label6 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            customerIDLabel = new Label();
            SuspendLayout();
            // 
            // clearButton
            // 
            clearButton.Location = new Point(765, 472);
            clearButton.Name = "clearButton";
            clearButton.Size = new Size(176, 59);
            clearButton.TabIndex = 46;
            clearButton.Text = "清空";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += clearButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(765, 363);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(176, 59);
            deleteButton.TabIndex = 45;
            deleteButton.Text = "刪除";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // searchButton
            // 
            searchButton.Location = new Point(765, 251);
            searchButton.Name = "searchButton";
            searchButton.Size = new Size(176, 59);
            searchButton.TabIndex = 44;
            searchButton.Text = "查詢";
            searchButton.UseVisualStyleBackColor = true;
            searchButton.Click += searchButton_Click;
            // 
            // modifyButton
            // 
            modifyButton.Location = new Point(765, 139);
            modifyButton.Name = "modifyButton";
            modifyButton.Size = new Size(176, 59);
            modifyButton.TabIndex = 43;
            modifyButton.Text = "修改";
            modifyButton.UseVisualStyleBackColor = true;
            modifyButton.Click += modifyButton_Click;
            // 
            // addButton
            // 
            addButton.Location = new Point(765, 27);
            addButton.Name = "addButton";
            addButton.Size = new Size(176, 59);
            addButton.TabIndex = 42;
            addButton.Text = "新增";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // faxNumberTextBox
            // 
            faxNumberTextBox.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            faxNumberTextBox.Location = new Point(182, 476);
            faxNumberTextBox.Name = "faxNumberTextBox";
            faxNumberTextBox.Size = new Size(472, 34);
            faxNumberTextBox.TabIndex = 40;
            // 
            // contactPhoneNumberTextBox
            // 
            contactPhoneNumberTextBox.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            contactPhoneNumberTextBox.Location = new Point(182, 363);
            contactPhoneNumberTextBox.Name = "contactPhoneNumberTextBox";
            contactPhoneNumberTextBox.Size = new Size(472, 34);
            contactPhoneNumberTextBox.TabIndex = 38;
            // 
            // customerAddressTextBox
            // 
            customerAddressTextBox.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            customerAddressTextBox.Location = new Point(182, 250);
            customerAddressTextBox.Name = "customerAddressTextBox";
            customerAddressTextBox.Size = new Size(472, 34);
            customerAddressTextBox.TabIndex = 36;
            // 
            // customerNameTextBox
            // 
            customerNameTextBox.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            customerNameTextBox.Location = new Point(182, 137);
            customerNameTextBox.Name = "customerNameTextBox";
            customerNameTextBox.Size = new Size(472, 34);
            customerNameTextBox.TabIndex = 35;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label8.Location = new Point(43, 479);
            label8.Name = "label8";
            label8.Size = new Size(117, 26);
            label8.TabIndex = 31;
            label8.Text = "傳真號碼：";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label6.Location = new Point(43, 366);
            label6.Name = "label6";
            label6.Size = new Size(117, 26);
            label6.TabIndex = 29;
            label6.Text = "聯絡電話：";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(43, 253);
            label4.Name = "label4";
            label4.Size = new Size(117, 26);
            label4.TabIndex = 27;
            label4.Text = "客戶地址：";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(43, 140);
            label3.Name = "label3";
            label3.Size = new Size(117, 26);
            label3.TabIndex = 26;
            label3.Text = "客戶名稱：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(43, 40);
            label1.Name = "label1";
            label1.Size = new Size(117, 26);
            label1.TabIndex = 47;
            label1.Text = "客戶編號：";
            // 
            // customerIDLabel
            // 
            customerIDLabel.AutoSize = true;
            customerIDLabel.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            customerIDLabel.Location = new Point(182, 40);
            customerIDLabel.Name = "customerIDLabel";
            customerIDLabel.Size = new Size(0, 26);
            customerIDLabel.TabIndex = 48;
            // 
            // CustomerDetailForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(984, 561);
            Controls.Add(customerIDLabel);
            Controls.Add(label1);
            Controls.Add(clearButton);
            Controls.Add(deleteButton);
            Controls.Add(searchButton);
            Controls.Add(modifyButton);
            Controls.Add(addButton);
            Controls.Add(faxNumberTextBox);
            Controls.Add(contactPhoneNumberTextBox);
            Controls.Add(customerAddressTextBox);
            Controls.Add(customerNameTextBox);
            Controls.Add(label8);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "CustomerDetailForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "客戶明細";
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
        private TextBox customerAddressTextBox;
        private TextBox customerNameTextBox;
        private Label label8;
        private Label label6;
        private Label label4;
        private Label label3;
        private Label label1;
        private Label customerIDLabel;
    }
}