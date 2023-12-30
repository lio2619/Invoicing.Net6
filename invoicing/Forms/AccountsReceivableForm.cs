//應收帳款
using invoicing.CommonFunction;
using invoicing.Models;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Printing;

namespace invoicing.Forms
{
    public partial class AccountsReceivableForm : Form
    {
        private CommonFormFunction commonFormFunction = new CommonFormFunction();
        private PrintFunction printFunction = new PrintFunction();
        private string[] _orders = new string[] { "出貨退出單", "出貨單" };
        private string _totalPrice;
        public AccountsReceivableForm()
        {
            InitializeComponent();
        }

        private void beginDateTime_ValueChanged(object sender, EventArgs e)
        {
            DateOnly startDate = DateOnly.FromDateTime(beginDateTime.Value);
            DateOnly endDate = DateOnly.FromDateTime(endDateTime.Value);
            List<string> names = commonFormFunction.ReadCustomerName(startDate, endDate, _orders);
            foreach (var name in names) customerName.Items.Add(name);
        }

        private void endDateTime_ValueChanged(object sender, EventArgs e)
        {
            DateOnly startDate = DateOnly.FromDateTime(beginDateTime.Value);
            DateOnly endDate = DateOnly.FromDateTime(endDateTime.Value);
            List<string> names = commonFormFunction.ReadCustomerName(startDate, endDate, _orders);
            foreach (var name in names) customerName.Items.Add(name);
        }

        private void customerName_TextChanged(object sender, EventArgs e)
        {
            string name = customerName.Text;
            DateOnly startDate = DateOnly.FromDateTime(beginDateTime.Value);
            DateOnly endDate = DateOnly.FromDateTime(endDateTime.Value);
            using (InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                var response = dbContext.Allsheetstoragecustomers
                        .Where(x => x.Date >= startDate && x.Date <= endDate && _orders.Contains(x.Order) && x.Customer == name && x.Delete == 0)
                        .AsNoTracking().ToList();
                totalPurchaseData.DataSource = response;
                _totalPrice = TotalPrice(startDate, endDate, name);
                totalManey.Text = _totalPrice;
            }
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
                return (decimal.Round(shippingOrderPrice - shippingReturnPrice)).ToString();
            }
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            /*using(InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                var count = dbContext.Allsheetstoragecustomers.Count();
                for(int i = 0; i < count; i++)
                {
                    var newDate = dbContext.Allsheetstoragecustomers
                    .Where(a => a.OrderNumber == i.ToString())
                    .Select(a => a.Date)
                    .FirstOrDefault();

                    var itemsToUpdate = dbContext.Allsheetstorages
                        .Where(b => b.OrderNumber == i.ToString())
                        .ToList();

                    itemsToUpdate.ForEach(item => item.Date = newDate);

                    dbContext.SaveChanges();
                }
            }*/
            
            if (string.IsNullOrEmpty(taxesTextBox.Text))
            {
                MessageBox.Show("請輸入營業稅");
                return;
            }
            printFunction.ChoosePrintPage(printPreviewDialog1, printDocument1);
        }

        private void printDocument1_PrintPage(object sender, PrintPageEventArgs e)
        {
            DateOnly startDate = DateOnly.FromDateTime(beginDateTime.Value);
            DateOnly endDate = DateOnly.FromDateTime(endDateTime.Value);
            printFunction.PrintCollectMoneyPage(e, startDate, endDate, _orders, customerName.Text, _totalPrice, decimal.Parse(taxesTextBox.Text));
        }
    }
}
