using System;
using System.Collections.Generic;
using System.Text;
using SportData.LOL.Entities;


namespace SportData.LOL.Services
{
    
    public interface IStandingsServices
    {
        Standings GetStandings(int RoundId);
    }
    public class StandingsServices : FantasyDataApiBase, IStandingsServices
    {
        private static readonly string Standings = "Standings";

        public StandingsServices(string baseUrl, string primarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey)
        { }
        public Standings GetStandings(int RoundId)
        {
            var url = string.Format("/{0}/{1}", Standings, RoundId);
            return GetRequest<Standings>(url);
        }
    }
}
