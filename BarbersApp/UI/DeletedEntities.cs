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
    public partial class DeletedEntities : Form
    {
        private ClientBusiness clientBS;
        private WorkerBusiness workerBS;
        private SaleDTOBusiness saleDTOBS;
        private ServiceBusiness serviceBS;
        private PaymentMethodBusiness paymentMethodBS;
        private SaleBusiness saleBS;

        public DeletedEntities()
        {
            InitializeComponent();
        }

        private void DeletedEntities_Load(object sender, EventArgs e)
        {
            dgvDeletedEntities.Visible = false;
            clientBS = new ClientBusiness();
            workerBS = new WorkerBusiness();
            saleDTOBS = new SaleDTOBusiness();
            serviceBS = new ServiceBusiness();
            paymentMethodBS = new PaymentMethodBusiness();
            saleBS = new SaleBusiness();
            loadCbx();
        }

        private void loadCbx()
        {
            cbxEntityType.Items.Add("Seleccione uno");
            cbxEntityType.Items.Add("Clientes");
            cbxEntityType.Items.Add("Trabajadores");
            cbxEntityType.Items.Add("Ventas");
            cbxEntityType.Items.Add("Servicios");
            cbxEntityType.Items.Add("Metodos de Pago");
            cbxEntityType.SelectedIndex = 0;
        }

        private void cbxEntityType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxEntityType.SelectedIndex != 0)
            {
                switch (cbxEntityType.SelectedItem.ToString())
                {
                    case "Clientes":
                        loadClientsDGV();
                        break;
                    case "Trabajadores":
                        loadWorkersDGV();
                        break;
                    case "Ventas":
                        loadSalesDGV();
                        break;
                    case "Servicios:":
                        loadServicesDGV();
                        break;
                    case "Metodos de Pago":
                        loadPaymentMethodsDGV();
                        break;
                }
                if (dgvDeletedEntities.Rows.Count > 0)
                {
                    dgvDeletedEntities.Visible = true;
                }
                else
                {
                    dgvDeletedEntities.Visible = false;
                }
            }
        }

        private void loadClientsDGV()
        {
            dgvDeletedEntities.DataSource = clientBS.GetInactives();
            dgvDeletedEntities.Columns["IdCli"].Visible = false;
            dgvDeletedEntities.Columns["IsActiveCli"].Visible = false;
            dgvDeletedEntities.Columns["Sales"].Visible = false;
        }

        private void loadWorkersDGV()
        {
            dgvDeletedEntities.DataSource = workerBS.GetInactives();
            dgvDeletedEntities.Columns["IdWor"].Visible = false;
            dgvDeletedEntities.Columns["IsActiveWor"].Visible = false;
            dgvDeletedEntities.Columns["Sales"].Visible = false;
        }

        private void loadSalesDGV()
        {
            dgvDeletedEntities.DataSource = saleDTOBS.GetInactives();
            dgvDeletedEntities.Columns["Id"].Visible = false;
        }

        private void loadServicesDGV()
        {
            dgvDeletedEntities.DataSource = serviceBS.GetInactives();
            dgvDeletedEntities.Columns["IdSer"].Visible = false;
            dgvDeletedEntities.Columns["IsActiveSer"].Visible = false;
            dgvDeletedEntities.Columns["DetailSales"].Visible = false;
        }

        private void loadPaymentMethodsDGV()
        {
            dgvDeletedEntities.DataSource = paymentMethodBS.GetInactives();
            dgvDeletedEntities.Columns["IdPay"].Visible = false;
            dgvDeletedEntities.Columns["IsActivePay"].Visible = false;
            dgvDeletedEntities.Columns["Sales"].Visible = false;
        }

        private void btnRestore_Click(object sender, EventArgs e)
        {
            if(dgvDeletedEntities.SelectedRows != null)
            {
                //METODOS YA HECHOS EN BUSINESS
                switch (cbxEntityType.SelectedItem.ToString())
                {
                    case "Clientes":
                        //RESTAURACION CLIENTES ;
                        var client = (Client)dgvDeletedEntities.CurrentRow.DataBoundItem;
                        clientBS.Restore(client);
                        break;
                    case "Trabajadores":
                        //RESTAURACION TRABAJADORES ;
                        var worker = (Worker)dgvDeletedEntities.CurrentRow.DataBoundItem;
                        workerBS.Restore(worker);
                        break;
                    case "Ventas":
                        //RESTAURACION VENTAS ;
                        var sale = (SaleDTO)dgvDeletedEntities.CurrentRow.DataBoundItem;
                        saleBS.Restore(sale.Id);
                        break;
                    case "Servicios:":
                        //RESTAURACION SERVICIOS ;
                        var service = (Service)dgvDeletedEntities.CurrentRow.DataBoundItem;
                        serviceBS.Restore(service);
                        break;
                    case "Metodos de Pago":
                        //RESTAURACION METODOS ;
                        var paymentMethod = (PaymentMethod)dgvDeletedEntities.CurrentRow.DataBoundItem;
                        paymentMethodBS.Restore(paymentMethod);
                        break;
                }

                cbxEntityType_SelectedIndexChanged(null, null); // Recarga la lista
                MessageBox.Show("Elemento restaurado.");
            }
        }
    }
}
