using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;


namespace Worker.Helpers
{
    public static class WebWrapper
    {
        private static RestClient _restClient;

        public static RestClient GetClient()
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri("https://bcanational.jobreadyrto.com.au/webservice/");
            client.Authenticator = new HttpBasicAuthenticator("bcaweb", "4dd3a2eb8518e276ba143805bb0720da23495ad4");
            return client;
        }





    }


}