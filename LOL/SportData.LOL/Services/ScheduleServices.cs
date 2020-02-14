using System;
using System.Collections.Generic;
using System.Text;
using SportData.LOL.Entities;

namespace SportData.LOL.Services
{
    public interface IScheduleServices
    {
        Schedules GetSchedule(int roundid);
    }
    public class ScheduleServices : FantasyDataApiBase, IScheduleServices
    {
        private static readonly string Schedule = "Schedule";

        public ScheduleServices(string baseUrl, string primarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey)
        { }
        public Schedules GetSchedule(int roundid)
        {
            var url = string.Format("/{0}/{1}", Schedule, roundid);
            return GetRequest<Schedules>(url);
        }
    }
}
