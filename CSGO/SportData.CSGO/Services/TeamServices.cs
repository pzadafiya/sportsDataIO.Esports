using System;
using System.Collections.Generic;
using System.Text;
using SportData.CSGO.Entities;
using SportData;

namespace SportData.CSGO.Services
{
    
    public interface ITeamServices
    {
        Teams GetTeams();
    }
    public class TeamServices : FantasyDataApiBase, ITeamServices
    {
        private static readonly string Teams = "Teams";        

        public TeamServices(string baseUrl, string primarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey)
        { }
        public Teams GetTeams()
        {
            var url = string.Format("/{0}", Teams);
            return GetRequest<Teams>(url);
        }        
    }
}