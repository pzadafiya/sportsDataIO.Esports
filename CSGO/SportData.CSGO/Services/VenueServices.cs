using System;
using System.Collections.Generic;
using System.Text;
using SportData.CSGO.Entities;
using SportData;

namespace SportData.CSGO.Services
{
    
    public interface IVenueServices
    {
        Venues GetVenues();
    }
    public class VenueServices : FantasyDataApiBase, IVenueServices
    {
        private static readonly string Venues = "Venues";        

        public VenueServices(string baseUrl, string primarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey)
        { }
        public Venues GetVenues()
        {
            var url = string.Format("/{0}", Venues);
            return GetRequest<Venues>(url);
        }        
    }
}