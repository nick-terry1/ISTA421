using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/// <summary>
///  author: nick terry
///  date: may 15, 2018
///  This program takes a random integer list of size 10 - 1000 and calculates the mean, median, standard deviation
///  median absolute deviation, kurtosis, and skewness of it
/// </summary>

namespace ex13_Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            STARTAGAIN:
            // Zeroth step
            Console.WriteLine("Enter a number between 10 - 1000");
            int n = int.Parse(Console.ReadLine());
            List<int> Zeroth = RandomList(n);
            foreach (int num in Zeroth)
            {
                Console.Write($"{num},");
            }
            Console.WriteLine();

            // First step
            int avg = Mean(Zeroth);
            Console.WriteLine("The mean of the list is {0}", avg);

            // Second step
            double med = Median(Zeroth);
            Console.WriteLine("The median of the list is {0}", med);

            // Third step
            int sd = StandardDeviation(Zeroth);
            Console.WriteLine($"The standard deviation is {sd}");

            // Fourth step
            double mAD = MedianAD(Zeroth);
            Console.WriteLine($"The median absolute deviation is {mAD}");

            // Fifth step
            double skew = Skewness(Zeroth);
            Console.WriteLine($"The Skewness is {skew}");

            // Sixth step
            double kurt = Kurtosis(Zeroth);
            Console.WriteLine($"The Kurtosis is {kurt}");


            Console.WriteLine("Enter 1 to run this program again with another random list");
            string restart = Console.ReadLine();
            if (restart == "1")
                goto STARTAGAIN;
        }

        // method to generate a random list of n size
        public static List<int> RandomList(int n)
        {
            List<int> result = new List<int>();
            for (int i = 0; i < n; i++)
            {
                // i is the seed value for the random class each iteration
                result.Add(new Random(i).Next(1000));
            }
            return result;
        }

        // method to give the average of the integer list
        public static int Mean(List<int> intList)
        {
            return (int)intList.Average();
        }

        // method to give the median (halfway point) of a list of sorted integers
        public static double Median(List<int> intList)
        {
            intList.Sort();
            // integer division requires the addition of one to get the midpoint
            if (intList.Count % 2 != 0)
                return (intList[intList.Count / 2 + 1]);

            // if the size of the list is even it needs to be split in half which requires a double casting
            else
            {
                double half1 = intList[intList.Count / 2];
                double half2 = intList[intList.Count / 2 + 1];
                return (half1 + half2) / 2;
            }
        }
        // method to get the standard deviation of a list of integers
        public static int StandardDeviation(List<int> intList)
        {
            List<int> numerator = new List<int>();
            double median = Median(intList);
            double average = Mean(intList);

            // the formula is: square root of the sum of the integer value minus the mean squared 
            // for every value, over the number of integers in the list
            foreach (int num in intList)
            {
                int temp = (int)(Math.Pow(num - average, 2));
                numerator.Add(temp);
            }
            int total = numerator.Sum();
            return (int)Math.Sqrt(total / intList.Count);
        }
        // method get the median absolute deviation
        public static double MedianAD(List<int> intList)
        {
            intList.Sort();
            double median = Median(intList);
            List<int> absList = new List<int>();

            // formula is median(|num - median(intList)|)
            foreach (int num in intList)
            {
                absList.Add((int)Math.Abs(num - median));
            }
            return Median(absList);
        }
        // method calculates skewness of an integer list
        public static double Skewness(List<int> intList)
        {
            return (3 * (Mean(intList) - Median(intList)) / StandardDeviation(intList));
        }
        // method calculates the kurtosis of an integer list
        public static double Kurtosis(List<int> intList)
        {
            List<double> numerator = new List<double>();
            // formula for kurtosis was too big so I split it into numerator and denominator
            foreach (int num in intList)
            {
                numerator.Add(Math.Pow((num - Mean(intList)), 4));
            }
            // the numerator is the sum of every value in the list minus the 
            // mean to the fourth power all over the number of integers in the list
            double total = numerator.Sum();
            double lastNumerator = total / intList.Count;
            // the denominator is the standard deviation of the list to the fourth power
            double denominator = Math.Pow(StandardDeviation(intList), 4);
            return lastNumerator / denominator;
        }
    }
}
