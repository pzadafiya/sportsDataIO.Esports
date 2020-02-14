using System;
using System.Collections.Generic;
using System.Text;
using SportData.LOL.Entities;

namespace SportData.LOL.Services
{    
    public interface ISpellServices
    {
        Spells GetSpells();
    }
    public class SpellServices : FantasyDataApiBase, ISpellServices
    {
        private static readonly string Spells = "Spells";

        public SpellServices(string baseUrl, string primarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey)
        { }
        public Spells GetSpells()
        {
            var url = string.Format("/{0}", Spells);
            return GetRequest<Spells>(url);
        }
    }
}
