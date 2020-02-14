using System;
using System.Collections.Generic;
using System.Text;

namespace SportData.CSGO.Entities
{
    public class Venues : List<Venue>
    { }
    public class Venue
    {
        public int VenueId { get; set; }

        public string Name { get; set; }

        public string Address { get; set; }

        public string City { get; set; }

        public string Zip { get; set; }

        public string Country { get; set; }

        public bool Open { get; set; }

        public int? Opened { get; set; }

        public string Nickname1 { get; set; }

        public string Nickname2 { get; set; }

        public int? Capacity { get; set; }

        public decimal? GeoLat { get; set; }

        public decimal? GeoLong { get; set; }

    }
}
