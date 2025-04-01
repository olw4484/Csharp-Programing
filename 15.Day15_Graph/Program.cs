namespace _15.Day15_Graph
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //노드 8개 0~7
            //1 번 그래프
            var grahp1 = new Dictionary<int, List<int>>(); 
            grahp1[0] = new List<int>() { 1, 3, 4 };   //0번노드
            grahp1[1] = new List<int>() { 3, 5 };      //1번노드
            grahp1[2] = new List<int>() { 1, 5, 6 };   //2번노드
            grahp1[3] = new List<int>() { 1, 7 };      //3번노드
            grahp1[4] = new List<int>() { 6, 7 };      //4번노드
            grahp1[5] = new List<int>() { 1, 3, 7 };   //5번노드
            grahp1[6] = new List<int>() { 4 };         //6번노드
            grahp1[7] = new List<int>() { 5 };         //7번노드

            foreach (var item in grahp1)
            {
                Console.WriteLine($"노드 : {item.Key}");
                foreach (var neighbor in item.Value)
                {
                    Console.Write($"{neighbor}");
                }
                Console.WriteLine();
            } // 딕셔너리 리스트에 딕셔너리를 값을 받는다.
            // 딕셔너리(딕셔너리) = 시작노드(연결노드:가중치)

            //2 번 그래프 , //int와 Dictionary<int>는 다른것
            Dictionary<int, List<int>> grahp2 = new Dictionary<int, List<int>>(); 
            grahp2[0] = new List<int>() { 1, 3 };       //0번노드
            grahp2[1] = new List<int>() { 0, 3, 5, 6};  //1번노드
            grahp2[2] = new List<int>() { 0, 1, 4, 5 }; //2번노드
            grahp2[3] = new List<int>() { 1 };          //3번노드
            grahp2[4] = new List<int>() { 2, 6 };       //4번노드
            grahp2[5] = new List<int>() { 1, 3 };       //5번노드
            grahp2[6] = new List<int>() { 2, 4 };       //6번노드
            grahp2[7] = new List<int>() { };            //7번노드

            foreach (var item in grahp2)
            {
                Console.WriteLine($"노드 : {item.Key}");
                foreach (var neighbor in item.Value)
                {
                    Console.Write($"{neighbor}");
                }
                Console.WriteLine();
            }

        }
    }
}
