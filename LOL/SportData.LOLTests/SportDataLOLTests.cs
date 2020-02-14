using NUnit.Framework;
using SportData.LOL;
using System;

namespace Tests
{
    public class SportDataLOLTests
    {
        //Areas(Countries)
        [Test]
        public void GetAreas()
        {
            var client = new SportDataLOLClient();
            var response = client.AreasServices.GetAreas();
            Assert.IsTrue(response.Count > 1);
        }

        //Competitions(Leagues)
        [Test]
        public void GetCompetition()
        {
            var client = new SportDataLOLClient();
            var response = client.CompetitionServices.GetCompetition();
            Assert.IsTrue(response.Count > 1);
        }

        //Memberships(Active)
        [Test]
        public void GetActiveMemberships()
        {
            var client = new SportDataLOLClient();
            var response = client.MembershipServices.GetActiveMemberships();
            Assert.IsTrue(response.Count >= 1);
        }
        //Memberships (Historical)
        [Test]
        public void GetHistoricalMemberships()
        {
            var client = new SportDataLOLClient();
            var response = client.MembershipServices.GetHistoricalMemberships();
            Assert.IsTrue(response.Count >= 1);
        }

        //Memberships by Team (Active)
        [Test]
        public void GetMembershipsByTeam()
        {
            var client = new SportDataLOLClient();
            var response = client.MembershipServices.GetMembershipsByTeam(100000001);
            Assert.IsTrue(response.Count >= 1);
        }

        //Memberships by Team(Historical)
        [Test]
        public void GetHistoricalMembershipsByTeam()        
        {
            var client = new SportDataLOLClient();
            var response = client.MembershipServices.GetHistoricalMembershipsByTeam(100000001);
            Assert.IsTrue(response.Count >= 1);
        }

        //Player
        [Test]
        public void GetPlayer()
        {
            var client = new SportDataLOLClient();
            var response = client.PlayerServices.GetPlayersByPlayerID(100000576);
            Assert.IsTrue(response.Count >= 1);
        }

        //Players
        [Test]
        public void GetPlayers()
        {
            var client = new SportDataLOLClient();
            var response = client.PlayerServices.GetPlayers();
            Assert.IsTrue(response.Count >= 1);
        }

        //Players by Team
        [Test]
        public void GetPlayersbyTeam()
        {
            var client = new SportDataLOLClient();
            var response = client.PlayerServices.GetPlayersbyTeam(100000001);
            Assert.IsTrue(response.Count >= 1);
        }

        //Season Teams 
        [Test]
        public void GetSeasonTeams()
        {
            var client = new SportDataLOLClient();
            var response = client.SeasonServices.GetSeasonTeams(100000023);
            Assert.IsTrue(response.Count >= 1);
        }

        //Standings
        [Test]
        public void GetStandings()
        {
            var client = new SportDataLOLClient();
            var response = client.StandingsServices.GetStandings(100000138);
            Assert.IsTrue(response.Count >= 1);
        }

        //Teams
        [Test]
        public void GetTeams()
        {
            var client = new SportDataLOLClient();
            var response = client.TeamServices.GetTeams();
            Assert.IsTrue(response.Count >= 1);
        }

        //Venues
        [Test]
        public void GetVenues()
        {
            var client = new SportDataLOLClient();
            var response = client.VenueServices.GetVenues();
            Assert.IsTrue(response.Count >= 1);
        }


        //Competition Fixtures(League Details)
        [Test]
        public void GetCompetitionDetails()
        {
            var client = new SportDataLOLClient();
            var response = client.CompetitionServices.GetCompetitionDetails(100000009);
            Assert.IsTrue(response.Count >= 1);
        }

        //Games by Date
        [Test]
        public void GetGamebyDate()
        {
            var client = new SportDataLOLClient();
            DateTime myDate = Convert.ToDateTime("2018-01-13");
            var response = client.GameServices.GetGamebyDate(myDate);
            Assert.IsTrue(response.Count >= 1);
        }

        //Schedule        
        [Test]
        public void GetSchedule()
        {
            var client = new SportDataLOLClient();
            var response = client.ScheduleServices.GetSchedule(100000138);
            Assert.IsTrue(response.Count >= 1);
        }

        //Box Score by gameid
        [Test]
        public void GetBoxScoresbyGameId()
        {
            var client = new SportDataLOLClient();
            var response = client.BoxScoreServices.GetBoxScoresbyGameId(100002649);
            Assert.IsTrue(response.Count >= 1);
        }

        //Box Scores by Date
        [Test]
        public void GetBoxScoresbyDate()
        {
            var client = new SportDataLOLClient();
            DateTime myDate = Convert.ToDateTime("2019-01-20");
            var response = client.BoxScoreServices.GetBoxScoresbyDate(myDate);
            Assert.IsTrue(response.Count >= 1);
        }

        //Champions
        [Test]
        public void GetChampions()
        {
            var client = new SportDataLOLClient();            
            var response = client.ChampionServices.GetChampions();
            Assert.IsTrue(response.Count >= 1);
        }

        //Items
        [Test]
        public void GetItems()
        {
            var client = new SportDataLOLClient();
            var response = client.ItemServices.GetItems();
            Assert.IsTrue(response.Count >= 1);
        }

        //Spells
        [Test]
        public void GetSpells()
        {
            var client = new SportDataLOLClient();
            var response = client.SpellServices.GetSpells();
            Assert.IsTrue(response.Count >= 1);
        }

        //Projected Player Game Stats by Date 
        [Test]
        public void GetProjectedPlayerGameStatsbyDate()
        {
            var client = new SportDataLOLClient();
            DateTime myDate = Convert.ToDateTime("2019-01-20");
            var response = client.ProjectionServices.GetProjectedPlayerGameStatsbyDate(myDate);
            Assert.IsTrue(response.Count >= 1);
        }
        //Projected Player Game Stats by Player
        [Test]
        public void GetProjectedPlayerGameStatsbyDateAndPlayerId()
        {
            var client = new SportDataLOLClient();
            DateTime myDate = Convert.ToDateTime("2019-01-20");
            var response = client.ProjectionServices.GetProjectedPlayerGameStatsbyDateAndPlayerId(myDate, 100001500);
            Assert.IsTrue(response.Count >= 1);
        }
    }
}