using System;
using System.Collections.Generic;
using System.Text;

namespace SportData.CSGO.Entities
{
    public class Rounds : List<Round>
    { }
    public class Round
    {
        public int RoundId { get; set; }

        public int SeasonId { get; set; }

        public int Season { get; set; }

        public int SeasonType { get; set; }

        public string Name { get; set; }

        public string Type { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public int? CurrentWeek { get; set; }

        public bool CurrentRound { get; set; }

    }

}
