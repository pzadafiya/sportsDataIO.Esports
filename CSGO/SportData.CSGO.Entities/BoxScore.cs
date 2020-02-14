using System;
using System.Collections.Generic;
using System.Text;

namespace SportData.CSGO.Entities
{    
    public class BoxScores : List<BoxScore>
    { }
    public class BoxScore
    {
        public List<Game> Game { get; set; }

        public List<Map> Map { get; set; }        
    }
}
