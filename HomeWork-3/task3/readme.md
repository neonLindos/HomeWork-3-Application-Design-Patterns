Произведите корректную (правильную) по вашему мнению реализацию с применением принципа Interface Segregation Principle, ISP:
Работа с принтерами
В этом примере интерфейс IPrinter содержит методы для различных типов принтеров: обычного принтера, сканера и факса. Но что если какой-то принтер поддерживает только печать и сканирование, но не поддерживает отправку факсов? Такой принтер будет вынужден реализовывать метод Fax, который ему не нужен.

```csharp
public interface IPrinter
{
    void Print(string content);
    void Scan(string content);
    void Fax(string content);
}

public class AllInOnePrinter : IPrinter
{
    public void Print(string content)
    {
        Console.WriteLine("Printing: " + content);
    }

    public void Scan(string content)
    {
        Console.WriteLine("Scanning: " + content);
    }

    public void Fax(string content)
    {
        Console.WriteLine("Faxing: " + content);
    }
}

public class BasicPrinter : IPrinter
{
    public void Print(string content)
    {
        Console.WriteLine("Printing: " + content);
    }

    public void Scan(string content)
    {
        throw new NotImplementedException();
    }

    public void Fax(string content)
    {
        throw new NotImplementedException();
    }
}
```
Проблемы:
•	Класс BasicPrinter вынужден реализовывать методы Scan и Fax, даже если он их не поддерживает. Это нарушает принцип ISP, так как он зависит от методов, которые ему не нужны.
Вам необходимо разделить IPrinter на несколько более мелких интерфейсов, каждый из которых описывает отдельную функциональность. 
