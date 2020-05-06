using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sneaker_Data
{
    public class Profile
    {
        public int ProfileId { get; set; }
        public Guid OwnerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }
        public string Username { get; set; }
        public DateTimeOffset DateOfBirth { get; set; }
        public string Email { get; set; }
        //public Sneaker SneakerTable { get; set; }
        //public Trade TradeTable { get; set; }
        public List<Sneaker> OwnedSneakers { get; set; }

    }
}
