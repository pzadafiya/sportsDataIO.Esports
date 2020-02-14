using System;
using System.Collections.Generic;
using System.Text;

namespace SportData.LOL.Entities
{
    public class Memberships : List<Membership>
    { }
    public class Membership
    {
        public int MembershipId { get; set; }

        public int TeamId { get; set; }

        public int PlayerId { get; set; }

        public string PlayerName { get; set; }

        public string TeamName { get; set; }

        public string TeamArea { get; set; }

        public bool Active { get; set; }

        public DateTime? StartDate { get; set; }

        public DateTime? EndDate { get; set; }

        public DateTime? Updated { get; set; }

    }

}
