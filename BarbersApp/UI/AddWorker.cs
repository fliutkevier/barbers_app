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
    public partial class AddWorker : Form
    {
        private Worker worker;
        private WorkerBusiness workerBS;
        public AddWorker(Worker worker)
        {
            this.worker = worker;
            workerBS = new WorkerBusiness();
            InitializeComponent();
        }
        
        public AddWorker()
        {
            worker = new Worker();
            workerBS = new WorkerBusiness();
            InitializeComponent();
        }

        private void AddPerson_Load(object sender, EventArgs e)
        {
            if(worker.IdWor > 0)
            {
                txtName.Text = worker.NameWor;
                txtLastname.Text = worker.LastnameWor;
                txtDni.Text = worker.DniWor;
                txtPhone.Text = worker.PhoneWor;
                txtAddress.Text = worker.AddressWor;
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                if (worker.IdWor < 1)
                {
                    fillWorker(worker);
                    if(!workerBS.DniExists(worker.DniWor))
                    {
                        if (workerBS.AddWorker(worker))
                        {
                            MessageBox.Show("Se agregó correctamente el trabajador.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el trabajador.", "ERROR");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Ya existe un trabajador con este DNI.");
                    }
                }
                else
                {
                    var dniExisting = worker.DniWor;
                    fillWorker(worker);
                    if(worker.DniWor != dniExisting)
                    {
                        if (!workerBS.DniExists(worker.DniWor))
                        {
                            if (workerBS.UpdWorker(worker))
                            {
                                MessageBox.Show("Se modificó correctamente el trabajador.");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("No se pudo modificar el trabajador.", "ERROR");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Ya existe un trabajador con este DNI.");
                        }
                    }
                    else if(worker.DniWor == dniExisting)
                    {
                        if (workerBS.UpdWorker(worker))
                        {
                            MessageBox.Show("Se modificó correctamente el trabajador.");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo modificar el trabajador.", "ERROR");
                        }
                    }    
                }
            }
        }

        private void fillWorker(Worker worker)
        {
            worker.NameWor = txtName.Text;
            worker.LastnameWor = txtLastname.Text;
            worker.DniWor = txtDni.Text;
            worker.PhoneWor = txtPhone.Text;
            worker.AddressWor = txtAddress.Text;
        }

        private bool validateFields()
        {
            if(!Helper.IsNotEmpty(txtName.Text, txtLastname.Text, txtDni.Text, txtPhone.Text, txtAddress.Text))
            {
                MessageBox.Show("Hay campos vacíos.", "ERROR");
                return false;
            }
            if(!Helper.IsNumeric(txtDni.Text))
            {
                MessageBox.Show("El campo DNI no acepta letras.", "ERROR");
                return false;
            }
            if(!Helper.IsNumeric(txtPhone.Text))
            {
                MessageBox.Show("El campo telefónico no acepta letras.", "ERROR");
                return false;
            }
            return true;
        }

    }
}
