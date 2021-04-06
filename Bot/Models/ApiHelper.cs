using System.Threading.Tasks;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using RestSharp;

namespace Bot.Models
{
  class ApiHelper
  {
    public static async Task<string> ApiCall()
    {
      var client = new RestClient("https://dad-jokes.p.rapidapi.com/random/joke");
      var request = new RestRequest(Method.GET);
      request.AddHeader("x-rapidapi-key", EnvironmentVariables.ApiKey);
      request.AddHeader("x-rapidapi-host", "dad-jokes.p.rapidapi.com");
      var response = await client.ExecuteTaskAsync(request);
      return response.Content;
    }
  }
}