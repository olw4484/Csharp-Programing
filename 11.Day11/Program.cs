namespace _11.Day11
{
    internal class Program
    {


        #region class P.M
        abstract class PocketMonster
        {
            public string Name { get; set; }

            public PocketMonster(string name)
            {
                Name = name;
            }
            public virtual void Skill()
            {
                Console.WriteLine("스킬");
            }
        }

        class Pikachu : PocketMonster //피카츄
        {
            public Pikachu() : base("피카츄") { }

            public override void Skill()
            {
                Console.WriteLine($"{Name}의 100만볼트!");
            }
        }
        class Charmander : PocketMonster //파이리
        {
            public Charmander() : base("파이리") { }

            public override void Skill()
            {
                Console.WriteLine($"{Name}의 화염방사!");
            }
        }
        class Squirtle : PocketMonster //꼬부기
        {
            public Squirtle() : base("꼬부기") { }
            public override void Skill()
            {
                Console.WriteLine($"{Name}의 물대포!");
            }
        }
        class Bulbasaur : PocketMonster //이상해씨
        {
            public Bulbasaur() : base("이상해씨") { }
            public override void Skill()
            {
                Console.WriteLine($"{Name}의 덩굴채찍!");
            }
        }
        class Kyogre : PocketMonster //가이오가
        {
            public Kyogre() : base("가이오가") { }
            public override void Skill()
            {
                Console.WriteLine($"{Name}의 물의 파동!");
            }
        }
        class Umbreon : PocketMonster //블래키
        {
            public Umbreon() : base("블래키") { }
            public override void Skill()
            {
                Console.WriteLine($"{Name}의 악의 파동!");
            }

        }
        #endregion
        class Trainer
        {
            
            PocketMonster[] pocketmonsters = new PocketMonster[6];

            public Trainer() //포켓몬 세팅
            {
                pocketmonsters[0] = new Pikachu();
                pocketmonsters[1] = new Charmander();
                pocketmonsters[2] = new Squirtle();
                pocketmonsters[3] = new Bulbasaur();
                pocketmonsters[4] = new Kyogre();
                pocketmonsters[5] = new Umbreon();
            }

            public void Print()
            {
                foreach (PocketMonster p in pocketmonsters)
                {
                    p.Skill();
                }
            }
        }

            static void Main(string[] args)
            {
                Trainer trainer = new Trainer();
                trainer.Print();
            }
        }
    }

