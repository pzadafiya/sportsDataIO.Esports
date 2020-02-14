using System;
using System.Collections.Generic;
using System.Text;

namespace SportData.LOL.Entities
{
    public class ChampionInfos : List<ChampionInfo>
    { }
    public class ChampionInfo
    {
        public int ChampionId { get; set; }

        public string Name { get; set; }

        public string Title { get; set; }
    }
}
