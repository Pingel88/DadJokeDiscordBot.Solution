using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Bot.Models;
using System.Threading;

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

    [Command("repo")]
    public async Task RepoLink()
    {
      await ReplyAsync("https://github.com/Pingel88/TravisScottDiscordBot.Solution");
    }

    [Command("joke")]
    public async Task DadJoke()
    {
      Joke joke = Joke.GetJoke();
      await ReplyAsync(joke.Setup);
      Thread.Sleep(7500);
      await ReplyAsync(joke.Punchline);
      Thread.Sleep(1000);
      await ReplyAsync("https://cdn.discordapp.com/attachments/828833580250562580/829008098969911346/Screen_Shot_2021-04-05_at_4.32.27_PM.png");
    }
  }
}