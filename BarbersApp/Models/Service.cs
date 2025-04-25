using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BarbersApp.Models;

public partial class Service
{
    public int IdSer { get; set; }
    [DisplayName("Nombre")]
    public string NameSer { get; set; } = null!;
    [DisplayName("Precio")]
    public decimal PriceSer { get; set; }

    public bool? IsActiveSer { get; set; }

    public virtual ICollection<DetailSale> DetailSales { get; set; } = new List<DetailSale>();
}
