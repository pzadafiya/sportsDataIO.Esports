using System;
using System.Collections.Generic;
using System.Text;

namespace SportData.LOL.Entities
{
    public class Players : List<Player>
    { }
    public class Player
    {
        public int PlayerId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string CommonName { get; set; }

        public string MatchName { get; set; }

        public string Position { get; set; }

        public string Gender { get; set; }

        public DateTime? BirthDate { get; set; }

        public string BirthCity { get; set; }

        public string BirthCountry { get; set; }

        public string Nationality { get; set; }

        public DateTime? Updated { get; set; }

    }

}
