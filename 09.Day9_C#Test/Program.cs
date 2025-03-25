using System.Text.RegularExpressions;

namespace _09.Day9_C_Test
{
    internal class Program
    {
        public static bool IsPrime(int number)
        {
            if (number == 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                    return false;
            }
            return true;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("소수를 확인하고 싶은 숫자를 입력하세요:");
            int input;

            while (true)
            {
                string? rawInput = Console.ReadLine();

                if (int.TryParse(rawInput, out input) && input > 0)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("유효한 양의 정수를 입력해주세요.");
                }
            }
            if (IsPrime(input))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

            Regex regex = new Regex(@"\d+");
            bool isMatch = regex.IsMatch("12345");
            Console.WriteLine(isMatch); // true

        }




    }

}



