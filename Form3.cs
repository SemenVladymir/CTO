using CTO.Controls;
using CTO.Tables;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CTO
{
    public partial class Form3 : Form
    {
        SQLConnection conn = new SQLConnection();
        List<CarBrands> brands;

        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            brands = conn.GetListCarBrands();
            foreach (CarBrands brand in brands)
                CarBrands.Items.Add(brand.BrandName);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (!(string.IsNullOrEmpty(NewClientName.Text) && string.IsNullOrEmpty(NewCarName.Text) && string.IsNullOrEmpty(ClientPhone.Text)
                && string.IsNullOrEmpty(NewCarYear.Text) && CarBrands.SelectedItem==null))
            {
                string ClientName = NewClientName.Text;
                string ClientPhoneNumb = ClientPhone.Text;
                Clients newClient = new Clients(ClientName, ClientPhoneNumb);
                conn.AddNewClient(newClient);

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
            if (!char.IsDigit(number) && number != 8)
                e.Handled = true;
        }
    }
}
