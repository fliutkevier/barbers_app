using BarbersApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarbersApp.Services
{
    public class PaymentMethodService
    {
        private int saved;
        public PaymentMethodService()
        {
            saved = 0;
        }

        public List<PaymentMethod> GetAll()
        {
            using (var db = new PeluKingDbContext())
            {
                return db.PaymentMethods.ToList();
            }
        }

        public bool Add(PaymentMethod paymentMethod)
        {
            using (var db = new PeluKingDbContext())
            {
                db.PaymentMethods.Add(paymentMethod);
                saved = db.SaveChanges();
            }
            return IsSaved(saved);
        }

        public bool Update(PaymentMethod paymentMethod)
        {
            using (var db = new PeluKingDbContext())
            {
                var pmFound = db.PaymentMethods.Find(paymentMethod.IdPay);
                if (pmFound != null)
                {
                    pmFound.NamePay = paymentMethod.NamePay;
                    pmFound.IsActivePay = paymentMethod.IsActivePay;
                    pmFound.percentageAdjustment_pay = paymentMethod.percentageAdjustment_pay;

                    saved = db.SaveChanges();
                }
            }
            return IsSaved(saved);
        }


        public bool Remove(PaymentMethod paymentMethod)
        {
            using (var db = new PeluKingDbContext())
            {
                var pmFound = db.PaymentMethods.Find(paymentMethod.IdPay);
                if (pmFound != null)
                {
                    db.PaymentMethods.Remove(pmFound);
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
