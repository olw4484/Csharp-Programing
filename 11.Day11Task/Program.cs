using System;

namespace _11.Day11Task
{
    internal class Program
    {
        #region//classPocket
        abstract class Pocketmon
        {
            public string Name { get; set; }

            public Pocketmon(string name)
            { Name = name; }
            public virtual void Attack()
            {
                Console.WriteLine("공격넣는곳");
            }
        }
        class Pikachu : Pocketmon //피카츄
        {
            public Pikachu() : base("피카츄") { }

            public override void Attack()
            {
                Console.WriteLine($"{Name}의 100만볼트!");
            }
        }
        class Charmander : Pocketmon //파이리
        {
            public Charmander() : base("파이리") { }

            public override void Attack()
            {
                Console.WriteLine($"{Name}의 100만볼트!");
            }
        }
        class Squirtle : Pocketmon //꼬부기
        {
            public Squirtle() : base("꼬부기") { }
            public override void Attack()
            {
                Console.WriteLine($"{Name}의 물대포!");
            }
        }
        class Bulbasaur : Pocketmon //이상해씨
        {
            public Bulbasaur() : base("이상해씨") { }
            public override void Attack()
            {
                Console.WriteLine($"{Name}의 덩굴채찍!");
            }
        }
        class Kyogre : Pocketmon //가이오가
        {
            public Kyogre() : base("가이오가") { }
            public override void Attack()
            {
                Console.WriteLine($"{Name}의 물의 파동!");
            }
        }
        class Umbreon : Pocketmon //블래키
        {
            public Umbreon() : base("블래키") { }
            public override void Attack()
            {
                Console.WriteLine($"{Name}의 악의 파동!");
            }

        }
        class Salamence : Pocketmon //보만다 6마리 이상이라만든 7번째 맴버.
        {
            public Salamence() : base("보만다") { }
            public override void Attack()
            {
                Console.WriteLine($"{Name}의 지진!");
            }

        }
        #endregion
        #region classTrainer
        class Trainer
        {

            Pocketmon[] pocketmonsters = new Pocketmon[6]; //포켓몬을 6마리 가지는 배열.
            Pocketmon pickPocketmon; 

            public Trainer() //포켓몬 6마리 세팅
            {
                pocketmonsters[0] = new Pikachu();
                pocketmonsters[1] = new Charmander();
                pocketmonsters[2] = new Squirtle();
                pocketmonsters[3] = new Bulbasaur();
                pocketmonsters[4] = new Kyogre();
                pocketmonsters[5] = new Umbreon();
            }

            public void Pick(int index) //포켓몬을 소환하는 기능?
            {
                if (index < 0 || index >= pocketmonsters.Length) //index의 길이
                {
                    Console.WriteLine("유요하지 않는 선택입니다");
                    return;
                }
                pickPocketmon = pocketmonsters[index];
                Console.WriteLine($"{pickPocketmon.Name}를 선택하였습니다.");
                pickPocketmon.Attack();

            }
            public void Print() // 보유포켓몬 목록 보여주는 것.
            {
                Console.WriteLine("보유 포켓몬 목록:");
                for (int i = 0;  i < pocketmonsters.Length; i++)
                {
                    Console.WriteLine($"{pocketmonsters[i].Name}");
                }
                Console.WriteLine();
            }
        }
        #endregion
        static void Main(string[] args)
        {
            Trainer trainer = new Trainer();
            
            trainer.Print(); //모든 포켓몬을 보여줌.
            trainer.Pick(3); //이상해씨 선택.
        }
    }
}
