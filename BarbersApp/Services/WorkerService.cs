using BarbersApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BarbersApp.Services
{
    public class WorkerService
    {
        private int saved;
        public WorkerService()
        {
            saved = 0;
        }
        public List<Worker> GetAll()
        {
            using (var db = new PeluKingDbContext())
            {
                return db.Workers.ToList();
            }
        }

        public Worker GetByDni(string dni)
        {
            using (var db = new PeluKingDbContext())
            {
                return db.Workers.FirstOrDefault(w => w.DniWor == dni);
            }
        }

        public bool Add(Worker worker)
        {
            using (var db = new PeluKingDbContext())
            {
                db.Workers.Add(worker);
                saved = db.SaveChanges();
            }
            return IsSaved(saved);
        }

        public bool Update(Worker worker)
        {
            using (var db = new PeluKingDbContext())
            {
                var workerFound = db.Workers.Find(worker.IdWor);
                if (workerFound != null)
                {
                    workerFound.NameWor = worker.NameWor;
                    workerFound.LastnameWor = worker.LastnameWor;
                    workerFound.DniWor = worker.DniWor;
                    workerFound.AddressWor = worker.AddressWor;
                    workerFound.PhoneWor = worker.PhoneWor;
                    workerFound.IsActiveWor = worker.IsActiveWor;

                    saved = db.SaveChanges();
                }
            }
            return IsSaved(saved);
        }


        public bool Remove(Worker worker)
        {
            using (var db = new PeluKingDbContext())
            {
                var workerFound = db.Workers.Find(worker.IdWor);
                if (workerFound != null)
                {
                    db.Workers.Remove(workerFound);
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
