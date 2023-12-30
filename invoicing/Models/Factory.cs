using System;
using System.Collections.Generic;

namespace invoicing.Models;

/// <summary>
/// 廠商
/// </summary>
public partial class Factory
{
    /// <summary>
    /// 流水號
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 公司全名
    /// </summary>
    public string FactoryName { get; set; } = null!;

    /// <summary>
    /// 公司簡稱
    /// </summary>
    public string? FactorAbbreviation { get; set; }

    /// <summary>
    /// 發票抬頭
    /// </summary>
    public string? InvoicePayment { get; set; }

    /// <summary>
    /// 統一編號
    /// </summary>
    public string? UniformNumber { get; set; }

    /// <summary>
    /// 負責人
    /// </summary>
    public string? ResponsiblePerson { get; set; }

    /// <summary>
    /// 聯絡人
    /// </summary>
    public string? ContactPerson { get; set; }

    /// <summary>
    /// 聯絡電話
    /// </summary>
    public string? ContactPhoneNumber { get; set; }

    /// <summary>
    /// 傳真號碼
    /// </summary>
    public string? FaxNumber { get; set; }

    /// <summary>
    /// 登記地址
    /// </summary>
    public string? RegisteredAddress { get; set; }

    /// <summary>
    /// 送貨地址
    /// </summary>
    public string? DeliveryAddress { get; set; }

    /// <summary>
    /// 帳單地址
    /// </summary>
    public string? BillingAddress { get; set; }

    /// <summary>
    /// 備註
    /// </summary>
    public string? Remark { get; set; }

    /// <summary>
    /// 0：沒刪1：刪除
    /// </summary>
    public sbyte Delete { get; set; }
}
