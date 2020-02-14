using SportData.LOL.Services;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportData.LOL
{
    public class SportDataLOLClient
    {
        #region Accessors

        public IAreasServices AreasServices { get; private set; }
        public ICompetitionServices CompetitionServices { get; private set; }
        public IGameServices GameServices { get; private set; }
        public IMembershipServices MembershipServices { get; private set; }
        public IPlayerServices PlayerServices { get; private set; }
        public ISeasonServices SeasonServices { get; private set; }        
        public ITeamServices TeamServices { get; private set; }
        public IVenueServices VenueServices { get; private set; }
        public IStandingsServices StandingsServices { get; private set; }
        public IScheduleServices ScheduleServices { get; private set; }
        public IChampionServices ChampionServices { get; private set; }
        public IItemServices ItemServices { get; private set; }
        public ISpellServices SpellServices { get; private set; }
        public IBoxScoreServices BoxScoreServices { get; private set; }
        public IProjectionServices ProjectionServices { get; private set; }

        #endregion Accessors


        public SportDataLOLClient(string primarySubscriptionKey, string ProjectionPrimarySubscriptionKey)
        {
            Uri scoreApiBaseUrl = LOLConfig.ScoreApiBaseUrl;
            Uri statApiBaseUrl = LOLConfig.StateApiBaseUrl;
            Uri ProjectionApiBaseUrl = LOLConfig.ProjectionApiBaseUrl;

            AreasServices = new AreaServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey);
            CompetitionServices = new CompetitionServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey);
            GameServices = new GameServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey);
            MembershipServices = new MembershipServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey);
            PlayerServices = new PlayerServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey);
            SeasonServices = new SeasonServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey);            
            TeamServices = new TeamServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey);
            VenueServices = new VenueServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey);
            StandingsServices = new StandingsServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey);
            ScheduleServices = new ScheduleServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey);

            ItemServices = new ItemServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey);
            SpellServices = new SpellServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey);
            ChampionServices = new ChampionServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey);
            BoxScoreServices = new BoxScoreServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey);

            ProjectionServices = new ProjectionServices(ProjectionApiBaseUrl.AbsoluteUri, ProjectionPrimarySubscriptionKey);
        }
        public SportDataLOLClient()
      : this(LOLConfig.PrimarySubscriptionKey, LOLConfig.ProjectionPrimarySubscriptionKey)
        { }
    }
}

