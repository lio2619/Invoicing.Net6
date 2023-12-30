using invoicing.CommonFunction;
using invoicing.InsideModels;
using invoicing.Models;

namespace invoicing.Forms
{
    public partial class PrintListOfItemForm : Form
    {
        private CommonFormFunction commonFormFunction = new CommonFormFunction();
        private PrintFunction printFunction = new PrintFunction();
        private List<ListOfItems> _listOfItems = new List<ListOfItems>();
        private string _totalPrice = string.Empty;
        private int _start = 0;
        private int _end = 130;
        public PrintListOfItemForm()
        {
            InitializeComponent();
            var names = commonFormFunction.ReadCustomerName();
            foreach (var name in names) customerName.Items.Add(name);
        }

        private void printButton_Click(object sender, EventArgs e)
        {
            string? name = customerName.Text;
            DateOnly startDate = DateOnly.FromDateTime(beginDateTime.Value);
            DateOnly endDate = DateOnly.FromDateTime(endDateTime.Value);
            _listOfItems = SearchShipmentList(startDate, endDate, name);
            if (!_listOfItems.Any())
            {
                MessageBox.Show($"{name}在{startDate}~{endDate}內沒有單子");
                return;
            }
            _totalPrice = SearchTotalPrice(startDate, endDate, name);
            _start = 0;
            _end = 130;
            printFunction.ChoosePrintPage(printPreviewDialog, printDocument);
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            string? name = customerName.Text;
            DateOnly startDate = DateOnly.FromDateTime(beginDateTime.Value);
            DateOnly endDate = DateOnly.FromDateTime(endDateTime.Value);
            printFunction.PrintListOfItem(e, startDate, endDate, _listOfItems, name, _totalPrice, _start, _end);
            _start += 130;
            _end += 130;
            if ((_listOfItems.Count) / 2 > _start) e.HasMorePages = true;
        }
        private List<ListOfItems> SearchShipmentList(DateOnly startDate, DateOnly endDate, string storeName)
        {
            List<ListOfItems> listOfItems = new List<ListOfItems>();
            using (InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                var response = dbContext.Allsheetstorages.Join(dbContext.Allsheetstoragecustomers, a => a.OrderNumber, b => b.OrderNumber,
                                        (a, b) => new { Allsheetstorages = a, AllsheetstoragesCustomer = b })
                                        .Where(x => x.AllsheetstoragesCustomer.Date >= startDate && x.AllsheetstoragesCustomer.Date <= endDate)
                                        .Where(x => x.AllsheetstoragesCustomer.Customer == storeName)
                                        .Where(x => x.AllsheetstoragesCustomer.Delete == 0)
                                        .Where(x => x.AllsheetstoragesCustomer.Order == "出貨單")
                                        .Select(x => new { x.Allsheetstorages.ItemNumber, x.Allsheetstorages.ItemName, x.Allsheetstorages.Quantity });
                foreach (var item in response)
                {
                    ListOfItems listOfItem = new ListOfItems
                    {
                        ItemNumber = item.ItemNumber,
                        ItemName = item.ItemName,
                        Quantity = item.Quantity,
                    };
                    listOfItems.Add(listOfItem);
                }
            }
            return listOfItems;
        }
        private string SearchTotalPrice(DateOnly startDate, DateOnly endDate, string storeName)
        {
            using (InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                var response = dbContext.Allsheetstoragecustomers
                                        .Where(x => x.Date >= startDate && x.Date <= endDate)
                                        .Where(x => x.Customer == storeName)
                                        .Where(x => x.Delete == 0)
                                        .Where(x => x.Order == "出貨單")
                                        .Sum(x => Convert.ToDecimal(x.OrderTotalPrice));
                return decimal.Round(response).ToString();
            }
        }
    }
}
