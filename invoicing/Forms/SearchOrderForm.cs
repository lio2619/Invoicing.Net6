using invoicing.CommonFunction;

namespace invoicing.Forms
{
    public partial class SearchOrderForm : Form
    {
        private readonly DataGridView _productDetailData;
        private readonly Label _orderNumberLabel;
        private readonly Label _totalPriceLabel;
        private readonly TextBox _remarkTextBox;
        private readonly ComboBox _storeName;
        private readonly DateTimePicker _dateTime;
        private readonly string _orderName;
        private string _orderNumber;
        private DateOnly _orderDate;
        public SearchOrderForm(string orderName, DataGridView productDetailData, Label orderNumberLabel, Label totalPriceLabel, TextBox remarkTextbox, ComboBox storeName, DateTimePicker dateTime)
        {
            InitializeComponent();
            _orderName = orderName;
            _productDetailData = productDetailData;
            _orderNumberLabel = orderNumberLabel;
            _totalPriceLabel = totalPriceLabel;
            _remarkTextBox = remarkTextbox;
            _storeName = storeName;
            _dateTime = dateTime;
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            CommonFormFunction commonFormFunction = new CommonFormFunction();
            DateOnly startDate = DateOnly.FromDateTime(startDateTime.Value);
            DateOnly endDate = DateOnly.FromDateTime(endDateTime.Value);
            commonFormFunction.SearchLoadOrder(loadOrderData, startDate, endDate, _orderName);
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_orderNumber)) return;
            CommonButtonFunction commonButtonFunction = new CommonButtonFunction();
            commonButtonFunction.LoadOrder(_orderNumber, _orderDate, _productDetailData, _orderNumberLabel, _totalPriceLabel, _remarkTextBox, _storeName, _dateTime);
            Close();
        }

        private void loadOrderData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (loadOrderData.Columns[e.ColumnIndex].Name == "choose")
            {
                _orderNumber = loadOrderData.Rows[e.RowIndex].Cells[1].Value.ToString();
                _orderDate = (DateOnly)loadOrderData.Rows[e.RowIndex].Cells[2].Value;
            }
        }
    }
}
