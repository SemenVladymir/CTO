namespace CTO.Tables
{
    internal class StatusOfWork
    {
        public int StatusId { get; set; }
        public string Status { get; set; }

        public StatusOfWork()
        {
            StatusId = 0;
            Status = string.Empty;
        }

        public StatusOfWork(int StatusId, string status)
        {
            this.StatusId = StatusId;
            Status = status;
        }

        public StatusOfWork(string status)
        {
            Status = status;
        }
    }
}
