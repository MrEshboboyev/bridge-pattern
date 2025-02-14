using System;
using Domain.Interfaces;

namespace Infrastructure.Services;

public class PushSender : IMessageSender
{
    public void SendMessage(string recipient, string message)
    {
        Console.WriteLine($"🔔 Push Notification sent to {recipient}: {message}");
    }
}
