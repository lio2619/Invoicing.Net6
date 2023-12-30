using System;
using System.Collections.Generic;

namespace invoicing.Models;

/// <summary>
/// 標準售價與建議售價對照表
/// </summary>
public partial class Suggestprice
{
    /// <summary>
    /// 標準售價
    /// </summary>
    public decimal StandardPrice { get; set; }

    /// <summary>
    /// 建議售價
    /// </summary>
    public decimal RecommendedPrice { get; set; }
}
