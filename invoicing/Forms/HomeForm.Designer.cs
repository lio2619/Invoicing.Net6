namespace invoicing
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeForm));
            menuStrip1 = new MenuStrip();
            customerInformationMenu = new ToolStripMenuItem();
            customerInformationTool = new ToolStripMenuItem();
            customerInformationDetailTool = new ToolStripMenuItem();
            productInformationMenu = new ToolStripMenuItem();
            productInformationTool = new ToolStripMenuItem();
            productInformationDetailTool = new ToolStripMenuItem();
            manufacturerInformationMenu = new ToolStripMenuItem();
            manufacturerInformationTool = new ToolStripMenuItem();
            manufacturerInformationDetailTool = new ToolStripMenuItem();
            shippingOrderMenu = new ToolStripMenuItem();
            IncomingOrderMenu = new ToolStripMenuItem();
            purchasingOrderMenu = new ToolStripMenuItem();
            orderFormMenu = new ToolStripMenuItem();
            shipmentReturnOrderMenu = new ToolStripMenuItem();
            incomingOutgoingOrderMenu = new ToolStripMenuItem();
            totalPurchasesMenu = new ToolStripMenuItem();
            totalSalesMenu = new ToolStripMenuItem();
            accountsReceivableMenu = new ToolStripMenuItem();
            plugInMenu = new ToolStripMenuItem();
            specialManufacturerTool = new ToolStripMenuItem();
            suggestPriceToolStripMenuItem = new ToolStripMenuItem();
            printListOfItemsToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { customerInformationMenu, productInformationMenu, manufacturerInformationMenu, shippingOrderMenu, IncomingOrderMenu, purchasingOrderMenu, orderFormMenu, shipmentReturnOrderMenu, incomingOutgoingOrderMenu, totalPurchasesMenu, totalSalesMenu, accountsReceivableMenu, plugInMenu, suggestPriceToolStripMenuItem, printListOfItemsToolStripMenuItem });
            resources.ApplyResources(menuStrip1, "menuStrip1");
            menuStrip1.Name = "menuStrip1";
            // 
            // customerInformationMenu
            // 
            customerInformationMenu.DropDownItems.AddRange(new ToolStripItem[] { customerInformationTool, customerInformationDetailTool });
            customerInformationMenu.Name = "customerInformationMenu";
            resources.ApplyResources(customerInformationMenu, "customerInformationMenu");
            // 
            // customerInformationTool
            // 
            customerInformationTool.Name = "customerInformationTool";
            resources.ApplyResources(customerInformationTool, "customerInformationTool");
            customerInformationTool.Click += customerInformationTool_Click;
            // 
            // customerInformationDetailTool
            // 
            customerInformationDetailTool.Name = "customerInformationDetailTool";
            resources.ApplyResources(customerInformationDetailTool, "customerInformationDetailTool");
            customerInformationDetailTool.Click += customerInformationDetailTool_Click;
            // 
            // productInformationMenu
            // 
            productInformationMenu.DropDownItems.AddRange(new ToolStripItem[] { productInformationTool, productInformationDetailTool });
            productInformationMenu.Name = "productInformationMenu";
            resources.ApplyResources(productInformationMenu, "productInformationMenu");
            // 
            // productInformationTool
            // 
            productInformationTool.Name = "productInformationTool";
            resources.ApplyResources(productInformationTool, "productInformationTool");
            productInformationTool.Click += productInformationTool_Click;
            // 
            // productInformationDetailTool
            // 
            productInformationDetailTool.Name = "productInformationDetailTool";
            resources.ApplyResources(productInformationDetailTool, "productInformationDetailTool");
            productInformationDetailTool.Click += productInformationDetailTool_Click;
            // 
            // manufacturerInformationMenu
            // 
            manufacturerInformationMenu.DropDownItems.AddRange(new ToolStripItem[] { manufacturerInformationTool, manufacturerInformationDetailTool });
            manufacturerInformationMenu.Name = "manufacturerInformationMenu";
            resources.ApplyResources(manufacturerInformationMenu, "manufacturerInformationMenu");
            // 
            // manufacturerInformationTool
            // 
            manufacturerInformationTool.Name = "manufacturerInformationTool";
            resources.ApplyResources(manufacturerInformationTool, "manufacturerInformationTool");
            manufacturerInformationTool.Click += manufacturerInformationTool_Click;
            // 
            // manufacturerInformationDetailTool
            // 
            manufacturerInformationDetailTool.Name = "manufacturerInformationDetailTool";
            resources.ApplyResources(manufacturerInformationDetailTool, "manufacturerInformationDetailTool");
            manufacturerInformationDetailTool.Click += manufacturerInformationDetailTool_Click;
            // 
            // shippingOrderMenu
            // 
            shippingOrderMenu.Name = "shippingOrderMenu";
            resources.ApplyResources(shippingOrderMenu, "shippingOrderMenu");
            shippingOrderMenu.Click += shippingOrderMenu_Click;
            // 
            // IncomingOrderMenu
            // 
            IncomingOrderMenu.Name = "IncomingOrderMenu";
            resources.ApplyResources(IncomingOrderMenu, "IncomingOrderMenu");
            IncomingOrderMenu.Click += IncomingOrderMenu_Click;
            // 
            // purchasingOrderMenu
            // 
            purchasingOrderMenu.Name = "purchasingOrderMenu";
            resources.ApplyResources(purchasingOrderMenu, "purchasingOrderMenu");
            purchasingOrderMenu.Click += purchasingOrderMenu_Click;
            // 
            // orderFormMenu
            // 
            orderFormMenu.Name = "orderFormMenu";
            resources.ApplyResources(orderFormMenu, "orderFormMenu");
            orderFormMenu.Click += orderFormMenu_Click;
            // 
            // shipmentReturnOrderMenu
            // 
            shipmentReturnOrderMenu.Name = "shipmentReturnOrderMenu";
            resources.ApplyResources(shipmentReturnOrderMenu, "shipmentReturnOrderMenu");
            shipmentReturnOrderMenu.Click += shipmentReturnOrderMenu_Click;
            // 
            // incomingOutgoingOrderMenu
            // 
            incomingOutgoingOrderMenu.Name = "incomingOutgoingOrderMenu";
            resources.ApplyResources(incomingOutgoingOrderMenu, "incomingOutgoingOrderMenu");
            incomingOutgoingOrderMenu.Click += incomingOutgoingOrderMenu_Click;
            // 
            // totalPurchasesMenu
            // 
            totalPurchasesMenu.Name = "totalPurchasesMenu";
            resources.ApplyResources(totalPurchasesMenu, "totalPurchasesMenu");
            totalPurchasesMenu.Click += totalPurchasesMenu_Click;
            // 
            // totalSalesMenu
            // 
            totalSalesMenu.Name = "totalSalesMenu";
            resources.ApplyResources(totalSalesMenu, "totalSalesMenu");
            totalSalesMenu.Click += totalSalesMenu_Click;
            // 
            // accountsReceivableMenu
            // 
            accountsReceivableMenu.Name = "accountsReceivableMenu";
            resources.ApplyResources(accountsReceivableMenu, "accountsReceivableMenu");
            accountsReceivableMenu.Click += accountsReceivableMenu_Click;
            // 
            // plugInMenu
            // 
            plugInMenu.DropDownItems.AddRange(new ToolStripItem[] { specialManufacturerTool });
            plugInMenu.Name = "plugInMenu";
            resources.ApplyResources(plugInMenu, "plugInMenu");
            // 
            // specialManufacturerTool
            // 
            specialManufacturerTool.Name = "specialManufacturerTool";
            resources.ApplyResources(specialManufacturerTool, "specialManufacturerTool");
            specialManufacturerTool.Click += specialManufacturerTool_Click;
            // 
            // suggestPriceToolStripMenuItem
            // 
            suggestPriceToolStripMenuItem.Name = "suggestPriceToolStripMenuItem";
            resources.ApplyResources(suggestPriceToolStripMenuItem, "suggestPriceToolStripMenuItem");
            suggestPriceToolStripMenuItem.Click += suggestPriceToolStripMenuItem_Click;
            // 
            // printListOfItemsToolStripMenuItem
            // 
            printListOfItemsToolStripMenuItem.Name = "printListOfItemsToolStripMenuItem";
            resources.ApplyResources(printListOfItemsToolStripMenuItem, "printListOfItemsToolStripMenuItem");
            printListOfItemsToolStripMenuItem.Click += printListOfItemsToolStripMenuItem_Click;
            // 
            // HomeForm
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "HomeForm";
            WindowState = FormWindowState.Maximized;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem customerInformationMenu;
        private ToolStripMenuItem customerInformationTool;
        private ToolStripMenuItem customerInformationDetailTool;
        private ToolStripMenuItem productInformationMenu;
        private ToolStripMenuItem productInformationTool;
        private ToolStripMenuItem productInformationDetailTool;
        private ToolStripMenuItem manufacturerInformationMenu;
        private ToolStripMenuItem manufacturerInformationTool;
        private ToolStripMenuItem manufacturerInformationDetailTool;
        private ToolStripMenuItem shippingOrderMenu;
        private ToolStripMenuItem IncomingOrderMenu;
        private ToolStripMenuItem purchasingOrderMenu;
        private ToolStripMenuItem orderFormMenu;
        private ToolStripMenuItem shipmentReturnOrderMenu;
        private ToolStripMenuItem incomingOutgoingOrderMenu;
        private ToolStripMenuItem totalPurchasesMenu;
        private ToolStripMenuItem totalSalesMenu;
        private ToolStripMenuItem accountsReceivableMenu;
        private ToolStripMenuItem plugInMenu;
        private ToolStripMenuItem specialManufacturerTool;
        private ToolStripMenuItem suggestPriceToolStripMenuItem;
        private ToolStripMenuItem printListOfItemsToolStripMenuItem;
    }
}