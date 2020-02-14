using System;
using System.Collections.Generic;
using System.Text;

namespace SportData.LOL.Entities
{
    public class Spells : List<Spell>
    { }
    public class Spell
    {
        public int SpellId { get; set; }

        public string Name { get; set; }

    }

}
