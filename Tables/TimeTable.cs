using CTO.Controls;
using System;
using System.Collections.Generic;

namespace CTO.Tables
{
    public class TimeTable
    {
        public int OperationId { get; set; }
        public int RepairerId { get; set; }
        public int TypeOfWorkId { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public float Cost { get; set; }
        public int CarId { get; set; }
        public int StatusId { get; set; }

        public TimeTable()
        {
            OperationId = 0;
            RepairerId = 0;
            TypeOfWorkId = 0;
            StartTime = DateTime.Now;
            EndTime = DateTime.Now;
            Cost = 0;
            CarId = 0;
            StatusId = 0;
        }

        public TimeTable(int operationId, int repairerId, int typeOfWorkId, DateTime startTime, DateTime endTime, float cost, int carId, int statusId)
        {
            OperationId = operationId;
            RepairerId = repairerId;
            TypeOfWorkId = typeOfWorkId;
            StartTime = startTime;
            EndTime = endTime;
            Cost = cost;
            CarId = carId;
            StatusId = statusId;
        }

        public TimeTable(int repairerId, int typeOfWorkId, DateTime startTime, DateTime endTime, float cost, int carId, int statusId)
        {
            RepairerId = repairerId;
            TypeOfWorkId = typeOfWorkId;
            StartTime = startTime;
            EndTime = endTime;
            Cost = cost;
            CarId = carId;
            StatusId = statusId;
        }
        public string GetCarName()
        {
            SQLConnection conn = new SQLConnection();
            List<Cars> cars = conn.GetListCars();
            return cars.Find(ee => ee.CarId == CarId).ToString();
        }
        public string GetClientFIO()
        {
            SQLConnection conn = new SQLConnection();
            List<Clients> clients = conn.GetListClients();
            List<Cars> cars = conn.GetListCars();
            int clientId = cars.Find(ee => ee.CarId == CarId).ClientId;
            return clients.Find(ee => ee.ClientId == clientId).ClientFIO;
        }

        public string GetRepairertFIO()
        {
            SQLConnection conn = new SQLConnection();
            List<Repairers> repairers = conn.GetListRepairers();
            return repairers.Find(ee => ee.RepairerId == RepairerId).RepairerFIO;
        }

        public string GetTypeOfWorkName()
        {
            SQLConnection conn = new SQLConnection();
            List<TypeOfWork> types = conn.GetListTypeOfWork();
            return types.Find(ee => ee.TypeOfWorkId == TypeOfWorkId).TypeOfWorkName;
        }

        public string GetStatusName()
        {
            SQLConnection conn = new SQLConnection();
            List<StatusOfWork> status = conn.GetListStatusOfWork();
            return status.Find(ee => ee.StatusId == StatusId).Status;
        }
    }
}
