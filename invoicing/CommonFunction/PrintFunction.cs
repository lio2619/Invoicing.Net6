using invoicing.InsideModels;
using invoicing.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.VisualBasic;
using System.Drawing.Printing;

namespace invoicing.CommonFunction
{
    internal class PrintFunction
    {
        private readonly string _name = "";
        private readonly string _contactPhone = "";
        private readonly string _faxPhone = "";
        private int[] _width = new int[] { 20, 135, 520, 575, 625, 680, 750 };
        private string[] _order = new string[] { "進貨退出單", "進貨單" };
        public PrintFunction() { }
        /// <summary>
        /// 選擇列印幾份
        /// </summary>
        /// <param name="printPreviewDialog"></param>
        /// <param name="printDocument"></param>
        public void ChoosePrintPage(PrintPreviewDialog printPreviewDialog, PrintDocument printDocument)
        {
            printPreviewDialog.Document = printDocument;
            try
            {
                short s = short.Parse(Interaction.InputBox("請輸入要印幾份", "標題", "1", -1, -1));
                printDocument.PrinterSettings.Copies = s;
            }
            catch (FormatException)
            {
                return;
            }
            printPreviewDialog.ShowDialog();
        }
        /// <summary>
        /// 一般單子列印
        /// </summary>
        /// <param name="productDetailData"></param>
        /// <param name="e"></param>
        /// <param name="dateTimePicker"></param>
        /// <param name="storeName"></param>
        /// <param name="orderNumber"></param>
        /// <param name="order"></param>
        /// <param name="remark"></param>
        /// <param name="totalPrice"></param>
        /// <param name="page"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public void PrintPage(DataGridView productDetailData, PrintPageEventArgs e, DateTimePicker dateTimePicker, string storeName, string orderNumber
                                        , string order, string remark, string totalPrice, int page, int start, int end)
        {
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Far;
            int high = 195;
            int totalPage = ((productDetailData.RowCount - 1) / 40) + 1;
            string fullOrderNumber = dateTimePicker.Value.ToString("yyyyMMdd") + orderNumber.PadLeft(3, '0');
            using (InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                var customerDetail = dbContext.Customers.Where(x => x.CustomerName == storeName)
                                            .Select(y => new { y.ContactPhoneNumberOne, y.FaxNumber, y.DeliveryAddress }).AsNoTracking().FirstOrDefault();
                PrintHeaderSetting(e, dateTimePicker, order, storeName, fullOrderNumber, customerDetail.ContactPhoneNumberOne, customerDetail.FaxNumber
                                        , customerDetail.DeliveryAddress, page, totalPage);
                start = PrintInsideSetting(e, productDetailData, stringFormat, high, start, end, order);
                bool halfPage = (start % 41) > 16;   //如果小於16就是半頁
                PrintLastSetting(e, remark, decimal.Round(Convert.ToDecimal(totalPrice), 2), halfPage);
            }
        }
        private void PrintHeaderSetting(PrintPageEventArgs e, DateTimePicker dateTimePicker, string order, string storeName, string fullOrderNameber
                                                , string tex, string fax, string address, int page, int totalPage)
        {
            string date = dateTimePicker.Text.ToString();
            if (_order.Contains(order))
            {
                e.Graphics.DrawString(_name, new Font("Arial", 22), Brushes.Black, new Point(20, 20));
                e.Graphics.DrawString(order, new Font("Arial", 22), Brushes.Black, new Point(560, 20));
                e.Graphics.DrawString(_contactPhone, new Font("Arial", 12), Brushes.Black, new Point(20, 60));
                e.Graphics.DrawString(_faxPhone, new Font("Arial", 12), Brushes.Black, new Point(250, 60));
                e.Graphics.DrawString($"頁次：{page}/{totalPage}", new Font("Arial", 12), Brushes.Black, new Point(560, 60));
                e.Graphics.DrawString($"廠商名稱：{storeName}", new Font("Arial", 12), Brushes.Black, new Point(20, 90));
                e.Graphics.DrawString($"貨單日期：{date}", new Font("Arial", 12), Brushes.Black, new Point(560, 90));
                e.Graphics.DrawString($"連絡電話：{tex}", new Font("Arial", 12), Brushes.Black, new Point(20, 120));
                e.Graphics.DrawString($"傳真號碼：{fax}", new Font("Arial", 12), Brushes.Black, new Point(250, 120));
                e.Graphics.DrawString($"貨單編號：{fullOrderNameber}", new Font("Arial", 12), Brushes.Black, new Point(560, 120));
                e.Graphics.DrawString($"送貨地址：{address}", new Font("Arial", 12), Brushes.Black, new Point(20, 150));
                Pen black = new Pen(Color.Black);
                PointF point1 = new PointF(20, 170);
                PointF point2 = new PointF(790, 170);
                e.Graphics.DrawLine(black, point1, point2);
                e.Graphics.DrawString("編號", new Font("Arial", 12), Brushes.Black, new Point(20, 170));
                e.Graphics.DrawString("品名", new Font("Arial", 12), Brushes.Black, new Point(140, 170));
                e.Graphics.DrawString("數量", new Font("Arial", 12), Brushes.Black, new Point(490, 170));
                e.Graphics.DrawString("單位", new Font("Arial", 12), Brushes.Black, new Point(540, 170));
                e.Graphics.DrawString("單價", new Font("Arial", 12), Brushes.Black, new Point(590, 170));
                e.Graphics.DrawString("金額", new Font("Arial", 12), Brushes.Black, new Point(640, 170));
                e.Graphics.DrawString("建議售價", new Font("Arial", 12), Brushes.Black, new Point(700, 170));
                PointF point3 = new PointF(20, 190);
                PointF point4 = new PointF(790, 190);
                e.Graphics.DrawLine(black, point3, point4);
            }
            else if (order == "採購單")
            {
                e.Graphics.DrawString(_name, new Font("Arial", 22), Brushes.Black, new Point(20, 20));
                e.Graphics.DrawString(order, new Font("Arial", 22), Brushes.Black, new Point(560, 20));
                e.Graphics.DrawString(_contactPhone, new Font("Arial", 12), Brushes.Black, new Point(20, 60));
                e.Graphics.DrawString(_faxPhone, new Font("Arial", 12), Brushes.Black, new Point(250, 60));
                e.Graphics.DrawString($"頁次：{page}/{totalPage}", new Font("Arial", 12), Brushes.Black, new Point(560, 60));
                e.Graphics.DrawString($"廠商名稱：{storeName}", new Font("Arial", 12), Brushes.Black, new Point(20, 90));
                e.Graphics.DrawString($"貨單日期：{date}", new Font("Arial", 12), Brushes.Black, new Point(560, 90));
                e.Graphics.DrawString($"連絡電話：{tex}", new Font("Arial", 12), Brushes.Black, new Point(20, 120));
                e.Graphics.DrawString($"傳真號碼：{fax}", new Font("Arial", 12), Brushes.Black, new Point(250, 120));
                e.Graphics.DrawString($"貨單編號：{fullOrderNameber}", new Font("Arial", 12), Brushes.Black, new Point(560, 120));
                e.Graphics.DrawString($"送貨地址：{address}", new Font("Arial", 12), Brushes.Black, new Point(20, 150));
                Pen black = new Pen(Color.Black);
                PointF point1 = new PointF(20, 170);
                PointF point2 = new PointF(790, 170);
                e.Graphics.DrawLine(black, point1, point2);
                e.Graphics.DrawString("編號", new Font("Arial", 12), Brushes.Black, new Point(20, 170));
                e.Graphics.DrawString("品名", new Font("Arial", 12), Brushes.Black, new Point(140, 170));
                e.Graphics.DrawString("數量", new Font("Arial", 12), Brushes.Black, new Point(490, 170));
                e.Graphics.DrawString("單位", new Font("Arial", 12), Brushes.Black, new Point(540, 170));
                e.Graphics.DrawString("備註", new Font("Arial", 12), Brushes.Black, new Point(640, 170));
                PointF point3 = new PointF(20, 190);
                PointF point4 = new PointF(790, 190);
                e.Graphics.DrawLine(black, point3, point4);
            }
            else
            {
                e.Graphics.DrawString(_name, new Font("Arial", 22), Brushes.Black, new Point(20, 20));
                e.Graphics.DrawString(order, new Font("Arial", 22), Brushes.Black, new Point(560, 20));
                e.Graphics.DrawString(_contactPhone, new Font("Arial", 12), Brushes.Black, new Point(20, 60));
                e.Graphics.DrawString(_faxPhone, new Font("Arial", 12), Brushes.Black, new Point(250, 60));
                e.Graphics.DrawString($"頁次：{page}/{totalPage}", new Font("Arial", 12), Brushes.Black, new Point(560, 60));
                e.Graphics.DrawString($"客戶名稱：{storeName}", new Font("Arial", 12), Brushes.Black, new Point(20, 90));
                e.Graphics.DrawString($"貨單日期：{date}", new Font("Arial", 12), Brushes.Black, new Point(560, 90));
                e.Graphics.DrawString($"連絡電話：{tex}", new Font("Arial", 12), Brushes.Black, new Point(20, 120));
                e.Graphics.DrawString($"傳真號碼：{fax}", new Font("Arial", 12), Brushes.Black, new Point(250, 120));
                e.Graphics.DrawString($"貨單編號：{fullOrderNameber}", new Font("Arial", 12), Brushes.Black, new Point(560, 120));
                e.Graphics.DrawString($"送貨地址：{address}", new Font("Arial", 12), Brushes.Black, new Point(20, 150));
                Pen black = new Pen(Color.Black);
                PointF point1 = new PointF(20, 170);
                PointF point2 = new PointF(790, 170);
                e.Graphics.DrawLine(black, point1, point2);
                e.Graphics.DrawString("編號", new Font("Arial", 12), Brushes.Black, new Point(20, 170));
                e.Graphics.DrawString("品名", new Font("Arial", 12), Brushes.Black, new Point(140, 170));
                e.Graphics.DrawString("數量", new Font("Arial", 12), Brushes.Black, new Point(490, 170));
                e.Graphics.DrawString("單位", new Font("Arial", 12), Brushes.Black, new Point(540, 170));
                e.Graphics.DrawString("單價", new Font("Arial", 12), Brushes.Black, new Point(590, 170));
                e.Graphics.DrawString("金額", new Font("Arial", 12), Brushes.Black, new Point(640, 170));
                e.Graphics.DrawString("建議售價", new Font("Arial", 12), Brushes.Black, new Point(700, 170));
                PointF point3 = new PointF(20, 190);
                PointF point4 = new PointF(790, 190);
                e.Graphics.DrawLine(black, point3, point4);
            }
        }
        private int PrintInsideSetting(PrintPageEventArgs e, DataGridView productDetailData, StringFormat stringFormat, int high, int start, int end, string order)
        {
            for (; start < end; start++)
            {
                if (start % 5 == 0 && start != 0 && start % 40 != 0)
                {
                    Pen black = new Pen(Color.Black);
                    PointF point1 = new PointF(20, high);
                    PointF point2 = new PointF(790, high);
                    e.Graphics.DrawLine(black, point1, point2);
                }
                if (start >= productDetailData.RowCount) return start;
                for (int j = 0; j < productDetailData.ColumnCount - 1; j++)
                {
                    if (order == "採購單")
                    {
                        if (j > 1)
                        {
                            int[] width = new int[] { 20, 135, 520, 575, 680, 750 };
                            e.Graphics.DrawString(productDetailData.Rows[start].Cells[j].Value?.ToString() ?? "", new Font("Arial", 10), Brushes.Black, new Point(width[j], high), stringFormat);
                        }
                        else
                        {
                            e.Graphics.DrawString(productDetailData.Rows[start].Cells[j].Value?.ToString() ?? "", new Font("Arial", 10), Brushes.Black, new Point(_width[j], high));
                        }
                    }
                    else
                    {
                        if (j > 1)
                        {
                            e.Graphics.DrawString(productDetailData.Rows[start].Cells[j].Value?.ToString() ?? "", new Font("Arial", 10), Brushes.Black, new Point(_width[j], high), stringFormat);
                        }
                        else
                        {
                            e.Graphics.DrawString(productDetailData.Rows[start].Cells[j].Value?.ToString() ?? "", new Font("Arial", 10), Brushes.Black, new Point(_width[j], high));
                        }
                    }
                }
                high += 20;
            }
            return start;
        }
        private void PrintLastSetting(PrintPageEventArgs e, string remark, decimal totalPrice, bool halfPage)
        {
            if (halfPage)
            {
                Pen black = new Pen(Color.Black);
                PointF point1 = new PointF(20, 1010);
                PointF point2 = new PointF(790, 1010);
                e.Graphics.DrawLine(black, point1, point2);
                e.Graphics.DrawString($"備註：{remark}", new Font("Arial", 12), Brushes.Black, new Point(20, 1020));
                e.Graphics.DrawString($"總計：{totalPrice}", new Font("Arial", 12), Brushes.Black, new Point(640, 1020));
            }
            else
            {
                Pen black = new Pen(Color.Black);
                PointF point1 = new PointF(20, 500);
                PointF point2 = new PointF(790, 500);
                e.Graphics.DrawLine(black, point1, point2);
                e.Graphics.DrawString($"備註：{remark}", new Font("Arial", 12), Brushes.Black, new Point(20, 510));
                e.Graphics.DrawString($"總計：{totalPrice}", new Font("Arial", 12), Brushes.Black, new Point(640, 510));
            }
        }
        /// <summary>
        /// 應收帳款列印
        /// </summary>
        /// <param name="e"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="orders"></param>
        /// <param name="storeName"></param>
        /// <param name="totalPrice"></param>
        /// <param name="taxes"></param>
        public void PrintCollectMoneyPage(PrintPageEventArgs e, DateOnly startDate, DateOnly endDate, string[] orders, string storeName, string totalPrice, decimal taxes)
        {
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Far;
            int high = 165;
            PrintCollectMoneyHeaderSetting(e, startDate, endDate, storeName);
            high = PrintCollectMoneyInsideSetting(e, stringFormat, startDate, endDate, orders, storeName, high);
            PrintCollectMoneyLastSetting(e, stringFormat, totalPrice, taxes, high);
        }
        private void PrintCollectMoneyHeaderSetting(PrintPageEventArgs e, DateOnly startDate, DateOnly endDate, string storeName)
        {
            e.Graphics.DrawString($"{_name}", new Font("Arial", 20), Brushes.Black, new Point(320, 20));
            e.Graphics.DrawString("應收帳款簡要表", new Font("Arial", 16), Brushes.Black, new Point(325, 60));
            e.Graphics.DrawString($"帳款區間：{startDate} ~ {endDate}", new Font("Arial", 12), Brushes.Black, new Point(20, 80));
            e.Graphics.DrawString($"客戶名稱：{storeName}", new Font("Arial", 12), Brushes.Black, new Point(20, 110));
            e.Graphics.DrawString("單別", new Font("Arial", 12), Brushes.Black, new Point(70, 140));
            e.Graphics.DrawString("交易日期", new Font("Arial", 12), Brushes.Black, new Point(140, 140));
            e.Graphics.DrawString("交易單號", new Font("Arial", 12), Brushes.Black, new Point(260, 140));
            e.Graphics.DrawString("合計金額", new Font("Arial", 12), Brushes.Black, new Point(550, 140));
            e.Graphics.DrawString("總計金額", new Font("Arial", 12), Brushes.Black, new Point(650, 140));
            Pen black = new Pen(Color.Black);
            PointF point1 = new PointF(20, 160);
            PointF point2 = new PointF(790, 160);
            e.Graphics.DrawLine(black, point1, point2);
        }
        private int PrintCollectMoneyInsideSetting(PrintPageEventArgs e, StringFormat stringFormat, DateOnly startDate, DateOnly endDate, string[] orders, string storeName, int high)
        {
            using (InvoicingDbContext dbContext = new InvoicingDbContext())
            {
                var response = dbContext.Allsheetstoragecustomers
                                    .Where(x => x.Customer == storeName && x.Date >= startDate && x.Date <= endDate && x.Delete == 0 && orders.Contains(x.Order))
                                    .OrderBy(y => y.Order).AsNoTracking().ToList();
                foreach (var item in response)
                {
                    e.Graphics.DrawString(item.Order, new Font("Arial", 12), Brushes.Black, new Point(120, high), stringFormat);
                    e.Graphics.DrawString(item.Date.ToString("yyyyMMdd"), new Font("Arial", 12), Brushes.Black, new Point(220, high), stringFormat);
                    e.Graphics.DrawString(item.Date.ToString("yyyyMMdd") + item.OrderNumber.PadLeft(3, '0'), new Font("Arial", 12), Brushes.Black, new Point(365, high), stringFormat);
                    if (item.Order == "出貨退出單")
                    {
                        e.Graphics.DrawString($"-{decimal.Round(item.OrderTotalPrice)}", new Font("Arial", 12), Brushes.Black, new Point(620, high), stringFormat);
                        e.Graphics.DrawString($"-{decimal.Round(item.OrderTotalPrice)}", new Font("Arial", 12), Brushes.Black, new Point(720, high), stringFormat);
                    }
                    else
                    {
                        e.Graphics.DrawString($"{decimal.Round(item.OrderTotalPrice)}", new Font("Arial", 12), Brushes.Black, new Point(620, high), stringFormat);
                        e.Graphics.DrawString($"{decimal.Round(item.OrderTotalPrice)}", new Font("Arial", 12), Brushes.Black, new Point(720, high), stringFormat);
                    }
                    high += 20;
                }
            }
            return high;
        }
        private void PrintCollectMoneyLastSetting(PrintPageEventArgs e, StringFormat stringFormat, string totalPrice, decimal taxes, int high)
        {
            Pen black = new Pen(Color.Black);
            PointF point1 = new PointF(20, high);
            PointF point2 = new PointF(790, high);
            e.Graphics.DrawLine(black, point1, point2);
            high += 10;
            e.Graphics.DrawString("本期合計：", new Font("Arial", 12), Brushes.Black, new Point(530, high));
            e.Graphics.DrawString(totalPrice, new Font("Arial", 12), Brushes.Black, new Point(720, high), stringFormat);
            high += 20;
            e.Graphics.DrawString("營業稅：", new Font("Arial", 12), Brushes.Black, new Point(530, high));
            e.Graphics.DrawString(taxes.ToString(), new Font("Arial", 12), Brushes.Black, new Point(720, high), stringFormat);
            high += 20;
            decimal cost = decimal.Parse(totalPrice) + taxes;
            e.Graphics.DrawString("本期總計：", new Font("Arial", 12), Brushes.Black, new Point(530, high));
            e.Graphics.DrawString(cost.ToString(), new Font("Arial", 12), Brushes.Black, new Point(720, high), stringFormat);
        }
        /// <summary>
        /// 出貨貨品清單列印
        /// </summary>
        /// <param name="e"></param>
        /// <param name="startDate"></param>
        /// <param name="endDate"></param>
        /// <param name="listOfItems"></param>
        /// <param name="storeName"></param>
        /// <param name="totalPrice"></param>
        /// <param name="start"></param>
        /// <param name="end"></param>
        public void PrintListOfItem(PrintPageEventArgs e, DateOnly startDate, DateOnly endDate, List<ListOfItems> listOfItems, string storeName
            , string totalPrice, int start, int end)
        {
            PrintListOfItemHeaderSetting(e, startDate, endDate, storeName);
            int high = PrintListOfItemInsideSetting(e, listOfItems, start, end);
            PrintListOfItemLastSetting(e, totalPrice, high);
        }
        private void PrintListOfItemHeaderSetting(PrintPageEventArgs e, DateOnly startDate, DateOnly endDate, string storeName)
        {
            e.Graphics.DrawString($"{_name}", new Font("Arial", 12), Brushes.Black, new Point(320, 20));
            e.Graphics.DrawString($"時間：{startDate} ~ {endDate}", new Font("Arial", 10), Brushes.Black, new Point(20, 60));
            e.Graphics.DrawString($"客戶名稱：{storeName}", new Font("Arial", 10), Brushes.Black, new Point(550, 60));
            e.Graphics.DrawString("貨品編號", new Font("Arial", 8), Brushes.Black, new Point(20, 90));
            e.Graphics.DrawString("品名", new Font("Arial", 8), Brushes.Black, new Point(105, 90));
            e.Graphics.DrawString("數量", new Font("Arial", 8), Brushes.Black, new Point(350, 90));
            e.Graphics.DrawString("貨品編號", new Font("Arial", 8), Brushes.Black, new Point(400, 90));
            e.Graphics.DrawString("品名", new Font("Arial", 8), Brushes.Black, new Point(480, 90));
            e.Graphics.DrawString("數量", new Font("Arial", 8), Brushes.Black, new Point(730, 90));
            Pen black = new Pen(Color.Black);
            PointF point1 = new PointF(20, 80);
            PointF point2 = new PointF(790, 80);
            e.Graphics.DrawLine(black, point1, point2);
        }
        private int PrintListOfItemInsideSetting(PrintPageEventArgs e, List<ListOfItems> listOfItems, int start, int end)
        {
            StringFormat stringFormat = new StringFormat();
            stringFormat.Alignment = StringAlignment.Far;
            int high = 105;
            for(int i = start; i <= end; i++)
            {
                var listOfItem = listOfItems[i];
                if(i % 2 == 1)
                {
                    e.Graphics.DrawString(listOfItem.ItemNumber, new Font("Arial", 8), Brushes.Black, new Point(20, high));
                    e.Graphics.DrawString(listOfItem.ItemName, new Font("Arial", 8), Brushes.Black, new Point(100, high));
                    e.Graphics.DrawString(listOfItem.Quantity, new Font("Arial", 8), Brushes.Black, new Point(370, high), stringFormat);
                }
                else
                {
                    e.Graphics.DrawString(listOfItem.ItemNumber, new Font("Arial", 8), Brushes.Black, new Point(400, high));
                    e.Graphics.DrawString(listOfItem.ItemName, new Font("Arial", 8), Brushes.Black, new Point(485, high));
                    e.Graphics.DrawString(listOfItem.Quantity, new Font("Arial", 8), Brushes.Black, new Point(750, high), stringFormat);
                    high += 15;
                }
            }
            return high;
        }
        private void PrintListOfItemLastSetting(PrintPageEventArgs e, string totalPrice, int high)
        {
            high += 15;
            e.Graphics.DrawString($"總金額：{totalPrice}", new Font("Arial", 8), Brushes.Black, new Point(630, high));
        }
    }
}
