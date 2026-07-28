using Microsoft.AspNetCore.SignalR;

namespace Learning_ASP.Net.Hubs;

public class ChatHub : Hub
{
    public Task Echo(string message)
    {
        Console.WriteLine($"收到：{message}");

        return Task.CompletedTask;
    }
}