using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _16.Day16_ConsoleGame.Scenes;
using static System.Formats.Asn1.AsnWriter;

namespace TextRPG
{
    public static class Game
    {
        // 게임에 필요한 정보들
        private static bool gameOver;

        private static Dictionary<string, Scene> sceneDic;
        private static Scene curScene;


        // 게임에 필요한 기능들
        public static void Start()
        {
            // 게임에 있는 모든 씬들을 보관하고 빠르게 찾아줄 용도로 쓸 자료구조
            sceneDic = new Dictionary<string, Scene>();
            sceneDic.Add("Title", new TitleScene());

            // 처음시작할 씬을 선정
            curScene = sceneDic["Title"];
        }

        public static void End()
        {

        }

        public static void Run()
        {
            while (gameOver == false)
            {
                curScene.Render();
                curScene.Choice();
                curScene.Input();
                curScene.Result();
                curScene.Wait();
                curScene.Next();
            }
        }
    }
}