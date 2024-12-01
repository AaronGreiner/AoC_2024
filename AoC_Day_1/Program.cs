using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AoC_Day_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] input = File.ReadAllLines(@"../../../input.txt");

            int totalDistance = 0;
            int similarityScore = 0;

            List<int> leftList = new List<int>();
            List<int> rightList = new List<int>();

            foreach (string s in input)
            {
                string[] numbers = s.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                leftList.Add(int.Parse(numbers[0]));
                rightList.Add(int.Parse(numbers[1]));
            }

            leftList.Sort();
            rightList.Sort();

            for (int i = 0; i < leftList.Count; i++)
            {
                totalDistance += Math.Abs(leftList[i] - rightList[i]);
            }

            foreach (int num in leftList)
            {
                similarityScore += num * rightList.Count(x => x == num);
            }

            Console.WriteLine("Total distance between the lists: " + totalDistance);
            Console.WriteLine("Total similarity score: " + similarityScore);
        }
    }
}
