using System;
using System.Collections.Generic;
using System.Text;
using SportData.CSGO.Entities;
using SportData;

namespace SportData.CSGO.Services
{
    
    public interface ISeasonServices
    {
        SeasonTeams GetSeasonTeams(int SeasonId);        
    }
    public class SeasonServices : FantasyDataApiBase, ISeasonServices
    {
        private static readonly string SeasonTeams = "SeasonTeams";        

        public SeasonServices(string baseUrl, string primarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey)
        { }
        public SeasonTeams GetSeasonTeams(int SeasonId)
        {
            var url = string.Format("/{0}/{1}", SeasonTeams, SeasonId);
            return GetRequest<SeasonTeams>(url);
        }        
    }
}