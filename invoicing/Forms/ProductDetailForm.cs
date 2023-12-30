using invoicing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;

namespace invoicing.Forms
{
    public partial class ProductDetailForm : Form
    {
        public ProductDetailForm()
        {
            InitializeComponent();
        }
        public ProductDetailForm(string itemNumber)
        {
            InitializeComponent();
            SearchItemDetail(itemNumber);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Merchandisemasterfile merchandisemasterfile = ReadFormInput();
            if (string.IsNullOrEmpty(merchandisemasterfile.ItemNumber))
            {
                MessageBox.Show("請輸入貨品編號");
                return;
            }
            try
            {
                using (InvoicingDbContext dbContext = new InvoicingDbContext())
                {
                    dbContext.Add(merchandisemasterfile);
                    dbContext.SaveChanges();
                }
                MessageBox.Show($"貨品：{merchandisemasterfile.ItemName}新增成功");
            }
            catch (DbUpdateException)
            {
                MessageBox.Show($"貨品：{merchandisemasterfile.ItemName}已在資料庫內");
            }
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            Merchandisemasterfile merchandisemasterfile = ReadFormInput();
            if (string.IsNullOrEmpty(merchandisemasterfile.ItemNumber))
            {
                MessageBox.Show("請輸入貨品編號");
                return;
            }
            try
            {
                using (InvoicingDbContext dbContext = new InvoicingDbContext())
                {
                    dbContext.Entry(merchandisemasterfile).State = EntityState.Modified;
                    dbContext.SaveChanges();
                }
                MessageBox.Show($"貨品：{merchandisemasterfile.ItemName}修改成功");
            }
            catch (DbUpdateException)
            {
                MessageBox.Show($"貨品：{merchandisemasterfile.ItemName}不在資料庫內");
            }
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string itemNumber = Interaction.InputBox("請輸入貨品編號", "標題", "1", -1, -1);
            SearchItemDetail(itemNumber);
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            Merchandisemasterfile merchandisemasterfile = ReadFormInput();
            if (string.IsNullOrEmpty(merchandisemasterfile.ItemNumber))
            {
                MessageBox.Show("請輸入貨品編號");
                return;
            }
            try
            {
                using (InvoicingDbContext dbContext = new InvoicingDbContext())
                {
                    dbContext.Remove(merchandisemasterfile);
                    dbContext.SaveChanges();
                }
                MessageBox.Show($"貨品：{merchandisemasterfile.ItemName}刪除成功");
            }
            catch (DbUpdateException)
            {
                MessageBox.Show($"貨品：{merchandisemasterfile.ItemName}不在資料庫內");
            }
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            itemNumberTextBox.Text = string.Empty;
            itemNameTextBox.Text = string.Empty;
            unitTextBox.Text = string.Empty;
            standardPriceTextBox.Text = string.Empty;
            priceATextBox.Text = string.Empty;
            priceBTextBox.Text = string.Empty;
            priceCTextBox.Text = string.Empty;
            standardCostTextBox.Text = string.Empty;
            existingCostTextBox.Text = string.Empty;
        }
        private Merchandisemasterfile ReadFormInput()
        {
            Merchandisemasterfile merchandisemasterfile = new Merchandisemasterfile
            {
                ItemNumber = itemNumberTextBox.Text,
                ItemName = itemNameTextBox.Text,
                Unit = unitTextBox.Text,
                StandardPrice = double.Parse(standardPriceTextBox.Text),
                PriceA = double.Parse(priceATextBox.Text),
                PriceB = double.Parse(priceBTextBox.Text),
                PriceC = double.Parse(priceCTextBox.Text),
                PriceD = 0.0,
                PriceE = 0.0,
                StandardCost = double.Parse(standardCostTextBox.Text),
                ExistingCost = double.Parse(existingCostTextBox.Text),
            };
            return merchandisemasterfile;
        }
        public void SearchItemDetail(string itemNumber)
        {
            using(InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                var response = dbContext.Merchandisemasterfiles.Where(x => x.ItemNumber == itemNumber).AsNoTracking().FirstOrDefault();
                if (response is null)
                {
                    MessageBox.Show("請輸入正確的貨品編號");
                    return;
                }
                itemNumberTextBox.Text = itemNumber;
                itemNameTextBox.Text = response.ItemName;
                unitTextBox.Text = response.Unit;
                standardPriceTextBox.Text = response.StandardPrice.ToString();
                priceATextBox.Text = response.PriceA.ToString();
                priceBTextBox.Text = response.PriceB.ToString();
                priceCTextBox.Text = response.PriceC.ToString();
                standardCostTextBox.Text = response.StandardCost.ToString();
                existingCostTextBox.Text = response.ExistingCost.ToString();
            }
        }
    }
}
