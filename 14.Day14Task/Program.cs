namespace _14.Day14Task
{
    internal class Program
    {
        public class MyStack<T>
        {
            private T?[] _array; // 배열 T = 제네릭
            private int _size; // 스택의 요소 개수
            private const int DefaultCapacity = 10; // 고정된 초기 배열 크기
            private int top;

            public bool IsEmpty()
            {
                return top == -1; // 스택이 비어 있는지 확인
            }

            public MyStack()
            {
                _array = new T[DefaultCapacity]; // 배열 생성
                _size = 0;
                top = -1; // top을 초기화
            }

            public int Count
            {
                get { return _size; }
            }

            public void Push(T item)
            {
                if (_size == _array.Length)
                {
                    Resize(); // 배열 크기가 가득 차면 크기를 늘림
                }
                _array[_size++] = item; // 요소를 추가하고 크기를 증가
                top = _size - 1; // top 갱신
            }

            private void Resize() // 크기를 2배로 늘리는 함수
            {
                int newCapacity = _array.Length * 2;
                T?[] newArray = new T[newCapacity];
                for (int i = 0; i < _array.Length; i++) // 기존 데이터를 복사
                {
                    newArray[i] = _array[i];
                }
                _array = newArray; // 새 배열로 교체
            }

            public T? Pop()
            {
                if (IsEmpty())
                {
                    return default(T); // 기본값 반환
                }

                T? item = _array[--_size]; // _size 감소 후 요소 가져오기
                _array[_size] = default(T); // 메모리 참조 해제를 위해 초기화
                top = _size - 1; // top 갱신
                return item;
            }
        }

        static void Main(string[] args)
        {
            var stack = new MyStack<int>();
            stack.Push(10);
            stack.Push(20);
            stack.Push(30);

            Console.WriteLine(stack.Pop()); 
            Console.WriteLine(stack.Pop()); 
            Console.WriteLine(stack.Pop()); 
        }
    }
}
