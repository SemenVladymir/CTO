using CTO.Controls;
using System.Collections.Generic;

namespace CTO.Tables
{
    internal class Repairers
    {
        public int RepairerId { get; set; }
        public string RepairerFIO { get; set; }
        public int RepairerSpecId { get; set; }
        public int RepairerLevel { get; set; }

        public Repairers()
        {
            RepairerId = 0;
            RepairerFIO = string.Empty;
            RepairerLevel = 0;
            RepairerSpecId = 0;
        }

        public Repairers(int RepairerId, string RepairerFIO, int RepairerSpecId, int RepairerLevel)
        {
            this.RepairerId = RepairerId;
            this.RepairerFIO = RepairerFIO;
            this.RepairerSpecId = RepairerSpecId;
            this.RepairerLevel = RepairerLevel;
        }

        public Repairers(string RepairerFIO, int RepairerSpecId, int RepairerLevel)
        {
            this.RepairerFIO = RepairerFIO;
            this.RepairerSpecId = RepairerSpecId;
            this.RepairerLevel = RepairerLevel;
        }

        public override string ToString()
        {
            SQLConnection conn = new SQLConnection();
            List <Specializations> spec = conn.GetListSpecializations();
            return $"{RepairerFIO} {spec[RepairerSpecId-1].SpecName}";
        }
    }
}
