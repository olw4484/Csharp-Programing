namespace _17.Day17_Algorithm
{
    internal class Program
    {
        //배열을 생성함.
        //무작위 숫자 중 가장 큰 값을 뒤로 보내야함. 
        //가장 큰 값을 제외하고 작은 숫자들을 앞으로 순차 정렬해야함.
        //순차정렬 방법은? for문을 사용함.


        //버블 - 인접한 것들을 비교해서 순차정렬함
        static void BubbleSort(int[] arr) //배열이나 리스트 생성.
        {

            int n = arr.Length; //배열이나 리스트의 길이 정의.

            for (int i = 0; i < n - 1; i++) // 몇번 반복하는가? 리스트의 길이만큼.
            {
                for (int j = 0; j < n - 1 - i; j++) // 배열의 인덱스의 위치가 정해지면 반복 횟수가 줄어야함. * 검토한걸 또 검토할 필욘 없으니까.
                {
                    //그럼 내부의 인덱스를 비교하는 코드를 작성하면 됨.
                    if (arr[j] > arr[j + 1]) //현재의 인덱스가 다음 인덱스보다 크면
                    {
                        //위치를 바꿔준다. 스왑문자 (A,B) = (B,A)
                        (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    }
                }
            }
        }

        //선택 - 가장 작은 값을 찾아 앞으로 이동시킴
        static void SelectionSort(int[] arr)
        {
            int n = arr.Length; //배열 길이 정의

            for (int i = 0; i < n - 1; i++)
            {
                int selectionNum = i; //선택한다. 반복할 배열의 숫자를
                //선택했으니 반복한다, 큰것을 옮긴다. 몇번?
                for (int j = i + 1; j < n; j++) // i + 1번. 선택한 것을 옮겨야하고 마지막으로 남는 숫자까지도 옮겨서 확인해야함.
                {
                    if (arr[j] < arr[selectionNum])//조건이 맞으면
                        selectionNum = j; // j를 selectionNum에 저장한다.
                }
                (arr[i], arr[selectionNum]) = (arr[selectionNum], arr[i]); //저장되었으면 바꿔준다.
            }
        }

        //삽입 - 데이터를 하나씩 정렬된 부분에 삽입. - 큰수부터 한다고함.

        static void InsertionSort(int[] arr)
        {
            //일단 배열.
            int n = arr.Length;
            for (int i = 1; i < n - 1; i++) // 반복 횟수 //i = 1로 바꿈.
            {
                int key = arr[i]; //인덱스 번호를 저장
                int j = i - 1; //큰 수부터 정렬하는거라 작은 수를 앞에 넣어야함. i가 1부터 시작이니 i - 1 = 0 = j; 이런식이면 j = 0번쨰가 되버림.
                //i가 커지면 음수값이나옴.

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j]; 
                    j--;
                }
                arr[j + 1] = key;
            }
        }
        static void Main(string[] args)
        {
            //알고리즘 구성 방식에대한 고민.
            //순서 흐름도 파악 및 구성.
            //요점은 작은 숫자부터 큰 숫자를 순차정렬하는 것이 목적이다.
            //방식은 힙을 제외한 5종류를 사용
            //버블, 선택, 삽입, 퀵, 병합


            
            //퀵   - 비펏을 기준으로 데이터를 나누고 정렬.
            //병합 - 배열을 반으로 나누고 각각 정렬후 병합함. - 트리방식 그래프 생각나네

            //테스트

            int[] arr = new int[] { 13 , 1 , 78 , 88 , 35 , 102 , 103, 203};

            BubbleSort(arr);
            Console.WriteLine(string.Join(",",arr)); 
            SelectionSort(arr);
            Console.WriteLine(string.Join(",", arr));
            InsertionSort(arr);
            Console.WriteLine(string.Join(",", arr)); 




        }
    }
}
