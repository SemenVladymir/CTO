using CTO.Controls;
using System.Collections.Generic;


namespace CTO.Tables
{
    internal class CarBrands
    {
        public int CarBrandId { get; set; }
        public string BrandName { get; set; }
        public int CountryId { get; set; }
        public string CountryName { get; set; }


        public CarBrands()
        {
            CarBrandId = 0;
            BrandName = string.Empty;
            CountryId = 0;
            CountryName = string.Empty;
        }

        public CarBrands(int CarBrandId, string brandName, int countryId)
        {
            this.CarBrandId = CarBrandId;
            SQLConnection conn = new SQLConnection();
            List<Countries> country = new List<Countries>();
            country = conn.GetListCountry();
            BrandName = brandName;
            CountryId = countryId;
            CountryName = country.Find(e =>  e.CountryId == countryId ).ToString();
        }

        public CarBrands(string brandName, int countryId)
        {
            SQLConnection conn = new SQLConnection();
            List<Countries> country = new List<Countries>();
            country = conn.GetListCountry();
            BrandName = brandName;
            CountryId = countryId;
            CountryName = country.Find(e => e.CountryId == countryId).ToString();
        }

        public string GetCarBrand()
        {
            return BrandName;
        }
    }
}
