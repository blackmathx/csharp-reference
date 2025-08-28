using CSharp_Reference.ConsoleGames;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Reference;
internal class _Z_LeetCodeStarter
{
    public static void runner()
    {
        Console.WriteLine("LeetCode Starter For C#");

        // 1 Two Sum
        int[] res = TwoSum(new int[] {1, 2, 3, 4, 5}, 9);

        // 9
        bool isPalindrome = IsPalindrome(12321);



    }

    // #1 Two Sum
    // Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    // You may assume that each input would have exactly one solution, and you may not use the same element twice.
    public static int[] TwoSum(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j)  continue;

                if (nums[i] + nums[j] == target)
                    return [i, j];
            }
        }

        return [0, 0];
    }


    // #9 Palindrome Number
    // Given an integer x, return true if x is a , and false otherwise.
    public static bool IsPalindrome(int x)
    {
        if (x < 0) return false;

        string str = x.ToString();
        char[] arr = str.ToCharArray();
        Array.Reverse(arr);
        string rev = new string(arr);

        return str == rev;
    }
}

