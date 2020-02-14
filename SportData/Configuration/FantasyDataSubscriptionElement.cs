using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Text;

namespace SportData.Configuration
{
    public class FantasyDataSubscriptionElement
    {
        //private static IOptions<AppSettingsModel> _AppSettingsModel;

        //public FantasyDataSubscriptionElement(IOptions<AppSettingsModel> AppSettingsModel)
        //{
        //    _AppSettingsModel = AppSettingsModel;
        //}

        //public string PrimarySubscriptionKeyTest()
        //{            
        //     return _AppSettingsModel.Value.primarySubscriptionKey;
        //}

        public string Name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }

        public Uri ApiBaseUrl
        {
            get
            {
                return (Uri)ApiBaseUrl;
            }
            set
            {
                ApiBaseUrl = value;
            }
        }

        public Uri StatApiBaseUrl
        {
            get
            {
                return new Uri(ApiBaseUrl + "/stats/");
            }
        }

        public Uri ScoreApiBaseUrl
        {
            get
            {
                return new Uri(ApiBaseUrl + "/scores/");
            }
        }

        public Uri ProjectionApiBaseUrl
        {
            get
            {
                return new Uri(ApiBaseUrl + "/projections/");
            }
        }

        public string PrimarySubscriptionKey
        {
            get
            {
                return PrimarySubscriptionKey;
            }
            set
            {
                PrimarySubscriptionKey = value;
            }
        }

        public string ProjectionPrimarySubscriptionKey
        {
            get
            {
                return ProjectionPrimarySubscriptionKey;
            }
            set
            {
                ProjectionPrimarySubscriptionKey = value;
            }
        }
    }
}
