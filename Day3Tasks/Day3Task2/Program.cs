namespace Day3Task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int height = 5;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(" ");
                }
                for (int k = i; k < height; k++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }

        }

    }
}
