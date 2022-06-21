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
            int[] nums;
            try
            {
                nums = new int[2146435072]; //outofmemoryexception
                if (nums.Length > 50000) //if num is like 2146435071 and doesnt throw outofmem, lets just set it to 256
                    nums = new int[256];
            }
            catch (OutOfMemoryException)
            {
                nums = new int[256]; //default to 256
                Console.WriteLine("OutOfMemoryException");
            }

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
