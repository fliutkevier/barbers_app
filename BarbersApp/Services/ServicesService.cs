using BarbersApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbersApp.Services
{
    public class ServicesService
    {
        private int saved;
        public ServicesService()
        {
            saved = 0;
        }
        public List<Service> GetAll()
        {
            using (var db = new PeluKingDbContext())
            {
                return db.Services.ToList();
            }
        }

        public bool Add(Service service)
        {
            using (var db = new PeluKingDbContext())
            {
                db.Services.Add(service);
                saved = db.SaveChanges();
            }
            return IsSaved(saved);
        }

        public bool Update(Service service)
        {
            using (var db = new PeluKingDbContext())
            {
                var serviceFound = db.Services.Find(service.IdSer);
                if (serviceFound != null)
                {
                    serviceFound.NameSer = service.NameSer;
                    serviceFound.PriceSer = service.PriceSer;
                    serviceFound.IsActiveSer = service.IsActiveSer;

                    saved = db.SaveChanges();
                }
            }
            return IsSaved(saved);
        }


        public bool Remove(Service service)
        {
            using (var db = new PeluKingDbContext())
            {
                var serviceFound = db.Services.Find(service.IdSer);
                if (serviceFound != null)
                {
                    db.Services.Remove(serviceFound);
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
