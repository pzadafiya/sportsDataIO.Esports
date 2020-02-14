using System;
using System.Collections.Generic;
using System.Text;
using SportData.LOL.Entities;

namespace SportData.LOL.Services
{
    public interface IPlayerServices
    {
        Players GetPlayers();

        Players GetPlayersbyTeam(int TeamID);

        Players GetPlayersByPlayerID(int PlayerId);
        
        
    }
    public class PlayerServices : FantasyDataApiBase, IPlayerServices
    {
        private static readonly string Player = "Player";
        private static readonly string Players = "Players";
        private static readonly string PlayersByTeam = "PlayersByTeam";

        public PlayerServices(string baseUrl, string primarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey)
        { }

        public Players GetPlayers()
        {
            var url = string.Format("/{0}", Players);
            return GetRequest<Players>(url);
        }

        public Players GetPlayersbyTeam(int TeamID)
        {
            var url = string.Format("/{0}/{1}", PlayersByTeam, TeamID);
            return GetRequest<Players>(url);
        }

        public Players GetPlayersByPlayerID(int PlayerId)
        {
            var url = string.Format("/{0}/{1}", Player, PlayerId);
            return GetRequest<Players>(url);
        }                
    }
}
