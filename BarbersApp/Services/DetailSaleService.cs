using BarbersApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace BarbersApp.Services
{
    public class DetailSaleService
    {
        private int saved;
        public DetailSaleService()
        {
            saved = 0;
        }

        public List<DetailSale> GetAll()
        {
            using (var db = new PeluKingDbContext())
            {
                return db.DetailSales.ToList();
            }
        }

        public bool Add(DetailSale detail)
        {
            using (var db = new PeluKingDbContext())
            {
                db.DetailSales.Add(detail);
                saved = db.SaveChanges();
            }
            return IsSaved(saved);
        }

        public bool AddRange(List<DetailSale> detailSales)
        {
            using (var db = new PeluKingDbContext())
            {
                db.DetailSales.AddRange(detailSales);
                saved = db.SaveChanges();
            }
            return IsSaved(saved);
        }

        public bool Update(DetailSale detail)
        {
            using (var db = new PeluKingDbContext())
            {
                var detailFound = db.DetailSales.Find(detail.IdDet);
                if (detailFound != null)
                {
                    detailFound.SaleIdDet = detail.SaleIdDet;
                    detailFound.ServiceIdDet = detail.ServiceIdDet;
                    detailFound.QuantityDet = detail.QuantityDet;
                    detailFound.AmountDet = detail.AmountDet;
                    detailFound.IsActiveDet = detail.IsActiveDet;

                    saved = db.SaveChanges();
                }
            }
            return IsSaved(saved);
        }

        public bool Remove(DetailSale detail)
        {
            using (var db = new PeluKingDbContext())
            {
                var detailFound = db.DetailSales.Find(detail.IdDet);
                if (detailFound != null)
                {
                    db.DetailSales.Remove(detailFound);
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
