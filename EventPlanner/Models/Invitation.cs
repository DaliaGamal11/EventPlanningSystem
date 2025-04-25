using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventPlanner.Models
{
    public enum RSVPStatus
    {
        Pending,
        Confirmed,
        Declined
    }

    internal class Invitation
    {
        public int Id { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }

        public int GuestId { get; set; }
        public Guest Guest { get; set; }

        public RSVPStatus RSVPStatus { get; set; }
        public string Note { get; set; }
    }
}
