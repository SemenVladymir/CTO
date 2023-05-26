namespace CTO.Tables
{
    internal class Countries
    {
        public int CountryId { get; set; }
        public string NameOfCountry { get; set; }

        public Countries()
        {
            CountryId = 0;
            NameOfCountry = string.Empty;
        }

        public Countries(int countryId, string nameOfCountry)
        {
            CountryId = countryId;
            NameOfCountry = nameOfCountry;
        }

        public override string ToString()
        {
            return NameOfCountry;
        }
    }
}
