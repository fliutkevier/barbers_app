using BarbersApp.Business;
using BarbersApp.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarbersApp.UI
{
    public partial class UpdPaymentMethodForm : Form
    {
        PaymentMethod paymentMethod;
        public UpdPaymentMethodForm(PaymentMethod paymentMethod)
        {
            this.paymentMethod = new PaymentMethod();
            this.paymentMethod = paymentMethod;
            InitializeComponent();
        }

        private void UpdPaymentMethodForm_Load(object sender, EventArgs e)
        {
            txtName.Text = paymentMethod.NamePay;
            txtPercentage.Text = paymentMethod.percentageAdjustment_pay.ToString();
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            PaymentMethodBusiness paymentBS = new PaymentMethodBusiness();
            paymentMethod.NamePay = txtName.Text;

            if (decimal.TryParse(txtPercentage.Text, out decimal parsedPercentage))
            {
                paymentMethod.percentageAdjustment_pay = parsedPercentage;
                if (paymentBS.Update(paymentMethod))
                {
                    MessageBox.Show("Se MODIFICÓ correctamente el método de pago.");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("No se pudo modificar el método de pago.");
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Porcentaje inválido (ej: +10 o -15)", "ERROR");
                return;
            }
        }
    }
}
