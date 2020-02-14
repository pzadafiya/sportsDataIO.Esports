﻿using System;
using System.Collections.Generic;
using System.Text;
using RestSharp;
using RestSharp.Serialization.Json;


namespace SportData
{
    public class FantasyDataApiBase
    {
        private const string JSON = "JSON";

        #region Properties and Accessors

        protected string BaseUrl { get; private set; }
        protected string PrimarySubscriptionKey { get; private set; }

        private static string _userAgent;

        private static string UserAgent
        {
            get
            {
                if (_userAgent == null)
                {
                    _userAgent = String.Format("FantasyData.NET RestSharp Client v" + System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());
                }
                return _userAgent;
            }
        }

        private RestClient _client;

        #endregion

        #region Constructors

        public FantasyDataApiBase(string baseUrl, string primarySubscriptionKey)
        {
            if (string.IsNullOrEmpty(primarySubscriptionKey))
                throw new ArgumentException("Primary Subscription Key is required.");

            if (string.IsNullOrEmpty(baseUrl))
                throw new ArgumentException("Api Base Url is required.");

            PrimarySubscriptionKey = primarySubscriptionKey;

            if (baseUrl.EndsWith("/"))
                baseUrl = baseUrl.Substring(0, baseUrl.Length - 1);

            BaseUrl = baseUrl;

            _client = new RestClient();
            _client.UserAgent = UserAgent;
            _client.BaseUrl = new Uri(baseUrl);   //Config.ApiBaseUrl;
        }
        #endregion

        public T GetRequest<T>(string path, params object[] args) where T : new()
        {
            return GetRequest<T>(path, string.Empty, args);
        }

        public T GetRequest<T>(string path, string rootElement, params object[] args) where T : new()
        {
            RestRequest request = new RestRequest(BuildUrl(path, args));
            if (!string.IsNullOrWhiteSpace(rootElement)) request.RootElement = rootElement;
            InitializeRequest(request);

            var response = _client.Execute<T>(request);

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                throw new FantasyDataException("Not Found");
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
            {
                throw new FantasyDataException("Internal Server Error When Requesting For ( " + path + " )");
            }

            return response.Data;
        }

        protected int GetInt(string path, params object[] args)
        {
            RestRequest request = new RestRequest(BuildUrl(path, args));
            InitializeRequest(request);

            var response = _client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                throw new FantasyDataException("Not Found");
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
            {
                throw new FantasyDataException("Internal Server Error");
            }

            return Convert.ToInt32(response.Content);
        }

        protected bool GetBool(string path, params object[] args)
        {
            RestRequest request = new RestRequest(BuildUrl(path, args));
            InitializeRequest(request);

            var response = _client.Execute(request);

            if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
            {
                throw new FantasyDataException("Not Found");
            }
            else if (response.StatusCode == System.Net.HttpStatusCode.InternalServerError)
            {
                throw new FantasyDataException("Internal Server Error");
            }

            return Convert.ToBoolean(response.Content);
        }

        public string BuildUrl(string path, params object[] args)
        {
            var formatPart = string.Format("/{0}", JSON);

            return formatPart + string.Format(path, args) + string.Format("{0}key={1}", (args.Length == 0 ? '?' : '&'), GetSubscriptionKey());
        }

        public void InitializeRequest(RestRequest request)
        {
            request.RequestFormat = DataFormat.Json;
            request.JsonSerializer = new JsonSerializer();
        }

        public string GetSubscriptionKey()
        {
            if (!string.IsNullOrEmpty(PrimarySubscriptionKey))
                return PrimarySubscriptionKey;

            throw new FantasyDataException("No subscription key set.");
        }

    }
}
