using System;

public class RemoveElementSolution
{
    public int RemoveElement(int[] nums, int val)
    {
        int k = 0; 

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val)
            {
                
                nums[k] = nums[i];
                k++;
            }
        }

        return k;
    }
}

class Program
{
    static void Main()
    {
        int[] nums = { 3, 2, 2, 3 };
        int val = 3;
        RemoveElementSolution solution = new RemoveElementSolution();
        int k = solution.RemoveElement(nums, val);

        Console.WriteLine($"Number of elements not equal to {val}: {k}");
        Console.Write("Array after removing occurrences of val: ");
        for (int i = 0; i < k; i++)
        {
            Console.Write(nums[i] + " ");
        }
    }
}
