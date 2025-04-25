using System;
using System.Collections.Generic;

namespace BarbersApp.Models;

public partial class DetailSale
{
    public int IdDet { get; set; }

    public int SaleIdDet { get; set; }

    public int ServiceIdDet { get; set; }

    public int QuantityDet { get; set; }

    public decimal AmountDet { get; set; }

    public bool IsActiveDet { get; set; }

    public virtual Sale SaleIdDetNavigation { get; set; } = null!;

    public virtual Service ServiceIdDetNavigation { get; set; } = null!;

    public DetailSale()
    {
        IdDet = 0;
        SaleIdDet = 0;
        ServiceIdDet = 0;
        QuantityDet = 0;
        AmountDet = 0;
        IsActiveDet = true;
    }
}
