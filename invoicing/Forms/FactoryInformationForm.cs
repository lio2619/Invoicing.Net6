using invoicing.CommonFunction;
using invoicing.Models;
using Microsoft.EntityFrameworkCore;

namespace invoicing.Forms
{
    public partial class FactoryInformationForm : Form
    {
        private readonly CommonFormFunction commonFormFunction = new CommonFormFunction();
        private object _source;
        private string _factoryName;
        public FactoryInformationForm()
        {
            InitializeComponent();
            commonFormFunction.FactoryOrder(factoryInformationData);
            _source = factoryInformationData.DataSource;
        }

        private void factoryNameText_TextChanged(object sender, EventArgs e)
        {
            string search = factoryNameText.Text;
            if (string.IsNullOrEmpty(search))
            {
                factoryInformationData.DataSource = _source;
            }
            else
            {
                using (InvoicingDbContext dbContext = new InvoicingDbContext())
                {
                    var response = dbContext.Factories.Where(x => x.FactoryName.Contains(search) && x.Delete == 0).AsNoTracking().ToList();
                    factoryInformationData.DataSource = response;
                }
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            FactoryDetailForm factoryDetailForm = new FactoryDetailForm();
            CallFormFunction callFormFunction = new CallFormFunction(factoryDetailForm, this);
            callFormFunction.OpenOtherForm();
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_factoryName)) return;
            FactoryDetailForm factoryDetailForm = new FactoryDetailForm(_factoryName);
            CallFormFunction callFormFunction = new CallFormFunction(factoryDetailForm, this);
            callFormFunction.OpenOtherForm();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(_factoryName)) return;
            FactoryDetailForm factoryDetailForm = new FactoryDetailForm(_factoryName);
            CallFormFunction callFormFunction = new CallFormFunction(factoryDetailForm, this);
            callFormFunction.OpenOtherForm();
        }

        private void factoryInformationData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (factoryInformationData.Columns[e.ColumnIndex].Name == "choose")
            {
                _factoryName = factoryInformationData.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
    }
}
