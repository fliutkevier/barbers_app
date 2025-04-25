using BarbersApp.Models;
using BarbersApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbersApp.Business
{
    public class WorkerBusiness
    {
        private WorkerService workerServ;
        public WorkerBusiness()
        {
            workerServ = new WorkerService();
        }

        public List<Worker> GetAll()
        {
            return workerServ.GetAll();
        }

        public List<Worker> GetActives()
        {
            return workerServ.GetAll().Where(wor => wor.IsActiveWor == true).ToList();
        }

        public List<Worker> GetInactives()
        {
            return workerServ.GetAll().Where(wor => wor.IsActiveWor == false).ToList();
        }

        public bool AddWorker(Worker worker)
        {
            return workerServ.Add(worker);
        }

        public bool UpdWorker(Worker worker)
        {
            return workerServ.Update(worker);
        }

        public bool SoftRemoveWorker(Worker worker)
        {
            worker.IsActiveWor = false;
            return workerServ.Update(worker);
        }

        public bool DniExists(string dni)
        {
            return workerServ.GetByDni(dni) != null;
        }

        public bool Restore(Worker worker)
        {
            worker.IsActiveWor = true;
            return workerServ.Update(worker);
        }
    }
}
