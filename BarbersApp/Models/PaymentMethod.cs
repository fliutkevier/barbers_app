using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BarbersApp.Models;

public partial class PaymentMethod
{
    public int IdPay { get; set; }
    [DisplayName("Nombre")]
    public string NamePay { get; set; } = null!;

    public bool IsActivePay { get; set; }
    [DisplayName("Recargo/Descuento")]
    public decimal percentageAdjustment_pay { get; set; }

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();

    public PaymentMethod()
    {
        IdPay = 0;
        NamePay = string.Empty;
        IsActivePay = true;
        percentageAdjustment_pay = 0;
    }
}
