using BarbersApp.Models;
using BarbersApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BarbersApp.Business
{
    public class DetailSaleBusiness
    {
        private DetailSaleService dSaleService;

        public DetailSaleBusiness()
        {
            dSaleService = new DetailSaleService();
        }

        public List<DetailSale> GetActives()
        {
            return dSaleService.GetAll().Where(ds => ds.IsActiveDet == true).ToList();
        }

        public List<DetailSale> GetBySaleId(int saleId)
        {
            return dSaleService.GetAll().Where(ds => ds.IsActiveDet == true && ds.SaleIdDet == saleId).ToList();
        }

        public bool Add(DetailSale dSale)
        {
            return dSaleService.Add(dSale);
        }

        public bool AddRange(List<DetailSale> list)
        {
            return dSaleService.AddRange(list);
        }
    }
}
