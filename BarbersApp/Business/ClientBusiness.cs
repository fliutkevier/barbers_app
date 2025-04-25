using BarbersApp.Models;
using BarbersApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbersApp.Business
{
    public class ClientBusiness
    {
        //List<Client> clients;
        ClientService clientServ;
        public ClientBusiness()
        {
            clientServ = new ClientService();
            //clients = new List<Client>();
        }

        public List<Client> GetAll()
        {
            return clientServ.GetAll();
        }

        public List<Client> GetActives()
        {
            return clientServ.GetAll().Where(c => c.IsActiveCli == true).ToList();
        }

        public List<Client> GetInactives()
        {
            return clientServ.GetAll().Where(c => c.IsActiveCli == false).ToList();
        }

        public bool Add(Client client)
        {
            return clientServ.Add(client);
        }

        public bool SoftRemove(Client client)
        {
            client.IsActiveCli = false;
            return clientServ.Update(client);
        }

        public bool Update(Client client)
        {
            return clientServ.Update(client);
        }

        public bool DniExists(string dni)
        {
            return clientServ.GetByDni(dni) != null;
        }

        public bool Restore(Client client)
        {
            client.IsActiveCli = true;
            return clientServ.Update(client);
        }
    }
}
