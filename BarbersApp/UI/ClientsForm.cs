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
    public partial class ClientsForm : Form
    {
        private List<Client> clients;
        private ClientBusiness clientBS;
        public ClientsForm()
        {
            clients = new List<Client>();
            clientBS = new ClientBusiness();
            clients = clientBS.GetActives();
            InitializeComponent();
        }

        private void loadDGV()
        {
            clients = clientBS.GetActives();
            dgvClients.DataSource = clients;

            dgvClients.Columns["IdCli"].Visible = false;
            dgvClients.Columns["IsActiveCli"].Visible = false;
            dgvClients.Columns["Sales"].Visible = false;
            dgvClients.Columns["Fullname"].Visible = false;
        }

        private void ClientsForm_Load(object sender, EventArgs e)
        {
            if (clients != null && clients.Count > 0)
            {
                loadDGV();
            }
            else
            {
                lblDgvEmpty.Visible = true;
                dgvClients.Visible = false;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var frm = new AddClient();
            frm.ShowDialog();
            loadDGV();
            if (clients.Count > 0)
            {
                lblDgvEmpty.Visible = false;
                dgvClients.Visible = true;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Client client = (Client)dgvClients.CurrentRow.DataBoundItem;
            var frm = new AddClient(client);
            frm.ShowDialog();
            loadDGV();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            ClientBusiness clientBS = new ClientBusiness();

            if (dgvClients.CurrentRow.DataBoundItem != null)
            {
                var result = MessageBox.Show("¿Seguro que querés eliminar este cliente?", "ADVERTENCIA", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    var client = (Client)dgvClients.CurrentRow.DataBoundItem;
                    if (clientBS.SoftRemove(client))
                    {
                        MessageBox.Show("Se eliminó correctamente al cliente.");
                        loadDGV();
                    }
                    else
                    {
                        MessageBox.Show("No se pudo eliminar el cliente.", "ERROR");
                    }
                }
            }
            else
            {
                MessageBox.Show("Seleccione un cliente para eliminar.", "ERROR");
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
                dgvClients.DataSource = clients.Where(c => c.DniCli.Contains(filter)).ToList();

            }
            else
            {
                dgvClients.DataSource = clients.Where(c => (c.NameCli + " " + c.LastnameCli).ToLower().Contains(filter)).ToList();
            }
        }
    }
}
