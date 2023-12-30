using invoicing.CommonFunction;
using invoicing.Forms;
using invoicing.Models;
using Microsoft.EntityFrameworkCore;

namespace invoicing.Froms
{
    public partial class CustomerInformationForm : Form
    {
        private readonly CommonFormFunction commonFormFunction = new CommonFormFunction();
        private object _source;
        private string _customerName;
        public CustomerInformationForm()
        {
            InitializeComponent();
            commonFormFunction.CustomerOrder(customerInformationData);
            _source = customerInformationData.DataSource;
        }

        private void customerNameText_TextChanged(object sender, EventArgs e)
        {
            string search = customerNameText.Text;
            if (string.IsNullOrEmpty(search))
            {
                customerInformationData.DataSource = _source;
            }
            else
            {
                using (InvoicingDbContext dbContext = new InvoicingDbContext())
                {
                    var response = dbContext.Customers.Where(x => x.CustomerName.Contains(search) && x.Delete == 0).AsNoTracking().ToList();
                    customerInformationData.DataSource = response;
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            CustomerDetailForm customerDetailForm = new CustomerDetailForm();
            CallFormFunction callFormFunction = new CallFormFunction(customerDetailForm, this);
            callFormFunction.OpenOtherForm();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_customerName)) return;
            CustomerDetailForm customerDetailForm = new CustomerDetailForm(_customerName);
            CallFormFunction callFormFunction = new CallFormFunction(customerDetailForm, this);
            callFormFunction.OpenOtherForm();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_customerName)) return;
            CustomerDetailForm customerDetailForm = new CustomerDetailForm(_customerName);
            CallFormFunction callFormFunction = new CallFormFunction(customerDetailForm, this);
            callFormFunction.OpenOtherForm();
        }

        private void customerInformationData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (customerInformationData.Columns[e.ColumnIndex].Name == "choose")
            {
                _customerName = customerInformationData.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
    }
}
