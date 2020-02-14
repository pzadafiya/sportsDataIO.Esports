using System;
using System.Collections.Generic;
using System.Text;
using SportData.CSGO.Services;
using SportData;

namespace SportData.CSGO
{
    public class SportDataCSGOClient
    {
        #region Accessors       

        public IAreasServices AreasServices { get; private set; }
        public ICompetitionServices CompetitionServices { get; private set; }
        public IGameServices GameServices { get; private set; }
        public IMembershipServices MembershipServices { get; private set; }
        public IPlayerServices PlayerServices { get; private set; }
        public ISeasonServices SeasonServices { get; private set; }
        public IScheduleServices ScheduleServices { get; private set; }
        public ITeamServices TeamServices { get; private set; }
        public IVenueServices VenueServices { get; private set; }
        public IBoxScoreServices BoxScoreServices { get; private set; }
        public IProjectionServices ProjectionServices { get; private set; }

        #endregion

        #region Constructors

        /// <summary>
        /// 
        /// </summary>
        /// <param name="apiBaseUrl"></param>
        /// <param name="primarySubscriptionKey"></param>
        /// <param name="secondarySubscriptionKey"></param>        

        public SportDataCSGOClient(string primarySubscriptionKey, string ProjectionPrimarySubscriptionKey)
        {
            Uri scoreApiBaseUrl = CSGOConfig.ScoreApiBaseUrl;
            Uri statApiBaseUrl = CSGOConfig.StateApiBaseUrl;
            Uri ProjectionApiBaseUrl = CSGOConfig.ProjectionApiBaseUrl;

            AreasServices = new AreaServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey);
            CompetitionServices = new CompetitionServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey);
            GameServices = new GameServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey);
            MembershipServices = new MembershipServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey);
            PlayerServices = new PlayerServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey);
            SeasonServices = new SeasonServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey);
            ScheduleServices = new ScheduleServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey);
            TeamServices = new TeamServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey);
            VenueServices = new VenueServices(scoreApiBaseUrl.AbsoluteUri, primarySubscriptionKey);

            BoxScoreServices = new BoxScoreServices(statApiBaseUrl.AbsoluteUri, primarySubscriptionKey);

            ProjectionServices = new ProjectionServices(ProjectionApiBaseUrl.AbsoluteUri, ProjectionPrimarySubscriptionKey);
        }

        /// <summary>
        /// 
        /// </summary>
        public SportDataCSGOClient()
      : this(CSGOConfig.PrimarySubscriptionKey, CSGOConfig.ProjectionPrimarySubscriptionKey)
        { }

        #endregion
    }
}
