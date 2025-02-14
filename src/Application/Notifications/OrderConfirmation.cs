using Domain.Interfaces;
using Domain.Models;

namespace Application.Notifications;

public class OrderConfirmation(IMessageSender messageSender) : Notification(messageSender)
{
    public override void Notify(string recipient)
    {
        string message = "Your order has been confirmed! 🚀";
        _messageSender.SendMessage(recipient, message);
    }
}
