using System.Runtime.InteropServices;

namespace _16.Day16_ConsoleGame.Scenes
{
    public static class Game
    {
        // 게임에 필요한 정보들
        private static bool gameOver;

        private static Dictionary<string, Scene> sceneDic;
        private static Scene _cutScene;

        public static Scene GetScene (string sceneName)
        {
            if (sceneDic.ContainsKey(sceneName))
            {
                return sceneDic[sceneName];
            }
            else
            {
                throw new KeyNotFoundException($"씬 {sceneName}을 찾을 수 없습니다.");
            }
        }
        public static Scene cutScene
        {
            get { return _cutScene; }
            set { _cutScene = value; }
        }


        // 게임에 필요한 기능들
        public static void Start()
        {
            // 게임에 있는 모든 씬들을 보관하고 빠르게 찾아줄 용도로 쓸 자료구조
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());
            sceneDic.Add("Shop", new Shop());
            sceneDic.Add("Square", new Square());

            // 처음시작할 씬을 선정
            cutScene = sceneDic["Title"];
        }

        public static void End()
        {
            gameOver = true;        
        }

        public static void Run()
        {
            while (gameOver == false)
            {
                cutScene.Render();
                cutScene.Choice();
                cutScene.Input();
                cutScene.Result();
                cutScene.Wait();
                cutScene.Next();
            }
        }
    }
}