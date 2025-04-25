using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BarbersApp.Models;

public partial class Worker
{
    public int IdWor { get; set; }
    [DisplayName("Nombre")]
    public string NameWor { get; set; } = null!;
    [DisplayName("Apellido")]
    public string LastnameWor { get; set; } = null!;
    [DisplayName("DNI")]
    public string DniWor { get; set; } = null!;
    [DisplayName("Telefono")]
    public string? PhoneWor { get; set; }
    [DisplayName("Direccion")]
    public string? AddressWor { get; set; }

    public bool IsActiveWor { get; set; }

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();

    public string Fullname => $"{NameWor} {LastnameWor}";

    public Worker()
    {
        IdWor = 0;
        NameWor = string.Empty;
        LastnameWor = string.Empty;
        DniWor = string.Empty;
        PhoneWor = string.Empty;
        AddressWor = string.Empty;
        IsActiveWor = true;
    }
}
