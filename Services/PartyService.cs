using System;
using System.Linq;
using Models;
using System.Xml.Linq;
using Newtonsoft.Json;
using Worker.Helpers;
using RestSharp;

namespace Worker.Services
{
    public class PartyService
    {
        private RestClient _restclient;

        public PartyService()
        {
            _restclient = WebWrapper.GetClient();
        }

        public PartyRoot  Get(string partyId)
        {
            try
            {
                var endPoint = "parties/{{partyId}}";
                endPoint = endPoint.Replace("{{partyId}}", partyId);
                var request = new RestRequest(endPoint);
                request.Method = Method.GET;
                var responseStream = _restclient.Execute(request);
                var response = responseStream.Content;
                var doc = XDocument.Parse(response);
                var json = JsonConvert.SerializeXNode(doc.Descendants("party").FirstOrDefault());
                return JsonConvert.DeserializeObject<PartyRoot>(json);
            }
            catch (Exception ex)
            {
                return new PartyRoot();
            }
        }

    }
}
