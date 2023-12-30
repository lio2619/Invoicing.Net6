//模糊搜尋
using invoicing.CommonFunction;

namespace invoicing.Forms
{
    public partial class FuzzySearchForm : Form
    {
        private readonly DataGridView _productDetailData;
        private readonly int _rowindex;
        private string chooseItemNumber;
        public FuzzySearchForm()
        {
            InitializeComponent();
        }
        public FuzzySearchForm(DataGridView productDetailData, int rowIndex)
        {
            InitializeComponent();
            _productDetailData = productDetailData;
            _rowindex = rowIndex;
        }
        private void search_Click(object sender, EventArgs e)
        {
            CommonFormFunction commonFormFunction = new CommonFormFunction();
            string itemNumber = itemNumberText.Text.Trim();
            commonFormFunction.ReadItemDetail(productDetailData, itemNumber);
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            _productDetailData.Rows[_rowindex].Cells[0].Value = chooseItemNumber;
            _productDetailData.CurrentCell = _productDetailData.Rows[_rowindex].Cells[0];
            _productDetailData.BeginEdit(true);
            Close();
        }

        private void productDetailData_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (productDetailData.Columns[e.ColumnIndex].Name == "choose")
            {
                chooseItemNumber = productDetailData.Rows[e.RowIndex].Cells[1].Value.ToString();
            }
        }
    }
}
