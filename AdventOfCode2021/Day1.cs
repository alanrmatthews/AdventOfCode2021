using System;
namespace AdventOfCode2021
{
    public class Day1
    {
        private static List<String> lines = File.ReadLines("../../../../day1input.txt").ToList();
        private static List<Int32> depths = lines.Select(x => int.Parse(x)).ToList();

        public Day1()
        {
        }

        static public int Part1()
        {
            var numberOfIncresingDepths = 0;

            for (int x = 0; x < depths.Count - 1; x++)
            {
                if (depths[x] < depths[x + 1])
                    numberOfIncresingDepths++;
            }

            return numberOfIncresingDepths;
        }

        static public int Part2()
        {
            var numberOfIncresingWindows = 0;

            int x = 0;
            int y = 3;
            while (y < depths.Count)
            {
                if (depths[y] > depths[x])
                    numberOfIncresingWindows++;

                x++;
                y++;
            }

            return numberOfIncresingWindows;
        }
    }
}

