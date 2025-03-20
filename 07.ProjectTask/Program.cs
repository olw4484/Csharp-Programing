namespace _07.ProjectTask
{
    internal class Program
    {
        static int count = 0;
        static int stage = 0;
        static int keyGet = 0;

        static void Start(int stage, out Position playerPos, out Position goalPos, out Position keyPos, out char[,] map)
        {
            Console.CursorVisible = false;
            playerPos = new Position();
            goalPos = new Position();
            keyPos = new Position();
            map = new char[0, 0];

            switch (stage)
            {
                case 0:
                    {
                        playerPos.x = 1; //플레이어 위치를 1,1로 시작
                        playerPos.y = 1;

                        goalPos.x = 8; //골의 위치를 8,8로 설정.
                        goalPos.y = 8;

                        keyPos.x = 7; //열쇠의 위치를 4,7로 설정.
                        keyPos.y = 4;
                        map = new char[10, 10]
                        {
                            {'#','#','#','#','#','#','#','#','#','#'},
                            {'#',' ','#',' ',' ',' ',' ',' ',' ','#'},
                            {'#',' ',' ',' ','#',' ','#','#',' ','#'},
                            {'#',' ','#',' ','#',' ','#','#',' ','#'},
                            {'#',' ','#',' ','#',' ','#',' ',' ','#'},
                            {'#',' ','#',' ','#',' ','#','#','#','#'},
                            {'#',' ','#',' ','#',' ',' ',' ','#','#'},
                            {'#',' ','#',' ','#','#','#','#','#','#'},
                            {'#',' ','#',' ',' ',' ',' ',' ',' ','#'},
                            {'#','#','#','#','#','#','#','#','#','#'}
                        };
                    }
                    break;
                case 1:
                    {
                        playerPos.x = 1; //플레이어 위치를 1,1로 시작
                        playerPos.y = 1;

                        goalPos.x = 2; //골의 위치를 3,2로 설정.
                        goalPos.y = 3;

                        keyPos.x = 11; //열쇠의 위치를 4,11로 설정.
                        keyPos.y = 4;

                        map = new char[12, 15]
                        {
                            {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
                            {'#',' ',' ',' ',' ',' ',' ',' ',' ','#',' ',' ',' ',' ','#'},
                            {'#','#','#','#',' ','#',' ','#',' ','#',' ','#','#',' ','#'},
                            {'#',' ',' ','#',' ','#',' ','#',' ','#',' ',' ','#',' ','#'},
                            {'#',' ','#','#',' ','#',' ','#',' ','#','#',' ','#',' ','#'},
                            {'#',' ','#',' ',' ','#',' ','#','#','#','#','#','#',' ','#'},
                            {'#',' ','#',' ','#','#',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                            {'#',' ','#',' ','#','#','#','#','#','#','#','#','#',' ','#'},
                            {'#',' ','#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                            {'#',' ','#',' ','#','#','#','#','#','#','#','#','#',' ','#'},
                            {'#',' ',' ',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                            {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'}
                        };
                    }
                    break;
                case 2:
                    {
                        playerPos.x = 13;
                        playerPos.y = 1;

                        goalPos.x = 2;
                        goalPos.y = 1;

                        keyPos.x = 3;
                        keyPos.y = 1;

                        map = new char[15, 15]
                        {
                            {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'},
                            {'#', ' ', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
                            {'#', ' ', '#', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', '#', '#', '#'},
                            {'#', ' ', '#', '#', ' ', '#', ' ', '#', ' ', '#', ' ', ' ', '#', '#', '#'},
                            {'#', ' ', '#', '#', ' ', '#', ' ', '#', ' ', '#', '#', ' ', '#', ' ', '#'},
                            {'#', ' ', '#', ' ', ' ', '#', ' ', '#', ' ', '#', '#', '#', '#', ' ', '#'},
                            {'#', ' ', '#', ' ', '#', '#', '#', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
                            {'#', ' ', '#', ' ', '#', '#', '#', '#', '#', '#', '#', '#', '#', ' ', '#'},
                            {'#', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
                            {'#', ' ', '#', ' ', '#', '#', '#', '#', '#', '#', '#', '#', '#', ' ', '#'},
                            {'#', ' ', '#', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#'},
                            {'#', ' ', '#', ' ', '#', ' ', '#', '#', '#', '#', '#', '#', '#', ' ', '#'},
                            {'#', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#'},
                            {'#', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', '#', ' ', ' ', ' ', '#'},
                            {'#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#'}
                        };
                    }
                    break;
                default:
                    playerPos = new Position();
                    goalPos = new Position();
                    keyPos = new Position();
                    map = new char[10, 10];
                    break;
            }
            ShowTitle();
            keyGet = 0;
        }

        struct Position
        {
            public int x;
            public int y;
        }

        static void ShowTitle()
        {
            Console.WriteLine("------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("미로찾기 게임");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("아무키나 눌러서 실행해주세요.");
            Console.ForegroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("언제든 ESC를 누르면 종료됩니다.");
            Console.ResetColor();
            Console.WriteLine("------------------------------");
            Console.ReadKey(true);
            Console.Clear();
        }

        static void Render(Position playerPos, Position goalPos, Position keyPos, char[,] map)
        {
            Console.Clear();
            PrintMap(map);
            PrintGoal(goalPos);
            PrintKey(keyPos);
            PrintPlayer(playerPos);
        }

        static void PrintMap(char[,] map)
        {
            for (int y = 0; y < map.GetLength(0); y++)
            {
                for (int x = 0; x < map.GetLength(1); x++)
                {
                    Console.Write(map[y, x]);
                }
                Console.WriteLine();
            }
        }

        static void PrintPlayer(Position playerPos)
        {
            Console.SetCursorPosition(playerPos.x, playerPos.y);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write('P');
            Console.ResetColor();
        }

        static void PrintGoal(Position goalPos)
        {
            Console.SetCursorPosition(goalPos.x, goalPos.y);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write('G');
            Console.ResetColor();
        }

        static void PrintKey(Position keyPos)
        {
            if (keyGet == 0)
            {
                Console.SetCursorPosition(keyPos.x, keyPos.y);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write('K');
                Console.ResetColor();
            }
        }

        static void Update(ConsoleKey key, ref Position playerPos, ref Position goalPos, ref Position keyPos, ref char[,] map, ref bool gameOver)
        {
            Move(key, ref playerPos, map);

            bool isClear = CheckGameClear(playerPos, goalPos);
            if (playerPos.x == keyPos.x && playerPos.y == keyPos.y && count == 0)
            {
                keyGet++;
            }

            if (isClear)
            {
                gameOver = true;
            }

            if (keyGet > 0 && playerPos.x == goalPos.x && playerPos.y == goalPos.y)
            {
                Console.Clear();
                Console.SetCursorPosition(0, 0);
                Console.WriteLine("스테이지 클리어");
                Console.ReadKey();
                
            }
        }

        static bool CheckGameClear(Position playerPos, Position goalPos)
        {
            bool success = (playerPos.x == goalPos.x) && (playerPos.y == goalPos.y);
            return success;
        }

        static ConsoleKey Input()
        {
            return Console.ReadKey(true).Key;
        }

        static void Move(ConsoleKey key, ref Position playerPos, char[,] map)
        {
            switch (key)
            {
                case ConsoleKey.W:
                case ConsoleKey.UpArrow:
                    if (map[playerPos.y - 1, playerPos.x] == ' ')
                        playerPos.y--;
                    break;
                case ConsoleKey.A:
                case ConsoleKey.LeftArrow:
                    if (map[playerPos.y, playerPos.x - 1] == ' ')
                        playerPos.x--;
                    break;
                case ConsoleKey.S:
                case ConsoleKey.DownArrow:
                    if (map[playerPos.y + 1, playerPos.x] == ' ')
                        playerPos.y++;
                    break;
                case ConsoleKey.D:
                case ConsoleKey.RightArrow:
                    if (map[playerPos.y, playerPos.x + 1] == ' ')
                        playerPos.x++;
                    break;
                case ConsoleKey.Escape:
                    Console.Clear();
                    Console.WriteLine("------------------");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("게임을 종료했습니다.");
                    Console.ResetColor();
                    Console.WriteLine("------------------");
                    Environment.Exit(0);
                    break;
            }
        }

        static void Main(string[] args)
        {
            Position playerPos;
            Position goalPos;
            Position keyPos;
            char[,] map;
            bool gameOver;

            while (true) // 게임을 반복적으로 진행
            {
                gameOver = false; // 각 스테이지 시작 시 gameOver를 false로 초기화
                Start(stage, out playerPos, out goalPos, out keyPos, out map);

                while (!gameOver)
                {
                    Render(playerPos, goalPos, keyPos, map);

                    ConsoleKey key = Input();
                    Update(key, ref playerPos, ref goalPos, ref keyPos, ref map, ref gameOver);
                }

                // 스테이지 클리어 후
                stage++; // 다음 스테이지로 넘어가기
                if (stage > 2) // 3스테이지가 끝나면
                {
                    End(); // End 함수 호출
                    return;
                }
            }
        }

        static void End()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("축하합니다! 모든 스테이지를 클리어하셨습니다.");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("게임을 종료합니다.");
            Console.ResetColor();
            Console.ReadKey(); // 사용자가 키를 누를 때까지 대기
        }
    }
}
