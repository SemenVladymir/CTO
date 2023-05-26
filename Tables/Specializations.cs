namespace CTO.Tables
{
    internal class Specializations
    {
        //public int 
        public string SpecName { get; set; }

        public Specializations()
        {
            SpecName = string.Empty;
        }

        public Specializations(string specName)
        {
            SpecName = specName;
        }
    }
}
