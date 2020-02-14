using System;
using System.Collections.Generic;
using System.Text;
using SportData.LOL.Entities;

namespace SportData.LOL.Services
{    
    
    public interface IChampionServices
    {
        Champions GetChampions();
    }
    public class ChampionServices : FantasyDataApiBase, IChampionServices
    {
        private static readonly string Champions = "Champions";

        public ChampionServices(string baseUrl, string primarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey)
        { }
        public Champions GetChampions()
        {
            var url = string.Format("/{0}", Champions);
            return GetRequest<Champions>(url);
        }
    }
}
