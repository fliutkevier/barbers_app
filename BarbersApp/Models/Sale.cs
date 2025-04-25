using System;
using System.Collections.Generic;

namespace BarbersApp.Models;

public partial class Sale
{
    public int IdSal { get; set; }

    public int ClientIdSal { get; set; }

    public int WorkerIdSal { get; set; }

    public int PaymentMethodIdSal { get; set; }

    public DateTime DateSal { get; set; }

    public decimal TotalSal { get; set; }

    public bool IsActiveSal { get; set; }

    public virtual Client ClientIdSalNavigation { get; set; } = null!;

    public virtual ICollection<DetailSale> DetailSales { get; set; } = new List<DetailSale>();

    public virtual PaymentMethod PaymentMethodIdSalNavigation { get; set; } = null!;

    public virtual Worker WorkerIdSalNavigation { get; set; } = null!;

    public Sale()
    {
        IdSal = 0;
        ClientIdSal = 0;
        WorkerIdSal = 0;
        PaymentMethodIdSal = 0;
        DateSal = DateTime.MinValue;
        TotalSal = 0;
        IsActiveSal = true;
    }
}
