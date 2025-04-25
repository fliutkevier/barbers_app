using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BarbersApp.Models;

public partial class Client
{
    public int IdCli { get; set; }
    [DisplayName("Nombre")]
    public string NameCli { get; set; } = null!;
    [DisplayName("Apellido")]
    public string LastnameCli { get; set; } = null!;
    [DisplayName("DNI")]
    public string DniCli { get; set; } = null!;
    [DisplayName("Telefono")]
    public string? PhoneCli { get; set; }

    public bool? IsActiveCli { get; set; }

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
    
    public string Fullname => $"{NameCli} {LastnameCli}";

    public Client()
    {
        IdCli = 0;
        NameCli = string.Empty;
        LastnameCli = string.Empty;
        DniCli = string.Empty;
        PhoneCli = string.Empty;
        IsActiveCli = true;
    }
}
