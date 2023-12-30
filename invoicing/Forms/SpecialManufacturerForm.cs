//唐詣
using ExcelDataReader;
using invoicing.CommonFunction;
using invoicing.Models;
using Microsoft.EntityFrameworkCore;

namespace invoicing.Forms
{
    public partial class SpecialManufacturerForm : Form
    {
        private CommonFormFunction commonFormFunction = new CommonFormFunction();
        private PrintFunction printFunction = new PrintFunction();
        private decimal _totalPrice = 0;
        private int _start = 0;
        private int _end = 40;
        private int _page = 1;
        public SpecialManufacturerForm()
        {
            InitializeComponent();
            var names = commonFormFunction.ReadCustomerName();
            foreach (var name in names) customerName.Items.Add(name);
        }
        private void productDetailData_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            commonFormFunction.DisplayDataGridViewLineNumber(productDetailData, e);
        }

        private void searchOrderButton_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "excel file (*.xls)|*.xls";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                productDetailData.DataSource = ReadExcelXLSFile(dialog.FileName);
                totalMoney.Text = _totalPrice.ToString();
            }
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

        private void printButton_Click(object sender, EventArgs e)
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

        private void refreshOrderButton_Click(object sender, EventArgs e)
        {
            DialogResult Result = MessageBox.Show("確定刷新", "詢問", MessageBoxButtons.YesNo);
            if (Result == DialogResult.Yes)
            {
                CommonButtonFunction commonButtonFunction = new CommonButtonFunction();
                commonButtonFunction.RefreshForm(productDetailData, orderNumber, totalMoney, remarkTextBox);
            }
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
        private List<Allsheetstorage> ReadExcelXLSFile(string excelPath)
        {
            List<Allsheetstorage> allsheetstorages = new List<Allsheetstorage>();
            // 使用FileStream打開Excel文件
            using (var stream = File.Open(excelPath, FileMode.Open, FileAccess.Read))
            {
                // 使用ExcelReaderFactory.CreateBinaryReader()方法創建一個可以讀取xls文件的reader
                using (var reader = ExcelReaderFactory.CreateBinaryReader(stream))
                {
                    var configuration = new ExcelDataSetConfiguration
                    {
                        ConfigureDataTable = _ => new ExcelDataTableConfiguration
                        {
                            UseHeaderRow = true
                        }
                    };

                    // 使用reader.AsDataSet()方法將Excel文件的內容讀取到一個DataSet對象中
                    var result = reader.AsDataSet(configuration);

                    int startRow = 11;
                    for (int i = startRow; i < result.Tables[0].Rows.Count; i += 2)
                    {
                        if (result.Tables[0].Rows[i][0] == null || result.Tables[0].Rows[i][0] is DBNull)
                        {
                            return allsheetstorages;
                        }
                        using (InvoicingDbContext dbContext = new InvoicingDbContext())
                        {
                            var response = dbContext.Merchandisemasterfiles.Where(x => x.ItemNumber == result.Tables[0].Rows[i][0].ToString()).AsNoTracking().FirstOrDefault();
                            var suggest = dbContext.Suggestprices.Where(x => x.StandardPrice == Convert.ToDecimal(response.StandardPrice)).Select(y => y.RecommendedPrice).FirstOrDefault();
                            if (response != null)
                            {
                                string quantity = (result.Tables[0].Rows[i][6] == null || result.Tables[0].Rows[i][6] is DBNull) ? result.Tables[0].Rows[i][7].ToString() : result.Tables[0].Rows[i][6].ToString();
                                decimal totalPrice = (Convert.ToDecimal(response.StandardPrice) * Convert.ToDecimal(quantity));
                                _totalPrice += totalPrice;
                                Allsheetstorage allsheetstorage = new Allsheetstorage
                                {
                                    ItemNumber = response.ItemNumber,
                                    ItemName = response.ItemName,
                                    Quantity = quantity,
                                    Unit = response.Unit,
                                    Price = response.StandardPrice.ToString(),
                                    TotalPrice = totalPrice.ToString(),
                                    Remark = suggest.ToString(),
                                };
                                allsheetstorages.Add(allsheetstorage);
                            }
                            else
                            {
                                MessageBox.Show($"第{i}行沒有貨品編號");
                                return allsheetstorages;
                            }
                        }
                    }
                }
            }
            return allsheetstorages;
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            printFunction.PrintPage(productDetailData, e, dateTime, customerName.Text, orderNumber.Text, "出貨單", remarkTextBox.Text, totalMoney.Text, _page, _start, _end);
            _page++;
            _start += 40;
            _end += 40;
            if (productDetailData.RowCount > _start) e.HasMorePages = true;
        }
    }
}
