Произведите корректную (правильную) по вашему мнению реализацию с применением принципа Dependency-Inversion Principle, DIP:
Система уведомлений
В этом примере класс NotificationService напрямую зависит от конкретных классов EmailSender и SmsSender. Если нужно добавить новый тип уведомления, например, через мессенджер, придётся изменить класс NotificationService.
```csharp
public class EmailSender
{
    public void SendEmail(string message)
    {
        Console.WriteLine("Email sent: " + message);
    }
}

public class SmsSender
{
    public void SendSms(string message)
    {
        Console.WriteLine("SMS sent: " + message);
    }
}

public class NotificationService
{
    private EmailSender emailSender = new EmailSender();
    private SmsSender smsSender = new SmsSender();

    public void SendNotification(string message)
    {
        emailSender.SendEmail(message);
        smsSender.SendSms(message);
    }
}
```

Проблемы:
•	Класс NotificationService жестко связан с конкретными реализациями EmailSender и SmsSender. Если потребуется изменить способ отправки уведомлений или добавить новый способ, придется изменять код NotificationService.
