using System;
using System.Collections.Generic;
using System.Text;

namespace SportData.LOL.Entities
{
    public class Areas : List<Area>
    { }
    public class Area
    {
        public int AreaId { get; set; }

        public string CountryCode { get; set; }

        public string Name { get; set; }

    }
}
