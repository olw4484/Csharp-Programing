class Program
{
    static int SumOdd(int start, int end)
    {
        if (start > end) return 0;  // 범위 초과 시 종료
        if (start % 2 == 0) return SumOdd(start + 1, end);  // 짝수일 경우 한 칸 이동

        if (start == end) return start; // 기본 경우
        int mid = (start + end) / 2;
        return SumOdd(start, mid) + SumOdd(mid + 1, end);
    }

    static int SumEven(int start, int end)
    {
        if (start > end) return 0;  // 범위 초과 시 종료
        if (start % 2 != 0) return SumEven(start + 1, end);  // 홀수일 경우 한 칸 이동

        if (start == end) return start; // 기본 경우
        int mid = (start + end) / 2;
        return SumEven(start, mid) + SumEven(mid + 1, end);
    }

    static void Main()
    {
        int oddSum = SumOdd(1, 99);   // 홀수 합
        int evenSum = SumEven(2, 100); // 짝수 합

        Console.WriteLine($"홀수 합: {oddSum}");
        Console.WriteLine($"짝수 합: {evenSum}");
        Console.WriteLine($"전체 합: {oddSum + evenSum}");
    }
}
