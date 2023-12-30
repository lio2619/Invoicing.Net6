using invoicing.CommonFunction;
using invoicing.Forms;
using invoicing.Froms;

namespace invoicing
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void customerInformationTool_Click(object sender, EventArgs e)
        {
            CustomerInformationForm customerForm = new CustomerInformationForm();
            CallFormFunction callFormFunction = new CallFormFunction(customerForm, this);
            callFormFunction.OpenForm();
        }

        private void productInformationTool_Click(object sender, EventArgs e)
        {
            ProductInformationForm productInformationForm = new ProductInformationForm();
            CallFormFunction callFormFunction = new CallFormFunction(productInformationForm, this);
            callFormFunction.OpenForm();
        }

        private void manufacturerInformationTool_Click(object sender, EventArgs e)
        {
            FactoryInformationForm factoryInformationForm = new FactoryInformationForm();
            CallFormFunction callFormFunction = new CallFormFunction(factoryInformationForm, this);
            callFormFunction.OpenForm();
        }
        //�X�f��
        private void shippingOrderMenu_Click(object sender, EventArgs e)
        {
            ShippingOrderForm shippingOrderForm = new ShippingOrderForm();
            CallFormFunction callFormFunction = new CallFormFunction(shippingOrderForm, this);
            callFormFunction.OpenForm();
        }
        //�i�f��
        private void IncomingOrderMenu_Click(object sender, EventArgs e)
        {
            IncomingOrderForm incomingOrderForm = new IncomingOrderForm();
            CallFormFunction callFormFunction = new CallFormFunction(incomingOrderForm, this);
            callFormFunction.OpenForm();
        }
        //���ʳ�
        private void purchasingOrderMenu_Click(object sender, EventArgs e)
        {
            PurchasingOrderForm purchasingOrderForm = new PurchasingOrderForm();
            CallFormFunction callFormFunction = new CallFormFunction(purchasingOrderForm, this);
            callFormFunction.OpenForm();
        }
        //�q�f��
        private void orderFormMenu_Click(object sender, EventArgs e)
        {
            OrderForm orderForm = new OrderForm();
            CallFormFunction callFormFunction = new CallFormFunction(orderForm, this);
            callFormFunction.OpenForm();
        }
        //�X�f�h�^��
        private void shipmentReturnOrderMenu_Click(object sender, EventArgs e)
        {
            ShipmentReturnOrderForm shipmentReturnOrderForm = new ShipmentReturnOrderForm();
            CallFormFunction callFormFunction = new CallFormFunction(shipmentReturnOrderForm, this);
            callFormFunction.OpenForm();
        }
        //�i�f�h�X��
        private void incomingOutgoingOrderMenu_Click(object sender, EventArgs e)
        {
            IncomingOutgoingOrderForm incomingOutgoingOrderForm = new IncomingOutgoingOrderForm();
            CallFormFunction callFormFunction = new CallFormFunction(incomingOutgoingOrderForm, this);
            callFormFunction.OpenForm();
        }
        //�`�i�f�B
        private void totalPurchasesMenu_Click(object sender, EventArgs e)
        {
            TotalPurchasesForm totalPurchasesForm = new TotalPurchasesForm();
            CallFormFunction callFormFunction = new CallFormFunction(totalPurchasesForm, this);
            callFormFunction.OpenForm();
        }
        //�`�P�f�B
        private void totalSalesMenu_Click(object sender, EventArgs e)
        {
            TotalSalesForm totalSalesForm = new TotalSalesForm();
            CallFormFunction callFormFunction = new CallFormFunction(totalSalesForm, this);
            callFormFunction.OpenForm();
        }
        //�����b��
        private void accountsReceivableMenu_Click(object sender, EventArgs e)
        {
            AccountsReceivableForm accountsReceivableForm = new AccountsReceivableForm();
            CallFormFunction callFormFunction = new CallFormFunction(accountsReceivableForm, this);
            callFormFunction.OpenForm();
        }
        //���
        private void specialManufacturerTool_Click(object sender, EventArgs e)
        {
            SpecialManufacturerForm specialManufacturerForm = new SpecialManufacturerForm();
            CallFormFunction callFormFunction = new CallFormFunction(specialManufacturerForm, this);
            callFormFunction.OpenForm();
        }

        private void productInformationDetailTool_Click(object sender, EventArgs e)
        {
            ProductDetailForm productInformationDetailForm = new ProductDetailForm();
            CallFormFunction callFormFunction = new CallFormFunction(productInformationDetailForm, this);
            callFormFunction.OpenForm();
        }

        private void customerInformationDetailTool_Click(object sender, EventArgs e)
        {
            CustomerDetailForm customerInformationDetailForm = new CustomerDetailForm();
            CallFormFunction callFormFunction = new CallFormFunction(customerInformationDetailForm, this);
            callFormFunction.OpenForm();
        }

        private void manufacturerInformationDetailTool_Click(object sender, EventArgs e)
        {
            FactoryDetailForm factoryDetailForm = new FactoryDetailForm();
            CallFormFunction callFormFunction = new CallFormFunction(factoryDetailForm, this);
            callFormFunction.OpenForm();
        }

        private void suggestPriceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SuggestPriceForm suggestPriceForm = new SuggestPriceForm();
            CallFormFunction callFormFunction = new CallFormFunction(suggestPriceForm, this);
            callFormFunction.OpenForm();
        }

        private void printListOfItemsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PrintListOfItemForm printListOfItemForm = new PrintListOfItemForm();
            CallFormFunction callFormFunction = new CallFormFunction(printListOfItemForm, this);
            callFormFunction.OpenForm();
        }
    }
}