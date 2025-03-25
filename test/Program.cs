using System;
using System.Text.RegularExpressions;

public class Program
{
    public static void Main()
    {
        // 예제: 원래 문자열에 줄바꿈이 포함되어 있는 경우
        string original = "Line1\nLine2";
        Console.WriteLine("원본:");
        Console.WriteLine(original);

        // Regex.Escape 적용: 특수문자를 이스케이프 처리
        string escaped = Regex.Escape(original);
        Console.WriteLine("\n이스케이프 후:");
        Console.WriteLine(escaped);
        // 보통 이 경우, 출력 결과는 "Line1\nLine2"처럼 보일 수 있음.

        // Regex.Unescape 적용: 다시 원래 문자로 복원
        string unescaped = Regex.Unescape(escaped);
        Console.WriteLine("\nUnescape 후:");
        Console.WriteLine(unescaped);
        // 출력은 원본과 같이 줄바꿈을 적용한 형태가 됩니다.
    }
}
