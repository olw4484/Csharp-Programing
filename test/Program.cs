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
    static void Main(string[] args)
    {
        Worker worker = new Worker(); // 작업자 생성
        Subscriber subscriber = new Subscriber(); // 구독자 생성

        // 작업 완료 이벤트를 구독 (핸들러 등록)
        worker.WorkCompleted += subscriber.OnWorkCompletedHandler;

        Console.WriteLine("메인 : 작업 시작 전");
        worker.DoWork(); // 작업 수행
        Console.WriteLine("메인 : 작업 완료");
    }
}