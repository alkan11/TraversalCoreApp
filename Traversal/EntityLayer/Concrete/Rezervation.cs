using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Rezervation
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public User? User { get; set; }
        public string? PersonCount { get; set; }
        public string? Description { get; set; }
        public DateTime RezervationDate { get; set; }
        public int Status { get; set; }
        public int DestinationID { get; set; }
        public Destination? Destination { get; set; }
    }
}
