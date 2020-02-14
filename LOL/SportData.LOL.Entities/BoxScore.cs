using System;
using System.Collections.Generic;
using System.Text;

namespace SportData.LOL.Entities
{
    public class BoxScores : List<BoxScore>
    { }
    public class BoxScore
    {
        public Game Game { get; set; }

        public List<Match> Matches { get; set; }

        public List<PlayerGame> PlayerGames { get; set; }

        public List<Team> TeamGames { get; set; }
    }
}
