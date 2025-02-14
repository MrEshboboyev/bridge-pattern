namespace Domain.Interfaces;

public interface IMessageSender
{
    void SendMessage(string recipient, string message);
}
