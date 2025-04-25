using BarbersApp.Models;
using BarbersApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbersApp.Business
{
    public class SaleBusiness
    {
        private SaleService saleService;

        public SaleBusiness()
        {
            saleService = new SaleService();
        }

        public List<Sale> GetActives()
        {
            return saleService.GetAll().Where(s => s.IsActiveSal == true).ToList();
        }

        public List<Sale> GetInactives()
        {
            return saleService.GetAll().Where(s => s.IsActiveSal == false).ToList();
        }

        public bool Add(Sale sale)
        {
            return saleService.Add(sale);
        }

        public bool SoftRemove(Sale sale)
        {
            sale.IsActiveSal = false;
            return saleService.Update(sale);
        }

        public bool SoftRemove(int idSale)
        {
            Sale sale = saleService.GetById(idSale);
            if(sale != null)
            {
                sale.IsActiveSal = false;
                return saleService.Update(sale);
            }
            else
            {
                return false;
            }
        }

        public bool Restore(int id)
        {
            Sale sale = saleService.GetById(id);
            if (sale != null)
            {
                sale.IsActiveSal = true;
                return saleService.Update(sale);
            }
            else
            {
                return false;
            }
        }
    }
}
