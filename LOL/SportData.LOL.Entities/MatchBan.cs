using System;
using System.Collections.Generic;
using System.Text;

namespace SportData.LOL.Entities
{
    public class MatchBans : List<MatchBan>
    { }
    public class MatchBan
    {
        public int MatchId { get; set; }

        public int TeamId { get; set; }

        public int? ChampionId { get; set; }

        public ChampionInfo Champion { get; set; }

    }

}
