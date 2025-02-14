using System;
using Domain.Interfaces;

namespace Infrastructure.Services;

public class SmsSender : IMessageSender
{
    public void SendMessage(string recipient, string message)
    {
        Console.WriteLine($"📱 SMS sent to {recipient}: {message}");
    }
}
