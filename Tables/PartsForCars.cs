namespace CTO.Tables
{
    internal class PartsForCars
    {
        public int PartId { get; set; }
        public string PartName { get; set; }
        public int CarBrandId { get; set; }
        public float CostOfPart { get; set; }

        public PartsForCars()
        {
            PartId = 0;
            PartName = string.Empty;
            CarBrandId = 0;
            CostOfPart = 0;
        }

        public PartsForCars(int PartId, string PartName, int CarBrandId, float CostOfPart)
        {
            this.PartId = PartId;
            this.PartName = PartName;
            this.CarBrandId = CarBrandId;
            this.CostOfPart = CostOfPart;
        }

        public PartsForCars(string PartName, int CarBrandId, float CostOfPart)
        {
            this.PartName = PartName;
            this.CarBrandId = CarBrandId;
            this.CostOfPart = CostOfPart;
        }
    }
}
