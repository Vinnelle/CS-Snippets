using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[10];

            for (int i = 0; i < 10; i++)
            {
                nums[i] = new Random().Next(1, 1000);
            }

            Console.WriteLine("Before: " + string.Join(", ", nums));

            nums = MergeSort(nums);

            Console.WriteLine("After: " + string.Join(", ", nums));
        }

        // Merge sort function
        private static int[] MergeSort(int[] nums)
        {
            if (nums.Length <= 1)
            {
                return nums;
            }

            int middle = nums.Length / 2;
            int[] left = new int[middle];
            int[] right = new int[nums.Length - middle];

            for (int i = 0; i < middle; i++)
            {
                left[i] = nums[i];
            }

            for (int i = middle; i < nums.Length; i++)
            {
                right[i - middle] = nums[i];
            }

            left = MergeSort(left);
            right = MergeSort(right);
            return Merge(left, right);
        }

        // Merge function
        private static int[] Merge(int[] left, int[] right)
        {
            int[] result = new int[left.Length + right.Length];

            int i = 0;
            int j = 0;
            int k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                {
                    result[k] = left[i];
                    i++;
                }
                else
                {
                    result[k] = right[j];
                    j++;
                }

                k++;
            }

            while (i < left.Length)
            {
                result[k] = left[i];
                i++;
                k++;
            }

            while (j < right.Length)
            {
                result[k] = right[j];
                j++;
                k++;
            }

            return result;
        }
    }
}
