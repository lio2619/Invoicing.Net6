using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace invoicing.Models;

public partial class InvoicingDbContext : DbContext
{
    public InvoicingDbContext()
    {
    }

    public InvoicingDbContext(DbContextOptions<InvoicingDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Allsheetstorage> Allsheetstorages { get; set; }

    public virtual DbSet<Allsheetstoragecustomer> Allsheetstoragecustomers { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<Factory> Factories { get; set; }

    public virtual DbSet<Merchandisemasterfile> Merchandisemasterfiles { get; set; }

    public virtual DbSet<Suggestprice> Suggestprices { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseMySql("server=127.0.0.1;port=3306;database=invoicing;user=root;password=", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.11.2-mariadb"));

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder
            .UseCollation("utf8mb4_general_ci")
            .HasCharSet("utf8mb4");

        modelBuilder.Entity<Allsheetstorage>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("allsheetstorage", tb => tb.HasComment("整張儲存"));

            entity.HasIndex(e => e.OrderNumber, "FK_allsheetstorage_allsheetstoragecustomer");

            entity.Property(e => e.Id)
                .HasComment("流水號")
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.Date)
                .HasComment("日期")
                .HasColumnName("date");
            entity.Property(e => e.ItemName)
                .HasMaxLength(60)
                .HasComment("品名");
            entity.Property(e => e.ItemNumber)
                .HasMaxLength(20)
                .HasComment("貨品編號");
            entity.Property(e => e.OrderNumber)
                .HasMaxLength(50)
                .HasDefaultValueSql("'0'")
                .HasComment("單子編號")
                .HasColumnName("orderNumber");
            entity.Property(e => e.Price)
                .HasMaxLength(50)
                .HasComment("單價")
                .HasColumnName("price");
            entity.Property(e => e.Quantity)
                .HasMaxLength(50)
                .HasComment("數量")
                .HasColumnName("quantity");
            entity.Property(e => e.Remark)
                .HasMaxLength(255)
                .HasComment("備註")
                .HasColumnName("remark");
            entity.Property(e => e.TotalPrice)
                .HasMaxLength(100)
                .HasComment("金額")
                .HasColumnName("totalPrice");
            entity.Property(e => e.Unit)
                .HasMaxLength(10)
                .HasComment("基本單位")
                .HasColumnName("unit");
        });

        modelBuilder.Entity<Allsheetstoragecustomer>(entity =>
        {
            entity.HasKey(e => new { e.OrderNumber, e.Date })
                .HasName("PRIMARY")
                .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

            entity.ToTable("allsheetstoragecustomer", tb => tb.HasComment("整張儲存_客戶"));

            entity.Property(e => e.OrderNumber)
                .HasMaxLength(50)
                .HasDefaultValueSql("'0'")
                .HasComment("單子編號")
                .HasColumnName("orderNumber");
            entity.Property(e => e.Date)
                .HasComment("日期")
                .HasColumnName("date");
            entity.Property(e => e.Customer)
                .HasMaxLength(100)
                .HasComment("客戶")
                .HasColumnName("customer");
            entity.Property(e => e.Delete)
                .HasComment("0：沒刪1：刪除")
                .HasColumnType("tinyint(4)")
                .HasColumnName("delete");
            entity.Property(e => e.Order)
                .HasMaxLength(50)
                .HasComment("單子")
                .HasColumnName("order");
            entity.Property(e => e.OrderTotalPrice)
                .HasPrecision(20, 6)
                .HasComment("總計")
                .HasColumnName("orderTotalPrice");
            entity.Property(e => e.Remark)
                .HasMaxLength(255)
                .HasComment("備註")
                .HasColumnName("remark");
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("customer", tb => tb.HasComment("客戶"));

            entity.Property(e => e.Id)
                .HasComment("流水號")
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(30)
                .HasComment("聯絡人一")
                .HasColumnName("contactPerson");
            entity.Property(e => e.ContactPhoneNumberOne)
                .HasMaxLength(30)
                .HasComment("聯絡電話一")
                .HasColumnName("contactPhoneNumberOne");
            entity.Property(e => e.ContactPhoneNumberTwo)
                .HasMaxLength(30)
                .HasComment("聯絡電話二")
                .HasColumnName("contactPhoneNumberTwo");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .HasComment("客戶全名")
                .HasColumnName("customerName");
            entity.Property(e => e.Delete)
                .HasComment("0：沒刪1：刪除")
                .HasColumnType("tinyint(4)")
                .HasColumnName("delete");
            entity.Property(e => e.DeliveryAddress)
                .HasMaxLength(100)
                .HasComment("送貨地址")
                .HasColumnName("deliveryAddress");
            entity.Property(e => e.DeliveryAddressZipCode)
                .HasMaxLength(10)
                .HasComment("送貨地址郵遞區號")
                .HasColumnName("deliveryAddressZipCode");
            entity.Property(e => e.FaxNumber)
                .HasMaxLength(30)
                .HasComment("傳真電話")
                .HasColumnName("faxNumber");
            entity.Property(e => e.InvoicePayment)
                .HasMaxLength(100)
                .HasComment("發票抬頭")
                .HasColumnName("invoicePayment");
            entity.Property(e => e.RegisteredAddress)
                .HasMaxLength(100)
                .HasComment("登記地址")
                .HasColumnName("registeredAddress");
            entity.Property(e => e.UniformNumber)
                .HasMaxLength(30)
                .HasComment("統一編號")
                .HasColumnName("uniformNumber");
        });

        modelBuilder.Entity<Factory>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PRIMARY");

            entity.ToTable("factory", tb => tb.HasComment("廠商"));

            entity.Property(e => e.Id)
                .HasComment("流水號")
                .HasColumnType("int(11)")
                .HasColumnName("id");
            entity.Property(e => e.BillingAddress)
                .HasMaxLength(100)
                .HasComment("帳單地址")
                .HasColumnName("billingAddress");
            entity.Property(e => e.ContactPerson)
                .HasMaxLength(30)
                .HasComment("聯絡人")
                .HasColumnName("contactPerson");
            entity.Property(e => e.ContactPhoneNumber)
                .HasMaxLength(30)
                .HasComment("聯絡電話")
                .HasColumnName("contactPhoneNumber");
            entity.Property(e => e.Delete)
                .HasComment("0：沒刪1：刪除")
                .HasColumnType("tinyint(4)")
                .HasColumnName("delete");
            entity.Property(e => e.DeliveryAddress)
                .HasMaxLength(100)
                .HasComment("送貨地址")
                .HasColumnName("deliveryAddress");
            entity.Property(e => e.FactorAbbreviation)
                .HasMaxLength(50)
                .HasComment("公司簡稱")
                .HasColumnName("factorAbbreviation");
            entity.Property(e => e.FactoryName)
                .HasMaxLength(100)
                .HasComment("公司全名")
                .HasColumnName("factoryName");
            entity.Property(e => e.FaxNumber)
                .HasMaxLength(30)
                .HasComment("傳真號碼")
                .HasColumnName("faxNumber");
            entity.Property(e => e.InvoicePayment)
                .HasMaxLength(100)
                .HasComment("發票抬頭")
                .HasColumnName("invoicePayment");
            entity.Property(e => e.RegisteredAddress)
                .HasMaxLength(100)
                .HasComment("登記地址")
                .HasColumnName("registeredAddress");
            entity.Property(e => e.Remark)
                .HasMaxLength(50)
                .HasComment("備註")
                .HasColumnName("remark");
            entity.Property(e => e.ResponsiblePerson)
                .HasMaxLength(30)
                .HasComment("負責人")
                .HasColumnName("responsiblePerson");
            entity.Property(e => e.UniformNumber)
                .HasMaxLength(30)
                .HasComment("統一編號")
                .HasColumnName("uniformNumber");
        });

        modelBuilder.Entity<Merchandisemasterfile>(entity =>
        {
            entity.HasKey(e => e.ItemNumber).HasName("PRIMARY");

            entity.ToTable("merchandisemasterfile", tb => tb.HasComment("貨品主檔"));

            entity.Property(e => e.ItemNumber)
                .HasMaxLength(20)
                .HasComment("貨品編號")
                .HasColumnName("itemNumber");
            entity.Property(e => e.ExistingCost)
                .HasComment("現行成本")
                .HasColumnName("existingCost");
            entity.Property(e => e.ItemName)
                .HasMaxLength(60)
                .HasComment("品名")
                .HasColumnName("itemName");
            entity.Property(e => e.PriceA)
                .HasComment("售價A")
                .HasColumnName("priceA");
            entity.Property(e => e.PriceB)
                .HasComment("售價B")
                .HasColumnName("priceB");
            entity.Property(e => e.PriceC)
                .HasComment("售價C")
                .HasColumnName("priceC");
            entity.Property(e => e.PriceD)
                .HasComment("售價D")
                .HasColumnName("priceD");
            entity.Property(e => e.PriceE)
                .HasComment("售價E")
                .HasColumnName("priceE");
            entity.Property(e => e.StandardCost)
                .HasComment("標準成本")
                .HasColumnName("standardCost");
            entity.Property(e => e.StandardPrice)
                .HasComment("標準售價")
                .HasColumnName("standardPrice");
            entity.Property(e => e.Unit)
                .HasMaxLength(10)
                .HasComment("基本單位")
                .HasColumnName("unit");
        });

        modelBuilder.Entity<Suggestprice>(entity =>
        {
            entity.HasKey(e => e.StandardPrice).HasName("PRIMARY");

            entity.ToTable("suggestprice", tb => tb.HasComment("標準售價與建議售價對照表"));

            entity.Property(e => e.StandardPrice)
                .HasPrecision(10, 3)
                .HasComment("標準售價")
                .HasColumnName("standardPrice");
            entity.Property(e => e.RecommendedPrice)
                .HasPrecision(10, 3)
                .HasComment("建議售價")
                .HasColumnName("recommendedPrice");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
