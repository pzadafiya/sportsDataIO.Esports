using System;
using System.Collections.Generic;
using System.Text;

namespace SportData.LOL.Entities
{
    public class Items : List<Item>
    { }
    public class Item
    {
        public int ItemId { get; set; }

        public string Name { get; set; }

        public int GoldBase { get; set; }

        public int GoldTotal { get; set; }

        public int GoldSell { get; set; }

    }

}
