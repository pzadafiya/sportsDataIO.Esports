using System;
using System.Collections.Generic;
using System.Text;
using SportData.CSGO.Entities;
using SportData;

namespace SportData.CSGO.Services
{
    
    public interface IScheduleServices
    {
        Schedules GetSchedule(int roundid);        
    }
    public class ScheduleServices : FantasyDataApiBase, IScheduleServices
    {
        private static readonly string Standings = "Standings";        

        public ScheduleServices(string baseUrl, string primarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey)
        { }
        public Schedules GetSchedule(int roundid)
        {
            var url = string.Format("/{0}/{1}", Standings, roundid);
            return GetRequest<Schedules>(url);
        }        
    }
}