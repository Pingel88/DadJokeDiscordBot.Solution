using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;

namespace Bot.Models
{
  public class Joke
  {
    public string Setup { get; set; }
    public string PunchLine { get; set; }

    public static Joke GetJoke()
    {
      var apiCallTask = ApiHelper.ApiCall();
      var result = apiCallTask.Result;
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Joke> jokeList = JsonConvert.DeserializeObject<List<Joke>>(jsonResponse["body"].ToString());
      return jokeList[0];
    }
  }
}