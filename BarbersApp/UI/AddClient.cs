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
    public partial class AddClient : Form
    {
        private Client client;
        private ClientBusiness clientBS;
        public AddClient()
        {
            client = new Client();
            clientBS = new ClientBusiness();
            InitializeComponent();
        }

        public AddClient(Client client)
        {
            this.client = client;
            clientBS = new ClientBusiness();
            InitializeComponent();
        }

        private void fillClient(Client client)
        {
            client.NameCli = txtName.Text;
            client.LastnameCli = txtLastname.Text;
            client.DniCli = txtDni.Text;
            client.PhoneCli = txtPhone.Text;
        }

        private bool validateFields()
        {
            if (!Helper.IsNotEmpty(txtName.Text, txtLastname.Text, txtDni.Text, txtPhone.Text))
            {
                MessageBox.Show("Hay campos vacíos.", "ERROR");
                return false;
            }
            if (!Helper.IsNumeric(txtDni.Text))
            {
                MessageBox.Show("El campo DNI no acepta letras.", "ERROR");
                return false;
            }
            if (!Helper.IsNumeric(txtPhone.Text))
            {
                MessageBox.Show("El campo telefónico no acepta letras.", "ERROR");
                return false;
            }
            return true;
        }

        private void AddClient_Load(object sender, EventArgs e)
        {
            if (client.IdCli > 0)
            {
                txtName.Text = client.NameCli;
                txtLastname.Text = client.LastnameCli;
                txtDni.Text = client.DniCli;
                txtPhone.Text = client.PhoneCli;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                if (client.IdCli < 1)
                {
                    fillClient(client);
                    if (!clientBS.DniExists(client.DniCli))
                    {
                        if (clientBS.Add(client))
                        {
                            MessageBox.Show("Se agregó correctamente el cliente.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el cliente.", "ERROR");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un cliente con este DNI.");
                    }
                }
                else
                {
                    var dniExisting = client.DniCli;
                    fillClient(client);
                    if(client.DniCli != dniExisting)
                    {
                        if(!clientBS.DniExists(client.DniCli))
                        {
                            if(clientBS.Update(client))
                            {
                                MessageBox.Show("Se modificó correctamente el cliente.");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo modificar el cliente.", "ERROR");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ya existe un cliente con este DNI.");
                        }
                    }
                    else if (client.DniCli == dniExisting)
                    {
                        if (clientBS.Update(client))
                        {
                            MessageBox.Show("Se modificó correctamente el cliente.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo modificar el cliente.", "ERROR");
                        }
                    }
                }
            }
        }
    }
}
