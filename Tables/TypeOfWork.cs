using System.Collections.Generic;

namespace CTO.Tables
{
    internal class TypeOfWork
    {
        public int TypeOfWorkId { get; set; }
        public string TypeOfWorkName { get; set; }
        public float CostOfWork { get; set; }
        public List<PartsForCars> PartsForCars { get; set; }

        public TypeOfWork()
        {
            TypeOfWorkId = 0;
            TypeOfWorkName = string.Empty;
            CostOfWork = 0;
            PartsForCars = new List<PartsForCars>();
        }

        public TypeOfWork(int TypeOfWorkId, string TypeOfWorkName, float CostOfWork, List<PartsForCars> PartsForCars)
        {
            this.TypeOfWorkId = TypeOfWorkId;
            this.TypeOfWorkName = TypeOfWorkName;
            this.CostOfWork = CostOfWork;
            this.PartsForCars = PartsForCars;
        }

        public TypeOfWork(string TypeOfWorkName, float CostOfWork, List<PartsForCars> PartsForCars)
        {
            this.TypeOfWorkName = TypeOfWorkName;
            this.CostOfWork = CostOfWork;
            this.PartsForCars = PartsForCars;
        }
    }
}
