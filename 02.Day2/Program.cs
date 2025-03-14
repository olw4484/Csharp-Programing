namespace _02.Day2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //기본 룰 : 질문이 5개, 100점상한, 1문제당 최대 20점(20 / 15 / 10 / 그외 - 10)

            //기본 점수 초기화
            int score = 0;
            //Q.1~5
            //문제마다 region으로 나누어 가독성을 높힘.
            #region Q.1
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Q.1 가장 좋아하는 음식을 선택해주세요.");
            Console.WriteLine("1. 치킨 \t 2. 피자 \t 3. 국밥");
            Console.WriteLine("---------------------------------------------");
            int choice1;
            int.TryParse(Console.ReadLine(), out choice1); //Parse는 예외처리가 어려워 TryParse를 사용해 string에 대한 예외처리를 추가.

            if (choice1 == 1)
            {
                score += 20;
            }
            else if (choice1 == 2)
            {
                score += 10;
            }
            else if (choice1 == 3)
            {
                score += 15;
            }
            else
            {
                Console.WriteLine("잘못된 선택입니다. 10점 감점합니다. \n");
                score -= 10;
            }
            #endregion
            #region Q.2
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Q.2 좋아하는 취미을 선택해주세요.");
            Console.WriteLine("1. 게임 \t 2. 독서 \t 3. 유튜브");
            Console.WriteLine("---------------------------------------------");
            int choice2;
            int.TryParse(Console.ReadLine(), out choice2);

            if (choice2 == 1)
            {
                score += 20;
            }
            else if (choice2 == 2)
            {
                score += 15;
            }
            else if (choice2 == 3)
            {
                score += 10;
            }
            else
            {
                Console.WriteLine("잘못된 선택입니다. 10점 감점합니다. \n");
                score -= 10;
            }
            #endregion
            #region Q.3
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Q.3 MBTI의 2번째 단어를 선택해주세요.");
            Console.WriteLine("1.N \t 2. S");
            Console.WriteLine("---------------------------------------------");
            int choice3;
            int.TryParse(Console.ReadLine(), out choice3);

            if (choice3 == 1)
            {
                score += 20;
            }
            else if (choice3 == 2)
            {
                score += 0;
            }
            else
            {
                Console.WriteLine("잘못된 선택입니다. 10점 감점합니다. \n");
                score -= 10;
            }
            #endregion
            #region Q.4
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Q.4 사는 곳 을 선택해주세요.");
            Console.WriteLine("1.서울 \t 2.부산 \t 3.경기 \t 4.그외");
            Console.WriteLine("---------------------------------------------");
            int choice4;
            int.TryParse(Console.ReadLine(), out choice4);

            if (choice4 == 1)
            {
                score += 20;
            }
            else if (choice4 == 2)
            {
                score += 0;
            }
            else if (choice4 == 3)
            {
                score += 0;
            }
            else if (choice4 == 4)
            {
                score += 0;
            }
            else
            {
                Console.WriteLine("잘못된 선택입니다. 10점 감점합니다. \n");
                score -= 10;
            }
            #endregion
            #region Q.5
            Console.WriteLine("---------------------------------------------");
            Console.WriteLine("Q.5 키을 선택해주세요.");
            Console.WriteLine("1. 180이상 \t 2. 179이하 170이상 \t 3. 169이하");
            Console.WriteLine("---------------------------------------------");
            int choice5;
            int.TryParse(Console.ReadLine(), out choice5);

            if (choice5 == 1)
            {
                score += 0;
            }
            else if (choice5 == 2)
            {
                score += 20;
            }
            else if (choice5 == 3)
            {
                score += 0;
            }
            else
            {
                Console.WriteLine("잘못된 선택입니다. 10점 감점합니다. \n");
                score -= 10;
            }
            #endregion
            #region result
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("모든 선택이 끝났습니다.\n");
            Console.ResetColor();

            Console.WriteLine("최종 점수는!\n");
            Console.WriteLine($"{score}입니다!\n");
            if (score >= 80)
            {
                Console.ForegroundColor = ConsoleColor.Yellow; //Console.ForegroundColor = ConsoleColor.Yellow; 텍스트의 Color지정
                Console.WriteLine("저랑 잘맞는군요!");
                Console.ResetColor(); //Console.ResetColor(); Color초기화
            }
            else if (score >= 40)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("그럭저럭이네요.");
                Console.ResetColor();
            }
            else if (score >= 20)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("저랑은 잘 안맞는 모양이에요...");
                Console.ResetColor();
            }
            else if (score >= 0)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("저랑 완전 반대되는 사람인가보네요!");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("선택지가 어려웠나요?");
                Console.ResetColor();
            }
            #endregion
        }
    }
}
