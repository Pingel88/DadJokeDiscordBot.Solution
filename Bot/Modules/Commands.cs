using Discord.Commands;
using System.Threading.Tasks;
using System.Threading;
using Bot.Models;

namespace Bot.Modules
{
  public class Commands : ModuleBase<SocketCommandContext>
  {
    [Command("ping")]
    public async Task Ping()
    {
      await ReplyAsync("pong");
    }

    [Command("joke")]
    public async Task DadJoke()
    {
      Joke joke = Joke.GetJoke();
      await ReplyAsync(joke.Setup);
      Thread.Sleep(6500);
      await ReplyAsync(joke.PunchLine);
    }

    [Command("botlink")]
    public async Task BotLink()
    {
      await ReplyAsync("https://discord.com/oauth2/authorize?client_id=828681816235180082&permissions=2048&scope=bot");
    }

    [Command("commands")]
    public async Task CommandList()
    {
      await ReplyAsync("```php\n$ping play ping pong with Dad Joke Discord Bot\n$joke enjoy a dad joke provided by Dad Joke Discord Bot\n$botlink add this bot to your Discord\n$github view source code\n```");
    }

    [Command("github")]
    public async Task GitHub()
    {
      await ReplyAsync("https://github.com/Pingel88/DadJokeDiscordBot.Solution");
    }
  }
}