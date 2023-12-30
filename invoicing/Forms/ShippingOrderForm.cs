//出貨單
using invoicing.CommonFunction;

namespace invoicing.Forms
{
    public partial class ShippingOrderForm : Form
    {
        private readonly CommonFormFunction commonFormFunction = new CommonFormFunction();
        private readonly PrintFunction printFunction = new PrintFunction();
        private int _start = 0;
        private int _end = 40;
        private int _page = 1;
        public ShippingOrderForm()
        {
            InitializeComponent();
            var names = commonFormFunction.ReadCustomerName();
            foreach (var name in names) customerName.Items.Add(name);
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void productDetailData_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            string itemNumber = productDetailData.Rows[e.RowIndex].Cells[0].Value?.ToString() ?? "0";
            if (e.ColumnIndex == 0)
            {
                commonFormFunction.ReadItemDetail(productDetailData, e.RowIndex, itemNumber);
                Form[] forms = Parent.FindForm().MdiChildren;
                foreach (Form form in forms)
                {
                    if (form.Name == "ProductDetailForm")
                    {
                        ((ProductDetailForm)form).SearchItemDetail(itemNumber);
                        break;
                    }
                }

            }
            if (e.ColumnIndex == 4)
            {
                commonFormFunction.UnitMultPrice(productDetailData, e.RowIndex, totalMoney);
            }
        }

        private void productDetailData_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productDetailData.Columns[e.ColumnIndex].Name == "search")
            {
                FuzzySearchForm fuzzySearchForm = new FuzzySearchForm(productDetailData, e.RowIndex);
                CallFormFunction callFormFunction = new CallFormFunction(fuzzySearchForm, this);
                callFormFunction.OpenOtherForm();
            }
        }

        private void productDetailData_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            commonFormFunction.DisplayDataGridViewLineNumber(productDetailData, e);
        }

        private void productDetailData_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right) return;
            DialogResult dialog = MessageBox.Show("是否刪除", "詢問", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                commonFormFunction.DeleteDataGridViewLine(productDetailData, totalMoney);
            }
        }

        private void previewPrintButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(orderNumber.Text))
            {
                MessageBox.Show("請先儲存");
                return;
            }
            _start = 0;
            _end = 40;
            _page = 1;
            printFunction.ChoosePrintPage(printPreviewDialog, printDocument);
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            printFunction.PrintPage(productDetailData, e, dateTime, customerName.Text, orderNumber.Text, "出貨單", remarkTextBox.Text, totalMoney.Text, _page, _start, _end);
            _page++;
            _start += 40;
            _end += 40;
            if (productDetailData.RowCount > _start) e.HasMorePages = true;
        }

        private void saveOrderButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(customerName.Text.ToString()))
            {
                MessageBox.Show("請選擇客戶");
                return;
            }
            DateOnly dateOnly = DateOnly.FromDateTime(dateTime.Value);
            string storeName = customerName.Text.ToString();
            string remark = remarkTextBox.Text.ToString();
            decimal totalPrice = Convert.ToDecimal(totalMoney.Text);
            CommonButtonFunction commonButtonFunction = new CommonButtonFunction(productDetailData, dateOnly, storeName, remark, totalPrice, "出貨單");
            if (string.IsNullOrEmpty(orderNumber.Text))
            {
                commonButtonFunction.SaveOrder(orderNumber);
            }
            else
            {
                commonButtonFunction.UpdateOrder(orderNumber.Text);
            }
        }

        private void refreshButton_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("確定刷新", "詢問", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                CommonButtonFunction commonButtonFunction = new CommonButtonFunction();
                commonButtonFunction.RefreshForm(productDetailData, orderNumber, totalMoney, remarkTextBox);
            }
        }

        private void loadOrderButton_Click(object sender, EventArgs e)
        {
            SearchOrderForm searchOrderForm = new SearchOrderForm("出貨單", productDetailData, orderNumber, totalMoney, remarkTextBox, customerName, dateTime);
            CallFormFunction callFormFunction = new CallFormFunction(searchOrderForm, this);
            callFormFunction.OpenOtherForm();
        }

        private void deleteOrderButton_Click(object sender, EventArgs e)
        {
            DateOnly dateOnly = DateOnly.FromDateTime(dateTime.Value);
            string storeName = customerName.Text.ToString();
            string remark = remarkTextBox.Text.ToString();
            decimal totalPrice = Convert.ToDecimal(totalMoney.Text);
            CommonButtonFunction commonButtonFunction = new CommonButtonFunction(productDetailData, dateOnly, storeName, remark, totalPrice, "出貨單");
            commonButtonFunction.DeleteOrder(orderNumber.Text);
        }

        private void createExcelButton_Click(object sender, EventArgs e)
        {
            string dateMonth = dateTime.Value.ToString("yyyyMM");
            string dateMonthDay = dateTime.Value.ToString("yyyyMMdd");
            string path = "../單子/" + dateMonth + "/出貨單/";
            string fileName = "出貨單_" + dateTime.Value.ToString("yyyy-MM-dd") + "_" + customerName.Text.ToString();
            CreateExcelFunction createExcelFunction = new CreateExcelFunction(productDetailData, dateMonth, dateMonthDay, fileName, orderNumber.Text, customerName.Text, "出貨單");
            createExcelFunction.CreateNewExcelFile(path, storeTypeLabel.Text);
        }
    }
}
