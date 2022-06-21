/*
The program I made demonstrates round robin scheduling. It starts by creating a list of processes, each with a name and a burst time. It then sets the time quantum (the amount of time each process is allowed to run for) to 3. Finally, it runs the Round Robin scheduling algorithm, which calculates the arrival time, burst time, turnaround time, and waiting time for each process. The results are then printed to the console.
*/

using System;
using System.Collections.Generic;

namespace RoundRobin
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a list of all the processes
            List<Process> processes = new List<Process>() {
                new Process("A", 5),
                new Process("B", 8),
                new Process("C", 12),
                new Process("D", 9),
                new Process("E", 2),
                new Process("F", 4)
            };

            // Set the time quantum
            int timeQuantum = 3;

            // Run the scheduling algorithm
            RoundRobin(processes, timeQuantum);

            // Print the results
            Console.WriteLine("Process\tArrival Time\tBurst Time\tTurnaround Time\tWaiting Time");
            foreach (Process p in processes)
            {
                Console.WriteLine(p.ToString());
            }
        }

        // Round Robin scheduling algorithm
        private static void RoundRobin(List<Process> processes, int timeQuantum)
        {
            int currentTime = 0;

            foreach (Process p in processes)
            {
                p.arrivalTime = currentTime;
                currentTime += timeQuantum;
                p.burstTime = currentTime - p.arrivalTime;
            }

            // Calculate turnaround time and waiting time for each process
            foreach (Process p in processes)
            {
                p.turnaroundTime = p.burstTime + p.arrivalTime;
                p.waitingTime = p.turnaroundTime - p.burstTime;
            }
        }
    }

    // Class to represent a process
    class Process
    {
        public string name;
        public int arrivalTime;
        public int burstTime;
        public int turnaroundTime;
        public int waitingTime;

        public Process(string name, int burstTime)
        {
            this.name = name;
            this.burstTime = burstTime;
        }

        public override string ToString()
        {
            return string.Format("{0}\t\t{1}\t\t{2}\t\t{3}\t\t\t{4}",
                name, arrivalTime, burstTime, turnaroundTime, waitingTime);
        }
    }
}
