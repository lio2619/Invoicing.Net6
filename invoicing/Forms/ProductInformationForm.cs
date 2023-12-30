using invoicing.CommonFunction;
using invoicing.Models;
using Microsoft.EntityFrameworkCore;
using System.Data;

namespace invoicing.Forms
{
    public partial class ProductInformationForm : Form
    {
        private readonly CommonFormFunction commonFormFunction = new CommonFormFunction();
        private object _source;
        private string _itemNumber;
        public ProductInformationForm()
        {
            InitializeComponent();
            commonFormFunction.ProductOrder(productInformationData);
            _source = productInformationData.DataSource;
        }

        private void customerNameText_TextChanged(object sender, EventArgs e)
        {
            string search = productTextBox.Text;
            if (string.IsNullOrEmpty(search))
            {
                productInformationData.DataSource = _source;
            }
            else
            {
                using (InvoicingDbContext dbContext = new InvoicingDbContext())
                {
                    if (search.All(char.IsDigit))
                    {
                        var response = dbContext.Merchandisemasterfiles.Where(x => x.ItemNumber.StartsWith(search)).AsNoTracking().ToList();
                        productInformationData.DataSource = response;
                    }
                    else
                    {
                        var response = dbContext.Merchandisemasterfiles.Where(x => x.ItemName.Contains(search)).AsNoTracking().ToList();
                        productInformationData.DataSource = response;
                    }
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            ProductDetailForm productDetailForm = new ProductDetailForm();
            CallFormFunction callFormFunction = new CallFormFunction(productDetailForm, this);
            callFormFunction.OpenOtherForm();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_itemNumber)) return;
            ProductDetailForm productDetailForm = new ProductDetailForm(_itemNumber);
            CallFormFunction callFormFunction = new CallFormFunction(productDetailForm, this);
            callFormFunction.OpenOtherForm();
        }
        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_itemNumber)) return;
            ProductDetailForm productDetailForm = new ProductDetailForm(_itemNumber);
            CallFormFunction callFormFunction = new CallFormFunction(productDetailForm, this);
            callFormFunction.OpenOtherForm();
        }
        private void productInformationData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productInformationData.Columns[e.ColumnIndex].Name == "choose")
            {
                _itemNumber = productInformationData.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
    }
}
