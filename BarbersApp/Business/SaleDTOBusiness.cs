using BarbersApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbersApp.Business
{
    public class SaleDTOBusiness
    {
        private SaleDTO sDto;
        private SaleBusiness saleBS;
        private ClientBusiness clientBS;
        private WorkerBusiness workerBS;
        private PaymentMethodBusiness paymentMethodBS;

        public SaleDTOBusiness()
        {
            
            saleBS = new SaleBusiness();
            clientBS = new ClientBusiness();
            workerBS = new WorkerBusiness();
            paymentMethodBS = new PaymentMethodBusiness();
        }

        public List<SaleDTO> GetActives()
        {
            List<SaleDTO> salesDTO = new List<SaleDTO>();
            var sales = saleBS.GetActives();

            foreach (var s in sales)
            {
                sDto = new SaleDTO();
                var client = clientBS.GetAll().FirstOrDefault(c => c.IdCli == s.ClientIdSal);
                var worker = workerBS.GetAll().FirstOrDefault(w => w.IdWor == s.WorkerIdSal);
                var paymentMethod = paymentMethodBS.GetActives().FirstOrDefault(pm => pm.IdPay == s.PaymentMethodIdSal);

                sDto.Total = s.TotalSal;
                sDto.ClientFullName = client.Fullname;
                sDto.WorkerName = worker.Fullname;
                sDto.PaymentMethodName = paymentMethod.NamePay;
                sDto.Date = s.DateSal;
                sDto.ClientDni = client.DniCli;
                sDto.Id = s.IdSal;
                sDto.TotalAdjusted = s.TotalSal + (s.TotalSal * paymentMethod.percentageAdjustment_pay / 100);

                salesDTO.Add(sDto);
            }

            return salesDTO;
        }

        public List<SaleDTO> GetInactives()
        {
            List<SaleDTO> salesDTO = new List<SaleDTO>();
            var sales = saleBS.GetInactives();

            foreach (var s in sales)
            {
                sDto = new SaleDTO();
                var client = clientBS.GetAll().FirstOrDefault(c => c.IdCli == s.ClientIdSal);
                var worker = workerBS.GetAll().FirstOrDefault(w => w.IdWor == s.WorkerIdSal);
                var paymentMethod = paymentMethodBS.GetAll().FirstOrDefault(pm => pm.IdPay == s.PaymentMethodIdSal);

                sDto.ClientFullName = client.Fullname;
                sDto.WorkerName = worker.Fullname;
                sDto.PaymentMethodName = paymentMethod.NamePay;
                sDto.ClientDni = client.DniCli;
                sDto.Total = s.TotalSal;
                sDto.Date = s.DateSal;
                sDto.Id = s.IdSal;
                sDto.TotalAdjusted = s.TotalSal + (s.TotalSal * paymentMethod.percentageAdjustment_pay / 100);

                salesDTO.Add(sDto);
            }

            return salesDTO;
        }
    }
}
