using CTO.Tables;
using Dapper;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace CTO.Controls
{
    internal class SQLConnection
    {
        readonly string strConn;

        public SQLConnection()
        {
            strConn = "Server=DESKTOP-MV43C0T;Database=CTO;Trusted_Connection=True;TrustServerCertificate=True;";
        }

        public SQLConnection(string strConn)
        {
            this.strConn = strConn;
        }


        //Countries
        public List<Countries> GetListCountry()
        {
            List<Countries> countries = new List<Countries>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                countries = conn.Query<Countries>("SELECT * FROM [Countries];").ToList();
            }
            return countries;
        }
        public void AddNewCountry(string NameOfCountry)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                conn.Execute("INSERT INTO [Countries]([NameOfCountry]) VALUES (@NameOfCountry)", new { NameOfCountry });
            }
        }


        //Cars
        public List<Cars> GetListCars()
        {
            List<Cars> cars = new List<Cars>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                cars = conn.Query<Cars>("SELECT * FROM [Cars];").ToList();
            }
            return cars;
        }
        public void AddNewCar(Cars NewCar)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                conn.Execute("INSERT INTO [Cars]([CarName],[CarBrandId],[CarYearMade],[ClientId]) VALUES (@CarName, @CarBrandId, @CarYearMade, @ClientId)",
                    new { NewCar.CarName, NewCar.CarBrandId, NewCar.CarYearMade, NewCar.ClientId });
            }
        }


        //Car brands
        public List<CarBrands> GetListCarBrands ()
        {
            List<CarBrands> carBrands = new List<CarBrands>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                carBrands = conn.Query<CarBrands>("SELECT * FROM [BrandsOfCars];").ToList();
            }
            return carBrands;
        }
        public void AddNewCarBrand(CarBrands brand)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                conn.Execute("INSERT INTO [BrandsOfCars]([BrandName],[CountryId]) VALUES(@BrandName, @CountryId)", new { brand.BrandName, brand.CountryId });
            }
        }


        //Clients
        public List<Clients> GetListClients()
        {
            List<Clients> clients = new List<Clients>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                clients = conn.Query<Clients>("SELECT * FROM [Clients];").ToList();
            }
            return clients;
        }
        public void AddNewClient(Clients client)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                conn.Execute("INSERT INTO [Clients]([ClientFIO],[ClientPhone]) VALUES(@ClientFIO, @ClientPhone)",
                    new { client.ClientFIO, client.ClientPhone });
            }
        }


        //Repairers
        public List<Repairers> GetListRepairers()
        {
            List<Repairers> repairers = new List<Repairers>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                repairers = conn.Query<Repairers>("SELECT * FROM [Repairers];").ToList();
            }
            return repairers;
        }
        public void AddNewRepairer(Repairers newrep)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                conn.Execute("INSERT INTO [Repairers]([RepairerFIO],[RepairerSpecId],[RepairerLevel]) VALUES(@RepairerFIO, @RepairerSpecId, @RepairerLevel)", new { newrep.RepairerFIO, newrep.RepairerSpecId, newrep.RepairerLevel });
            }
        }


        //Parts for cars
        public List<PartsForCars> GetListPartsForCar()
        {
            List<PartsForCars> parts = new List<PartsForCars>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                parts = conn.Query<PartsForCars>("SELECT * FROM [PartsForCars];").ToList();
            }
            return parts;
        }
        public void AddNewPartForCar(PartsForCars newPart)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                conn.Execute("INSERT INTO [PartsForCars]([PartName],[CarBrandId],[CostOfPart]) VALUES(@PartName, @CarBrandId, @CostOfPart)", new { newPart.PartName, newPart.CarBrandId, newPart.CostOfPart });
            }
        }


        //Specializations of repairers
        public List<Specializations> GetListSpecializations()
        {
            List<Specializations> spec = new List<Specializations>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                spec = conn.Query<Specializations>("SELECT * FROM [Specializations];").ToList();
            }
            return spec;
        }
        public void AddNewSpecialization(Specializations newSpec)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                conn.Execute("INSERT INTO [Specializations]([SpecName]) VALUES(@SpecName)", new { newSpec.SpecName });
            }
        }


        //Status of work
        public List<StatusOfWork> GetListStatusOfWork()
        {
            List<StatusOfWork> status = new List<StatusOfWork>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                status = conn.Query<StatusOfWork>("SELECT * FROM [StatusOfWork];").ToList();
            }
            return status;
        }


        //Type of works
        public List<TypeOfWork> GetListTypeOfWork()
        {
            List<TypeOfWork> workType = new List<TypeOfWork>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                workType = conn.Query<TypeOfWork>("SELECT * FROM [TypeOfWorkS];").ToList();
            }
            return workType;
        }
        public void AddNewTypeOfWork(TypeOfWork newType)
        {
            if (newType != null)
            {
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    conn.Execute("INSERT INTO [TypeOfWorks]([TypeOfWorkName],[CostOfWork]) VALUES(@TypeOfWorkName, @CostOfWork)", new { newType.TypeOfWorkName, newType.CostOfWork });
                    List<TypeOfWork> list = GetListTypeOfWork();
                    foreach (var item in newType.PartsForCars)
                    {
                        conn.Execute("INSERT INTO [TypeOfWorks_Parts]([TypeOfWorkId],[PartId]) VALUES(@TypeOfWorkId, @PartId)", new { list[list.Count - 1].TypeOfWorkId, item.PartId });
                    }
                }
            }
        }


        //Type of work with Parts
        public List<Operation_Parts> GetListOperation_Parts()
        {
            List<Operation_Parts> oper_parts = new List<Operation_Parts>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                oper_parts = conn.Query<Operation_Parts>("SELECT * FROM [TypeOfWorks_Parts];").ToList();
            }
            return oper_parts;
        }
        public void AddNewOperation_Parts(Operation_Parts oper_parts)
        {
            if (oper_parts != null)
            {
                List<Operation_Parts> parts = new List<Operation_Parts>();
                using (SqlConnection conn = new SqlConnection(strConn))
                {
                    conn.Open();
                    conn.Execute("INSERT INTO [TypeOfWorks_Parts]([TypeOfWorkId],[PartId]) VALUES(@TypeOfWorkId, @PartId)", new { oper_parts.TypeOfWorkId, oper_parts.PartId });
                }
            }
        }


        //Table of timing
        public List<TimeTable> GetListOperationsFromTimeTable()
        {
            List<TimeTable> timeTable = new List<TimeTable>();
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                timeTable = conn.Query<TimeTable>("SELECT * FROM [TimeTable];").ToList();
            }
            return timeTable;
        }
        public void AddNewOperationToTimeTable(TimeTable newOperation)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                conn.Execute("INSERT INTO [TimeTable]([RepairerId],[TypeOfWorkId],[StartTime],[EndTime],[Cost],[CarId],[StatusId])" +
                    "VALUES(@RepairerId, @TypeOfWorkId, @StartTime, @EndTime, @Cost, @CarId, @StatusId)",
                    new { newOperation.RepairerId, newOperation.TypeOfWorkId, newOperation.StartTime, newOperation.EndTime, newOperation.Cost, newOperation.CarId, newOperation.StatusId });
            }
        }
        public void UpdateOperationTimeTable (TimeTable newOperation)
        {
            using (SqlConnection conn = new SqlConnection(strConn))
            {
                conn.Open();
                conn.Execute("UPDATE TimeTable SET RepairerId=@RepairerId, TypeOfWorkId=@TypeOfWorkId, StartTime=@StartTime, EndTime=@EndTime, Cost=@Cost, CarId=@CarId, StatusId=@StatusId WHERE OperationId=@OperationId",
                    new { newOperation.RepairerId, newOperation.TypeOfWorkId, newOperation.StartTime, newOperation.EndTime, newOperation.Cost, newOperation.CarId, newOperation.StatusId, newOperation.OperationId });
            }
        }
    }
}
