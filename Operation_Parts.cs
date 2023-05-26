namespace CTO
{
    internal class Operation_Parts
    {
        public int TypeOfWorkId { get; set; }
        public int PartId { get; set; }

        public Operation_Parts()
        {
            TypeOfWorkId = 0;
            PartId = 0;
        }

        public Operation_Parts(int TypeOfWorkId, int PartId)
        {
            this.TypeOfWorkId = TypeOfWorkId;
            this.PartId = PartId;
        }
    }
}
