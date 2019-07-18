using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace MyAudit
{
    public static class HttpRequestor
    {
        private static readonly HttpClient client = new HttpClient();
        
        public static async Task<string> MakeSimpleGetRequestAuth(string url)
        {
            string token = "10706~oo0QV8eXY10gHhkgmspUqNsFrq9P5TT1XnOK1N17JDNwD3wUTiCtO2uTkzFceUK9";
            try
            {
                //Sets securely oupor canvas token to our http header
                client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", token);
                //asynchronously makes a get request to the link we want to
                HttpResponseMessage response = await client.GetAsync(url);
                response.EnsureSuccessStatusCode();
                //stringfy the response
                string responseBody = await response.Content.ReadAsStringAsync();
                return responseBody;
            }
            catch (HttpRequestException e)
            {
                Console.WriteLine("\nException Caught!");
                Console.WriteLine("Message :{0} ", e.Message);
                throw;
            }
        }
    }
 
}

