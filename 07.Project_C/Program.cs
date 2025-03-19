namespace _07.Project_C
{
    internal class Program
    {
        #region Start
        static int count = 0; //static 전역에 영향을 끼칠 수 있는 변수.
        static void Start(int stage, out Position playerPos, out Position goalPos, out Position keyPos, out char[,] map)
        {
            Console.CursorVisible = false;
            playerPos.x = 0;
            playerPos.y = 0;
            goalPos.x = 0;
            goalPos.y = 0;
            keyPos.x = 0;
            keyPos.y = 0;
            map = new char[0, 0];

            switch (count)
            {
                case 0:
                    {
                        playerPos.x = 1; //플레이어 위치를 1,1로 시작
                        playerPos.y = 1;

                        goalPos.x = 8; //골의 위치를 8,8로 설정.
                        goalPos.y = 8;

                        keyPos.x = 7; //열쇠의 위치를 4,7로 설정.
                        keyPos.y = 4;
                        map = new char[10, 10]  //{' ','#'}
                        {
                    {'#','#','#','#','#','#','#','#','#','#'}, //0
                    {'#',' ','#',' ',' ',' ',' ',' ',' ','#'}, //1
                    {'#',' ',' ',' ','#',' ','#','#',' ','#'}, //2
                    {'#',' ','#',' ','#',' ','#','#',' ','#'}, //3
                    {'#',' ','#',' ','#',' ','#',' ',' ','#'}, //4
                    {'#',' ','#',' ','#',' ','#','#','#','#'}, //5
                    {'#',' ','#',' ','#',' ',' ',' ','#','#'}, //6
                    {'#',' ','#',' ','#','#','#','#','#','#'}, //7
                    {'#',' ','#',' ',' ',' ',' ',' ',' ','#'}, //8
                    {'#','#','#','#','#','#','#','#','#','#'} //9
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

                        map = new char[15, 15] // 함수
                        {
                    {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
                    {'#',' ',' ',' ',' ','#',' ',' ',' ','#',' ',' ',' ',' ','#'},
                    {'#','#','#','#',' ','#',' ','#',' ','#',' ','#','#',' ','#'},
                    {'#',' ',' ','#',' ','#',' ','#',' ','#',' ',' ','#',' ','#'},
                    {'#',' ','#','#',' ','#',' ','#',' ','#','#',' ','#',' ','#'},
                    {'#',' ','#',' ',' ','#',' ','#','#','#','#','#','#',' ','#'},
                    {'#',' ','#',' ','#','#',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                    {'#',' ','#',' ','#','#','#','#','#','#','#','#','#',' ','#'},
                    {'#',' ','#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                    {'#',' ','#',' ','#','#','#','#','#','#','#','#','#',' ','#'},
                    {'#',' ','#',' ','#',' ',' ',' ',' ',' ',' ',' ',' ',' ','#'},
                    {'#',' ','#',' ','#',' ','#','#','#','#','#','#','#',' ','#'},
                    {'#',' ','#',' ','#',' ','#',' ',' ',' ',' ',' ','#',' ','#'},
                    {'#',' ',' ',' ',' ',' ','#','#',' ','#','#',' ',' ',' ','#'},
                    {'#','#','#','#','#','#','#','#','#','#','#','#','#','#','#'},
                        };
                    }
                    break;
                case 2:
                    {
                        playerPos.x = 13;
                        playerPos.y = 1;

                        goalPos.x = 2;
                        goalPos.y = 3;

                        keyPos.x = 3;
                        keyPos.y = 1;

                        map = new char[15, 15] // 함수
                        {
                { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
                { '#', ' ', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', '#', '#', ' ', '#', ' ', '#', ' ', '#', ' ', '#', '#', '#', '#' },
                { '#', ' ', '#', '#', ' ', '#', ' ', '#', ' ', '#', ' ', ' ', '#', '#', '#' },
                { '#', ' ', '#', '#', ' ', '#', ' ', '#', ' ', '#', '#', ' ', '#', ' ', '#' },
                { '#', ' ', '#', ' ', ' ', '#', ' ', '#', ' ', '#', '#', '#', '#', ' ', '#' },
                { '#', ' ', '#', ' ', '#', '#', '#', '#', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', '#', ' ', '#', '#', '#', '#', '#', '#', '#', '#', '#', ' ', '#' },
                { '#', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', '#', ' ', '#', '#', '#', '#', '#', '#', '#', '#', '#', ' ', '#' },
                { '#', ' ', '#', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#' },
                { '#', ' ', '#', ' ', '#', ' ', '#', '#', '#', '#', '#', '#', '#', ' ', '#' },
                { '#', ' ', '#', ' ', '#', ' ', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#' },
                { '#', ' ', ' ', ' ', ' ', ' ', ' ', '#', ' ', '#', '#', ' ', ' ', ' ', '#' },
                { '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#', '#' },
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
        }
        struct Position
        {
            public int x;
            public int y;
        }

        static void ShowTitle() //타이틀
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
        #endregion
        #region Render
        static void Render(Position playerPos, Position goalPos, Position keyPos, char[,] map)
        {
            Console.Clear();
            //Console.SetCursorPosition(0, 0);
            PrintMap(map); //map은 배경과 같은 것이므로 가장 위에 둬서 먼저 그려지게 만들어야함.
            PrintGoal(goalPos);
            PrintKey(keyPos);
            PrintPlayer(playerPos); //playerPos를 가장 밑에 둬서 P가 가장 위에 그려지게 만듬.
        }
        static void PrintMap(char[,] map)
        {
            for (int y = 0; y < map.GetLength(0); y++) // y축만큼 반복 할때 
            {
                for (int x = 0; x < map.GetLength(1); x++) // x축만큼 반복
                {
                    Console.Write(map[y, x]); // map이란 변수의 y,x값을 출력
                }
                Console.WriteLine(); //줄바꿈
            }
        }
        static void PrintPlayer(Position playerPos)
        {
            Console.SetCursorPosition(playerPos.x, playerPos.y);
            Console.ForegroundColor = ConsoleColor.Blue; //플레이어를 파란색으로 설정함.
            Console.Write('P'); //Player의 P.
            Console.ResetColor(); //컬러 리셋

        }
        static void PrintGoal(Position goalPos)
        {
            Console.SetCursorPosition(goalPos.x, goalPos.y);
            Console.ForegroundColor = ConsoleColor.Yellow; //골의 위치는 노란색으로 설정함.
            Console.Write('G'); //Goal의 G.
            Console.ResetColor(); //컬러 리셋
        }
        static void PrintKey(Position keyPos)
        {
            Console.SetCursorPosition(keyPos.x, keyPos.y);
            Console.ForegroundColor = ConsoleColor.Green; //열쇠는 초록으로 설정함.
            Console.Write('K'); //Key의 K.
            Console.ResetColor(); //컬러 리셋
        }
        #endregion
        #region Update

        static ConsoleKey Input()
        {
            return Console.ReadKey(true).Key; //키 입력을 받아줌.
        }//입력받은 키를 저장.
        static void Update(ConsoleKey key, ref Position playerPos, ref Position goalPos, ref Position keyPos, ref char[,] map, ref bool nextStage, ref int stage)
        {
            Move(key, ref playerPos, map);

            bool goalCheck = GoalCheck(playerPos, goalPos);
            {
                if (goalCheck)
                {
                    count++;
                    nextStage = IsClear(playerPos, goalPos, keyPos);
                    if (nextStage)
                    {
                        stage++;
                        nextStage = false;
                        Start(stage, out playerPos, out goalPos, out keyPos, out map);
                    }
                }
            }

            static bool GoalCheck(Position playerPos, Position goalPos) //플레이어 위치와 골의 위치가 같으면 true값 리턴.
            {
                return (playerPos.x == goalPos.x) && (playerPos.y == goalPos.y);
            }
            static void Move(ConsoleKey key, ref Position playerPos, char[,] map) //키 입력이 들어오면 맞는걸 찾아서 실행해줌.
            {
                switch (key) //삼거리 해결됨. Main에서 Render와 Update의 순서를 바꿈.
                {
                    case ConsoleKey.W:
                    case ConsoleKey.UpArrow:
                        if (map[playerPos.y - 1, playerPos.x] == ' ') //y - 1이 공백이면 위로 간다.
                            playerPos.y--;
                        break;
                    case ConsoleKey.A:
                    case ConsoleKey.LeftArrow:
                        if (map[playerPos.y, playerPos.x - 1] == ' ')//x - 1이 공백이면 왼쪽으로 간다.
                            playerPos.x--;
                        break;
                    case ConsoleKey.S:
                    case ConsoleKey.DownArrow:
                        if (map[playerPos.y + 1, playerPos.x] == ' ')//y + 1이 공백이면 아래로 간다.
                            playerPos.y++;
                        break;
                    case ConsoleKey.D:
                    case ConsoleKey.RightArrow:
                        if (map[playerPos.y, playerPos.x + 1] == ' ')//x + 1이 공백이면 오른쪽으로 간다.
                            playerPos.x++;
                        break;
                }
            }
        }
        static bool IsClear(Position playerPos, Position goalPos, Position keyPos)
        {
            return count == 3 && (playerPos.x == goalPos.x) && (playerPos.y == goalPos.y);
        }
        #endregion
        #region End
        static void End()
        {
            Console.Clear();
            Console.WriteLine("-----------------------");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("게임을 클리어했습니다.");
            Console.ResetColor();
            Console.WriteLine("-----------------------");
        }

        #endregion
        static void Main(string[] args)
        {

            bool gameOver = false; //gameOver가 true가 아닐시 !gameOver는 쓸수 없나
            bool exit = false; //exit가 true가 아닐시
            bool nextStage = false; //nextStage가 true가 아닐시
            Position playerPos; //player의 위치 정보가 있을 경우
            Position goalPos; //goal의 위치 정보가 있을 경우
            Position keyPos; //key의 위치정보가 있을 경우
            char[,] map; //map의 정보가 있을 경우.
            int stage = 0;

            Start(stage, out playerPos, out goalPos, out keyPos, out map); //Start함수를 1회 실행해줌.

            while (!gameOver && !exit && !nextStage)
            {
                ConsoleKey key = Input();
                if (key == ConsoleKey.Escape) //ESC를 누르면 게임 종료.
                {
                    Console.Clear();
                    Console.WriteLine("게임을 종료하였습니다.");
                    exit = true;
                    Environment.Exit(0); //CMD종료 명령어. 솔직히 궁금해서 구글링함.
                }
                else
                {
                    Update(key, ref playerPos, ref goalPos, ref keyPos, ref map, ref nextStage, ref stage); //Update와 Render의 순서에 따라 문제발생할 가능성이 있음. 문법적 오류는 아닌 논리순서적 오류인듯.
                    Render(playerPos, goalPos, keyPos, map);
                }
                if (gameOver)
                {
                    stage++; // 다음 스테이지로
                    if (stage > 2) // 마지막 스테이지까지 클리어
                    {
                        gameOver = false;
                        Console.Clear();
                        Console.WriteLine("모든 스테이지를 클리어했습니다!");
                        break;
                    }
                    Start(stage, out playerPos, out goalPos, out keyPos, out map);
                }

            }
            End();
        }
    }
}



