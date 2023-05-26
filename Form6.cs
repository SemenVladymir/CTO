using CTO.Controls;
using CTO.Tables;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CTO
{
    public partial class Form6 : Form
    {
        SQLConnection conn = new SQLConnection();
        List<CarBrands> brands;
        public Form6()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (PartName.Text!="" && CarBrand.SelectedItem!=null && PartCost.Text != null)
            {
                List<CarBrands> brends = conn.GetListCarBrands();
                int BreanId = brends.Find(ee => ee.BrandName == CarBrand.SelectedItem.ToString()).CarBrandId;
                PartsForCars newPart = new PartsForCars(PartName.Text, BreanId, (float)Math.Round(Convert.ToDouble(PartCost.Text), 2));
                conn.AddNewPartForCar(newPart);
            }
            else
                MessageBox.Show("You need to fill in all fields of the form!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            brands = conn.GetListCarBrands();
            foreach (CarBrands brand in brands)
                CarBrand.Items.Add(brand.BrandName);
        }

        private void PartCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8 && number!=44)
                e.Handled = true;
        }
    }
}
