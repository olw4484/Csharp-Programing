using System.Text.RegularExpressions;

namespace _99.Coding_exercises
{
    internal class Program
    {
        public static class InputQueue
        {
            public static Queue<(char, int)> queue = new Queue<(char, int)>();

            public static void AddQueue()
            {
                Console.WriteLine("수식을 입력해주세요. 'end' 입력 시 종료됩니다.");
                while (true)
                {
                    string? input = Console.ReadLine();
                    if (string.IsNullOrEmpty(input)) continue;
                    if (input.ToLower() == "end")
                        break;

                    MatchCollection matches = Regex.Matches(input, @"([-+*/%])?\s*(-?\d+)");
                    queue.Clear();

                    foreach (Match match in matches)
                    {
                        char operation = match.Groups[1].Success ? match.Groups[1].Value[0] : '+';
                        if (int.TryParse(match.Groups[2].Value, out int number))
                        {
                            queue.Enqueue((operation, number));
                            Console.WriteLine($"추가된 연산: {operation} {number}");
                        }
                        else
                        {
                            Console.WriteLine("잘못된 입력입니다. 다시 입력해주세요.");
                            queue.Clear();
                            return;
                        }
                    }
                }
            }
        }

        public static class Calculate
        {
            public static int ProcessQueue()
            {
                if (InputQueue.queue.Count < 1) // 큐에 넣은 값이 0개면 값을 입력해달라고함.
                {
                    Console.WriteLine("유효한 수식을 입력해주세요.");
                    return 0;
                }

                Stack<int> values = new Stack<int>(); // 숫자값 스택
                Stack<char> operators = new Stack<char>(); // 수식값 스택

                while (InputQueue.queue.Count > 0) //큐에 값이 1개라도 있을 경우
                {
                    var (op, num) = InputQueue.queue.Dequeue(); //char op, int num이라 간단히 작성하기 위해 var를 사용 / 첫 번째 튜플을 꺼내온다.

                    if (values.Count == 0) // 숫자값이 들어갈 스택이 0이라면 
                    {
                        values.Push(num); //튜플의 num을 넣는다.
                        continue; //반복
                    }

                    if (op == '+' || op == '-') //튜플의 char가 + 혹은 -일 경우 
                    {
                        while (operators.Count > 0 && (operators.Peek() == '*' || operators.Peek() == '/' || operators.Peek() == '%')) //수식 1개 이상의 값이 들어 있으면서 그 값이 `*` `/` `%`일때 
                        {
                            int right = values.Pop(); //첫 번째 값을 꺼내고
                            int left = values.Pop(); // 두 번째 값을 꺼낸다.
                            char prevOp = operators.Pop(); //그리고 가장 위의 연산자도 꺼내온다.
                            values.Push(ApplyOperation(left, right, prevOp)); // 연산 수행 및 결과 값을 다시 스택에 저장.
                        }
                        operators.Push(op); //남은 연산자를 다시 넣고
                        values.Push(num); //남은 숫자도 스택에 넣는다.
                    }
                    else // `*` `/` `%`가 아닐때 
                    {
                        int left = values.Pop(); // 스택의 값을 꺼내오고
                        values.Push(ApplyOperation(left, num, op)); //연산 수행 시작
                    }
                }

                while (operators.Count > 0) //연산자가 있을 경우 연산을 한다.
                {
                    int right = values.Pop();
                    int left = values.Pop();
                    char prevOp = operators.Pop();
                    values.Push(ApplyOperation(left, right, prevOp));
                }

                return values.Count > 0 ? values.Pop() : 0; //모든 연산자도 소모 했을땐 연산이 끝나고 스택의 개체값이 1개라도 있으면 반환하고 없으면 0을 반환한다.
            }

            private static int ApplyOperation(int left, int right, char op) // 계산해주는 함수
            {
                return op switch //C# 8.0에서 추가된 스위치 표현식
                {
                    '+' => left + right,
                    '-' => left - right,
                    '*' => left * right,
                    '/' => right == 0 ? throw new DivideByZeroException("0으로 나눌 수 없습니다.") : left / right,
                    '%' => right == 0 ? throw new DivideByZeroException("0으로 나눌 수 없습니다.") : left % right,
                    _ => left
                };
            }
        }


        public static class ControlFlow
        {
            public static void Start()
            {
                InputQueue.AddQueue();
                Console.WriteLine($"계산 결과:{Calculate.ProcessQueue()}");
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("계산기 프로그램을 시작합니다.");
            ControlFlow.Start();
        }
    }
}
