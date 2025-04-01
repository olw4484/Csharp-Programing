using _16.Day16_ConsoleGame.Scenes;

namespace _16.Day16_ConsoleGame
{
    public class Square : Scene //아 개 멍청하게 , numpad숫자 눌러놓고 왜 작동 안하나 그 생각하고 있었네 
    {
        private static int SunCount = 0;
        public void SunEvent()
        {
            if (SunCount <= 10) // 아무일 없음. 또는의 조건식이... 
            {
                Console.WriteLine("****************************************************");
                Console.WriteLine("따듯한 햇살이 당신을 훑었습니다.");
                Console.WriteLine("그러나 아무일도 일어나지 않았습니다.");
                Console.WriteLine("****************************************************");

            }
            else if (SunCount > 11 && SunCount <= 20) // 운이 최대 10 오름.
            {
                Console.WriteLine("****************************************************");
                Console.WriteLine("햇빛의 가호를 받아 운이 상승합니다.");
                Console.WriteLine("운이 1올랐습니다.");
                Console.WriteLine("****************************************************");
            }
            else if (SunCount > 21 && SunCount <= 25) // 화염 내성이 오름.
            {
                Console.WriteLine("****************************************************");
                Console.WriteLine("햇빛을 너무 받아서 피부가 탔습니다.");
                Console.WriteLine("피부가 검게 변하면서 화염내성이 1 올랐습니다.");
                Console.WriteLine("****************************************************");
            }
            else if (SunCount >= 26)
            {
                Console.WriteLine("****************************************************");
                Console.WriteLine("따듯한 햇살이 당신을 훑었습니다.");
                Console.WriteLine("그러나 아무일도 일어나지 않았습니다.");
                Console.WriteLine("****************************************************");
            }
            SunCount++;
        }

        public override void Render()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("당신은 광장에 있습니다.");
            Console.WriteLine("사람들이 오가고, 다양한 상점들이 들어서 있습니다.");
            Console.WriteLine("눈부신 햇살이 당신의 기분을 좋게 만듭니다.");
            Console.WriteLine("****************************************************");
        }
        public override void Choice()
        {
            Console.WriteLine("1.상점으로 이동");
            Console.WriteLine("2.포션 상점으로 이동");
            Console.WriteLine("3.휴식하기");
            Console.WriteLine("4.성문 밖으로 나가기");
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.WriteLine("상점으로 이동합니다.");
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.WriteLine("미구현 상태입니다.");
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    SunEvent();
                    break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    Console.WriteLine("미구현 상태입니다.");
                    break;
            }
        }

        public override void Wait()
        {
            Console.WriteLine("계속하려면 아무키나 누르세요.");
            Console.ReadKey(true);
            Cleared();
        }
        public override void Next()
        {
            if (input == ConsoleKey.D1 || input == ConsoleKey.NumPad1)
            {
                Game.cutScene = Game.GetScene("Shop");
            }
            
        }
    }
}
