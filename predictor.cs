/*
The program I made uses a simple prediction function to attempt to predict the next number in a sequence of 5 numbers. It does this by taking the difference between each consecutive number in the array, and then adding up those differences. The predicted next number is simply the sum of those differences.
*/

using System;

namespace Predictor
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[5];

            for (int i = 0; i < 5; i++)
            {
                nums[i] = new Random().Next(1, 10);
            }

            Console.WriteLine("Numbers: " + string.Join(", ", nums));

            int nextNum = Predictor(nums);

            Console.WriteLine("Predicted Next Number: " + nextNum);
        }

        // Prediction function
        private static int Predictor(int[] nums)
        {
            int nextNum = 0;

            for (int i = 0; i < 4; i++)
            {
                nextNum += nums[i + 1] - nums[i];
            }

            return nextNum;
        }
    }
}
