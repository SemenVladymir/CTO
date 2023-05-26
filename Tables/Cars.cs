using CTO.Controls;
using CTO.Tables;
using System.Collections.Generic;

namespace CTO
{
    internal class Cars
    {
        public int CarId { get; set; }
        public string CarName { get; set; }
        public int CarBrandId { get; set; }
        public int CarYearMade { get; set; }
        public int ClientId { get; set; }

        public Cars()
        {
            CarId = 0;
            CarName = string.Empty;
            CarBrandId = 0;
            CarYearMade = 0;
            ClientId = 0;
        }

        public Cars(int CarId, string carName, int carBrandId, int carYearMade, int clientId)
        {
            this.CarId = CarId;
            CarName = carName;
            CarBrandId = carBrandId;
            CarYearMade = carYearMade;
            ClientId = clientId;
        }

        public Cars(string carName, int carBrandId, int carYearMade, int clientId)
        {
            CarName = carName;
            CarBrandId = carBrandId;
            CarYearMade = carYearMade;
            ClientId = clientId;
        }

        public override string ToString()
        {
            SQLConnection conn = new SQLConnection();
            List<CarBrands> brands = conn.GetListCarBrands();
            return $"{brands[CarBrandId-1].BrandName} {CarName} {CarYearMade}";
        }

        public int GetCarId(string carName)
        {
                SQLConnection conn = new SQLConnection();
                List<Cars> cars = conn.GetListCars();
                return cars.Find(ee => ee.CarName.Equals(carName)).CarId;
        }
    }
}
