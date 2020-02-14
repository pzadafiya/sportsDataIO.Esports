using System;
using Microsoft.Extensions.Configuration;

namespace SportData
{
    public class LOLConfig
    {
        //private const string appSettingFilePath = @"D:\Projects\GithubRepo\SportDataEsportAPI\sportsdata\";
        //private static string appSettingFilePath = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location.Substring(0, Assembly.GetEntryAssembly().Location.IndexOf("bin\\")));
        private static string appSettingFilePath = AppDomain.CurrentDomain.BaseDirectory.Substring(0, AppDomain.CurrentDomain.BaseDirectory.IndexOf("bin\\"));
        private const string appSettingFileName = "appsettings.json";
        private const string SectionTagName = "fantasyDataLOL";

        public static string PrimarySubscriptionKey
        {
            get
            {

                var builder = new ConfigurationBuilder()
                  .SetBasePath(appSettingFilePath)
                  .AddJsonFile(appSettingFileName);
                var config = builder.Build();

                var appConfig = new AppSettingsModel();
                config.GetSection(SectionTagName).Bind(appConfig);
                return appConfig.primarySubscriptionKey;
            }
        }

        public static Uri ApiBaseUrl
        {
            get
            {
                var builder = new ConfigurationBuilder()
                  .SetBasePath(appSettingFilePath)
                  .AddJsonFile(appSettingFileName);
                var config = builder.Build();

                var appConfig = new AppSettingsModel();
                config.GetSection(SectionTagName).Bind(appConfig);
                return (new System.Uri(appConfig.baseUrl));
            }
        }

        public static Uri StateApiBaseUrl
        {
            get
            {
                var builder = new ConfigurationBuilder()
                  .SetBasePath(appSettingFilePath)
                  .AddJsonFile(appSettingFileName);
                var config = builder.Build();

                var appConfig = new AppSettingsModel();
                config.GetSection(SectionTagName).Bind(appConfig);
                return (new System.Uri(appConfig.baseUrl + "/stats/"));
            }
        }

        public static Uri ScoreApiBaseUrl
        {
            get
            {
                var builder = new ConfigurationBuilder()
                  .SetBasePath(appSettingFilePath)
                  .AddJsonFile(appSettingFileName);
                var config = builder.Build();

                var appConfig = new AppSettingsModel();
                config.GetSection(SectionTagName).Bind(appConfig);
                return (new System.Uri(appConfig.baseUrl + "/scores/"));
            }
        }

        public static string ProjectionPrimarySubscriptionKey
        {

            get
            {
                var builder = new ConfigurationBuilder()
                  .SetBasePath(appSettingFilePath)
                  .AddJsonFile(appSettingFileName);
                var config = builder.Build();

                var appConfig = new AppSettingsModel();
                config.GetSection(SectionTagName).Bind(appConfig);
                return appConfig.ProjectionPrimarySubscriptionKey;
            }
        }

        public static Uri ProjectionApiBaseUrl
        {
            get
            {

                var builder = new ConfigurationBuilder()
                  .SetBasePath(appSettingFilePath)
                  .AddJsonFile(appSettingFileName);
                var config = builder.Build();

                var appConfig = new AppSettingsModel();
                config.GetSection(SectionTagName).Bind(appConfig);
                return (new System.Uri(appConfig.baseUrl + "/projections/"));
            }
        }
    }
}
