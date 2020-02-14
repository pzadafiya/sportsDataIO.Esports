using System;
using System.Collections.Generic;
using System.Text;
using SportData.LOL.Entities;
using SportData.Utils;

namespace SportData.LOL.Services
{
    public interface IGameServices
    {
        Games GetGamebyDate(DateTime date);
    }
    public class GameServices : FantasyDataApiBase, IGameServices
    {
        private static readonly string GamesByDate = "GamesByDate";
        private static readonly string AreAnyGamesInProgress = "AreAnyGamesInProgress";

        public GameServices(string baseUrl, string primarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey)
        { }
        public Games GetGamebyDate(DateTime date)
        {
            var url = string.Format("/{0}/{1}", GamesByDate, date.ToApiDate());
            return GetRequest<Games>(url);
        }
    }
}
