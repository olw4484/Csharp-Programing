namespace _06.Day6
{
    internal class Program
    {
        struct Position
        {
            public int x;
            public int y;
        }

        static ConsoleKey Input()
        {
            return Console.ReadKey(true).Key; // Prevents displaying the key press in the console
        }

        static void Update(ref Position playerPos,ref Position goalPos, ConsoleKey input, bool[,] map, ref bool gameOver)
        {
            Move(ref playerPos, input, map);
            bool isClera = CheckGameClear(playerPos, goalPos);
            if (isClera)
            {
                gameOver = true;
            }


            if (playerPos.x == 13 && playerPos.y == 8)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("게임 클리어");
                Console.ReadKey();
                Environment.Exit(0);
            }
        }

        static void Render(Position playerPos, Position goalPos, bool[,] map)
        {
            Console.Clear();
            //Console.SetCursorPosition(0, 0);
            PrintMap(map);
            PrintPlayer(playerPos);
            PrintGoal(goalPos);

        }

        static void Move(ref Position playerPos, ConsoleKey input, bool[,] map)
        {
            switch (input)
            {
                case ConsoleKey.UpArrow:
                case ConsoleKey.W:
                    if (map[playerPos.y - 1, playerPos.x] == true)
                    {
                        playerPos.y--;
                    }
                    break;
                case ConsoleKey.DownArrow:
                case ConsoleKey.S:
                    if (map[playerPos.y + 1, playerPos.x] == true)
                    {
                        playerPos.y++;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                case ConsoleKey.A:
                    if (map[playerPos.y, playerPos.x - 1] == true)
                    {
                        playerPos.x--;
                    }
                    break;
                case ConsoleKey.RightArrow:
                case ConsoleKey.D:
                    if (map[playerPos.y, playerPos.x + 1] == true)
                    {
                        playerPos.x++;
                    }
                    break;
            }
        }
        static bool CheckGameClear(Position playerPos, Position galPos)
        {
            bool success = (playerPos.x == galPos.x) && (playerPos.y == galPos.y);
            return success;
        }

        static void PrintMap(bool[,] map)
        {
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    if (map[y, x] == false)
                    {
                        Console.Write('■');
                    }
                    else
                    {
                        Console.Write(' ');
                    }
                }
                Console.WriteLine();
            }
        }

        static void PrintPlayer(Position playerPos)
        {
            Console.SetCursorPosition(playerPos.x, playerPos.y);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write('●');
            Console.ResetColor();
        }

        static void PrintGoal(Position goalPos)
        {
            Console.SetCursorPosition(goalPos.x, goalPos.y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write('G');
            Console.ResetColor();
        }

        static void Start(ref Position playerPos, ref Position goalPos, out bool[,] map)
        {
            Console.CursorVisible = false;
            playerPos.x = 1;
            playerPos.y = 1;

            goalPos.x = 13;
            goalPos.y = 8;

            map = new bool[10,15]
            {
                {false, false, false,false,false,false,false,false,false,false,false,false,false,false,false},
                {false,true,true,true,true,true,true,true,true,true,true,true,true,true,false},
                {false,true,true,true,true,true,true,true,true,true,true,true,true,true,false},
                {false,true,true,true,true,true,true,true,true,true,true,true,true,true,false},
                {false,true,true,true,true,true,true,true,true,true,true,true,true,true,false},
                {false,true,true,true,true,true,true,true,true,true,true,true,true,true,false},
                {false,true,true,true,true,true,true,true,true,true,true,true,true,true,false},
                {false,false,false,true,true,true,true,true,true,true,true,true,true,true,false},
                {true,true,false,true,true,true,true,true,true,true,true,true,true,true,false},
                {true,true,false,false,false,false,false,false,false,false,false,false,false,false,false},
            };

            ShowTitle();
        }

        static void ShowTitle()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("미로 찾기 게임", ConsoleColor.Yellow);
            Console.WriteLine("-------------------");
            Console.WriteLine("게임을 시작하려면 아무 키나 누르세요.");

            Console.ReadKey(true);
        }

        static void End()
        {
            Console.Clear();
            Console.WriteLine("게임을 종료하였습니다."); 
        }

        static void Main(string[] args)
        {
            bool gameOver = false;
            Position playerPos = new Position();
            Position goalPos = new Position();
            bool[,] map;

            Start(ref playerPos, ref goalPos, out map);

            while (gameOver == false)
            {
                ConsoleKey input = Input();
                if (input == ConsoleKey.Escape)
                {
                    gameOver = true;
                }
                else
                {
                    Update(ref playerPos, ref goalPos, input, map, ref gameOver);
                    Render(playerPos, goalPos, map);
                }
            }
            End();
        }
    }
}
