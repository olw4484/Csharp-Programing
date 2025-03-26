using static System.Formats.Asn1.AsnWriter;

namespace _12.Day12
{
    internal class Program
    {
        //추가할만한 것, Switch문으로 console의 선택지 띄우기 및 선택시 그 상황에 맞게 console 불러오기.
        //소지 골드에 따른 상점에서의 물건 사고 팔때의 상호작용. 돈이 있을때 상품을 구매하면 골드 차감, 없을때 구매하려고하면 돈이 없으니 꺼지라는 대사 출력.
        //상자나 문에 잘못된 입력키를 눌렀을때 void Talk 출력하게 만들기.
        //아이템이면 습득하게 만들기. 그럼 큰틀부터 갈아엎어야하네.
        //아 플레이어가 없네ㅋㅋㅋㅋ

        #region IInteraction
        public interface IInteraction //Open, Talk가 2개가 들어가고 하위에서도 강제되니까 메모리 낭비같은 느낌이 듦.
        {
            void Open();
            void Talk();
            void Get();
        }
        public class Npc : IInteraction
        {
            public void Open()
            {
                Console.WriteLine("Npc를 열수는 없습니다.");
            }
            public void Talk()
            {
                Console.WriteLine("-------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("무엇을 찾고 있는가요?");
                Console.ResetColor();
                Console.WriteLine("-------------------------------------------------");
            }
            public void Get()
            {
                Console.WriteLine("Npc를 가질수는 없습니다.");
            }
        }
        public class Chest : IInteraction
        {
            public void Open()
            {
                Console.WriteLine("-------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("상자를 열기만 했습니다.");
                Console.ResetColor();
                Console.WriteLine("-------------------------------------------------");
            }
            public void Talk()
            {
                Console.WriteLine("상자와는 대화할 수 없습니다.");
            }
            public void Get()
            {
                Console.WriteLine("-------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("아이템을 습득했습니다.");
                Console.ResetColor();
                Console.WriteLine("-------------------------------------------------");
            }
        }
        public class Door : IInteraction
        {
            public void Open()
            {
                Console.WriteLine("-------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("문를 열었습니다.");
                Console.ResetColor();
                Console.WriteLine("-------------------------------------------------");
            }
            public void Talk()
            {
                Console.WriteLine("문과는 대화할 수 없습니다.");
            }
            public void Get()
            {
                Console.WriteLine("문을 가질 수는 없습니다.");
            }
        }
        #endregion
        #region Main
        static void Main(string[] args)
        {
            //인터페이스로 배열을 만들 수 있다.
            IInteraction[] interaction = { new Door(), new Npc(), new Chest() }; //객체를 배열로 초기화.

            foreach (var inter in interaction)
            {
                Console.WriteLine("-------------------------------------------------");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"{inter.GetType().Name}앞에 있습니다. G를 눌러 상호작용해주세요.");
                Console.ResetColor();
                Console.WriteLine("-------------------------------------------------");
                var input = Console.ReadKey(true).Key;

                if (input == ConsoleKey.G)
                {
                    if (inter is Npc)
                    {
                        inter.Talk(); //아 상점여는 기능.
                        Console.WriteLine("-------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("G를 눌러 상점을 이용해주세요.");
                        Console.ResetColor();
                        Console.WriteLine("-------------------------------------------------");
                        var store = Console.ReadKey(true).Key;

                        if (store == ConsoleKey.G)
                        {
                            Console.WriteLine("-------------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow; //이거 예전에도 검색했었었네 ㅋㅋㅋㅋ
                            Console.WriteLine("상점을 열었습니다.");
                            Console.ResetColor();
                            Console.WriteLine("-------------------------------------------------");
                        }
                    }
                    else if (inter is Chest)
                    {
                        inter.Open();
                        Console.WriteLine("-------------------------------------------------");
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("G를 눌러 아이템을 습득해주세요.");
                        Console.ResetColor();
                        Console.WriteLine("-------------------------------------------------");
                        var store = Console.ReadKey(true).Key;

                        if (store == ConsoleKey.G)
                        {
                            Console.WriteLine("-------------------------------------------------");
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("아이템을 얻었습니다.");
                            Console.ResetColor();
                            Console.WriteLine("-------------------------------------------------");
                        }
                        else
                        {
                            inter.Open();
                        }
                    }
                }
            }
            #endregion
        }
    }
}

