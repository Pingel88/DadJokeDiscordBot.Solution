using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Discord;
using Discord.Commands;
using Discord.WebSocket;

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
      await ReplyAsync("I'm Jeroen, snoot snoot snoot I'm better because I'm Europapa.");
    }
  }
}

