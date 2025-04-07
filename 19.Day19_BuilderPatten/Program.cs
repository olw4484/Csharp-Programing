namespace _19.Day19_BuilderPatten
{
    internal class Program
    {
        #region IAnimal
        public interface IAnimal
        {
            public string Name { get; }
            public string Products { get; }
        }
        class Chiken : IAnimal
        {
            public string Name => "닭";
            public string Products => "달걀";
        }
        class GoldenChiken : IAnimal
        {
            public string Name => "황금 닭";
            public string Products => "황금 달걀";
        }
        class Dairy : IAnimal
        {
            public string Name => "젖소";
            public string Products => "우유";
        }
        class GoldenDairy : IAnimal
        {
            public string Name => "황금 젖소";
            public string Products => "황금 우유?";
        }
        class Sheep : IAnimal
        {
            public string Name => "양";
            public string Products => "양털";
        }
        class GoldenSheep : IAnimal
        {
            public string Name => "황금 양";
            public string Products => "황금 양털";
        }
        #endregion
        #region AnimalBuilder
        public class AnimalBuilder //빌더에도 랜덤을 넣을 수 있다.
        {
            private static readonly Random _random = new Random(); //랜덤 생성

            public IAnimal BuildAnimal()
            {
                bool isGolden = _random.Next(0, 100) < 5;
                int animalType = _random.Next(0, 3);

                if (isGolden)
                {
                    return animalType switch
                    {
                        0 => new GoldenChiken(),
                        1 => new GoldenDairy(),
                        2 => new GoldenSheep(), 
                        _ => throw new ArgumentException("올바르지 않은 값입니다.")
                    };
                }
                else
                {
                    return animalType switch
                    {
                        0 => new Chiken(),
                        1 => new Dairy(),
                        2 => new Sheep(),
                        _ => throw new ArgumentException("올바르지 않은 값입니다.")
                    };
                }
            }
        }
        #endregion
        static void Main(string[] args)
        {
            var builder = new AnimalBuilder();

            int goldCount = 0;

            for (int i = 0; i < 100000; i++) //100000회 반복.
            {
                var animal = builder.BuildAnimal();

                Console.WriteLine($"{animal.Name}이 {animal.Products}를 생성했습니다.");
                
                if (animal is GoldenChiken || animal is GoldenDairy || animal is GoldenSheep)
                {
                    goldCount++;
                }
            }

            Console.WriteLine($"황금의 등장 횟수 : {goldCount} 입니다.");

        }
    }
}
//1만번 돌리고 511개 등장. 5퍼 내외 맞는듯.
//10만번 2번 돌렸을때 4892, 5062.

//1 회차   5퍼인데2개?                                           2회차 5퍼인데 1개.
//젖소이 우유를 생성했습니다.                               /양이 양털를 생성했습니다.
//양이 양털를 생성했습니다.                                 /닭이 달걀를 생성했습니다.
//젖소이 우유를 생성했습니다.                               /양이 양털를 생성했습니다.
//닭이 달걀를 생성했습니다.                                 /젖소이 우유를 생성했습니다.
//양이 양털를 생성했습니다.                                 /양이 양털를 생성했습니다.
//황금 젖소이 황금 우유?를 생성했습니다.                     /황금 양이 황금 양털를 생성했습니다.
//양이 양털를 생성했습니다.                                 /닭이 달걀를 생성했습니다.
//황금 닭이 황금 달걀를 생성했습니다.                        /닭이 달걀를 생성했습니다.
//닭이 달걀를 생성했습니다.                                 /젖소이 우유를 생성했습니다.
//양이 양털를 생성했습니다.                                 /양이 양털를 생성했습니다.







