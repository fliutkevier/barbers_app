using BarbersApp.Models;
using BarbersApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbersApp.Business
{
    public class ServiceBusiness
    {
        private ServicesService serviceServ;
        public ServiceBusiness()
        {
            serviceServ = new ServicesService();
        }
        public List<Service> GetActives()
        {
            return serviceServ.GetAll().Where(ser => ser.IsActiveSer == true).ToList();
        }

        public List<Service> GetInactives()
        {
            return serviceServ.GetAll().Where(ser => ser.IsActiveSer == false).ToList();
        }

        public bool Add(Service service)
        {
            return serviceServ.Add(service);
        }

        public bool Update(Service service)
        {
            return serviceServ.Update(service);
        }

        public bool SoftRemove(Service service)
        {
            service.IsActiveSer = false;
            return serviceServ.Update(service);
        }

        public bool Restore(Service service)
        {
            service.IsActiveSer = true;
            return serviceServ.Update(service);
        }
    }
}
