using System;
using System.Collections.Generic;

namespace invoicing.Models;

/// <summary>
/// 整張儲存
/// </summary>
public partial class Allsheetstorage
{
    /// <summary>
    /// 流水號
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 單子編號
    /// </summary>
    public string OrderNumber { get; set; } = null!;

    /// <summary>
    /// 日期
    /// </summary>
    public DateOnly? Date { get; set; }

    /// <summary>
    /// 貨品編號
    /// </summary>
    public string? ItemNumber { get; set; }

    /// <summary>
    /// 品名
    /// </summary>
    public string? ItemName { get; set; }

    /// <summary>
    /// 基本單位
    /// </summary>
    public string? Unit { get; set; }

    /// <summary>
    /// 數量
    /// </summary>
    public string? Quantity { get; set; }

    /// <summary>
    /// 單價
    /// </summary>
    public string? Price { get; set; }

    /// <summary>
    /// 金額
    /// </summary>
    public string? TotalPrice { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? Remark { get; set; }
}
