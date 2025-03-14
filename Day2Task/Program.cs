namespace Day2Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("숫자 2개를 입력해주세요.");
            Console.WriteLine("---------------------------------------------");
            int num1, num2;
            int.TryParse(Console.ReadLine(), out num1);
            int.TryParse(Console.ReadLine(), out num2);

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine($"입력하신 값은 {num1}, {num2}입니다.");
            Console.WriteLine("---------------------------------------------");

            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("연산자를 입력해주세요.(+, -, *, / , %) : ");
            Console.WriteLine("---------------------------------------------");
            string? oper = Console.ReadLine(); // 연산자의 영문명인 operator가 안되므로 앞글자를 따서 oper라고 지음.
                                               // string?이 가지는 의미는 입력값에 null도 포함함을 의미, null값이 입력될 수 있다는 경고가 뜨는 것을 지우기 위해서 추가함.

            switch (oper)
            {
                case "+":
                    Console.WriteLine("+를 선택했습니다.");
                    Console.WriteLine($"입력 값 : \n{num1}{oper}{num2}");
                    Console.WriteLine($"결과 값 : {num1 + num2}입니다.");
                    break;

                case "-":
                    Console.WriteLine("-를 선택했습니다.");
                    Console.WriteLine($"입력 값 : \n{num1}{oper}{num2}");
                    Console.WriteLine($"결과 값 : {num1 - num2}입니다.");
                    break;

                case "*":
                    Console.WriteLine("*를 선택했습니다.");
                    Console.WriteLine($"입력 값 : \n{num1}{oper}{num2}");
                    Console.WriteLine($"결과 값 : {num1 * num2}입니다.");
                    break;

                case "/":
                    if (num2 == 0)
                    {
                        Console.WriteLine("2번째 숫자에 0을 넣을 수 없습니다."); // num2값이 0을 입력할 경우 프로그램을 종료.
                    }
                    else
                    {
                        Console.WriteLine("/를 선택했습니다.");
                        Console.WriteLine($"입력 값 : \n{num1}{oper}{num2}");
                        Console.WriteLine($"결과 값 : {num1 / num2}입니다.");
                    }
                    break;

                case "%":
                    if (num2 == 0)
                    {
                        Console.WriteLine("2번째 숫자에 0을 넣을 수 없습니다."); // num2값이 0을 입력할 경우 프로그램을 종료.
                    }
                    else
                    {
                        Console.WriteLine("%를 선택했습니다.");
                        Console.WriteLine($"입력 값 : \n{num1}{oper}{num2}");
                        Console.WriteLine($"결과 값 : {num1 % num2}입니다.");
                    }
                    break;


            }



        }
    }
}
