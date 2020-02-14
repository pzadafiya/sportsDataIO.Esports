using System;
using System.Collections.Generic;
using System.Text;

namespace SportData.LOL.Entities
{
    public class Seasons : List<Season>
    { }
    public class Season
    {
        public int SeasonId { get; set; }

        public int CompetitionId { get; set; }

        public int season { get; set; }

        public string Name { get; set; }

        public string CompetitionName { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public bool CurrentSeason { get; set; }

        public List<Round> Rounds { get; set; }

    }

}
