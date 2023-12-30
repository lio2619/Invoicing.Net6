using System;
using System.Collections.Generic;

namespace invoicing.Models;

/// <summary>
/// 貨品主檔
/// </summary>
public partial class Merchandisemasterfile
{
    /// <summary>
    /// 貨品編號
    /// </summary>
    public string ItemNumber { get; set; } = null!;

    /// <summary>
    /// 品名
    /// </summary>
    public string? ItemName { get; set; }

    /// <summary>
    /// 基本單位
    /// </summary>
    public string? Unit { get; set; }

    /// <summary>
    /// 標準售價
    /// </summary>
    public double? StandardPrice { get; set; }

    /// <summary>
    /// 售價A
    /// </summary>
    public double? PriceA { get; set; }

    /// <summary>
    /// 售價B
    /// </summary>
    public double? PriceB { get; set; }

    /// <summary>
    /// 售價C
    /// </summary>
    public double? PriceC { get; set; }

    /// <summary>
    /// 售價D
    /// </summary>
    public double? PriceD { get; set; }

    /// <summary>
    /// 售價E
    /// </summary>
    public double? PriceE { get; set; }

    /// <summary>
    /// 標準成本
    /// </summary>
    public double? StandardCost { get; set; }

    /// <summary>
    /// 現行成本
    /// </summary>
    public double? ExistingCost { get; set; }
}
