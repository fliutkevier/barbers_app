using BarbersApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbersApp.Services
{
    public class ClientService
    {
        private int saved;
        public ClientService()
        {
            saved = 0;
        }

        public List<Client> GetAll()
        {
            using(var db = new PeluKingDbContext())
            {
                return db.Clients.ToList();
            }
        }

        public Client GetByDni(string dni)
        {
            using (var db = new PeluKingDbContext())
            {
                return db.Clients.FirstOrDefault(c => c.DniCli == dni);
            }
        }

        public bool Add(Client client)
        {
            using (var db = new PeluKingDbContext())
            {
                db.Clients.Add(client);
                saved = db.SaveChanges();
            }
            return IsSaved(saved);
        }

        public bool Update(Client client)
        {
            using (var db = new PeluKingDbContext())
            {
                var clientFound = db.Clients.Find(client.IdCli);
                if (clientFound != null)
                {
                    clientFound.NameCli = client.NameCli;
                    clientFound.LastnameCli = client.LastnameCli;
                    clientFound.DniCli = client.DniCli;
                    clientFound.PhoneCli = client.PhoneCli;
                    clientFound.IsActiveCli = client.IsActiveCli;

                    saved = db.SaveChanges();
                }
            }
            return IsSaved(saved);
        }

        public bool Remove(Client client)
        {
            using (var db = new PeluKingDbContext())
            {
                var clientFound = db.Clients.Find(client.IdCli);
                if (clientFound != null)
                {
                    db.Clients.Remove(clientFound);
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
