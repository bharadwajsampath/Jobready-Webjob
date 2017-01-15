using RestSharp;
using RestSharp.Authenticators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MailService
{
    class ClientWrapper
    {

        public static RestClient GetNewClient()
        {
            RestClient client = new RestClient();
            client.BaseUrl = new Uri("https://jrdemo1.jobreadyrto.com.au/webservice/");
            client.Authenticator = new HttpBasicAuthenticator("Basic", "e3t1c2VybmFtZX19OjRkZDNhMmViODUxOGUyNzZiYTE0MzgwNWJiMDcyMGRhMjM0OTVhZDQ=");
            return client;
        }
    }
}
