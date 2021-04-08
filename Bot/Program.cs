using Discord;
using Discord.Commands;
using Discord.WebSocket;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Reflection;
using System.Threading;
using System.Threading.Tasks;
using Bot.Models;

namespace Bot
{
  public class Program
  {
    public static void Main(string[] args)
      => new Program().MainAsync().GetAwaiter().GetResult();

    private DiscordSocketClient _client;
    private CommandService _commands;
    private IServiceProvider _services;

    public async Task MainAsync()
    {
      _client = new DiscordSocketClient();
      _commands = new CommandService();

      _services = new ServiceCollection()
        .AddSingleton(_client)
        .AddSingleton(_commands)
        .BuildServiceProvider();
        
      _client.Log += Log;

      var token = EnvironmentVariables.BotToken;

      await RegisterCommandsAsync();

      await _client.LoginAsync(TokenType.Bot, token);

      await _client.StartAsync();

      await Task.Delay(-1);
    }
    
    private Task Log(LogMessage msg)
    {
      Console.WriteLine(msg.ToString());
      return Task.CompletedTask;
    }

    public async Task RegisterCommandsAsync()
    {
      _client.MessageReceived += HandleCommandAsync;
      await _commands.AddModulesAsync(Assembly.GetEntryAssembly(), _services);
    }

    private async Task HandleCommandAsync(SocketMessage arg)
    {
      var message = arg as SocketUserMessage;
      var context = new SocketCommandContext(_client, message);
      if (message.Author.IsBot) return;

      int argPos = 0;
      if (message.HasStringPrefix("$", ref argPos))
      {
        var result = await _commands.ExecuteAsync(context, argPos, _services);
        if (!result.IsSuccess) 
        {
          Console.WriteLine(result.ErrorReason);
          if (result.ErrorReason == "Unknown command.")
          {
            await message.Channel.SendMessageAsync("Invalid command. For a list of commands, type $commands");
            Thread.Sleep(3000);
            await message.Channel.SendMessageAsync("https://i.imgur.com/iwEd8zI.gif");
          }
        }
        if (result.Error.Equals(CommandError.UnmetPrecondition)) await message.Channel.SendMessageAsync(result.ErrorReason);
      }
    }
  }
}