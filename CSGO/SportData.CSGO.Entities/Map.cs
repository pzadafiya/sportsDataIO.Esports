using System;
using System.Collections.Generic;
using System.Text;

namespace SportData.CSGO.Entities
{
    public class Maps : List<Map>
    { }
    public class Map
    {
        public int? Number { get; set; }

        public string Name { get; set; }

        public string Status { get; set; }

        public int? CurrentRound { get; set; }

        public int? TeamAScore { get; set; }

        public int? TeamBScore { get; set; }

        public List<Leaderboard> Leaderboards { get; set; }
    }
}
