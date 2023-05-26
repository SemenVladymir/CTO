using CTO.Controls;
using CTO.Tables;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CTO
{
    public partial class Form2 : Form
    {
        string car;
        string operation;
        string repairer;
        SQLConnection conn = new SQLConnection();
        List<Clients> clients = new List<Clients>();
        List<Cars> cars = new List<Cars>();
        List<TypeOfWork> operations = new List<TypeOfWork>();
        List<Repairers> repairers = new List<Repairers>();
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            SetTime.Format = DateTimePickerFormat.Custom;
            SetTime.CustomFormat = "ddd   dd.MM.yyyy   HH:mm";
            clients = conn.GetListClients();
            cars = conn.GetListCars();
            operations = conn.GetListTypeOfWork();
            repairers = conn.GetListRepairers();

            foreach (Clients client in clients)
                Clients.Items.Add(client.ClientFIO);
            foreach (Cars car in cars)
                Cars.Items.Add(car.ToString());
            foreach (TypeOfWork work in operations)
                Operations.Items.Add(work.TypeOfWorkName);
            foreach (Repairers rep in repairers)
                Repairers.Items.Add(rep.ToString());

            Clients.SelectedIndexChanged += Clients_SelectedIndexChanged;
            Cars.SelectedIndexChanged += Cars_SelectedIndexChanged;
            Operations.SelectedIndexChanged += Operations_SelectedIndexChanged;


            btnCancel.Click += (s, ee) => { this.Close(); };
        }

        private void Operations_SelectedIndexChanged(object sender, EventArgs e)
        {
            Parts.Items.Clear();
            operations.Clear();
            operations = conn.GetListTypeOfWork();
            int operId = operations.Find(ee => Operations.SelectedItem.ToString().IndexOf(ee.TypeOfWorkName)>-1).TypeOfWorkId;

            List<Operation_Parts> oper_parts = conn.GetListOperation_Parts();
            List<Operation_Parts> ListPartsId = oper_parts.FindAll(ee => ee.TypeOfWorkId == operId);

            List<PartsForCars> parts = conn.GetListPartsForCar();
            List<PartsForCars> newParts = new List<PartsForCars>();
            foreach (Operation_Parts part in ListPartsId)
                Parts.Items.Add(parts.Find(ee => ee.PartId == part.PartId).PartName);
        }

        private void Cars_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Clients> newListClients = new List<Clients>();
            newListClients = clients.FindAll(ee => ee.ClientId == Cars.SelectedIndex + 1);
            Clients.Items.Clear();
            foreach (Clients client in newListClients)
                Clients.Items.Add(client.ClientFIO);
        }

        private void Clients_SelectedIndexChanged(object sender, EventArgs e)
        {
            List<Cars> newListCars = new List<Cars>();
            newListCars = cars.FindAll(ee=>ee.ClientId==Clients.SelectedIndex+1);
            Cars.Items.Clear();
            foreach (Cars car in newListCars)
                Cars.Items.Add(car.ToString());
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            Form3 newForm = new Form3();
            newForm.Show();
            newForm.Deactivate += (s, ee) => 
            {
                clients = conn.GetListClients();
                Clients.Items.Clear();
                foreach (Clients client in clients)
                    Clients.Items.Add(client.ClientFIO);
            };
        }

        private void btnAddCar_Click(object sender, EventArgs e)
        {
            Form4 newForm = new Form4();
            newForm.Show();
            newForm.Deactivate += (s, ee) => 
            {
                cars = conn.GetListCars();
                Cars.Items.Clear();
                foreach (Cars car in cars)
                    Cars.Items.Add(car.ToString());
            };
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            if (!(Cars.SelectedItem == null || Repairers.SelectedItem == null
                || Operations.SelectedItem == null || SetTime.Value == null))
            {
                List<Cars> cars = conn.GetListCars();
                car = Cars.SelectedItem.ToString();
                int CarId = cars.Find(ee => car.IndexOf(ee.CarName)>-1).CarId;

                List<Repairers> repairers = conn.GetListRepairers();
                repairer = Repairers.SelectedItem.ToString();
                int RepairersId = repairers.Find(ee => repairer.IndexOf(ee.RepairerFIO)>-1).RepairerId;

                List<TypeOfWork> operations = conn.GetListTypeOfWork();
                operation = Operations.SelectedItem.ToString();
                int OperationId = operations.Find(ee => ee.TypeOfWorkName == operation).TypeOfWorkId;

                float cost = operations.Find(ee=> ee.TypeOfWorkName == operation).CostOfWork;

                List<Operation_Parts> oper_parts = conn.GetListOperation_Parts();
                List<Operation_Parts> ListPartsId = oper_parts.FindAll(ee => ee.TypeOfWorkId == OperationId);

                List<PartsForCars> parts = conn.GetListPartsForCar();
                foreach (Operation_Parts part in ListPartsId)
                    cost += parts.Find(ee => ee.PartId == part.PartId).CostOfPart;


                TimeTable newTable = new TimeTable(RepairersId, OperationId, SetTime.Value, SetTime.Value, cost, CarId, 1);
                conn.AddNewOperationToTimeTable(newTable);


            }
            else
                MessageBox.Show("You need to fill in all fields of the form!");
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddOperation_Click(object sender, EventArgs e)
        {
            Form5 newForm = new Form5();
            newForm.Show();
            newForm.Deactivate += (s, ee) =>
            {
                List<TypeOfWork> operations = conn.GetListTypeOfWork();
                Operations.Items.Clear();
                foreach (TypeOfWork work in operations)
                    Operations.Items.Add(work.TypeOfWorkName);
            };
        }

        private void AddRepairer_Click(object sender, EventArgs e)
        {
            Form7 newForm = new Form7();
            newForm.Show();
            newForm.Deactivate += (s, ee) =>
            {
                repairers = conn.GetListRepairers();
                Repairers.Items.Clear();
                foreach (Repairers rep in repairers)
                    Repairers.Items.Add(rep.ToString());
            };
        }
    }
}
