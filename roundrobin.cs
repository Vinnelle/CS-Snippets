/*
The program I made demonstrates the round robin scheduling algorithm. This algorithm is used to schedule processes in a way that each process gets a turn to run for a certain amount of time, and then the next process in line gets a turn. In this program, each process gets a turn to run for one time unit.

The program starts by taking in an array of process times. It then creates an array to hold the waiting times for each process. It also creates an array to hold the order of the processes. The program then has a while loop that runs until all processes have been completed. Within the while loop, there is a check to see if the current process is finished. If it is, the program moves on to the next process. If it isn't, the program runs the process for one time unit and updates the waiting times for all processes. The program also updates the current time. Once all processes have been completed, the program calculates the average waiting time and prints it out.
*/

using System;

namespace RoundRobin
{
    class Program
    {
        static void Main(string[] args)
        {
            // input
            int[] processTimes = { 10, 5, 15, 7, 6 };

            // output
            Console.WriteLine("Processes: " + string.Join(", ", processTimes));
            Console.WriteLine("Average Wait Time: " + RoundRobin(processTimes));
        }

        // Round Robin scheduling algorithm
        private static double RoundRobin(int[] processTimes)
        {
            int n = processTimes.Length;

            // create an array to hold the waiting times
            int[] waitingTimes = new int[n];

            // create an array to hold the order of the processes
            int[] processOrder = new int[n];

            // variable to keep track of the current process
            int currentProcess = 0;

            // variable to keep track of the current time
            int currentTime = 0;

            // fill the processOrder array with the processes in order
            for (int i = 0; i < n; i++)
            {
                processOrder[i] = i;
            }

            // loop through the processes
            while (currentProcess < n)
            {
                // check if the process is finished
                if (processTimes[currentProcess] == 0)
                {
                    // move on to the next process
                    currentProcess++;
                }
                else
                {
                    // run the process for one time unit
                    processTimes[currentProcess]--;

                    // update the waiting times for all processes
                    for (int i = 0; i < n; i++)
                    {
                        if (i != currentProcess && processTimes[i] > 0)
                        {
                            waitingTimes[i]++;
                        }
                    }

                    // update the current time
                    currentTime++;
                }
            }

            // calculate the average waiting time
            double averageWaitTime = (double)Array.Sum(waitingTimes) / n;

            return averageWaitTime;
        }
    }
}
