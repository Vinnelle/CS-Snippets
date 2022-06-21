/*
The program I just made uses the bubble sort algorithm to sort an array of integers. It starts by creating an array of 256 random numbers. It then prints out the array, sorts it using bubble sort, and then prints out the sorted array.
create a basic C# program that takes 5 random numbers and attempts to predict the next number in the sequence.
*/

using System;

namespace Bubble
{
    class Sort
    {
        static void Main(string[] args)
        {
            int[] nums = new int[256];

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = new Random().Next(1, nums.Length + 1);
            }

            Console.WriteLine("Before: " + string.Join(", ", nums));

            nums = BubbleSort(nums);

            Console.WriteLine("After: " + string.Join(", ", nums));
        }

        // Bubble sort algorithm
        private static int[] BubbleSort(int[] nums)
        {
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = 0; j < nums.Length - 1 - i; j++)
                {
                    if (nums[j] > nums[j + 1])
                    {
                        int temp = nums[j + 1];
                        nums[j + 1] = nums[j];
                        nums[j] = temp;
                    }
                }
            }

            return nums;
        }
    }
}
