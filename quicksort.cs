/*
The program I made uses the quick sort algorithm to sort an array of integers. It starts by creating an array of 256 random numbers. It then prints out the array, sorts it using quick sort, and then prints out the sorted array.
*/

using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums;
            try
            {
            	nums = new int [2146435072]; //outofmemoryexception
            	if (nums.Length > 50000) //if num is like 2146435071 and doesnt throw outofmem, lets just set it to 256
            }
            catch (OutOfMemoryException)
            {
            	nums = new int[256]; //default to 256
            	Console.WriteLine("OutOfMemoryException");
            }

            for (int i = 0; i < 256; i++)
            {
                nums[i] = new Random().Next(1, nums.Length + 1);
            }

            Console.WriteLine("Before: " + string.Join(", ", nums));

            nums = QuickSort(nums, 0, nums.Length - 1);

            Console.WriteLine("After: " + string.Join(", ", nums));
        }

        // Quick sort function
        public static int[] QuickSort(int[] nums, int left, int right)
        {
            if (left < right)
            {
                int pivot = Partition(nums, left, right);

                QuickSort(nums, left, pivot - 1);
                QuickSort(nums, pivot + 1, right);
            }

            return nums;
        }

        // Partition function
        private static int Partition(int[] nums, int left, int right)
        {
            int pivot = nums[right];

            int i = left - 1;

            for (int j = left; j < right; j++)
            {
                if (nums[j] <= pivot)
                {
                    i++;

                    int temp = nums[i];
                    nums[i] = nums[j];
                    nums[j] = temp;
                }
            }

            int temp1 = nums[i + 1];
            nums[i + 1] = nums[right];
            nums[right] = temp1;

            return i + 1;
        }
    }
}
