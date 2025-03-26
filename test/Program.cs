public interface IOpenable
{
    void Open();
    void Close();
}
public class Door : IOpenable
{
    public void Open()
    {
        Console.WriteLine("문이 열렸습니다.");
    }
    public void Close()
    {
        Console.WriteLine("문이 닫혔습니다.");
    }
}
public class GarageDoor : IOpenable
{
    public void Open()
    {
        Console.WriteLine("차고 문이 열렸습니다.");
    }

    public void Close()
    {
        Console.WriteLine("차고 문이 닫혔습니다.");
    }
}
class Program
{
    static void Main(string[] args)
    {
        IOpenable door = new Door();
        door.Open();
        door.Close();
        IOpenable gerageDoor = new GarageDoor();
        gerageDoor.Open();
        gerageDoor.Close();
    }
}