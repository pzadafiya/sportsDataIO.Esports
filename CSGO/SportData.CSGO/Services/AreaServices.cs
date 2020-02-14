using System;
using System.Collections.Generic;
using System.Text;
using SportData.CSGO.Entities;
using SportData;

namespace SportData.CSGO.Services
{
    
    public interface IAreasServices
    {
        Areas GetAreas();    
    }

    public class AreaServices : FantasyDataApiBase, IAreasServices
    {
        private static readonly string Areas = "Areas";                

        public AreaServices(string baseUrl, string primarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey)
        { }
        public Areas GetAreas()
        {
            var url = string.Format("/{0}", Areas);
            return GetRequest<Areas>(url);
        }        
    }
}
