using System;
using System.Collections.Generic;
using System.Text;

namespace SportData.CSGO.Entities
{
    public class Competitions : List<Competition>
    { }
    public class Competition
    {
        public int CompetitionId { get; set; }

        public int AreaId { get; set; }

        public string AreaName { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public string Type { get; set; }

        public string Format { get; set; }

        public List<Season> Seasons { get; set; }

    }

}
