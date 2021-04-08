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
      Thread.Sleep(3000);
      await ReplyAsync("https://cdn.discordapp.com/attachments/828833580250562580/829008098969911346/Screen_Shot_2021-04-05_at_4.32.27_PM.png");
    }

    [Command("botlink")]
    public async Task BotLink()
    {
      await ReplyAsync("https://discord.com/oauth2/authorize?client_id=828681816235180082&permissions=2048&scope=bot");
    }

    [Command("commands")]
    public async Task CommandList()
    {
      await ReplyAsync("```php\n$ping play ping pong with Travis Scott Discord Bot\n$joke enjoy a dad joke provided by Travis Scott Discord Bot\n$botlink add this bot to your Discord\n$github view source code\n```");
    }

    [Command("github")]
    public async Task GitHub()
    {
      await ReplyAsync("https://github.com/Pingel88/TravisScottDiscordBot.Solution");
    }
  }
}