using invoicing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace invoicing.Forms
{
    public partial class CustomerDetailForm : Form
    {
        public CustomerDetailForm()
        {
            InitializeComponent();
        }
        public CustomerDetailForm(string customerName)
        {
            InitializeComponent();
            SearchCustomerDetail(customerName);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Customer customer = ReadFormInput();
            if (string.IsNullOrEmpty(customer.CustomerName))
            {
                MessageBox.Show("請輸入客戶名稱");
                return;
            }
            try
            {
                using (InvoicingDbContext dbContext = new InvoicingDbContext())
                {
                    dbContext.Add(customer);
                    dbContext.SaveChanges();
                }
                MessageBox.Show($"客戶：{customer.CustomerName}新增成功");
            }
            catch (DbUpdateException)
            {
                MessageBox.Show($"客戶：{customer.CustomerName}已在資料庫內");
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            Customer customer = ReadFormInput();
            customer.Id = Convert.ToInt16(customerIDLabel.Text);
            if (string.IsNullOrEmpty(customer.CustomerName))
            {
                MessageBox.Show("請輸入客戶名稱");
                return;
            }
            try
            {
                using (InvoicingDbContext dbContext = new InvoicingDbContext())
                {
                    dbContext.Entry(customer).State = EntityState.Modified;
                    dbContext.SaveChanges();
                }
                MessageBox.Show($"客戶：{customer.CustomerName}修改成功");
            }
            catch (DbUpdateException)
            {
                MessageBox.Show($"客戶：{customer.CustomerName}不在資料庫內");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string customerName = Interaction.InputBox("請輸入客戶名稱", "標題", "1", -1, -1);
            SearchCustomerDetail(customerName);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Customer customer = ReadFormInput();
            customer.Id = Convert.ToInt16(customerIDLabel.Text);
            customer.Delete = 1;
            if (string.IsNullOrEmpty(customer.CustomerName))
            {
                MessageBox.Show("請輸入客戶名稱");
                return;
            }
            try
            {
                using (InvoicingDbContext dbContext = new InvoicingDbContext())
                {
                    dbContext.Entry(customer).State = EntityState.Modified;
                    dbContext.SaveChanges();
                }
                MessageBox.Show($"客戶：{customer.CustomerName}刪除成功");
            }
            catch (DbUpdateException)
            {
                MessageBox.Show($"客戶：{customer.CustomerName}不在資料庫內");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            customerIDLabel.Text = string.Empty;
            customerNameTextBox.Text = string.Empty;
            customerAddressTextBox.Text = string.Empty;
            contactPhoneNumberTextBox.Text = string.Empty;
            faxNumberTextBox.Text = string.Empty;
        }
        private Customer ReadFormInput()
        {
            Customer customer = new Customer
            {
                CustomerName = customerNameTextBox.Text,
                DeliveryAddress = customerAddressTextBox.Text,
                ContactPhoneNumberOne = contactPhoneNumberTextBox.Text,
                FaxNumber = faxNumberTextBox.Text
            };
            return customer;
        }
        private void SearchCustomerDetail(string customerName)
        {
            using (InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                var response = dbContext.Customers.Where(x => x.CustomerName == customerName && x.Delete == 0).AsNoTracking().FirstOrDefault();
                if (response == null)
                {
                    MessageBox.Show("請輸入正確的客戶名稱");
                    return;
                }
                customerIDLabel.Text = response.Id.ToString();
                customerNameTextBox.Text = response.CustomerName;
                customerAddressTextBox.Text = response.DeliveryAddress;
                contactPhoneNumberTextBox.Text = response.ContactPhoneNumberOne;
                faxNumberTextBox.Text = response.FaxNumber;
            }
        }
    }
}
