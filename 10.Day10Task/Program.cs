namespace _10.Day10Task
{
    internal class Program
    {
        //문제 컨셉이 포켓몬 생각 많이 나네.
        class Trainer
        {
            public string Name { get; set; }
            Monster[] monsters = new Monster[6];
            int monsterCount = 0;

            public Trainer() //이름, 주머니, 몬스터 추가 및 삭제 기능.
            {

                Console.WriteLine("플레이어의 이름을 입력해주세요."); 
                string? inputName = Console.ReadLine();

                if (string.IsNullOrEmpty(inputName))
                {
                    Console.WriteLine("잘못 입력하셨습니다.");
                }
                else
                {
                    Name = inputName.Trim();
                    Console.WriteLine($"입력하신 이름은 {Name}입니다.");
                }

            }
            public string Add(Monster monster)
            {
                for (int i = 0; i < monsters.Length; i++)
                {
                    if (monsters[i] == null)
                    {
                        monsters[i] = monster;
                        monsterCount++;
                        return $"{monster.Name}몬스터를 추가했습니다.";
                    }
                }
                return "몬스터 가방이 가득찼습니다."; //아무것도 하지 말라는게 이 return도 없어야하는건가.
            }
            public void AddMonster()
            {
                Console.WriteLine("추가할 몬스터의 이름을 입력해주세요:");
                string? monsterName = Console.ReadLine();
                if (string.IsNullOrEmpty(monsterName))
                {
                    Console.WriteLine("잘못 입력했습니다.");
                    return;
                }

                Console.WriteLine("추가할 몬스터의 레벨을 입력해주세요:");
                string? levelInput = Console.ReadLine();
                if (string.IsNullOrEmpty(levelInput) || !int.TryParse(levelInput, out int level))
                {
                    Console.WriteLine("잘못 입력했습니다.");
                    return;
                }

                Monster newMonster = new Monster(monsterName.Trim(), level);
                string result = Add(newMonster);
                Console.WriteLine($"추가된 몬스터의 이름은 {newMonster.Name}, 레벨은 {newMonster.Level}입니다.");
                Console.WriteLine(result);
            }
            public void Remove(string name) 
            {
                bool removed = false;
                for (int i = 0; i < monsterCount; i++)
                {
                    if (monsters[i] != null && monsters[i].Name == name)
                    {
                        Console.WriteLine($"{monsters[i].Name}가 제거되었습니다.");
                        monsters[i] = null;
                        removed = true;
                    }
                }
                if (!removed)
                {
                    Console.WriteLine("해당 이름의 몬스터가 없습니다.");
                }
            }
            public string PrintAll() //정상작동 확인
            {
                if (monsterCount == 0)
                {
                    return "보유중인 몬스터가 없습니다.";
                }
                else
                {
                    string result = $"{Name} 트레이너의 몬스터 목록:" + '\n';
                    foreach (var monster in monsters)
                    {
                        if (monster != null)
                        {
                            result += monster.ToString() + "\n";
                        }
                    }
                    return result;
                }
            }
            public class Monster //몬스터 이름 , 레벨, 출력기능.
            {
                public string Name { get; set; }
                public int Level { get; set; }

                public Monster(string name, int level)
                {
                    Name = name;
                    Level = level;
                }
                public override string ToString()
                {
                    return $"이름 : {Name} / level : {Level}";
                }

            }
            static void Main(string[] args)
            {
                Trainer trainer = new Trainer(); //예시에 드래곤 많이 보였던것같아서 드래곤으로 채움.
                trainer.AddMonster();
                Trainer.Monster monster1 = new Monster("삼삼드레", 64);
                string addResult1 = trainer.Add(monster1);
                Console.WriteLine(addResult1);
                Trainer.Monster monster2 = new Monster("신뇽", 23);
                string addResult2 = trainer.Add(monster2);
                Console.WriteLine(addResult2);
                Trainer.Monster monster3 = new Monster("망나뇽", 60);
                string addResult3 = trainer.Add(monster3);
                Console.WriteLine(addResult3);
                Trainer.Monster monster4 = new Monster("보만다", 58);
                string addResult4 = trainer.Add(monster4);
                Console.WriteLine(addResult4);
                Trainer.Monster monster5 = new Monster("한카리아스", 55);
                string addResult5 = trainer.Add(monster5);
                Console.WriteLine(addResult5);
                Trainer.Monster monster6 = new Monster("어차피 가방이 꽉참", 100);
                string addResult6 = trainer.Add(monster6);
                Console.WriteLine(addResult6);

                Console.WriteLine(trainer.PrintAll());
            }
        }
    }
}

