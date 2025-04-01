namespace _16.Day16_ConsoleGame.Scenes
{
    public class TitleScene : Scene
    {

        public override void Render()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("*          판타지 RPG             *");
            Console.WriteLine("**********************************");
            Console.WriteLine();
        }

        public override void Choice()
        {
            Console.WriteLine("1. 게임시작");
            Console.WriteLine("2. 불러오기(미구현)");
            Console.WriteLine("3. 게임종료(ESC)");
        }
        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.WriteLine("모험을 시작합니다.");
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.WriteLine("아직 미구현 상태입니다.");
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                case ConsoleKey.Escape:
                    Console.WriteLine("게임을 종료했습니다.");
                    break;
            }
        }
        public override void Wait()
        {
            Console.WriteLine("계속하려면 아무키나 누르세요.");
            Console.ReadKey(true);
            Console.Clear();
        }

        public override void Next()
        {
            if (input == ConsoleKey.D1 || input == ConsoleKey.NumPad1)
            {
                Game.cutScene = Game.GetScene("Square");
            }
            if (input == ConsoleKey.D3 || input == ConsoleKey.NumPad3 || input == ConsoleKey.Escape )
            {
                Game.End();
            }
            Cleared();
        }
    }
}