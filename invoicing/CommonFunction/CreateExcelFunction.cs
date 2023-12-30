using invoicing.Models;
using Microsoft.EntityFrameworkCore;
using OfficeOpenXml;

namespace invoicing.CommonFunction
{
    internal class CreateExcelFunction
    {
        private readonly DataGridView _productDetailData;
        private readonly string _dateMonth;
        private readonly string _dateMonthDay;
        private readonly string _fileName;
        private readonly string _orderNumber;
        private readonly string _storeName;
        private readonly string _order;
        public CreateExcelFunction(DataGridView productDetailData, string dateMonth, string dateMonthDay, string fileName, string orderNumber, string storeName, string order)
        {
            _productDetailData = productDetailData;
            _dateMonth = dateMonth;
            _dateMonthDay = dateMonthDay;
            _fileName = fileName;
            _orderNumber = orderNumber;
            _storeName = storeName;
            _order = order;
        }
        public CreateExcelFunction()
        {

        }
        public void CreateNewExcelFile(string path, string storeType)
        {
            if (!Directory.Exists(path))
            {
                Directory.CreateDirectory(path);
            }
            using (InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                var orderPriceRemark = dbContext.Allsheetstoragecustomers.Where(x => x.OrderNumber == _orderNumber)
                                                                    .Select(y => new { y.OrderTotalPrice, y.Remark }).AsNoTracking().FirstOrDefault();
                if (storeType == "客戶：")
                {
                    var response = dbContext.Customers.Where(x => x.CustomerName == _storeName)
                                            .Select(y => new { y.ContactPhoneNumberOne, y.FaxNumber }).AsNoTracking().FirstOrDefault();
                    WriteExcelFileContent(response.ContactPhoneNumberOne, response.FaxNumber, orderPriceRemark.OrderTotalPrice, orderPriceRemark.Remark);
                }
                else
                {
                    var response = dbContext.Factories.Where(x => x.FactoryName == _storeName)
                                            .Select(y => new { y.ContactPhoneNumber, y.FaxNumber }).AsNoTracking().FirstOrDefault();
                    WriteExcelFileContent(response.ContactPhoneNumber, response.FaxNumber, orderPriceRemark.OrderTotalPrice, orderPriceRemark.Remark);
                }

            }
        }
        private void WriteExcelFileContent(string contactPhone, string fax, decimal totalPrice, string remark)
        {
            int row = 5;
            var file = new FileInfo($@"../單子/{_dateMonth}/{_order}/{_fileName.Split('(')[0]}_{_orderNumber}.xlsx");
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            using (var excel = new ExcelPackage(file))
            {
                try
                {
                    ExcelWorksheet ws;
                    ws = excel.Workbook.Worksheets.Add("MySheet");
                    ws.Cells[1, 1].Value = _order;
                    ws.Cells[1, 7].Value = "貨單日期：" + _dateMonthDay;
                    ws.Cells[2, 1].Value = "客戶名稱：";
                    ws.Cells[2, 2].Value = _storeName;
                    ws.Cells[2, 7].Value = "貨單編號：" + _dateMonthDay + _orderNumber;
                    ws.Cells[3, 1].Value = "連絡電話：" + contactPhone;
                    ws.Cells[3, 4].Value = "傳真號碼：" + fax;
                    ws.Cells[4, 1].Value = "編號";
                    ws.Cells[4, 2].Value = "品名";
                    ws.Cells[4, 5].Value = "數量";
                    ws.Cells[4, 6].Value = "單位";
                    ws.Cells[4, 7].Value = "單價";
                    ws.Cells[4, 8].Value = "金額";
                    ws.Cells[4, 9].Value = "備註";
                    int[] cell = new int[] { 1, 2, 5, 6, 7, 8, 9 };
                    for (int i = 0; i < _productDetailData.RowCount; i++)
                    {
                        for (int j = 0; j < _productDetailData.ColumnCount - 1; j++)
                        {
                            ws.Cells[row, cell[j]].Value = _productDetailData.Rows[i].Cells[j].Value?.ToString() ?? "";
                        }
                        row++;
                    }
                    ws.Cells[row, 1].Value = "備註：" + totalPrice;
                    ws.Cells[row, 8].Value = "總計：" + remark;
                    excel.SaveAs(file);
                }
                catch (InvalidOperationException)
                {
                    MessageBox.Show("已經有這個檔案了");
                    return;
                }
            }
            MessageBox.Show("完成");
        }
    }
}
