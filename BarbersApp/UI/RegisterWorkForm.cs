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
    public partial class RegisterWorkForm : Form
    {
        private BindingList<Service> servicesAdded;
        private decimal total;
        public RegisterWorkForm()
        {
            servicesAdded = new BindingList<Service>();
            total = 0;
            InitializeComponent();
        }

        private void RegisterWorkForm_Load(object sender, EventArgs e)
        {
            dtpTime.CustomFormat = "HH:mm";
            loadComboBoxes();
            loadDGVServicesAdded();
        }

        private void loadComboBoxes()
        {
            ClientBusiness clientBS = new ClientBusiness();
            WorkerBusiness workerBS = new WorkerBusiness();
            ServiceBusiness serviceBS = new ServiceBusiness();
            PaymentMethodBusiness paymentMethodBS = new PaymentMethodBusiness();

            var clients = clientBS.GetActives();
            clients.Insert(0, new Client { IdCli = 0, NameCli = "Seleccione", LastnameCli = "uno"});
            cbxClients.DataSource = clients;
            cbxClients.DisplayMember = "Fullname";
            cbxClients.ValueMember = "IdCli";

            var workers = workerBS.GetActives();
            workers.Insert(0, new Worker { IdWor = 0, NameWor = "Seleccione", LastnameWor = "uno"});
            cbxWorkers.DataSource = workers;
            cbxWorkers.DisplayMember = "Fullname";
            cbxWorkers.ValueMember = "IdWor";

            var services = serviceBS.GetActives();
            services.Insert(0, new Service { IdSer = 0, NameSer = "Seleccione uno"});
            cbxServices.DataSource = services;
            cbxServices.DisplayMember = "NameSer";
            cbxServices.ValueMember = "IdSer";

            var paymentMethods = paymentMethodBS.GetActives();
            paymentMethods.Insert(0, new PaymentMethod { IdPay = 0, NamePay = "Seleccione uno" });
            cbxPaymentMethod.DataSource = paymentMethods;
            cbxPaymentMethod.DisplayMember = "NamePay";
            cbxPaymentMethod.ValueMember = "IdPay";
        }

        private void checkTodayNow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkTodayNow.Checked == false)
            {
                dtpTime.Visible = true;
            }
            else
            {
                dtpTime.Visible = false;
            }

        }

        private void btnAddService_Click(object sender, EventArgs e)
        {
            lblTotal.Visible = true;
            var service = new Service();
            service = (Service)cbxServices.SelectedItem;
            servicesAdded.Add(service);
            addToTotal(service);

        }

        private void loadDGVServicesAdded()
        {
            dgvServicesAdded.DataSource = servicesAdded;
            dgvServicesAdded.Columns["IdSer"].Visible = false;
            dgvServicesAdded.Columns["IsActiveSer"].Visible = false;
            dgvServicesAdded.Columns["DetailSales"].Visible = false;
        }

        private void addToTotal(Service service)
        {
            total += service.PriceSer;
            lblTotal.Text = $"Total: $ {total:0.##}";
        }

        private void cbxPaymentMethod_SelectedIndexChanged(object sender, EventArgs e)
        {
            var paymentMet = (PaymentMethod)cbxPaymentMethod.SelectedItem;
            var adjustment = paymentMet.percentageAdjustment_pay;

            var totalAdjusted = total + (total * adjustment / 100);
            lblTotal.Text = $"Total: $ {totalAdjusted:0.##}";
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            servicesAdded.Clear();
            loadDGVServicesAdded();

            total = 0;
            lblTotal.Text = $"Total: $ {total:0.##}";
        }

        private void btnAddJob_Click(object sender, EventArgs e)
        {
            if(cbxClients.SelectedIndex == 0 || cbxWorkers.SelectedIndex == 0 || cbxServices.SelectedIndex == 0 || cbxPaymentMethod.SelectedIndex == 0)
            {
                MessageBox.Show("Seleccione correctamente los desplegables.", "ERROR");
                return;
            }

            var client = (Client)cbxClients.SelectedItem;
            var worker = (Worker)cbxWorkers.SelectedItem;
            var paymentMethod = (PaymentMethod)cbxPaymentMethod.SelectedItem;
            var time = new DateTime();

            if(checkTodayNow.Checked)
            {
                time = DateTime.Now;
            }
            else
            {
                time = dtpTime.Value;
            }

            Sale sale = new Sale();
            sale.ClientIdSal = client.IdCli;
            sale.WorkerIdSal = worker.IdWor;
            sale.PaymentMethodIdSal = paymentMethod.IdPay;
            sale.DateSal = time;
            sale.TotalSal = total;

            SaleBusiness saleBS = new SaleBusiness();
            DetailSale detailSale = new DetailSale();
            DetailSaleBusiness detailSaleBS = new DetailSaleBusiness();
            List<DetailSale> details = new List<DetailSale>();

            if(saleBS.Add(sale))
            {
                int saleId = saleBS.GetActives().First(s => s.IdSal == sale.IdSal).IdSal;

                foreach (var group in servicesAdded.GroupBy(dt => dt.NameSer))
                {
                    var service = group.First();
                    int quantity = QuantityService(service.NameSer);

                    var detail = new DetailSale
                    {
                        ServiceIdDet = service.IdSer,
                        QuantityDet = quantity,
                        SaleIdDet = saleId,
                        AmountDet = (int)service.PriceSer * quantity
                    };
                    details.Add(detail);
                }

                if(detailSaleBS.AddRange(details))
                {
                    MessageBox.Show("Se agregó la venta correctamente.");
                    clean();
                }
            }
            else
            {
                MessageBox.Show("NO se pudo registrar la venta", "ERROR");
            }

            cbxClients.SelectedIndex = 0;
            cbxWorkers.SelectedIndex = 0;
            cbxServices.SelectedIndex = 0;
            cbxPaymentMethod.SelectedIndex = 0;
        }

        private int QuantityService(string serviceName)
        {
            return servicesAdded.Count(s => s.NameSer == serviceName);
        }

        private void clean()
        {
            servicesAdded.Clear();
            total = 0;
        }
    }
}
