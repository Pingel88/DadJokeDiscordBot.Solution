using Discord.Commands;
using System.Threading.Tasks;
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

    [Command("snoot")]
    public async Task Snoot()
    {
      await ReplyAsync("I'm Jeroen, snoot snoot snoot I'm better because I'm a Europeepeepeepeepeepeepeepeepeepeepeepeepeepen15.");
    }

    [Command("jeroen")]
    public async Task Jeroen()
    {
      await ReplyAsync("https://i.gifer.com/G2La.gif");
    }

    [Command("levi")]
    public async Task Levi()
    {
      await ReplyAsync("https://media.giphy.com/media/xThtag14x9AOyZOXiU/giphy.gif");
    }

    [Command("morgan")]
    public async Task Morgan()
    {
      await ReplyAsync("https://i.imgur.com/UlPocBP.gif");
    }

    [Command("joke")]
    public async Task DadJoke()
    {
      Joke joke = Joke.GetJoke();
      await ReplyAsync(joke.Setup);
      await ReplyAsync(joke.PunchLine);
    }
  }
}