using NUnit.Framework;
using SportData.CSGO;
using System;
using SportData;

namespace SportData.CSGOTests
{
    public class SportDataCSGOTests
    {
        //Areas (Countries)
        [Test]
        public void GetAreas()
        {
            var client = new SportDataCSGOClient();
            var response = client.AreasServices.GetAreas();
            Assert.IsTrue(response.Count > 1);
        }
        //Memberships (Active)
        [Test]
        public void GetMembershipActive()
        {
            var client = new SportDataCSGOClient();
            var response = client.MembershipServices.GetActiveMemberships();
            Assert.IsTrue(response.Count >= 1);
        }
        //Memberships by Team (Historical)
        [Test]
        public void GetMembershiHistorical()
        {
            var client = new SportDataCSGOClient();
            var response = client.MembershipServices.GetHistoricalMembershipsByTeam(100000001);
            Assert.IsTrue(response.Count >= 1);
        }
        //Player
        [Test]
        public void GetPlayersByPlayerID()
        {
            var client = new SportDataCSGOClient();
            var response = client.PlayerServices.GetPlayersByPlayerID(100001011);
            Assert.IsTrue(response.Count >= 1);
        }
        //Players
        [Test]
        public void GetPlayers()
        {
            var client = new SportDataCSGOClient();
            var response = client.PlayerServices.GetPlayers();
            Assert.IsTrue(response.Count >= 1);
        }
        //Players by Team
        [Test]
        public void GetPlayersbyTeam()
        {
            var client = new SportDataCSGOClient();
            var response = client.PlayerServices.GetPlayersbyTeam(100000078);
            Assert.IsTrue(response.Count >= 1);
        }
        //Schedule
        [Test]
        public void GetSchedule()
        {
            var client = new SportDataCSGOClient();
            var response = client.ScheduleServices.GetSchedule(100000138);
            Assert.IsTrue(response.Count >= 1);
        }
        //Teams
        [Test]
        public void GetTeams()
        {
            var client = new SportDataCSGOClient();
            var response = client.TeamServices.GetTeams();
            Assert.IsTrue(response.Count >= 1);
        }
        //Competition Fixtures 
        [Test]
        public void GetCompetition()
        {
            var client = new SportDataCSGOClient();
            var response = client.CompetitionServices.GetCompetition();
            Assert.IsTrue(response.Count >= 1);
        }
        //Games by Date
        [Test]
        public void GetGamebyDate()
        {
            var client = new SportDataCSGOClient();
            DateTime myDate = Convert.ToDateTime("2018-01-13");
            var response = client.GameServices.GetGamebyDate(myDate);
            Assert.IsTrue(response.Count >= 1);
        }
        //Box Score by gameid
        [Test]
        public void GetBoxScoresbyGameId()
        {
            var client = new SportDataCSGOClient();
            var response = client.BoxScoreServices.GetBoxScoresbyGameId(100000091);
            Assert.IsTrue(response.Count >= 1);
        }
        //Box Scores by Date
        [Test]
        public void GetBoxScoresbyDate()
        {
            var client = new SportDataCSGOClient();
            DateTime myDate = Convert.ToDateTime("2018-01-13");
            var response = client.BoxScoreServices.GetBoxScoresbyDate(myDate);
            Assert.IsTrue(response.Count >= 1);
        }
        //Projected Player Game Stats by Date 
        [Test]
        public void GetProjectedPlayerGameStatsbyDate()
        {
            var client = new SportDataCSGOClient();
            DateTime myDate = Convert.ToDateTime("2018-01-13");
            var response = client.ProjectionServices.GetProjectedPlayerGameStatsbyDate(myDate);
            Assert.IsTrue(response.Count >= 1);
        }
        //Projected Player Game Stats by Player
        [Test]
        public void GetProjectedPlayerGameStatsbyDateAndPlayerId()
        {
            var client = new SportDataCSGOClient();
            DateTime myDate = Convert.ToDateTime("2018-01-13");
            var response = client.ProjectionServices.GetProjectedPlayerGameStatsbyDateAndPlayerId(myDate, 100001079);
            Assert.IsTrue(response.Count >= 1);
        }

        //Competition Fixtures(League Details)
        [Test]
        public void GetCompetitionDetails()
        {
            var client = new SportDataCSGOClient();            
            var response = client.CompetitionServices.GetCompetitionDetails(100000009);
            Assert.IsTrue(response.Count >= 1);
        }

        
        //Venues
        [Test]
        public void GetVenues()
        {
            var client = new SportDataCSGOClient();
            var response = client.VenueServices.GetVenues();
            Assert.IsTrue(response.Count >= 1);
        }

        //Season Teams 
        [Test]
        public void GetSeasonTeams()
        {
            var client = new SportDataCSGOClient();
            var response = client.SeasonServices.GetSeasonTeams(100000023);
            Assert.IsTrue(response.Count >= 1);
        }

    }
}