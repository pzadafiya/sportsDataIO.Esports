using System;
using System.Collections.Generic;
using System.Text;
using SportData.LOL.Entities;

namespace SportData.LOL.Services
{
    
    public interface IItemServices
    {
        Items GetItems();
    }
    public class ItemServices : FantasyDataApiBase, IItemServices
    {
        private static readonly string Items = "Items";

        public ItemServices(string baseUrl, string primarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey)
        { }
        public Items GetItems()
        {
            var url = string.Format("/{0}", Items);
            return GetRequest<Items>(url);
        }
    }
}
