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
    public partial class HistoryForm : Form
    {
        SaleDTOBusiness saleDTOBS;
        private List<SaleDTO> sales;
        private List<SaleDTO> filteredSales;
        private List<SaleDTO> displayedSales;
        public HistoryForm()
        {
            displayedSales = new List<SaleDTO>();
            saleDTOBS = new SaleDTOBusiness();
            sales = saleDTOBS.GetActives();
            filteredSales = sales;
            InitializeComponent();
        }

        private void HistoryForm_Load(object sender, EventArgs e)
        {
            if (sales != null && sales.Count > 0)
            {
                loadSales();
            }
            else
            {
                lblDgvEmpty.Visible = true;
                dgvSales.Visible = false;
            }

        }

        private void loadSales()
        {
            sales = saleDTOBS.GetActives();
            dgvSales.DataSource = sales.OrderByDescending(s => s.Date).ToList();
            dgvSales.Columns["Id"].Visible = false;
            dgvSales.Columns["TotalAdjusted"].DefaultCellStyle.Format = "0.##";
        }

        private void btnDetails_Click(object sender, EventArgs e)
        {
            if (dgvSales.SelectedRows != null)
            {
                SaleDTO saleDetail = (SaleDTO)dgvSales.CurrentRow.DataBoundItem;
                var frm = new DetailsForm(saleDetail);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Seleccione una venta para visualizar los detalles.");
            }
        }

        private void applyFilter()
        {
            string textFilter = txtFilter.Text.Trim().ToLower();
            string textFilterWorker = txtFilterWorker.Text.Trim().ToLower();

            if(dtpFrom.Value == DateTime.Now && dtpTo.Value == DateTime.Now)
            {
                filteredSales = sales;
            }
            else if (textFilter == string.Empty &&  textFilterWorker == string.Empty)
            {
                filteredSales = sales;
            }

            if (!string.IsNullOrEmpty(textFilter))
            {
                filteredSales = filteredSales.Where(s =>
                    s.ClientFullName.ToLower().Contains(textFilter) ||
                    s.ClientDni.ToLower().Contains(textFilter)
                ).ToList();
            }


            if (!string.IsNullOrEmpty(textFilterWorker))
            {
                filteredSales = filteredSales.Where(s =>
                    s.WorkerName.ToLower().Contains(txtFilterWorker.Text)
                ).ToList();
            }

            

            applySorting();

            
        }

        private void applySorting()
        {
            displayedSales = filteredSales;

            if (rbAZClient.Checked)
            {
                displayedSales = displayedSales.OrderBy(s => s.ClientFullName).ToList();
            }
            else if (rbTotal.Checked)
            {
                displayedSales = displayedSales.OrderByDescending(s => s.Total).ToList();
            }
            else if (rbDate.Checked)
            {
                displayedSales = displayedSales.OrderBy(s => s.Date).ToList();
            }
            else if (rbLastSales.Checked)
            {
                displayedSales = displayedSales.OrderByDescending(s => s.Date).ToList();
            }

            dgvSales.DataSource = null;
            dgvSales.DataSource = displayedSales;
            dgvSales.Columns["Id"].Visible = false;
        }

        private void rbAZClient_CheckedChanged(object sender, EventArgs e)
        {
            applySorting();
        }

        private void rbTotal_CheckedChanged(object sender, EventArgs e)
        {
            applySorting();
        }

        private void rbDate_CheckedChanged(object sender, EventArgs e)
        {
            applySorting();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            applyFilter();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            SaleBusiness saleBS = new SaleBusiness();
            if (dgvSales.CurrentRow.DataBoundItem != null)
            {
                var result = MessageBox.Show("¿Seguro que querés eliminar esta venta?", "ADVERTENCIA", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var sale = (SaleDTO)dgvSales.CurrentRow.DataBoundItem;
                    if (saleBS.SoftRemove(sale.Id))
                    {
                        MessageBox.Show("Se eliminó correctamente la venta.");
                        loadSales();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar la venta.", "ERROR");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione una venta para eliminar.", "ERROR");
            }
        }

        private void txtFilterWorker_TextChanged(object sender, EventArgs e)
        {
            applyFilter();
        }

        private void rbLastSales_CheckedChanged(object sender, EventArgs e)
        {
            applySorting();
        }

        private void btnGenerateSummary_Click(object sender, EventArgs e)
        {
            DateTime fromDate = dtpFrom.Value;
            DateTime toDate = dtpTo.Value;

            filteredSales = sales.Where(s => s.Date.Date >= fromDate.Date && s.Date.Date <= toDate.Date).ToList();
            if (filteredSales.Count > 0)
            {
                dgvSales.DataSource = filteredSales.OrderByDescending(s => s.Date).ToList();
            }
            else
            {
                MessageBox.Show("No hay registros entre esas fechas.", "ERROR");
            }
        }

        private void btnClean_Click(object sender, EventArgs e)
        {
            txtFilter.Text = string.Empty;
            txtFilterWorker.Text = string.Empty;
            lblTotal.Text = "0";
            lblTotal.Visible = false;
            dtpFrom.Value = DateTime.Now;
            dtpTo.Value = DateTime.Now;
            loadSales();
        }

        private void btnTotal_Click(object sender, EventArgs e)
        {
            lblTotal.Visible = true;
            decimal totalSum = 0;

            foreach (DataGridViewRow row in dgvSales.Rows)
            {
                if (row.Cells["TotalAdjusted"].Value != null)
                {
                    decimal value;
                    if (decimal.TryParse(row.Cells["TotalAdjusted"].Value.ToString(), out value))
                    {
                        totalSum += value;
                    }
                }
            }

            lblTotal.Text = $"Total: ${totalSum:N0}";
        }
    }
}
