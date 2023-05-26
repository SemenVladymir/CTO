using CTO.Controls;
using CTO.Tables;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CTO
{
    public partial class Form4 : Form
    {
        SQLConnection conn = new SQLConnection();
        List<CarBrands> brands;
        List<Clients> clients;

        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            brands = conn.GetListCarBrands();
            foreach (CarBrands brand in brands)
                CarBrands.Items.Add(brand.BrandName);
            clients = conn.GetListClients();
            foreach (Clients client in clients)
                Clients.Items.Add(client.ClientFIO);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!(Clients.SelectedItem==null && string.IsNullOrEmpty(NewCarName.Text) && string.IsNullOrEmpty(NewCarYear.Text) && CarBrands.SelectedItem == null))
            {
                string ClientName = Clients.SelectedItem.ToString();

                string NameOfCar = NewCarName.Text;
                int YearOfCar = Convert.ToInt32(NewCarYear.Text);
                brands = conn.GetListCarBrands();
                int BrandId = brands.Find(ee => ee.BrandName.Equals(CarBrands.SelectedItem.ToString())).CarBrandId;
                List<Clients> Clientslist = conn.GetListClients();
                int ClientId = Clientslist.Find(ee => ee.ClientFIO.Equals(ClientName)).ClientId;
                Cars newCar = new Cars(NameOfCar, BrandId, YearOfCar, ClientId);
                conn.AddNewCar(newCar);
            }
            else
                MessageBox.Show("You need to fill in all fields of the form!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void NewCarYear_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char number = e.KeyChar;
            if (!char.IsDigit(number) && number!=8)
                e.Handled = true;
        }
    }
}
