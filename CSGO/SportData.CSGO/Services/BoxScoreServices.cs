using System;
using System.Collections.Generic;
using System.Text;
using SportData.CSGO.Entities;
using SportData;
using SportData.Utils;

namespace SportData.CSGO.Services
{

    public interface IBoxScoreServices
    {
        BoxScores GetBoxScoresbyGameId(int GameId);
        BoxScores GetBoxScoresbyDate(DateTime Date);
    }
    public class BoxScoreServices : FantasyDataApiBase, IBoxScoreServices
    {
        private static readonly string BoxScore = "BoxScore";
        private static readonly string BoxScores = "BoxScores";

        public BoxScoreServices(string baseUrl, string primarySubscriptionKey)
            : base(baseUrl, primarySubscriptionKey)
        { }
        public BoxScores GetBoxScoresbyGameId(int GameId)
        {
            var url = string.Format("/{0}/{1}", BoxScore, GameId);
            return GetRequest<BoxScores>(url);
        }
        public BoxScores GetBoxScoresbyDate(DateTime Date)
        {
            var url = string.Format("/{0}/{1}", BoxScores, Date.ToApiDate());
            return GetRequest<BoxScores>(url);
        }
    }
}