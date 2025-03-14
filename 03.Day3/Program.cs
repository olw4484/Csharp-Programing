namespace _03.Day3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("두 수 사이의 합을 구합니다. 시작할 작은 수를 입력하여주세요.");
            //(n1~n2)의 모두 더한 값이 n3로 출력되어야한다.
            //2번째 숫자가 1번째 숫자보다 작으면 다시 값을 받아야한다.

            int startNum;

            while (true)
            {
                string? startInput = Console.ReadLine();
                if (int.TryParse(startInput, out startNum))

                {
                    Console.WriteLine($"입력하신 시작 수는 {startNum}입니다.");
                    break;
                }
                else
                {
                    Console.WriteLine("유효하지 않은 값입니다. 다시 입력해주세요."); //예외처리 

                }
            }

            Console.WriteLine("끝 수를 입력해주세요.");

            int endNum;

            while (true)
            {
                string? endInput = Console.ReadLine();
                if (int.TryParse(endInput, out endNum)) 
                {
                    if (startNum <= endNum) //시작 수와 끝 수 비교하여 끝 수가 작으면 다시 시작.
                    {
                        Console.WriteLine($"입력하신 끝 수는 {endNum}입니다.");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("끝 수가 시작 수보다 낮을 수 없습니다.");
                    }
                }
                else
                {
                    Console.WriteLine("유효하지 않은 값입니다. 다시 입력해주세요.");
                }
            }
            int resultNum = 0;
            for (int i = startNum; i <= endNum; i++) //시작 수부터 순차적으로 1을 더해 시행횟수가 끝 수에 도달하면 멈춤.
            {
                resultNum += i;
            }

            Console.WriteLine($"{startNum}과 {endNum}의 합은 {resultNum}입니다 ");
        }
    }
}
