using _16.Day16_ConsoleGame.Scenes;

namespace _16.Day16_ConsoleGame
{
    class Shop : Scene
    {
        public override void Render()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("상점에는 다양한 상품들이 진열되어 있다.");
            Console.WriteLine("날카롭게 벼려진 검과 단단해보이는 방패, 갑옷.");
            Console.WriteLine("그것들을 지키듯 서 있는 한 남자가 눈에 들어왔다.");
            Console.WriteLine("\"어서오시오, 진열되어 있는 상품 말고도 다른게 있으니 편하게 둘러보시게나.\"");
            Console.WriteLine("당신은 무엇을 할 것인가?");
            Console.WriteLine("****************************************************");
        }

        public override void Choice()
        {
            Console.WriteLine("****************************************************");
            Console.WriteLine("1.아이템 둘러보기");
            Console.WriteLine("2.훔치기");
            Console.WriteLine("3.근처에대해서 물어보기"); //대화하는게 2개가 있을 필요가 있나. 씬을 전환해서 상점 주인이랑 대화하는씬을 따로 만드는 게 나을지도.
            Console.WriteLine("4.뒤돌아가기");
            Console.WriteLine("****************************************************");
        }

        public override void Result()
        {
            switch (input)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Console.WriteLine("원하는 아이템이 있는가?");
                    break;

                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Console.WriteLine("당신의 운을 시험할 때이다.");
                    break;

                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Console.WriteLine("****************************************************");
                    Console.WriteLine("근처의 소문?");
                    Console.WriteLine("마을의 모험가들한테 듣기로는");
                    Console.WriteLine("요즘들어 소형 몬스터들의 출몰이 잦아졌다고 하더군.");
                    Console.WriteLine("****************************************************");//퀘스트.
                    break;

                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    Console.WriteLine("다시 들려주시게.");
                    break;
            }

        }

        public override void Wait()
        {
            Console.WriteLine("계속하려면 아무키나 누르세요.");
            Console.ReadKey(true);
        }

        public override void Next()
        {
            if (input == ConsoleKey.D1 || input == ConsoleKey.NumPad1)
            {
                Console.WriteLine("당신은 상점 주인에게 말을 걸었습니다.");
            }
            else if (input == ConsoleKey.D2 || input == ConsoleKey.NumPad2)
            {
                Console.WriteLine("훔치기를 시도합니다.");

                Random random = new Random();
                int steal = random.Next(1, 101);

                if (steal <= 70)
                {
                    Console.WriteLine("당신은 훔치기에 실패했습니다. 상점에서 쫓겨 납니다.");
                    
                    Game.cutScene = Game.GetScene("Square");
                }
                else if (steal <= 95)
                {
                    Console.WriteLine("당신은 훔치기에 성공했습니다.");
                    
                }
                else
                {
                    Console.WriteLine("당신은 매우 정교한 손놀림으로 아이템을 훔쳤습니다.");
                    
                }
            }
            else if (input == ConsoleKey.D3 || input == ConsoleKey.NumPad3)
            {
                Console.WriteLine("당신은 몬스터의 출몰이 잦아진 것을 알았습니다.");
                //player에 퀘스트 클래스 추가.
            }
            else if (input == ConsoleKey.D4 || input == ConsoleKey.NumPad4)
            {
                
                Game.cutScene = Game.GetScene("Square");
            }
            else
            { Console.WriteLine("잘못된 키를 입력하셨습니다."); }
            

        }

    }
}
