using System;
using System.Collections.Generic;
using System.Text;

namespace SportData.LOL.Entities
{
    public class PlayerGames : List<PlayerGame>
    { }
    public class PlayerGame
    {
        public int GameId { get; set; }

        public int OpponentId { get; set; }

        public string Opponent { get; set; }

        public DateTime? Day { get; set; }

        public DateTime? DateTime { get; set; }

        public int PlayerId { get; set; }

        public int? TeamId { get; set; }

        public string Team { get; set; }

        public string Name { get; set; }

        public decimal? Kills { get; set; }

        public decimal? Assists { get; set; }

        public decimal? Deaths { get; set; }

        public decimal? LargestKillingSpree { get; set; }

        public decimal? LargestMultiKill { get; set; }

        public decimal? KillingSpree { get; set; }

        public decimal? LongestTimeSpentLiving { get; set; }

        public decimal? DoubleKills { get; set; }

        public decimal? TripleKills { get; set; }

        public decimal? QuadraKills { get; set; }

        public decimal? PentaKills { get; set; }

        public decimal? UnrealKills { get; set; }

        public decimal? TotalDamageDealt { get; set; }

        public decimal? MagicDamageDealt { get; set; }

        public decimal? PhysicalDamageDealt { get; set; }

        public decimal? TrueDamageDealt { get; set; }

        public decimal? LargestCriticalStrike { get; set; }

        public decimal? TotalDamageDealtToChampions { get; set; }

        public decimal? MagicDamageDealtToChampions { get; set; }

        public decimal? PhysicalDamageDealtToChampions { get; set; }

        public decimal? TrueDamageDealtToChampions { get; set; }

        public decimal? TotalHeal { get; set; }

        public decimal? TotalUnitsHealed { get; set; }

        public decimal? TotalDamageTaken { get; set; }

        public decimal? MagicDamageTaken { get; set; }

        public decimal? PhysicalDamageTaken { get; set; }

        public decimal? TrueDamageTaken { get; set; }

        public decimal? GoldEarned { get; set; }

        public decimal? GoldSpent { get; set; }

        public decimal? TurretKills { get; set; }

        public decimal? InhibitorKills { get; set; }

        public decimal? TotalMinionsKilled { get; set; }

        public decimal? NeutralMinionsKIlled { get; set; }

        public decimal? NeutralMinionsKIlledTeamJungle { get; set; }

        public decimal? NeutralMinionsKilledEnemyJungle { get; set; }

        public decimal? TotalTimeCrowdControlDealt { get; set; }

        public decimal? VisionWardsBoughtInGame { get; set; }

        public decimal? SightWardsBoughtInGame { get; set; }

        public decimal? WardsPlaced { get; set; }

        public decimal? WardsKilled { get; set; }

        public decimal? CombatPlayerScore { get; set; }

        public decimal? ObjectivePlayerScore { get; set; }

        public decimal? TotalPlayerScore { get; set; }

        public decimal? FantasyPoints { get; set; }

        public decimal? TenKillsOrAssists { get; set; }

        public DateTime? Updated { get; set; }

        public int Games { get; set; }

        public int Matches { get; set; }

    }

}
