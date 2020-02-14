using System;
using System.Collections.Generic;
using System.Text;

namespace SportData.LOL.Entities
{
    public class CompetitionDetails : List<CompetitionDetail>
    { }
    public class CompetitionDetail
    {
        public int CompetitionId { get; set; }

        public int AreaId { get; set; }

        public string AreaName { get; set; }

        public string Name { get; set; }

        public string Gender { get; set; }

        public string Type { get; set; }

        public string Format { get; set; }

        public Season CurrentSeason { get; set; }

        public List<TeamDetail> Teams { get; set; }

        public List<Game> Games { get; set; }

        public List<Season> Seasons { get; set; }
    }

}
