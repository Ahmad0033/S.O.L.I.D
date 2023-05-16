// Example of Dependency Inversion Principle (DIP)
// This interface represents a message sender.

public interface IMessageSender
{
    void SendMessage(string message);
}

// represents an email message sender.

public class EmailSender : IMessageSender
{
    public void SendMessage(string message)
    {
        // Code for sending an email
    }
}

// represents an SMS message sender.

public class SmsSender : IMessageSender
{
    public void SendMessage(string message)
    {
        // Code for sending an SMS
    }
}

// processes and sends messages using a message sender.

public class MessageService
{
    private IMessageSender messageSender;

    public MessageService(IMessageSender sender)
    {
        messageSender = sender;
    }

    public void SendMessage(string message)
    {
        messageSender.SendMessage(message);
    }
}
