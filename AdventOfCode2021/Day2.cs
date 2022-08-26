using System;
namespace AdventOfCode2021
{
    public class Day2
    {
        private static List<String> lines = File.ReadLines("../../../../day2input.txt").ToList();

        public Day2()
        {
        }

        static public int Part1()
        {
            int horizontal = 0;
            int depth = 0;

            foreach (var line in lines)
            {
                var sline = line.Split(' ');
                var command = sline[0];
                var units = int.Parse(sline[1]);

                switch (command)
                {
                    case "forward":
                        horizontal += units;
                        break;

                    case "up":
                        depth -= units;
                        break;

                    case "down":
                        depth += units;
                        break;
                }
            }

            return horizontal * depth;
        }

        static public int Part2()
        {
            int horizontal = 0;
            int depth = 0;
            int aim = 0;

            foreach (var line in lines)
            {
                var sline = line.Split(' ');
                var command = sline[0];
                var units = int.Parse(sline[1]);

                switch (command)
                {
                    case "forward":
                        horizontal += units;
                        depth += aim * units;
                        break;

                    case "up":
                        aim -= units;
                        break;

                    case "down":
                        aim += units;
                        break;
                }
            }

            return horizontal * depth;
        }
    }
}

