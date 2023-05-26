using CTO.Controls;
using CTO.Tables;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CTO
{
    public partial class Form8 : Form
    {
        public int numberId;
        public string client;
        public string phone;
        public string car;
        public string operation;
        public DateTime startDateTime;
        public DateTime endDateTime;
        public string repairer;
        public float cost;
        public string status;
        SQLConnection conn = new SQLConnection();
        List<TimeTable> table = new List<TimeTable>();
        List<PartsForCars> parts = new List<PartsForCars>();
        List<Clients> clients = new List<Clients>();
        List<Cars> cars = new List<Cars>();
        List<TypeOfWork> operations = new List<TypeOfWork>();
        List<Repairers> repairers = new List<Repairers>();
        List<StatusOfWork> statuses = new List<StatusOfWork>();
        TimeTable timeTable;
        public Form8()
        {
            InitializeComponent();
        }

        private void Form8_Load(object sender, EventArgs e)
        {
            SetTime.Format = DateTimePickerFormat.Custom;
            SetTime.CustomFormat = "dd.MM.yyyy HH:mm";
            EndTime.Format = DateTimePickerFormat.Custom;
            EndTime.CustomFormat = "dd.MM.yyyy HH:mm";
            ClientFIO.Text = client;
            Phone.Text = phone;
            CarName.Text = car;
            SetTime.Value = startDateTime;
            EndTime.Value = endDateTime;

            cars = conn.GetListCars();
            parts = conn.GetListPartsForCar();
            table = conn.GetListOperationsFromTimeTable();
            operations = conn.GetListTypeOfWork();
            repairers = conn.GetListRepairers();
            statuses = conn.GetListStatusOfWork();
            Operations.SelectedIndexChanged += Operations_SelectedIndexChanged;


            int carId = cars.Find(ee => car.IndexOf(ee.CarName) > -1).CarId;
            int repairerId = table.Find(ee=> ee.CarId == carId).RepairerId;


            foreach (TypeOfWork work in operations)
                Operations.Items.Add(work.TypeOfWorkName);
            Operations.SelectedItem = operation;
            foreach (Repairers rep in repairers)
                Repairers.Items.Add(rep.ToString());
            Repairers.SelectedItem = repairers.Find(ee=>ee.RepairerId==repairerId).ToString();
            foreach (var part in parts)
                Part.Items.Add(part.PartName);
            foreach (var stat in statuses)
                Status.Items.Add(stat.Status);
            Status.SelectedItem = status;
            Cost.Text = table.Find(ee => ee.CarId == carId).Cost.ToString();
        }

        private void Operations_SelectedIndexChanged(object sender, EventArgs e)
        {
            Parts.Items.Clear();
            operations.Clear();
            operations = conn.GetListTypeOfWork();
            int operId = operations.Find(ee => Operations.SelectedItem.ToString().IndexOf(ee.TypeOfWorkName) > -1).TypeOfWorkId;

            List<Operation_Parts> oper_parts = conn.GetListOperation_Parts();
            List<Operation_Parts> ListPartsId = oper_parts.FindAll(ee => ee.TypeOfWorkId == operId);

            List<PartsForCars> parts = conn.GetListPartsForCar();
            foreach (Operation_Parts part in ListPartsId)
                Parts.Items.Add(parts.Find(ee => ee.PartId == part.PartId).PartName);
        }

        private void AddPart_Click(object sender, EventArgs e)
        {
            if (Part.SelectedItem != null)
            {
                Parts.Items.Add(Part.SelectedItem.ToString());
            }
        }

        private void NewPart_Click(object sender, EventArgs e)
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

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int carId = cars.Find(ee => car.IndexOf(ee.CarName) > -1).CarId;
            int operationId = operations.Find(ee => ee.TypeOfWorkName == Operations.SelectedItem.ToString()).TypeOfWorkId;
            int statusId = statuses.Find(ee => ee.Status == Status.SelectedItem.ToString()).StatusId;
            int repairerId = repairers.Find(ee => Repairers.SelectedItem.ToString().IndexOf(ee.RepairerFIO)>-1).RepairerId;

            timeTable = new TimeTable(numberId, repairerId, operationId, SetTime.Value, EndTime.Value, (float)Math.Round(Convert.ToDouble(Cost.Text), 2), carId, statusId);
            conn.UpdateOperationTimeTable(timeTable);
            this.Close();
        }
    }
}
