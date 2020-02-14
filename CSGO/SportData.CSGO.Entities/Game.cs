using System;
using System.Collections.Generic;
using System.Text;

namespace SportData.CSGO.Entities
{
    public class Games : List<Game>
    { }
    public class Game
    {
        public int GameId { get; set; }

        public int RoundId { get; set; }

        public int Season { get; set; }

        public int SeasonType { get; set; }

        public string Group { get; set; }

        public int? TeamAId { get; set; }

        public int? TeamBId { get; set; }

        public int? VenueId { get; set; }

        public DateTime? Day { get; set; }

        public DateTime? DateTime { get; set; }

        public string Status { get; set; }

        public int? Week { get; set; }

        public string BestOf { get; set; }

        public string Winner { get; set; }

        public string VenueType { get; set; }

        public string TeamAKey { get; set; }

        public string TeamAName { get; set; }

        public int? TeamAScore { get; set; }

        public string TeamBKey { get; set; }

        public string TeamBName { get; set; }

        public int? TeamBScore { get; set; }

        public int? TeamAMoneyLine { get; set; }

        public int? TeamBMoneyLine { get; set; }

        public int? DrawMoneyLine { get; set; }

        public decimal? PointSpread { get; set; }

        public int? TeamAPointSpreadPayout { get; set; }

        public int? TeamBPointSpreadPayout { get; set; }

        public DateTime? Updated { get; set; }

        public DateTime? UpdatedUtc { get; set; }
    }
}
