public class Worker
{
    // 작업 완료를 알리는 이벤트 선언
    public event EventHandler<string> WorkCompleted;

    public void DoWork()
    {
        Console.WriteLine("DoWork : 작업 수행 중...");


        Thread.Sleep(1000); // 1초대기

        // 작업 완료 후 이벤트 발생
        OnWorkCompleted("작업이 완료되었습니다.");
    }

    // 이벤트 트리거 메서드
    protected virtual void OnWorkCompleted(string message)
    {
        WorkCompleted?.Invoke(this, message); // 이벤트를 발생시켜 구독된 핸들러를 호출
    }
}

public class Subscriber
{
    public void OnWorkCompletedHandler(object sender, string message)
    {
        Console.WriteLine("Subscriber : {0}", message);
    }
}

class Program
{
    static void Main()
    {
        Queue<int> queue = new Queue<int>(); //큐 생성

        queue.Enqueue(10);
        queue.Enqueue(20);
        queue.Enqueue(30);

        Console.WriteLine($"Count : {queue.Count}"); // 3개가 있어서 3

        Console.WriteLine($"Peek : {queue.Peek()}"); // 먼저 들어간 10을 출력 10

        Console.WriteLine($"Dequeue : {queue.Dequeue()}"); // 출력 후 제거, 10을 꺼낸다고

        Console.WriteLine($"Count after Dequeue: {queue.Count}"); // 출력: Count after Dequeue: 2

        Console.WriteLine($"Contains 20? {queue.Contains(20)}"); // 출력: Contains 20? True

        queue.Clear(); //큐 초기화
        Console.WriteLine($"Count after Clear: {queue.Count}"); // 출력: Count after Clear: 0
    }
}

