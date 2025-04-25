using BarbersApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbersApp.Services
{
    public class SaleService
    {
        private int saved;
        public SaleService()
        {
            saved = 0;
        }

        public List<Sale> GetAll()
        {
            using (var db = new PeluKingDbContext())
            {
                return db.Sales.ToList();
            }
        }

        public Sale GetById(int id)
        {
            using (var db = new PeluKingDbContext())
            {
                return db.Sales.FirstOrDefault(s => s.IdSal == id);
            }
        }

        public bool Add(Sale sale)
        {
            using (var db = new PeluKingDbContext())
            {
                db.Sales.Add(sale);
                saved = db.SaveChanges();
            }
            return IsSaved(saved);
        }

        public bool Update(Sale sale)
        {
            using (var db = new PeluKingDbContext())
            {
                var saleFound = db.Sales.Find(sale.IdSal);
                if (saleFound != null)
                {
                    saleFound.TotalSal = sale.TotalSal;
                    saleFound.IsActiveSal = sale.IsActiveSal;
                    saleFound.DateSal = sale.DateSal;
                    saleFound.ClientIdSal = sale.ClientIdSal;
                    saleFound.WorkerIdSal = sale.WorkerIdSal;
                    saleFound.PaymentMethodIdSal = sale.PaymentMethodIdSal;

                    saved = db.SaveChanges();
                }
            }
            return IsSaved(saved);
        }

        public bool Remove(Sale sale)
        {
            using (var db = new PeluKingDbContext())
            {
                var saleFound = db.Sales.Find(sale.IdSal);
                if (saleFound != null)
                {
                    db.Sales.Remove(saleFound);
                    saved = db.SaveChanges();
                }
            }
            return IsSaved(saved);
        }
        private bool IsSaved(int saved)
        {
            if (saved > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
