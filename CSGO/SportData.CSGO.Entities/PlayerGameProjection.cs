using System;
using System.Collections.Generic;
using System.Text;

namespace SportData.CSGO.Entities
{
    public class PlayerGameProjections : List<PlayerGameProjection>
    { }
    public class PlayerGameProjection
    {
        public int PlayerId { get; set; }

        public int? TeamId { get; set; }

        public string Name { get; set; }

        public string MatchName { get; set; }

        public string Team { get; set; }

        public int? GameId { get; set; }

        public int? OpponentId { get; set; }

        public string Opponent { get; set; }

        public DateTime? Day { get; set; }

        public DateTime? DateTime { get; set; }

        public DateTime? Updated { get; set; }

        public DateTime? UpdatedUtc { get; set; }

        public int? Games { get; set; }

        public decimal? Maps { get; set; }

        public decimal? FantasyPoints { get; set; }

        public decimal? Kills { get; set; }

        public decimal? Assists { get; set; }

        public decimal? Deaths { get; set; }

        public decimal? Headshots { get; set; }

        public decimal? AverageDamagePerRound { get; set; }

        public decimal? Kast { get; set; }

        public decimal? Rating { get; set; }

    }

}
