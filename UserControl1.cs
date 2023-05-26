using CTO.Controls;
using CTO.Tables;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CTO
{
    public partial class UserControl1 : UserControl
    {
        SQLConnection conn = new SQLConnection();
        public UserControl1()
        {
            InitializeComponent();

            this.MouseHover += UserControl1_MouseHover1;
            this.MouseLeave += UserControl1_MouseLeave1;
            this.Click += UserControl1_Click;
        }

        private void UserControl1_Click(object sender, EventArgs e)
        {
            List<Clients> newClients = conn.GetListClients();
            Form8 newForm = new Form8();
            newForm.numberId = Convert.ToInt32(NumberId.Text);
            newForm.client = ClientFIO.Text;
            newForm.phone = newClients.Find(ee => ee.ClientFIO == ClientFIO.Text).ClientPhone;
            newForm.car = Car.Text;
            newForm.operation = Operation.Text;
            newForm.repairer = Master.Text;
            newForm.startDateTime = Convert.ToDateTime(StartTime.Text);
            newForm.endDateTime = Convert.ToDateTime(EndTime.Text);
            newForm.status = Status.Text;
            newForm.Show();
            newForm.Deactivate += (s, ee) =>
            {
                Operation.Text = newForm.Operations.SelectedItem.ToString();
                Master.Text = newForm.Repairers.SelectedItem.ToString();
                StartTime.Text = newForm.SetTime.Value.ToString();
                EndTime.Text = newForm.EndTime.Value.ToString();
                Status.Text = newForm.Status.SelectedItem.ToString();
            };

        }

        private void UserControl1_MouseLeave1(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.BorderStyle = BorderStyle.None;
        }

        private void UserControl1_MouseHover1(object sender, EventArgs e)
        {
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.BorderStyle = BorderStyle.FixedSingle;
        }

        public UserControl1(TimeTable table) : this()
        {
            NumberId.Text = table.OperationId.ToString();
            ClientFIO.Text = table.GetClientFIO();
            Car.Text = table.GetCarName();
            Operation.Text = table.GetTypeOfWorkName();
            StartTime.Text = table.StartTime.ToString();
            EndTime.Text = table.EndTime.ToString();
            Master.Text = table.GetRepairertFIO();
            Status.Text = table.GetStatusName();
        }
    }
}
