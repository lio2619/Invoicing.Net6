using invoicing.Models;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Globalization;

namespace invoicing.CommonFunction
{
    internal class CommonButtonFunction
    {
        private readonly DataGridView _productDetailData;
        private readonly DateOnly _orderDate;
        private readonly string _storeName;
        private readonly string _remark;
        private readonly decimal _totalPrice;
        private readonly string _orderName;
        public CommonButtonFunction() { }
        public CommonButtonFunction(DataGridView productDetailData, DateOnly orderDate, string storeName, string remark, decimal totalPrice, string orderName)
        {
            _productDetailData = productDetailData;
            _orderDate = orderDate;
            _storeName = storeName;
            _remark = remark;
            _totalPrice = totalPrice;
            _orderName = orderName;
        }
        /// <summary>
        /// 儲存單子
        /// </summary>
        /// <param name="orderNumberLabel"></param>
        public void SaveOrder(Label orderNumberLabel)
        {
            using(InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                string? orderNumber = dbContext.Allsheetstoragecustomers.Where(x => x.Date.Month == _orderDate.Month && x.Date.Year == _orderDate.Year)
                                                            .Max(x => x.OrderNumber);
                if(string.IsNullOrEmpty(orderNumber))
                {
                    orderNumber = "1";
                }
                else
                {
                    orderNumber = (int.Parse(orderNumber) + 1).ToString();
                }
                SaveOrderDetail(orderNumber);
                Allsheetstoragecustomer allsheetstoragecustomers = new Allsheetstoragecustomer
                {
                    OrderNumber = orderNumber,
                    Date = _orderDate,
                    Customer = _storeName,
                    Order = _orderName,
                    Remark = _remark,
                    OrderTotalPrice = _totalPrice,
                    Delete = 0
                };
                dbContext.Allsheetstoragecustomers.Add(allsheetstoragecustomers);
                dbContext.SaveChanges();
                orderNumberLabel.Text = orderNumber;
                MessageBox.Show("儲存成功");
            }
        }
        /// <summary>
        /// 儲存單子明細
        /// </summary>
        /// <param name="orderNumber"></param>
        private void SaveOrderDetail(string orderNumber)
        {
            BindingList<Allsheetstorage> dataSource = (BindingList<Allsheetstorage>)((BindingSource)_productDetailData.DataSource).List;
            List<Allsheetstorage> allsheetstorages = new List<Allsheetstorage>(dataSource);
            allsheetstorages.ForEach(x =>{x.OrderNumber = orderNumber; x.Date = _orderDate; });
            using(InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                dbContext.Allsheetstorages.AddRange(allsheetstorages);
                dbContext.SaveChanges();
            }
        }
        /// <summary>
        /// 更新單子
        /// </summary>
        /// <param name="orderNumber"></param>
        public void UpdateOrder(string orderNumber)
        {
            using(InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                Allsheetstoragecustomer allsheetstoragecustomers = new Allsheetstoragecustomer
                {
                    OrderNumber = orderNumber,
                    Date = _orderDate,
                    Customer = _storeName,
                    Order = _orderName,
                    Remark = _remark,
                    OrderTotalPrice = _totalPrice,
                    Delete = 0
                };
                dbContext.Entry(allsheetstoragecustomers).State = EntityState.Modified;
                dbContext.SaveChanges();
            }
            UpdateOrderDetail(orderNumber);
            MessageBox.Show("更新成功");
        }
        /// <summary>
        /// 更新單子明細
        /// </summary>
        /// <param name="orderNumber"></param>
        private void UpdateOrderDetail(string orderNumber)
        {
            BindingList<Allsheetstorage> dataSource = (BindingList<Allsheetstorage>)((BindingSource)_productDetailData.DataSource).List;
            List<Allsheetstorage> allsheetstorages = new List<Allsheetstorage>(dataSource);
            allsheetstorages.ForEach(x => { x.OrderNumber = orderNumber; x.Date = _orderDate; });
            using (InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                var response = dbContext.Allsheetstorages.Where(x => x.OrderNumber == orderNumber && x.Date == _orderDate).ToList();
                dbContext.Allsheetstorages.RemoveRange(response);
                dbContext.SaveChanges();
                dbContext.Allsheetstorages.AddRange(allsheetstorages);
                dbContext.SaveChanges();
            }
        }
        /// <summary>
        /// 刷新form的元件
        /// </summary>
        /// <param name="productDetailData"></param>
        /// <param name="orderNumberLabel"></param>
        /// <param name="totalPriceLabel"></param>
        /// <param name="remarkTextbox"></param>
        public void RefreshForm(DataGridView productDetailData, Label orderNumberLabel, Label totalPriceLabel, TextBox remarkTextBox)
        {
            productDetailData.DataSource = null;
            orderNumberLabel.Text = string.Empty;
            totalPriceLabel.Text = string.Empty;
            remarkTextBox.Text = string.Empty;
        }
        /// <summary>
        /// 讀取舊單子
        /// </summary>
        /// <param name="orderNumber"></param>
        /// <param name="productDetailData"></param>
        /// <param name="orderNumberLabel"></param>
        /// <param name="totalPriceLabel"></param>
        /// <param name="remarkTextbox"></param>
        /// <param name="storeName"></param>
        /// <param name="dateTime"></param>
        public void LoadOrder(string orderNumber, DateOnly orderDate, DataGridView productDetailData, Label orderNumberLabel, Label totalPriceLabel, TextBox remarkTextbox, ComboBox storeName, DateTimePicker dateTime)
        {
            using(InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                var response = dbContext.Allsheetstoragecustomers.Where(x => x.OrderNumber == orderNumber && x.Date == orderDate)
                                                                                        .AsNoTracking().FirstOrDefault();
                orderNumberLabel.Text = response.OrderNumber;
                totalPriceLabel.Text = response.OrderTotalPrice.ToString();
                remarkTextbox.Text = response.Remark;
                storeName.Text = response.Customer;
                dateTime.Value = DateTime.ParseExact(response.Date.ToString(), "yyyy/M/d", CultureInfo.InvariantCulture); ;
            }
            LoadOrderDetail(orderNumber, orderDate, productDetailData);
        }
        /// <summary>
        /// 讀取舊單子明細
        /// </summary>
        /// <param name="orderNumber"></param>
        /// <param name="productDetailData"></param>
        private void LoadOrderDetail(string orderNumber, DateOnly orderDate, DataGridView productDetailData)
        {
            using (InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                var response = dbContext.Allsheetstorages.Where(x => x.OrderNumber == orderNumber && x.Date == orderDate).AsNoTracking().ToList();
                BindingList<Allsheetstorage> source = new BindingList<Allsheetstorage>(response);
                productDetailData.DataSource = null;
                productDetailData.DataSource = source;
            }
        }
        public void DeleteOrder(string orderNumber)
        {
            DialogResult dialog = MessageBox.Show("是否刪除", "詢問", MessageBoxButtons.YesNo);
            if (dialog == DialogResult.Yes)
            {
                using (InvoicingDbContext dbContext = new InvoicingDbContext())
                {
                    Allsheetstoragecustomer allsheetstoragecustomers = new Allsheetstoragecustomer
                    {
                        OrderNumber = orderNumber,
                        Date = _orderDate,
                        Customer = _storeName,
                        Order = _orderName,
                        Remark = _remark,
                        OrderTotalPrice = _totalPrice,
                        Delete = 1
                    };
                    dbContext.Entry(allsheetstoragecustomers).State = EntityState.Modified;
                    dbContext.SaveChanges();
                }
                MessageBox.Show("刪除成功");
            }
        }
        public void AddSuggestPrice(decimal standardPrice, decimal suggestPrice)
        {
            using (InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                try
                {
                    Suggestprice suggestprice = new Suggestprice
                    {
                        StandardPrice = standardPrice,
                        RecommendedPrice = suggestPrice
                    };
                    dbContext.Suggestprices.Add(suggestprice);
                    dbContext.SaveChanges();
                    MessageBox.Show("新增成功");
                }
                catch (DbUpdateException)
                {
                    MessageBox.Show($"標準售價{standardPrice}已經有了");
                }
            }
        }
    }
}
