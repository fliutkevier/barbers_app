using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbersApp.Models
{
    public class DetailSaleDTO
    {
        [DisplayName("Nombre del Servicio")]
        public string ServiceName { get; set; }
        [DisplayName("Cantidad")]
        public int Quantity { get; set; }
        [DisplayName("Precio de Unidad")]
        public decimal UnitPrice { get; set; }
        [DisplayName("Monto")]
        public decimal Amount { get; set; }
    }
}
