using CTO.Controls;
using CTO.Tables;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CTO
{
    public partial class Form7 : Form
    {
        SQLConnection conn = new SQLConnection();
        List<Specializations> specializations;
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            specializations = conn.GetListSpecializations();
            foreach (var spec in specializations)
                Select.Items.Add(spec.SpecName);
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (RepairerName.Text != null && SpecList.Items.Count > 0 && Level.Text != null)
            {
                List<Specializations> Spec = conn.GetListSpecializations();
                List<Specializations> newSpec = new List<Specializations>();
                foreach (var item in SpecList.Items)
                    newSpec.Add(Spec.Find(ee => ee.SpecName ==item.ToString()));
                Repairers newRepairer = new Repairers(RepairerName.Text, 1, Convert.ToInt32(Level.Text));
                conn.AddNewRepairer(newRepairer);
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
            if (Select.SelectedItem != null)
            {
                SpecList.Items.Add(Select.SelectedItem.ToString());
            }
        }

        private void Level_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char number = e.KeyChar;
            if (!char.IsDigit(number) && number != 8)
                e.Handled = true;
        }
    }
}
