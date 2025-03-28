namespace _14.Day14_JosephusProblem
{
    internal class Program
    {

        //요세푸스 문제
        //int n = 사람수 , int k = 제시된 숫자                        /*
        //int k 번째에 있는 사람부터 제거                              
        //제거가 되었을때 배열을 / 재정렬 정렬할 필요가 있나?            반복문
        //재정렬된 배열에서 다시 k번째 사람 제거                        */
        //최종적으로 남는 사람이 이기는 게임이니 return int winner; 
        //
        public static int JosephusProblem(int n, int k)
        { 
            List<int> people = new List<int>(); //list 생성
            for (int i = 1; i <= n; i++) // n이랑 i가 같아질때까지 리스트에 사람(객체) 추가.
            {
                people.Add(i); 
            }
            people.Sort(); //사람 정렬 / 정렬할 필요가 진짜 있나?

            //제거하는 코드 이것도 반복문, 끝날때까지 무한 반복 해야한다.

            int index = 0; //제거할 사람 

            while (people.Count > 1)
            {
                index = (index + k) % people.Count;
                Console.WriteLine($"제거된 사람은 : {people[index]}"); //제거된 사람 보여줌
                people.RemoveAt(index); // 리스트에서 제거
            }
            return people[0];

        }

        public static void Main(string[] args)
        {
            int n = 15;
            int k = 4;
            int survivor = JosephusProblem(n, k);

            Console.WriteLine("살아남은 사람은 {0}입니다", survivor);

        }
    }
}
