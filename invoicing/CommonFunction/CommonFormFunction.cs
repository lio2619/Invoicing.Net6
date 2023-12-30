using invoicing.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace invoicing.CommonFunction
{
    internal class CommonFormFunction
    {
        public CommonFormFunction()
        {
        }
        /// <summary>
        /// 透過貨品編號讀取貨品資料並且放入datagridview中
        /// </summary>
        /// <param name="productDetailData"></param>
        /// <param name="rowIndex"></param>
        /// <param name="itemNumber"></param>
        public void ReadItemDetail(DataGridView productDetailData, int rowIndex, string itemNumber)
        {
            using (InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                var response = dbContext.Merchandisemasterfiles.Where(x => x.ItemNumber == itemNumber)
                                                                .Select(x => new { x.ItemName, x.Unit, x.PriceA }).AsNoTracking().FirstOrDefault();
                if (response is not null)
                {
                    productDetailData.Rows[rowIndex].Cells[1].Value = response.ItemName;    //品名
                    productDetailData.Rows[rowIndex].Cells[3].Value = response.Unit;        //單位
                    productDetailData.Rows[rowIndex].Cells[4].Value = response.PriceA;      //售價
                }
                else
                {
                    MessageBox.Show("請輸入正確的編號", "錯誤");
                }
            }
        }
        public void ReadItemDetailPurchasingOrder(DataGridView productDetailData, int rowIndex, string itemNumber)
        {
            using (InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                var response = dbContext.Merchandisemasterfiles.Where(x => x.ItemNumber == itemNumber)
                                                                .Select(x => new { x.ItemName, x.Unit }).AsNoTracking().FirstOrDefault();
                if (response is not null)
                {
                    productDetailData.Rows[rowIndex].Cells[1].Value = response.ItemName;    //品名
                    productDetailData.Rows[rowIndex].Cells[3].Value = response.Unit;        //單位
                }
                else
                {
                    MessageBox.Show("請輸入正確的編號", "錯誤");
                }
            }
        }
        public void ReadItemDetailIncomingOutgoingOrder(DataGridView productDetailData, int rowIndex, string itemNumber, string storeName)
        {
            using (InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                var response = dbContext.Merchandisemasterfiles.Where(x => x.ItemNumber == itemNumber)
                                                                .Select(x => new { x.ItemName, x.Unit, x.StandardCost }).AsNoTracking().FirstOrDefault();
                if (response is not null)
                {
                    productDetailData.Rows[rowIndex].Cells[1].Value = response.ItemName;    //品名
                    productDetailData.Rows[rowIndex].Cells[3].Value = response.Unit;        //單位
                    if (storeName == "唐詣")
                    {
                        productDetailData.Rows[rowIndex].Cells[4].Value = decimal.Round(Convert.ToDecimal(response.StandardCost) / 1.05m, 3);
                    }
                    else
                    {
                        productDetailData.Rows[rowIndex].Cells[4].Value = response.StandardCost;      //售價
                    }
                }
                else
                {
                    MessageBox.Show("請輸入正確的編號", "錯誤");
                }
            }
        }
        public void UnitMultPrice(DataGridView productDetailData, int rowIndex, Label totalMoney)
        {
            decimal quantity = decimal.Parse(productDetailData.Rows[rowIndex].Cells[2].Value?.ToString() ?? "0");   //數量
            decimal price = decimal.Parse(productDetailData.Rows[rowIndex].Cells[4].Value?.ToString() ?? "0");      //價錢
            if (quantity <= 0 || price <= 0)
            {
                productDetailData.Rows[rowIndex].Cells[5].Value = 0;
                MessageBox.Show("請輸入數量與價錢", "錯誤");
            }
            else
            {
                productDetailData.Rows[rowIndex].Cells[5].Value = quantity * price;
            }
            totalMoney.Text = productDetailData.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDecimal(x.Cells[5].Value)).ToString();
        }
        /// <summary>
        /// 顯示行數
        /// </summary>
        /// <param name="productDetailData"></param>
        /// <param name="e"></param>
        public void DisplayDataGridViewLineNumber(DataGridView productDetailData, DataGridViewRowPostPaintEventArgs e)
        {
            Rectangle rectangle = new Rectangle(e.RowBounds.Location.X, e.RowBounds.Location.Y,
                                                   productDetailData.RowHeadersWidth - 4, e.RowBounds.Height);
            TextRenderer.DrawText(e.Graphics, (e.RowIndex + 1).ToString(), productDetailData.RowHeadersDefaultCellStyle.Font,
                                   rectangle, productDetailData.RowHeadersDefaultCellStyle.ForeColor,
                                    TextFormatFlags.VerticalCenter | TextFormatFlags.Right);
        }
        /// <summary>
        /// 刪除指定行
        /// </summary>
        /// <param name="productDetailData"></param>
        /// <param name="totalMoney"></param>
        public void DeleteDataGridViewLine(DataGridView productDetailData, Label totalMoney)
        {
            try
            {
                int i = productDetailData.CurrentRow.Index;
                DataGridViewRow row = productDetailData.Rows[i];
                productDetailData.Rows.Remove(row);
                totalMoney.Text = productDetailData.Rows.Cast<DataGridViewRow>().Sum(x => Convert.ToDecimal(x.Cells[5].Value)).ToString();
            }
            catch (InvalidOperationException)
            {
                MessageBox.Show("沒有東西可以刪除");
                return;
            }
        }
        /// <summary>
        /// 讀取客戶名稱
        /// </summary>
        /// <returns></returns>
        public List<string> ReadCustomerName()
        {
            List<string> customerNames = new List<string>();
            using (InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                customerNames = dbContext.Customers.OrderBy(y => y.CustomerName).Select(x => x.CustomerName).ToList();
            }
            return customerNames;
        }
        public List<string> ReadCustomerName(DateOnly startDate, DateOnly endDate, string[] orders)
        {
            List<string> customerNames = new List<string>();
            using (InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                customerNames = dbContext.Allsheetstoragecustomers
                                        .Where(x => orders.Contains(x.Order) && x.Date >= startDate && x.Date <= endDate && x.Delete == 0)
                                        .Select(y => y.Customer)
                                        .Distinct().OrderBy(z => z).AsNoTracking().ToList();
            }
            return customerNames;
        }
        /// <summary>
        /// 讀取廠商名稱
        /// </summary>
        /// <returns></returns>
        public List<string> ReadFactoryName()
        {
            List<string> factoryNames = new List<string>();
            using (InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                factoryNames = dbContext.Factories.OrderBy(y => y.FactoryName).Select(x => x.FactoryName).ToList();
            }
            return factoryNames;
        }
        /// <summary>
        /// 模糊搜尋
        /// </summary>
        /// <param name="productDetailData"></param>
        /// <param name="itemNumber"></param>
        public void ReadItemDetail(DataGridView productDetailData, string itemNumber)
        {
            using (InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                var response = dbContext.Merchandisemasterfiles.Where(y => y.ItemNumber.StartsWith(itemNumber))
                                                    .Select(x => new { x.ItemNumber, x.ItemName, x.Unit, x.PriceA }).AsNoTracking().ToList();
                productDetailData.DataSource = response;
            }
        }
        public void SearchLoadOrder(DataGridView productDetailData, DateOnly startDate, DateOnly endDate, string orderName)
        {
            using (InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                var response = dbContext.Allsheetstoragecustomers.Where(x => x.Order == orderName && (x.Date >= startDate && x.Date <= endDate) && x.Delete == 0)
                                                            .Select(y => new { y.OrderNumber, y.Date, y.Customer, y.OrderTotalPrice, y.Remark })
                                                            .OrderBy(z => z.OrderNumber).AsNoTracking().ToList();
                productDetailData.DataSource = response;
            }
        }
        public void ProductOrder(DataGridView productInformationData)
        {
            using (InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                var response = dbContext.Merchandisemasterfiles.AsNoTracking().ToList();
                productInformationData.DataSource = response;
            }
        }
        public void CustomerOrder(DataGridView customerInformationData)
        {
            using (InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                var response = dbContext.Customers.Where(x => x.Delete == 0).AsNoTracking().ToList();
                customerInformationData.DataSource = response;
            }
        }
        public void FactoryOrder(DataGridView factoryInformationData)
        {
            using (InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                var response = dbContext.Factories.Where(x => x.Delete == 0).AsNoTracking().ToList();
                factoryInformationData.DataSource = response;
            }
        }
        public void StandardPriceToRecommendedPrice(DataGridView suggestPriceData)
        {
            using (InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                var response = dbContext.Suggestprices.OrderBy(x => Convert.ToInt16(x.StandardPrice)).AsNoTracking().ToList();
                suggestPriceData.DataSource = response;
            }
        }
    }
}
