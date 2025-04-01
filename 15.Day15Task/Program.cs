namespace _15.Day15Task
{
    internal class Program
    {
        class Edge
        {
            public int Destination { get; set; } //목적지 노드
            public int Weight { get; set; } // 가중치
            public Edge(int destination, int weight)
            {
                Destination = destination;
                Weight = weight;
            }
        }
        class Node
        {
            public int NodeNum { get; set; } //노드 세팅
            public List<Edge> Edges { get; set; } = new List<Edge>(); //리스트로 정리 , 왜 리스트인가 - 동적 자료 구조로 노드의 추가를 편하게 하기 위해서.
            public Node(int nodeNum) // 새로운 리스트를 추가, 
            {
                NodeNum = nodeNum;
                Edges = new List<Edge>();
            }

            public void AddEdge(int destination, int weight)
            {
                Edges.Add(new Edge(destination, weight));
            }
        }
        class Graph
        {
            public Dictionary<int, Node> Nodes { get; private set; } = new Dictionary<int, Node>();
            public void AddNode(int nodeNum)
            {
                if (!Nodes.ContainsKey(nodeNum)) //중복확인
                {
                    Nodes[nodeNum] = new Node(nodeNum);
                }
            }
            public void AddEdge(int source, int destination, int weight)
            {
                if (weight < 0)
                {
                    throw new ArgumentException("가중치는 음수가 될 수 없습니다."); //예외 발생시 ()안의 콘솔을 출력해줌.
                }

                AddNode(source);
                AddNode(destination);

                Nodes[source].AddEdge(destination, weight);
            }
        }
        class GraphPrinter
        {
            public static void Print(Graph graph)
            {
                foreach (var node in graph.Nodes.Values)
                {
                    Console.Write($"노드 {node.NodeNum} :");
                    foreach (var edge in node.Edges)
                    {
                        Console.Write($" - 노드 {edge.Destination}, 가중치 {edge.Weight}");
                    }
                    Console.WriteLine();
                }
            }
        }
        static void Main(string[] args)
        {
            // 그래프 생성
            Graph graph = new Graph();

            // 간선 추가
            graph.AddEdge(0, 1, 5);
            graph.AddEdge(0, 2, 3);
            graph.AddEdge(0, 3, 2);
            graph.AddEdge(1, 0, 5);
            graph.AddEdge(1, 3, 1);
            graph.AddEdge(2, 1, 4);
            graph.AddEdge(3, 0, 2);
            graph.AddEdge(3, 2, 6);

            // 그래프 출력
            GraphPrinter.Print(graph);


        }
    }
}

