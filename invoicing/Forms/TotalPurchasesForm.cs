//總進貨額
using invoicing.CommonFunction;
using invoicing.InsideModels;
using invoicing.Models;

namespace invoicing.Forms
{
    public partial class TotalPurchasesForm : Form
    {
        private CommonFormFunction commonFormFunction = new CommonFormFunction();
        private readonly string[] _orders = new string[] { "進貨退出單", "進貨單" };
        public TotalPurchasesForm()
        {
            InitializeComponent();
            var names = commonFormFunction.ReadFactoryName();
            foreach (var name in names) factoryName.Items.Add(name);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string? name = factoryName.Text;
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
                var incommingOrder = dbContext.Allsheetstoragecustomers.Where(x => x.Order == "進貨單" && x.Delete == 0
                                                                && (x.Date >= startDate && x.Date <= endDate)).Select(y => y.OrderTotalPrice).ToList();
                var incommingOutgoing = dbContext.Allsheetstoragecustomers.Where(x => x.Order == "進貨退出單" && x.Delete == 0
                                                                && (x.Date >= startDate && x.Date <= endDate)).Select(y => y.OrderTotalPrice).ToList();
                decimal incommingOrderPrice = incommingOrder.Sum();
                decimal incommingOutgoingPrice = incommingOutgoing.Sum();
                if (incommingOrderPrice > 0 && incommingOutgoingPrice > 0)
                    return (incommingOrderPrice - incommingOutgoingPrice).ToString();
                else if (incommingOrderPrice > 0 && incommingOutgoingPrice == 0)
                    return incommingOrderPrice.ToString();
                else if (incommingOrderPrice == 0 && incommingOutgoingPrice > 0)
                    return incommingOutgoingPrice.ToString();
            }
            return string.Empty;
        }
        private string TotalPrice(DateOnly startDate, DateOnly endDate, string factoryName)
        {
            using (InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                var incommingOrder = dbContext.Allsheetstoragecustomers.Where(x => x.Order == "進貨單" && x.Delete == 0
                                                                && (x.Date >= startDate && x.Date <= endDate) && x.Customer == factoryName)
                                                                .Select(y => y.OrderTotalPrice).ToList();
                var incommingOutgoing = dbContext.Allsheetstoragecustomers.Where(x => x.Order == "進貨退出單" && x.Delete == 0
                                                                && (x.Date >= startDate && x.Date <= endDate) && x.Customer == factoryName)
                                                                .Select(y => y.OrderTotalPrice).ToList();
                decimal incommingOrderPrice = incommingOrder.Sum();
                decimal incommingOutgoingPrice = incommingOutgoing.Sum();
                if (incommingOrderPrice > 0 && incommingOutgoingPrice > 0)
                    return (incommingOrderPrice - incommingOutgoingPrice).ToString();
                else if (incommingOrderPrice > 0 && incommingOutgoingPrice == 0)
                    return incommingOrderPrice.ToString();
                else if (incommingOrderPrice == 0 && incommingOutgoingPrice > 0)
                    return incommingOutgoingPrice.ToString();
            }
            return string.Empty;
        }
    }
}
