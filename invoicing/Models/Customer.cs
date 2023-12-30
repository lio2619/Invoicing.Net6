using System;
using System.Collections.Generic;

namespace invoicing.Models;

/// <summary>
/// 客戶
/// </summary>
public partial class Customer
{
    /// <summary>
    /// 流水號
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// 客戶全名
    /// </summary>
    public string CustomerName { get; set; } = null!;

    /// <summary>
    /// 發票抬頭
    /// </summary>
    public string? InvoicePayment { get; set; }

    /// <summary>
    /// 統一編號
    /// </summary>
    public string? UniformNumber { get; set; }

    /// <summary>
    /// 聯絡人一
    /// </summary>
    public string? ContactPerson { get; set; }

    /// <summary>
    /// 聯絡電話一
    /// </summary>
    public string? ContactPhoneNumberOne { get; set; }

    /// <summary>
    /// 聯絡電話二
    /// </summary>
    public string? ContactPhoneNumberTwo { get; set; }

    /// <summary>
    /// 傳真電話
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
    /// 送貨地址郵遞區號
    /// </summary>
    public string? DeliveryAddressZipCode { get; set; }

    /// <summary>
    /// 0：沒刪1：刪除
    /// </summary>
    public sbyte Delete { get; set; }
}
