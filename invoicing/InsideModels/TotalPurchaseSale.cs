namespace invoicing.InsideModels
{
    public partial class TotalPurchaseSale
    {

        /// <summary>
        /// 客戶
        /// </summary>
        public string? Name { get; set; }

        /// <summary>
        /// 單子
        /// </summary>
        public string? Order { get; set; }

        /// <summary>
        /// 金額
        /// </summary>
        public string? Price { get; set; }
    }
}
