namespace CTO
{
    internal class Clients
    {
        public int ClientId { get; set; }
        public string ClientFIO { get; set; }
        public string ClientPhone { get; set; }
       

        public Clients()
        {
            ClientId = 0;
            ClientFIO = string.Empty;
            ClientPhone = string.Empty;
        }

        public Clients(int ClientId, string ClientFIO, string ClientPhone)
        {
            this.ClientId = ClientId;
            this.ClientFIO = ClientFIO;
            this.ClientPhone = ClientPhone;
        }

        public Clients(string ClientFIO, string ClientPhone)
        {
            this.ClientFIO = ClientFIO;
            this.ClientPhone = ClientPhone;
        }
        public override string ToString()
        {
            return $"Client: {ClientFIO}, Phone: {ClientPhone}";
        }
    }
}
