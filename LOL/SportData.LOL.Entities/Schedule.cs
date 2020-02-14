using System;
using System.Collections.Generic;
using System.Text;

namespace SportData.LOL.Entities
{
    public class Schedules : List<Schedule>
    { }
    public class Schedule
    {
        public int StandingId { get; set; }

        public int RoundId { get; set; }

        public int TeamId { get; set; }

        public string Name { get; set; }

        public int Order { get; set; }

        public int Games { get; set; }

        public int Wins { get; set; }

        public int Losses { get; set; }

        public int Points { get; set; }

        public int ScoreFor { get; set; }

        public int ScoreAgainst { get; set; }

        public int ScoreDifference { get; set; }

        public string Group { get; set; }
    }
}
