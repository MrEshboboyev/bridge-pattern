using System;
using Domain.Interfaces;
using Domain.Models;

namespace Application.Notifications;

public class PromotionNotification(IMessageSender messageSender) : Notification(messageSender)
{
    public override void Notify(string recipient)
    {
        string message = "🎉 Big Sale! Get 50% off on all products!";
        _messageSender.SendMessage(recipient, message);
    }
}
