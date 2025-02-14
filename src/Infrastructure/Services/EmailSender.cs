using System;
using Domain.Interfaces;

namespace Infrastructure.Services;

public class EmailSender : IMessageSender
{
    public void SendMessage(string recipient, string message)
    {
        Console.WriteLine($"📧 Email sent to {recipient}: {message}");
    }
}
