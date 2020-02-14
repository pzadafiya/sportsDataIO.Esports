using System;
using System.Collections.Generic;
using System.Text;
using SportData.LOL.Entities;

namespace SportData.LOL.Services
{
    public interface IMembershipServices
    {
        Memberships GetActiveMemberships();
        Memberships GetHistoricalMemberships();
        Memberships GetMembershipsByTeam(int TeamId);        
        Memberships GetHistoricalMembershipsByTeam(int TeamId);
    }
    public class MembershipServices : FantasyDataApiBase, IMembershipServices
    {
        private static readonly string ActiveMemberships = "ActiveMemberships";
        private static readonly string HistoricalMemberships = "HistoricalMemberships";
        private static readonly string MembershipsByTeam = "MembershipsByTeam";
        private static readonly string HistoricalMembershipsByTeam = "HistoricalMembershipsByTeam";


        public MembershipServices(string baseUrl, string primarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey)
        { }

        public Memberships GetActiveMemberships()
        {
            var url = string.Format("/{0}", ActiveMemberships);
            return GetRequest<Memberships>(url);
        }

        public Memberships GetHistoricalMemberships()
        {
            var url = string.Format("/{0}", HistoricalMemberships);
            return GetRequest<Memberships>(url);
        }

        public Memberships GetMembershipsByTeam(int TeamId)
        {
            var url = string.Format("/{0}/{1}", MembershipsByTeam, TeamId);
            return GetRequest<Memberships>(url);
        }

        public Memberships GetHistoricalMembershipsByTeam(int TeamId)
        {
            var url = string.Format("/{0}/{1}", HistoricalMembershipsByTeam, TeamId);
            return GetRequest<Memberships>(url);
        }
    }
}
