using CTO.Controls;
using CTO.Tables;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CTO
{
    public partial class Form5 : Form
    {
        SQLConnection conn = new SQLConnection();
        List<PartsForCars> parts;

        public Form5()
        {
            InitializeComponent();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            parts = conn.GetListPartsForCar();
            foreach (var part in parts)
                Part.Items.Add(part.PartName);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (Operation.Text != null && PartList.Items.Count > 0 && Cost.Text != null)
            {
                List<PartsForCars> newPartsList = new List<PartsForCars>();
                parts = conn.GetListPartsForCar();
                foreach(var part in PartList.Items)
                    newPartsList.Add(parts.Find(ee => ee.PartName == part.ToString()));
                TypeOfWork newType = new TypeOfWork(Operation.Text, (float)Math.Round(Convert.ToDouble(Cost.Text)), newPartsList);
                conn.AddNewTypeOfWork(newType);
            }
            else
                MessageBox.Show("You need to fill in all fields of the form!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AddPart_Click(object sender, EventArgs e)
        {
            if (Part.SelectedItem!=null)
            {
                PartList.Items.Add(Part.SelectedItem.ToString());
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form6 newForm = new Form6();
            newForm.Show();
            newForm.Deactivate += (s, ee) =>
            {
                parts.Clear();
                parts = conn.GetListPartsForCar();
                Part.Items.Clear();
                foreach (var part in parts)
                    Part.Items.Add(part.PartName);
            };
        }

        private void Cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8 && number != 44)
                e.Handled = true;
        }
    }
}
