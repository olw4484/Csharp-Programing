using System;
using System.Collections.Generic;

class Program
{
    static Dictionary<string, Dictionary<string, int>> cities = new Dictionary<string, Dictionary<string, int>>
    {
        { "낙양", new Dictionary<string, int> { { "병력", 100 }, { "금", 500 }, { "쌀", 200 } } },
        { "허창", new Dictionary<string, int> { { "병력", 150 }, { "금", 300 }, { "쌀", 250 } } },
        { "성도", new Dictionary<string, int> { { "병력", 80 }, { "금", 200 }, { "쌀", 300 } } }
    };

    static string currentCity = "낙양";

    static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            DisplayCityInfo();
            Console.WriteLine("명령 입력: ");
            Console.WriteLine("- 1: 병력 모집");
            Console.WriteLine("- 2: 전투");
            Console.WriteLine("- 3: 자원 관리");
            Console.WriteLine("- 4: 도시 이동");
            Console.WriteLine("- 0: 종료");

            string command = Console.ReadLine();

            switch (command)
            {
                case "1":
                    RecruitTroops();
                    break;
                case "2":
                    Battle();
                    break;
                case "3":
                    ManageResources();
                    break;
                case "4":
                    MoveCity();
                    break;
                case "0":
                    Console.WriteLine("게임 종료.");
                    return;
                default:
                    Console.WriteLine("올바른 명령을 입력하세요!");
                    break;
            }
        }
    }

    static void DisplayCityInfo()
    {
        Console.WriteLine($"[현재 도시: {currentCity}]");
        Console.WriteLine($"병력: {cities[currentCity]["병력"]}");
        Console.WriteLine($"금: {cities[currentCity]["금"]}");
        Console.WriteLine($"쌀: {cities[currentCity]["쌀"]}");
    }

    static void RecruitTroops()
    {
        Console.WriteLine("병력 모집 중...");
        cities[currentCity]["병력"] += 10;
        cities[currentCity]["금"] -= 50;
        Console.WriteLine("병력 모집 완료! 병력이 10 증가했습니다.");
        Console.ReadLine();
    }

    static void Battle()
    {
        Console.WriteLine("어느 도시를 공격하시겠습니까? (현재 도시 제외):");
        foreach (var city in cities.Keys)
        {
            if (city != currentCity)
                Console.WriteLine($"- {city}");
        }

        string targetCity = Console.ReadLine();
        if (!cities.ContainsKey(targetCity) || targetCity == currentCity)
        {
            Console.WriteLine("올바른 도시를 선택하세요!");
        }
        else
        {
            Console.WriteLine($"{currentCity}의 병력: {cities[currentCity]["병력"]}");
            Console.WriteLine($"{targetCity}의 병력: {cities[targetCity]["병력"]}");

            int currentArmy = cities[currentCity]["병력"];
            int targetArmy = cities[targetCity]["병력"];

            if (currentArmy > targetArmy)
            {
                Console.WriteLine($"{targetCity}를 점령했습니다!");
                cities[currentCity]["병력"] -= targetArmy;
                cities[targetCity]["병력"] = 0; // 병력 소멸
            }
            else
            {
                Console.WriteLine("패배했습니다... 병력을 잃었습니다.");
                cities[currentCity]["병력"] -= targetArmy / 2; // 일부 병력 소멸
            }
        }
        Console.ReadLine();
    }

    static void ManageResources()
    {
        Console.WriteLine("쌀을 판매하거나 구매하시겠습니까? (판매: sell, 구매: buy)");
        string action = Console.ReadLine();

        if (action == "sell")
        {
            cities[currentCity]["금"] += 100;
            cities[currentCity]["쌀"] -= 50;
            Console.WriteLine("쌀을 판매하여 금을 얻었습니다!");
        }
        else if (action == "buy")
        {
            cities[currentCity]["금"] -= 100;
            cities[currentCity]["쌀"] += 50;
            Console.WriteLine("쌀을 구매했습니다!");
        }
        else
        {
            Console.WriteLine("올바른 명령을 입력하세요!");
        }
        Console.ReadLine();
    }

    static void MoveCity()
    {
        Console.WriteLine("이동할 도시를 선택하세요:");
        foreach (var city in cities.Keys)
        {
            if (city != currentCity)
                Console.WriteLine($"- {city}");
        }

        string targetCity = Console.ReadLine();
        if (cities.ContainsKey(targetCity) && targetCity != currentCity)
        {
            currentCity = targetCity;
            Console.WriteLine($"{targetCity}로 이동했습니다.");
        }
        else
        {
            Console.WriteLine("올바른 도시를 선택하세요!");
        }
        Console.ReadLine();
    }
}
