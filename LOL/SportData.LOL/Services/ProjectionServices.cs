using System;
using System.Collections.Generic;
using System.Text;
using SportData.LOL.Entities;
using SportData.Utils;

namespace SportData.LOL.Services
{
    public interface IProjectionServices
    {
        PlayerGameProjections GetProjectedPlayerGameStatsbyDate(DateTime Date);
        PlayerGameProjections GetProjectedPlayerGameStatsbyDateAndPlayerId(DateTime Date, int playerid);
    }
    public class ProjectionServices : FantasyDataApiBase, IProjectionServices
    {
        private static readonly string PlayerGameProjectionStatsByDate = "PlayerGameProjectionStatsByDate";
        private static readonly string PlayerGameProjectionStatsByPlayer = "PlayerGameProjectionStatsByPlayer";

        public ProjectionServices(string baseUrl, string primarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey)
        { }
        public PlayerGameProjections GetProjectedPlayerGameStatsbyDate(DateTime Date)
        {
            var url = string.Format("/{0}/{1}", PlayerGameProjectionStatsByDate, Date.ToApiDate());
            return GetRequest<PlayerGameProjections>(url);
        }
        public PlayerGameProjections GetProjectedPlayerGameStatsbyDateAndPlayerId(DateTime Date, int playerid)
        {
            var url = string.Format("/{0}/{1}/{2}", PlayerGameProjectionStatsByPlayer, Date.ToApiDate(), playerid);
            return GetRequest<PlayerGameProjections>(url);
        }
    }
}
