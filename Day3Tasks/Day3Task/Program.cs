namespace Day3Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //트리 만들기?
            //각 파일별로 공백과 (" ") 별("*")로 5단 트리 모양 만들기.
            //중첩 반복문을 사용할것.

            for (int i = 0; i < 5; i++)
            {
                for (
                    int j = 0; j <= i; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine(" ");
            }


        }
    }
}
