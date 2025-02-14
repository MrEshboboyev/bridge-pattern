using Domain.Interfaces;

namespace Domain.Models;

public abstract class Notification(IMessageSender messageSender)
{
    protected IMessageSender _messageSender = messageSender;

    public abstract void Notify(string recipient);
}
