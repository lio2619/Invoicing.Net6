//總銷貨額
using invoicing.CommonFunction;
using invoicing.InsideModels;
using invoicing.Models;
using Microsoft.EntityFrameworkCore;

namespace invoicing.Forms
{
    public partial class TotalSalesForm : Form
    {
        private CommonFormFunction commonFormFunction = new CommonFormFunction();
        private readonly string[] _orders = new string[] { "出貨退出單", "出貨單" };
        public TotalSalesForm()
        {
            InitializeComponent();
            var names = commonFormFunction.ReadCustomerName();
            foreach (var name in names) customerName.Items.Add(name);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string? name = customerName.Text;
            DateOnly startDate = DateOnly.FromDateTime(beginDateTime.Value);
            DateOnly endDate = DateOnly.FromDateTime(endDateTime.Value);
            List<TotalPurchaseSale> totalPurchaseSales = new List<TotalPurchaseSale>();
            if (string.IsNullOrEmpty(name))
            {
                totalPurchaseSales = SearchMoney(startDate, endDate);
                totalPurchaseData.DataSource = totalPurchaseSales;
                totalMoney.Text = TotalPrice(startDate, endDate);
            }
            else
            {
                totalPurchaseSales = SearchMoney(startDate, endDate, name);
                totalPurchaseData.DataSource = totalPurchaseSales;
                totalMoney.Text = TotalPrice(startDate, endDate, name);
            }
        }
        private List<TotalPurchaseSale> SearchMoney(DateOnly startDate, DateOnly endDate)
        {
            List<TotalPurchaseSale> totalPurchaseSales = new List<TotalPurchaseSale>();
            using (InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                var response = dbContext.Allsheetstoragecustomers
                            .Where(a => a.Date >= startDate && a.Date <= endDate && _orders.Contains(a.Order) && a.Delete == 0)
                            .GroupBy(a => new { a.Customer, a.Order })
                            .AsEnumerable() //為什麼這個就可以? 將資料拉到記憶體操作
                            .Select(g => new { g.Key.Customer, g.Key.Order, TotalPrice = g.Sum(a => a.OrderTotalPrice) })
                            .OrderBy(r => r.Customer)
                            .ToList();
                foreach (var item in response)
                {
                    TotalPurchaseSale totalPurchaseSale = new TotalPurchaseSale
                    {
                        Order = item.Order,
                        Name = item.Customer,
                        Price = item.TotalPrice.ToString()
                    };
                    totalPurchaseSales.Add(totalPurchaseSale);
                }
            }
            return totalPurchaseSales;
        }
        private List<TotalPurchaseSale> SearchMoney(DateOnly startDate, DateOnly endDate, string factoryName)
        {
            List<TotalPurchaseSale> totalPurchaseSales = new List<TotalPurchaseSale>();
            using (InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                var response = dbContext.Allsheetstoragecustomers
                            .Where(a => a.Date >= startDate && a.Date <= endDate && _orders.Contains(a.Order) && a.Delete == 0 && a.Customer == factoryName)
                            .GroupBy(a => new { a.Customer, a.Order })
                            .AsEnumerable() //為什麼這個就可以? 將資料拉到記憶體操作
                            .Select(g => new { g.Key.Customer, g.Key.Order, TotalPrice = g.Sum(a => a.OrderTotalPrice) })
                            .OrderBy(r => r.Customer)
                            .ToList();
                foreach (var item in response)
                {
                    TotalPurchaseSale totalPurchaseSale = new TotalPurchaseSale
                    {
                        Order = item.Order,
                        Name = item.Customer,
                        Price = item.TotalPrice.ToString()
                    };
                    totalPurchaseSales.Add(totalPurchaseSale);
                }
            }
            return totalPurchaseSales;
        }
        private string TotalPrice(DateOnly startDate, DateOnly endDate)
        {
            using (InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                var shippingOrder = dbContext.Allsheetstoragecustomers.Where(x => x.Order == "出貨單" && x.Delete == 0
                                                                && (x.Date >= startDate && x.Date <= endDate)).Select(y => y.OrderTotalPrice).ToList();
                var shippingReturn = dbContext.Allsheetstoragecustomers.Where(x => x.Order == "出貨退出單" && x.Delete == 0
                                                                && (x.Date >= startDate && x.Date <= endDate)).Select(y => y.OrderTotalPrice).ToList();
                decimal shippingOrderPrice = shippingOrder.Sum();
                decimal shippingReturnPrice = shippingReturn.Sum();
                if (shippingOrderPrice > 0 && shippingReturnPrice > 0)
                    return (shippingOrderPrice - shippingReturnPrice).ToString();
                else if (shippingOrderPrice > 0 && shippingReturnPrice == 0)
                    return shippingOrderPrice.ToString();
                else if (shippingOrderPrice == 0 && shippingReturnPrice > 0)
                    return shippingReturnPrice.ToString();
            }
            return string.Empty;
        }
        private string TotalPrice(DateOnly startDate, DateOnly endDate, string customerName)
        {
            using (InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                var shippingOrder = dbContext.Allsheetstoragecustomers.Where(x => x.Order == "出貨單" && x.Delete == 0
                                                                && (x.Date >= startDate && x.Date <= endDate) && x.Customer == customerName)
                                                                .Select(y => y.OrderTotalPrice).ToList();
                var shippingReturn = dbContext.Allsheetstoragecustomers.Where(x => x.Order == "出貨退出單" && x.Delete == 0
                                                                && (x.Date >= startDate && x.Date <= endDate) && x.Customer == customerName)
                                                                .Select(y => y.OrderTotalPrice).ToList();
                decimal shippingOrderPrice = shippingOrder.Sum();
                decimal shippingReturnPrice = shippingReturn.Sum();
                if (shippingOrderPrice > 0 && shippingReturnPrice > 0)
                    return (shippingOrderPrice - shippingReturnPrice).ToString();
                else if (shippingOrderPrice > 0 && shippingReturnPrice == 0)
                    return shippingOrderPrice.ToString();
                else if (shippingOrderPrice == 0 && shippingReturnPrice > 0)
                    return shippingReturnPrice.ToString();
            }
            return string.Empty;
        }
    }
}
