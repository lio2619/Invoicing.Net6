namespace invoicing.InsideModels
{
    public class ListOfItems
    {
        /// <summary>
        /// 貨品編號
        /// </summary>
        public string? ItemNumber { get; set; }

        /// <summary>
        /// 貨品名稱
        /// </summary>
        public string? ItemName { get; set; }
        /// <summary>
        /// 數量
        /// </summary>
        public string? Quantity { get; set; }
    }
}
