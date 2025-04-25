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
    public partial class AddService : Form
    {
        Service service;
        ServiceBusiness serviceBS;
        public AddService()
        {
            service = new Service();
            serviceBS = new ServiceBusiness();
            InitializeComponent();
        }

        public AddService(Service service)
        {
            this.service = service;
            serviceBS = new ServiceBusiness();
            InitializeComponent();
        }

        private void AddService_Load(object sender, EventArgs e)
        {
            if (service.IdSer > 0)
            {
                txtName.Text = service.NameSer;
                txtPrice.Text = service.PriceSer.ToString();
            }
        }

        private void btnAccept_Click(object sender, EventArgs e)
        {
            if (validateFields())
            {
                if (service.IdSer < 1)
                {
                    fillService(service);
                    if (serviceBS.Add(service))
                    {
                        MessageBox.Show("Se agregó correctamente el servicio.");
                        this.Close();
                    }
                }
                else
                {
                    fillService(service);
                    if (serviceBS.Update(service))
                    {
                        MessageBox.Show("Se MODIFICÓ correctamente el servicio.");
                        this.Close();
                    }
                }
            }
        }

        private void fillService(Service service)
        {
            service.NameSer = txtName.Text;
            service.PriceSer = int.Parse(txtPrice.Text);
        }

        private bool validateFields()
        {
            if (!Helper.IsNotEmpty(txtName.Text, txtPrice.Text))
            {
                MessageBox.Show("Hay campos vacíos.", "ERROR");
                return false;
            }
            if (!Helper.IsNumeric(txtPrice.Text))
            {
                MessageBox.Show("El campo precio no acepta letras.", "ERROR");
                return false;
            }
            return true;
        }

    }
}
