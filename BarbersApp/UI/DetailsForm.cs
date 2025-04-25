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
    public partial class DetailsForm : Form
    {
        private SaleDTO _saleDTODetail;
        public DetailsForm(SaleDTO saleDetail)
        {
            _saleDTODetail = saleDetail;
            InitializeComponent();
        }

        private void DetailsForm_Load(object sender, EventArgs e)
        {
            List<DetailSaleDTO> detailDTOs = new List<DetailSaleDTO>();
            DetailSaleBusiness dsBS = new DetailSaleBusiness();
            var detailSales = dsBS.GetBySaleId(_saleDTODetail.Id);

            lblClientNameSold.Text = _saleDTODetail.ClientFullName;
            lblWorkerNameSold.Text = _saleDTODetail.WorkerName;
            lblClientDniSold.Text = _saleDTODetail.ClientDni;
            lblDateSold.Text = _saleDTODetail.Date.ToString("dd/MM/yyyy HH:mm");
            lblTotalSold.Text = $"$ {_saleDTODetail.Total:N2}";
            lblPaymentMethodSold.Text = _saleDTODetail.PaymentMethodName;

            ServiceBusiness serviceBS = new ServiceBusiness();
            var services = serviceBS.GetActives();
            foreach (var detail in detailSales)
            {
                var service = services.FirstOrDefault(s => s.IdSer == detail.ServiceIdDet);

                if (service != null)
                {
                    detailDTOs.Add(new DetailSaleDTO
                    {
                        ServiceName = service.NameSer,
                        Quantity = detail.QuantityDet,
                        UnitPrice = service.PriceSer,
                        Amount = detail.AmountDet
                    });
                }
            }

            dgvServices.DataSource = null;
            dgvServices.DataSource = detailDTOs.OrderBy(d => d.ServiceName).ToList();
        }
    }
}
