using BarbersApp.Models;
using BarbersApp.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbersApp.Business
{
    public class PaymentMethodBusiness
    {
        private PaymentMethodService paymentSV;
        public PaymentMethodBusiness()
        {
            paymentSV = new PaymentMethodService();
        }

        public List<PaymentMethod> GetAll()
        {
            return paymentSV.GetAll();
        }

        public List<PaymentMethod> GetActives()
        {
            return paymentSV.GetAll().Where(pm => pm.IsActivePay == true).ToList();
        }

        public List<PaymentMethod> GetInactives()
        {
            return paymentSV.GetAll().Where(pm => pm.IsActivePay == false).ToList();
        }

        public bool Add(PaymentMethod pm)
        {
            return paymentSV.Add(pm);
        }

        public bool Update(PaymentMethod pm)
        {
            return paymentSV.Update(pm);
        }

        public bool SoftRemove(PaymentMethod pm)
        {
            pm.IsActivePay = false;
            return paymentSV.Update(pm);
        }

        public bool Restore(PaymentMethod pm)
        {
            pm.IsActivePay = true;
            return paymentSV.Update(pm);
        }
    }
}
