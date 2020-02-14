using System;
using System.Collections.Generic;
using System.Text;
using SportData.CSGO.Entities;
using SportData;

namespace SportData.CSGO.Services
{
    
    public interface ICompetitionServices
    {
        Competitions GetCompetition();
        CompetitionDetails GetCompetitionDetails(int competitionid);
    }
    public class CompetitionServices : FantasyDataApiBase, ICompetitionServices
    {
        private static readonly string Competitions = "Competitions";
        private static readonly string CompetitionDetails = "CompetitionDetails";


        public CompetitionServices(string baseUrl, string primarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey)
        { }
        public Competitions GetCompetition()
        {
            var url = string.Format("/{0}", Competitions);
            return GetRequest<Competitions>(url);
        }        
        public CompetitionDetails GetCompetitionDetails(int CompetitionId)
        {
            var url = string.Format("/{0}/{1}", CompetitionDetails, CompetitionId);
            return GetRequest<CompetitionDetails>(url);
        }        
    }
}