using System;
using System.Collections.Generic;
using System.Configuration;
using Microsoft.EntityFrameworkCore;

namespace BarbersApp.Models;

public partial class PeluKingDbContext : DbContext
{
    public PeluKingDbContext()
    {
    }

    public PeluKingDbContext(DbContextOptions<PeluKingDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Client> Clients { get; set; }

    public virtual DbSet<DetailSale> DetailSales { get; set; }

    public virtual DbSet<PaymentMethod> PaymentMethods { get; set; }

    public virtual DbSet<Sale> Sales { get; set; }

    public virtual DbSet<Service> Services { get; set; }

    public virtual DbSet<Worker> Workers { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        if(!optionsBuilder.IsConfigured)
        {
            optionsBuilder.UseSqlServer(
                ConfigurationManager.ConnectionStrings["PeluKingDbContext"].ConnectionString);
        }
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Client>(entity =>
        {
            entity.HasKey(e => e.IdCli);

            entity.Property(e => e.IdCli).HasColumnName("id_cli");
            entity.Property(e => e.DniCli)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("dni_cli");
            entity.Property(e => e.IsActiveCli)
                .HasDefaultValue(true)
                .HasColumnName("isActive_cli");
            entity.Property(e => e.LastnameCli)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("lastname_cli");
            entity.Property(e => e.NameCli)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("name_cli");
            entity.Property(e => e.PhoneCli)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("phone_cli");
        });

        modelBuilder.Entity<DetailSale>(entity =>
        {
            entity.HasKey(e => e.IdDet);

            entity.Property(e => e.IdDet).HasColumnName("id_det");
            entity.Property(e => e.AmountDet).HasColumnName("amount_det");
            entity.Property(e => e.IsActiveDet)
                .HasDefaultValue(true)
                .HasColumnName("isActive_det");
            entity.Property(e => e.QuantityDet).HasColumnName("quantity_det");
            entity.Property(e => e.SaleIdDet).HasColumnName("saleId_det");
            entity.Property(e => e.ServiceIdDet).HasColumnName("serviceId_det");

            entity.HasOne(d => d.SaleIdDetNavigation).WithMany(p => p.DetailSales)
                .HasForeignKey(d => d.SaleIdDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetailSales_Sales");

            entity.HasOne(d => d.ServiceIdDetNavigation).WithMany(p => p.DetailSales)
                .HasForeignKey(d => d.ServiceIdDet)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_DetailSales_Services");
        });

        modelBuilder.Entity<PaymentMethod>(entity =>
        {
            entity.HasKey(e => e.IdPay);

            entity.Property(e => e.IdPay).HasColumnName("id_pay");
            entity.Property(e => e.IsActivePay)
                .HasDefaultValue(true)
                .HasColumnName("isActive_pay");
            entity.Property(e => e.NamePay)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("name_pay");
        });

        modelBuilder.Entity<Sale>(entity =>
        {
            entity.HasKey(e => e.IdSal);

            entity.Property(e => e.IdSal).HasColumnName("id_sal");
            entity.Property(e => e.ClientIdSal).HasColumnName("clientId_sal");
            entity.Property(e => e.DateSal)
                .HasColumnType("datetime")
                .HasColumnName("date_sal");
            entity.Property(e => e.IsActiveSal)
                .HasDefaultValue(true)
                .HasColumnName("isActive_sal");
            entity.Property(e => e.PaymentMethodIdSal).HasColumnName("paymentMethodId_sal");
            entity.Property(e => e.TotalSal)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("total_sal");
            entity.Property(e => e.WorkerIdSal).HasColumnName("workerId_sal");

            entity.HasOne(d => d.ClientIdSalNavigation).WithMany(p => p.Sales)
                .HasForeignKey(d => d.ClientIdSal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sales_Clients");

            entity.HasOne(d => d.PaymentMethodIdSalNavigation).WithMany(p => p.Sales)
                .HasForeignKey(d => d.PaymentMethodIdSal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sales_PaymentMethods");

            entity.HasOne(d => d.WorkerIdSalNavigation).WithMany(p => p.Sales)
                .HasForeignKey(d => d.WorkerIdSal)
                .OnDelete(DeleteBehavior.ClientSetNull)
                .HasConstraintName("FK_Sales_Workers");
        });

        modelBuilder.Entity<Service>(entity =>
        {
            entity.HasKey(e => e.IdSer);

            entity.Property(e => e.IdSer).HasColumnName("id_ser");
            entity.Property(e => e.IsActiveSer)
                .HasDefaultValue(true)
                .HasColumnName("isActive_ser");
            entity.Property(e => e.NameSer)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("name_ser");
            entity.Property(e => e.PriceSer)
                .HasColumnType("decimal(10, 2)")
                .HasColumnName("price_ser");
        });

        modelBuilder.Entity<Worker>(entity =>
        {
            entity.HasKey(e => e.IdWor);

            entity.Property(e => e.IdWor).HasColumnName("id_wor");
            entity.Property(e => e.AddressWor)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("address_wor");
            entity.Property(e => e.DniWor)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("dni_wor");
            entity.Property(e => e.IsActiveWor)
                .HasDefaultValue(true)
                .HasColumnName("isActive_wor");
            entity.Property(e => e.LastnameWor)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("lastname_wor");
            entity.Property(e => e.NameWor)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("name_wor");
            entity.Property(e => e.PhoneWor)
                .HasMaxLength(15)
                .IsUnicode(false)
                .HasColumnName("phone_wor");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
