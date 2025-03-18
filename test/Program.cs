using System;
using static System.Net.Mime.MediaTypeNames;

public class Solution
{
    enum Month
    {
        Jan,  //0
        Feb,  //1
        Mar,  //2
        Apr,  //3
        May,  //4
        Jun,  //5
        Jul,  //6
        Aug,  //7
        Sep,  //8
        Oct,  //9
        Nov,  //10
        Dec  //11
    }
    public static void Main(string[] agrs)
    {
        Month currentMonth = Month.Jan;
        Console.WriteLine($"지금은 :{currentMonth}, {(int)currentMonth + 1}월입니다.");
        Console.WriteLine($"문자 {currentMonth}의 할당 숫자값은 {(int)currentMonth}입니다.");

    }
}