using System.Net.Sockets;

namespace FluentValidationDemo.Models
{
    public class Studio
    {
        public string Name { get; set; }
        public int YearOfEstablishment { get; set; }
        public int TotalRevenue { get; set; }
        public List<Game> Games { get; set; }
        public Address Address { get; set; }
    }
}