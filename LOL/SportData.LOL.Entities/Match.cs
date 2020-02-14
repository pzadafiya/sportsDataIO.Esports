using System;
using System.Collections.Generic;
using System.Text;

namespace SportData.LOL.Entities
{
    public class Matchs : List<Match>
    { }
    public class Match
    {
        public int GameId { get; set; }

        public int Number { get; set; }

        public string MapName { get; set; }

        public int? WinningTeamId { get; set; }

        public string GameVersion { get; set; }

        public List<MatchBan> MatchBans { get; set; }

        public List<PlayerMatch> PlayerMatches { get; set; }        
    }
}
