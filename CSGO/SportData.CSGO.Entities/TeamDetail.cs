using System;
using System.Collections.Generic;
using System.Text;

namespace SportData.CSGO.Entities
{
    public class TeamDetails : List<TeamDetail>
    { }
    public class TeamDetail
    {
        public int TeamId { get; set; }

        public int? AreaId { get; set; }

        public string AreaName { get; set; }

        public string Key { get; set; }

        public string Name { get; set; }

        public string ShortName { get; set; }

        public bool Active { get; set; }

        public string Gender { get; set; }

        public string Type { get; set; }

        public string Website { get; set; }

        public string Email { get; set; }

        public int? Founded { get; set; }

        public string PrimaryColor { get; set; }

        public string SecondaryColor { get; set; }

        public string TertiaryColor { get; set; }

        public string QuaternaryColor { get; set; }

        public string Facebook { get; set; }

        public string Twitter { get; set; }

        public string YouTube { get; set; }

        public string Instagram { get; set; }

        public List<Player> Players { get; set; }
    }

}
