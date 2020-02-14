using System;
using System.Collections.Generic;
using System.Text;
using SportData.CSGO.Entities;
using SportData;

namespace SportData.CSGO.Services
{
    
    public interface IMembershipServices
    {
        Memberships GetActiveMemberships();
        Memberships GetHistoricalMembershipsByTeam(int TeamId);
    }
    public class MembershipServices : FantasyDataApiBase, IMembershipServices
    {
        private static readonly string ActiveMemberships = "ActiveMemberships";
        private static readonly string HistoricalMembershipsByTeam = "HistoricalMembershipsByTeam";


        public MembershipServices(string baseUrl, string primarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey)
        { }
        public Memberships GetActiveMemberships()
        {
            var url = string.Format("/{0}", ActiveMemberships);
            return GetRequest<Memberships>(url);
        }
        public Memberships GetHistoricalMembershipsByTeam(int TeamId)
        {
            var url = string.Format("/{0}/{1}", HistoricalMembershipsByTeam, TeamId);
            return GetRequest<Memberships>(url);
        }
    }
}