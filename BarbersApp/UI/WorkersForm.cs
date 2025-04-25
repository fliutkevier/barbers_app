using BarbersApp.Business;
using BarbersApp.Models;
using Microsoft.IdentityModel.Tokens;
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
    public partial class WorkersForm : Form
    {
        private List<Worker> workers;
        private WorkerBusiness workerBusiness;
        public WorkersForm()
        {
            workerBusiness = new WorkerBusiness();
            workers = workerBusiness.GetActives();
            InitializeComponent();
        }

        private void workerForm_Load(object sender, EventArgs e)
        {
            if (workers != null && workers.Count > 0)
            {
                loadDGV();
            }
            else
            {
                lblDgvEmpty.Visible = true;
                dgvWorkers.Visible = false;
            }
        }

        private void btnAddWorker_Click(object sender, EventArgs e)
        {
            var frm = new AddWorker();
            frm.ShowDialog();
            loadDGV();
            if (workers.Count > 0)
            {
                lblDgvEmpty.Visible = false;
                dgvWorkers.Visible = true;
            }
        }

        private void loadDGV()
        {
            workers = workerBusiness.GetActives();
            dgvWorkers.DataSource = workers;

            dgvWorkers.Columns["IdWor"].Visible = false;
            dgvWorkers.Columns["IsActiveWor"].Visible = false;
            dgvWorkers.Columns["Sales"].Visible = false;
            dgvWorkers.Columns["Fullname"].Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Worker worker = (Worker)dgvWorkers.CurrentRow.DataBoundItem;
            var frm = new AddWorker(worker);
            frm.ShowDialog();
            loadDGV();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            WorkerBusiness workerBS = new WorkerBusiness();

            if (dgvWorkers.CurrentRow.DataBoundItem != null)
            {
                var result = MessageBox.Show("¿Seguro que querés eliminar este trabajador?", "ADVERTENCIA", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var worker = (Worker)dgvWorkers.CurrentRow.DataBoundItem;
                    if (workerBS.SoftRemoveWorker(worker))
                    {
                        MessageBox.Show("Se eliminó correctamente el trabajador.");
                        loadDGV();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el trabajador.", "ERROR");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un trabajador para eliminar.", "ERROR");
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            string filter = txtFilter.Text.ToLower().Trim();

            if (filter.IsNullOrEmpty())
            {
                loadDGV();
            }

            if (Helper.IsNumeric(filter))
            {
                dgvWorkers.DataSource = workers.Where(w => w.DniWor.Contains(filter)).ToList();
                
            }
            else
            {
                dgvWorkers.DataSource = workers.Where(w => (w.NameWor + " " + w.LastnameWor).ToLower().Contains(filter)).ToList();
            }
        }
    }
}
