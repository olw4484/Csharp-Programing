namespace Day3Task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = 5;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < height - i - 1; j++)
                {
                    Console.Write(" ");
                }
                for (int k = 0; k <= i; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();

            }
        }
    }
}
