using invoicing.CommonFunction;

namespace invoicing.Forms
{
    public partial class SuggestPriceForm : Form
    {
        private readonly CommonFormFunction commonFormFunction = new CommonFormFunction();
        private readonly CommonButtonFunction buttonFunction = new CommonButtonFunction();
        public SuggestPriceForm()
        {
            InitializeComponent();
            commonFormFunction.StandardPriceToRecommendedPrice(suggestPriceData);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                buttonFunction.AddSuggestPrice(Convert.ToDecimal(standardPriceTextBox.Text), Convert.ToDecimal(recommendedPriceTextBox.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("請輸入售價");
            }
        }
    }
}
