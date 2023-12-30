namespace invoicing.Forms
{
    partial class PrintListOfItemForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrintListOfItemForm));
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            customerName = new ComboBox();
            endDateTime = new DateTimePicker();
            beginDateTime = new DateTimePicker();
            printButton = new Button();
            printPreviewDialog = new PrintPreviewDialog();
            printDocument = new System.Drawing.Printing.PrintDocument();
            SuspendLayout();
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(26, 219);
            label3.Name = "label3";
            label3.Size = new Size(117, 26);
            label3.TabIndex = 11;
            label3.Text = "結束時間：";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(27, 120);
            label2.Name = "label2";
            label2.Size = new Size(117, 26);
            label2.TabIndex = 10;
            label2.Text = "起始時間：";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(40, 26);
            label1.Name = "label1";
            label1.Size = new Size(75, 26);
            label1.TabIndex = 9;
            label1.Text = "客戶：";
            // 
            // customerName
            // 
            customerName.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            customerName.FormattingEnabled = true;
            customerName.Location = new Point(121, 23);
            customerName.Name = "customerName";
            customerName.Size = new Size(224, 34);
            customerName.TabIndex = 8;
            // 
            // endDateTime
            // 
            endDateTime.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            endDateTime.Location = new Point(145, 216);
            endDateTime.Name = "endDateTime";
            endDateTime.Size = new Size(200, 34);
            endDateTime.TabIndex = 7;
            // 
            // beginDateTime
            // 
            beginDateTime.CalendarFont = new Font("Microsoft JhengHei UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            beginDateTime.Font = new Font("Microsoft JhengHei UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            beginDateTime.Location = new Point(145, 117);
            beginDateTime.Name = "beginDateTime";
            beginDateTime.Size = new Size(200, 34);
            beginDateTime.TabIndex = 6;
            // 
            // printButton
            // 
            printButton.Location = new Point(79, 307);
            printButton.Name = "printButton";
            printButton.Size = new Size(235, 66);
            printButton.TabIndex = 12;
            printButton.Text = "列印";
            printButton.UseVisualStyleBackColor = true;
            printButton.Click += printButton_Click;
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
            // printDocument
            // 
            printDocument.PrintPage += printDocument_PrintPage;
            // 
            // PrintListOfItemForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(384, 411);
            Controls.Add(printButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(customerName);
            Controls.Add(endDateTime);
            Controls.Add(beginDateTime);
            Name = "PrintListOfItemForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "列印貨品清單";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox customerName;
        private DateTimePicker endDateTime;
        private DateTimePicker beginDateTime;
        private Button printButton;
        private PrintPreviewDialog printPreviewDialog;
        private System.Drawing.Printing.PrintDocument printDocument;
    }
}