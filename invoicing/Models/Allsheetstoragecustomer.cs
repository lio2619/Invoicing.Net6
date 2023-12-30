using System;
using System.Collections.Generic;

namespace invoicing.Models;

/// <summary>
/// 整張儲存_客戶
/// </summary>
public partial class Allsheetstoragecustomer
{
    /// <summary>
    /// 單子編號
    /// </summary>
    public string OrderNumber { get; set; } = null!;

    /// <summary>
    /// 日期
    /// </summary>
    public DateOnly Date { get; set; }

    /// <summary>
    /// 客戶
    /// </summary>
    public string? Customer { get; set; }

    /// <summary>
    /// 單子
    /// </summary>
    public string? Order { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 總計
    /// </summary>
    public decimal OrderTotalPrice { get; set; }

    /// <summary>
    /// 0：沒刪1：刪除
    /// </summary>
    public sbyte Delete { get; set; }
}