//100회 7개 나옴. 그이 확률이 7퍼
//젖소이 우유를 생성했습니다.
//젖소이 우유를 생성했습니다.
//양이 양털를 생성했습니다.
//닭이 달걀를 생성했습니다.
//젖소이 우유를 생성했습니다.
//양이 양털를 생성했습니다.
//젖소이 우유를 생성했습니다.
//황금 닭이 황금 달걀를 생성했습니다.
//황금 닭이 황금 달걀를 생성했습니다.
//닭이 달걀를 생성했습니다.
//양이 양털를 생성했습니다.
//젖소이 우유를 생성했습니다.
//젖소이 우유를 생성했습니다.
//젖소이 우유를 생성했습니다.
//황금 닭이 황금 달걀를 생성했습니다.
//양이 양털를 생성했습니다.
//양이 양털를 생성했습니다.
//황금 양이 황금 양털를 생성했습니다.
//양이 양털를 생성했습니다.
//양이 양털를 생성했습니다.
//닭이 달걀를 생성했습니다.
//황금 닭이 황금 달걀를 생성했습니다.
//닭이 달걀를 생성했습니다.
//닭이 달걀를 생성했습니다.
//젖소이 우유를 생성했습니다.
//닭이 달걀를 생성했습니다.
//닭이 달걀를 생성했습니다.
//양이 양털를 생성했습니다.
//닭이 달걀를 생성했습니다.
//닭이 달걀를 생성했습니다.
//양이 양털를 생성했습니다.
//젖소이 우유를 생성했습니다.
//닭이 달걀를 생성했습니다.
//닭이 달걀를 생성했습니다.
//닭이 달걀를 생성했습니다.
//양이 양털를 생성했습니다.
//황금 닭이 황금 달걀를 생성했습니다.
//닭이 달걀를 생성했습니다.
//닭이 달걀를 생성했습니다.
//양이 양털를 생성했습니다.
//젖소이 우유를 생성했습니다.
//양이 양털를 생성했습니다.
//양이 양털를 생성했습니다.
//젖소이 우유를 생성했습니다.
//젖소이 우유를 생성했습니다.
//닭이 달걀를 생성했습니다.
//닭이 달걀를 생성했습니다.
//양이 양털를 생성했습니다.
//젖소이 우유를 생성했습니다.
//닭이 달걀를 생성했습니다.
//닭이 달걀를 생성했습니다.
//양이 양털를 생성했습니다.
//닭이 달걀를 생성했습니다.
//양이 양털를 생성했습니다.
//양이 양털를 생성했습니다.
//젖소이 우유를 생성했습니다.
//양이 양털를 생성했습니다.
//젖소이 우유를 생성했습니다.
//양이 양털를 생성했습니다.
//양이 양털를 생성했습니다.
//닭이 달걀를 생성했습니다.
//닭이 달걀를 생성했습니다.
//양이 양털를 생성했습니다.
//젖소이 우유를 생성했습니다.
//양이 양털를 생성했습니다.
//양이 양털를 생성했습니다.
//젖소이 우유를 생성했습니다.
//양이 양털를 생성했습니다.
//젖소이 우유를 생성했습니다.
//양이 양털를 생성했습니다.
//젖소이 우유를 생성했습니다.
//양이 양털를 생성했습니다.
//젖소이 우유를 생성했습니다.
//양이 양털를 생성했습니다.
//닭이 달걀를 생성했습니다.
//젖소이 우유를 생성했습니다.
//닭이 달걀를 생성했습니다.
//닭이 달걀를 생성했습니다.
//닭이 달걀를 생성했습니다.
//양이 양털를 생성했습니다.
//양이 양털를 생성했습니다.
//양이 양털를 생성했습니다.
//양이 양털를 생성했습니다.
//닭이 달걀를 생성했습니다.
//젖소이 우유를 생성했습니다.
//닭이 달걀를 생성했습니다.
//젖소이 우유를 생성했습니다.
//닭이 달걀를 생성했습니다.
//젖소이 우유를 생성했습니다.
//닭이 달걀를 생성했습니다.
//닭이 달걀를 생성했습니다.
//닭이 달걀를 생성했습니다.
//닭이 달걀를 생성했습니다.
//양이 양털를 생성했습니다.
//닭이 달걀를 생성했습니다.
//닭이 달걀를 생성했습니다.
//양이 양털를 생성했습니다.
//젖소이 우유를 생성했습니다.
//황금 닭이 황금 달걀를 생성했습니다.
//양이 양털를 생성했습니다.