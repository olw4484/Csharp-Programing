using System;

public class Solution
{
    public int[] solution(int[] num_list)
    {
        int[] answer = new int[] { };
        int evenCount = 0;
        int oddCount = 0;

        for (int i = 0; i < num_list.Length; i++) // i 변수의 타입 지정 및 초기화, 범위를 지정.
        {
            if (i % 2 == 0)
            {
                evenCount++;
            }
            else
            {
                oddCount++;
            }
        }
        return answer;
    }
    public static void Main(string[] args)
    {
        Solution sol = new Solution();
        int[] num_list = new int[] { 1, 2, 3, 4, 5, 6 };
        int[] ret = sol.solution(num_list);
        Console.WriteLine("solution 함수의 반환 값은 " + ret + " 입니다.");
    }
}