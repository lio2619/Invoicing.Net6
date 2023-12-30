using invoicing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace invoicing.Forms
{
    public partial class FactoryDetailForm : Form
    {
        public FactoryDetailForm()
        {
            InitializeComponent();
        }
        public FactoryDetailForm(string factoryName)
        {
            InitializeComponent();
            SearchFactoryDetail(factoryName);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Factory factory = ReadFormInput();
            if (string.IsNullOrEmpty(factory.FactoryName))
            {
                MessageBox.Show("請輸入廠商名稱");
            }
            try
            {
                using (InvoicingDbContext dbContext = new InvoicingDbContext())
                {
                    dbContext.Add(factory);
                    dbContext.SaveChanges();
                }
                MessageBox.Show($"廠商：{factory.FactoryName}新增成功");
            }
            catch (DbUpdateException)
            {
                MessageBox.Show($"廠商：{factory.FactoryName}已在資料庫內");
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            Factory factory = ReadFormInput();
            factory.Id = Convert.ToInt16(factoryIDLabel.Text);
            if (string.IsNullOrEmpty(factory.FactoryName))
            {
                MessageBox.Show("請輸入廠商名稱");
            }
            try
            {
                using (InvoicingDbContext dbContext = new InvoicingDbContext())
                {
                    dbContext.Entry(factory).State = EntityState.Modified;
                    dbContext.SaveChanges();
                }
                MessageBox.Show($"廠商：{factory.FactoryName}修改成功");
            }
            catch (DbUpdateException)
            {
                MessageBox.Show($"廠商：{factory.FactoryName}不在資料庫內");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string factoryName = Interaction.InputBox("請輸入廠商名稱", "標題", "1", -1, -1);
            SearchFactoryDetail(factoryName);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Factory factory = ReadFormInput();
            factory.Id = Convert.ToInt16(factoryIDLabel.Text);
            factory.Delete = 1;
            if (string.IsNullOrEmpty(factory.FactoryName))
            {
                MessageBox.Show("請輸入廠商名稱");
            }
            try
            {
                using (InvoicingDbContext dbContext = new InvoicingDbContext())
                {
                    dbContext.Entry(factory).State = EntityState.Modified;
                    dbContext.SaveChanges();
                }
                MessageBox.Show($"廠商：{factory.FactoryName}刪除成功");
            }
            catch (DbUpdateException)
            {
                MessageBox.Show($"廠商：{factory.FactoryName}不在資料庫內");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            factoryIDLabel.Text = string.Empty;
            factoryNameTextBox.Text = string.Empty;
            factoryAddressTextBox.Text = string.Empty;
            contactPhoneNumberTextBox.Text = string.Empty;
            faxNumberTextBox.Text = string.Empty;
        }
        private Factory ReadFormInput()
        {
            Factory factory = new Factory
            {
                FactoryName = factoryNameTextBox.Text,
                DeliveryAddress = factoryAddressTextBox.Text,
                ContactPhoneNumber = contactPhoneNumberTextBox.Text,
                FaxNumber = faxNumberTextBox.Text
            };
            return factory;
        }
        private void SearchFactoryDetail(string factoryName)
        {
            using (InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                var response = dbContext.Factories.Where(x => x.FactoryName == factoryName && x.Delete == 0).AsNoTracking().FirstOrDefault();
                if (response == null)
                {
                    MessageBox.Show("請輸入正確的廠商名稱");
                    return;
                }
                factoryIDLabel.Text = response.Id.ToString();
                factoryNameTextBox.Text = response.FactoryName;
                factoryAddressTextBox.Text = response.DeliveryAddress;
                contactPhoneNumberTextBox.Text = response.ContactPhoneNumber;
                faxNumberTextBox.Text = response.FaxNumber;
            }
        }
    }
}
