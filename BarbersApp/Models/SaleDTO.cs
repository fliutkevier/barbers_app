using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbersApp.Models
{
    public class SaleDTO
    {
        public int Id { get; set; }
        [DisplayName("Cliente")]
        public string ClientFullName { get; set; }
        [DisplayName("DNI Cliente")]
        public string ClientDni { get; set; }
        [DisplayName("Trabajador")]
        public string WorkerName { get; set; }
        [DisplayName("Metodo de Pago")]
        public string PaymentMethodName { get; set; }
        [DisplayName("Fecha")]
        public DateTime Date { get; set; }
        public decimal Total { get; set; }
        [DisplayName("Precio Ajustado")]
        public decimal TotalAdjusted { get; set; }
    }
}
