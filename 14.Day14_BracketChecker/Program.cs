namespace _14.Day14_BracketChecker
{
    internal class Program
    {

        // 괄호 검사기
        // 정규표현식은 어렵겠네, 순차정렬로 정리하는것도 안될듯.
        // True , false 값을 얻어야하니까 bool
        // 순차적으로 쪼개서 넣는다 했을 때 stack
        // 딕셔너리,
        //
        //
        //
        //
        //
        public static bool BracketChecker(string b)
        {
            Dictionary<char, char> checker = new Dictionary<char, char> { { ']', '[' }, { ')', '(' }, { '}', '{' } };
           
            Stack<char> charStack = new Stack<char>(); //스택 배열 생성 char = 단일
            foreach (char c in b) //( { [ 면 넣는다.
            {
                if (c == '(' || c == '{' || c == '[')
                {
                    charStack.Push(c);
                }
                else if (c == ')' || c == '}' || c == ']')
                {
                    if (charStack.Count == 0) //스택이 0일때 위의 값을 넣으려고하면 
                        return false; //false를 반환

                    char top = charStack.Peek();
                    if (top == checker[c])
                    {
                        charStack.Pop();
                    }
                    else
                    {
                        return false;
                    }

                }

            }
            return charStack.Count == 0;

        }
        static void Main(string[] args)
        {
            Console.WriteLine(BracketChecker("()"));           
            Console.WriteLine(BracketChecker("({[]})"));       
            Console.WriteLine(BracketChecker("{[()]}"));
            Console.WriteLine(BracketChecker("("));            
            Console.WriteLine(BracketChecker("{[}]"));         
            Console.WriteLine(BracketChecker("({[})]"));       

        }
    }
}
