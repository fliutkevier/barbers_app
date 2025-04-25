using BarbersApp.Business;
using BarbersApp.Models;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarbersApp.UI
{
    public partial class ServicesForm : Form
    {
        private List<Service> services;
        private List<PaymentMethod> paymentMethods;
        PaymentMethod paymentMethod;
        private ServiceBusiness serviceBS;
        private PaymentMethodBusiness pmBS;
        public ServicesForm()
        {
            serviceBS = new ServiceBusiness();
            services = serviceBS.GetActives();
            pmBS = new PaymentMethodBusiness();
            paymentMethods = pmBS.GetActives();
            InitializeComponent();
        }

        private void ServicesForm_Load(object sender, EventArgs e)
        {
            if (services != null && services.Count > 0)
            {
                loadDGV();
            }
            else
            {
                lblDgvEmpty.Visible = true;
                dgvServices.Visible = false;
            }
            if (paymentMethods != null && paymentMethods.Count > 0)
            {
                loadDGVPM();
            }
            else
            {
                lblDgvEmptyPM.Visible = true;
                dgvPaymentMethod.Visible = false;
            }
        }

        private void loadDGV()
        {
            services = serviceBS.GetActives();
            dgvServices.DataSource = services;

            dgvServices.Columns["IdSer"].Visible = false;
            dgvServices.Columns["IsActiveSer"].Visible = false;
            dgvServices.Columns["DetailSales"].Visible = false;
        }

        private void loadDGVPM()
        {
            paymentMethods = pmBS.GetActives();
            dgvPaymentMethod.DataSource = paymentMethods;
            dgvPaymentMethod.Columns["IdPay"].Visible = false;
            dgvPaymentMethod.Columns["IsActivePay"].Visible = false;
            dgvPaymentMethod.Columns["Sales"].Visible = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new AddService();
            frm.ShowDialog();
            loadDGV();
            if (services.Count > 0)
            {
                lblDgvEmpty.Visible = false;
                dgvServices.Visible = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Service service = (Service)dgvServices.CurrentRow.DataBoundItem;
            var frm = new AddService(service);
            frm.ShowDialog();
            loadDGV();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ServiceBusiness serviceBS = new ServiceBusiness();

            if (dgvServices.CurrentRow.DataBoundItem != null)
            {
                var result = MessageBox.Show("¿Seguro que querés eliminar este servicio?", "ADVERTENCIA", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var service = (Service)dgvServices.CurrentRow.DataBoundItem;
                    if (serviceBS.SoftRemove(service))
                    {
                        MessageBox.Show("Se eliminó correctamente el servicio.");
                        loadDGV();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el servicio.", "ERROR");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un servicio para eliminar.", "ERROR");
            }
        }

        private void btnAddPM_Click(object sender, EventArgs e)
        {
            paymentMethod = new PaymentMethod();
            string newPM = txtAddPM.Text;
            string percentage = txtPercentage.Text;

            if (string.IsNullOrEmpty(newPM))
            {
                MessageBox.Show("El metodo de pago está vacío.", "ERROR");
                return;
            }

            if (string.IsNullOrEmpty(percentage))
            {
                MessageBox.Show("El porcentaje está vacío, ingrese 0 en caso de no querer.", "ERROR");
                return;
            }

            if (decimal.TryParse(percentage, out decimal parsedPercentage))
            {
                paymentMethod.percentageAdjustment_pay = parsedPercentage;
                paymentMethod.NamePay = newPM;

                PaymentMethodBusiness pmBS = new PaymentMethodBusiness();
                if (pmBS.Add(paymentMethod))
                {
                    cleanAndLoad();
                }
            }
            else
            {
                MessageBox.Show("Porcentaje inválido (ej: +10 o -15)", "ERROR");
                return;
            }
        }

        private void cleanAndLoad()
        {
            txtAddPM.Text = string.Empty;
            txtPercentage.Text = string.Empty;
            loadDGVPM();
            if (paymentMethods.Count > 0)
            {
                lblDgvEmpty.Visible = false;
                dgvPaymentMethod.Visible = true;
            }
        }

        private void btnRemovePM_Click(object sender, EventArgs e)
        {
            PaymentMethodBusiness pmBS = new PaymentMethodBusiness();

            if (dgvPaymentMethod.CurrentRow.DataBoundItem != null)
            {
                var result = MessageBox.Show("¿Seguro que querés eliminar este método de pago?", "ADVERTENCIA", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var pm = (PaymentMethod)dgvPaymentMethod.CurrentRow.DataBoundItem;
                    if (pmBS.SoftRemove(pm))
                    {
                        MessageBox.Show("Se eliminó correctamente el método de pago.");
                        loadDGVPM();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el método de pago.", "ERROR");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un método de pago para eliminar.", "ERROR");
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filter = txtFilter.Text.ToLower().Trim();

            if (filter.IsNullOrEmpty())
            {
                loadDGV();
            }

            if (!Helper.IsNumeric(filter))
            {
                dgvServices.DataSource = services.Where(s => s.NameSer.ToLower().Contains(filter)).ToList();
            }
        }

        private void btnUpdatePayment_Click(object sender, EventArgs e)
        {
            paymentMethod = (PaymentMethod)dgvPaymentMethod.CurrentRow.DataBoundItem;

            var frm = new UpdPaymentMethodForm(paymentMethod);
            frm.ShowDialog();
            loadDGVPM();
        }
    }
}
