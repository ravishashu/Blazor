namespace ServerManagement.Models
{
    public class Server
    {
        public Server()
        {
            Random random = new Random();
            int randomNumnber = random.Next(0, 2);
            IsOnline = randomNumnber != 0;
        }
        public int ServerId { get; set; }
        public bool IsOnline { get; set; }
        public string? Name { get; set; }
        public string? City { get; set; }
    }
}
