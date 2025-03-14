namespace _04.Day4
{
    internal class Program
    {
        public static void PrintMessage()
        {
            Console.WriteLine("Hello, world!");
        }

        static void Main(string[] args)
        {
            PrintMessage(); // PrintMessage 메서드 호출
            Console.WriteLine("키를 눌러주세요.");
            Console.ReadLine(); // 종료 대기
        }
    }
}
