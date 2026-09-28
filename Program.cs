using NetCord;
using NetCord.Gateway;
using NetCord.Logging;

string token = File.ReadAllText("bot_token.md").Trim();

GatewayClient client = new(new BotToken(token), new GatewayClientConfiguration
{
    Logger = new ConsoleLogger(),
});

await client.StartAsync();
await Task.Delay(-1);