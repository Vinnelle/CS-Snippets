/*
The linear regression algorithm is used to find the linear relationship between a dependent variable and one or more independent variables. In this program, the dependent variable is y and the independent variable is x. The program first calculates the slope of the line using the formula:

Slope = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX)

Where n is the number of data points, sumXY is the sum of the products of the x-values and the y-values, sumX is the sum of the x-values, sumY is the sum of the y-values, and sumX2 is the sum of the squares of the x-values.

The program then calculates the y-intercept using the formula:

yIntercept = (sumY - slope * sumX) / n

Where sumY is the sum of the y-values, slope is the slope of the line, and sumX is the sum of the x-values.

Finally, the program uses the slope and y-intercept values to make predictions for new x-values.
*/

using System;

namespace LinearRegression
{
    class Program
    {
        static void Main(string[] args)
        {
            // inputs
            int[] x = { 1, 2, 3, 4, 5 };
            int[] y = { 2, 4, 6, 8, 10 };

            // calculate slope
            double slope = CalculateSlope(x, y);

            // calculate y-intercept
            double yIntercept = CalculateYIntercept(x, y, slope);

            // make predictions
            for (int i = 0; i < x.Length; i++)
            {
                double prediction = slope * x[i] + yIntercept;
                Console.WriteLine($"Prediction for x = {x[i]}: {prediction}");
            }
        }

        // Function to calculate slope
        private static double CalculateSlope(int[] x, int[] y)
        {
            if (x.Length != y.Length)
            {
                throw new ArgumentException("Input arrays must be the same length.");
            }

            int n = x.Length;

            double sumX = 0;
            double sumY = 0;
            double sumXY = 0;
            double sumX2 = 0;

            for (int i = 0; i < n; i++)
            {
                sumX += x[i];
                sumY += y[i];
                sumXY += x[i] * y[i];
                sumX2 += x[i] * x[i];
            }

            double slope = (n * sumXY - sumX * sumY) / (n * sumX2 - sumX * sumX);
            return slope;
        }

        // Function to calculate y-intercept
        private static double CalculateYIntercept(int[] x, int[] y, double slope)
        {
            if (x.Length != y.Length)
            {
                throw new ArgumentException("Input arrays must be the same length.");
            }

            int n = x.Length;

            double sumX = 0;
            double sumY = 0;

            for (int i = 0; i < n; i++)
            {
                sumX += x[i];
                sumY += y[i];
            }

            double yIntercept = (sumY - slope * sumX) / n;
            return yIntercept;
        }
    }
}
