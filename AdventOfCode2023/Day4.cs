using System.Diagnostics.Metrics;

namespace AdventOfCode2023
{
    public class Day4 : DayChallenge
    {
        private string[] pairs;

        public Day4()
        {
            pairs = File.ReadAllText("./Inputs/InputDay4.txt").Split("\r\n");
        }

        public override void RunPart1()
        {
            int counter = 0;
            foreach (string pair in pairs)
            {
                string[] splitPair = pair.Split(",");
                int[] pair1Int = splitPair[0].Split("-").Select(x => Convert.ToInt32(x)).ToArray();
                int[] pair2Int = splitPair[1].Split("-").Select(x => Convert.ToInt32(x)).ToArray();

                if ((pair1Int[0] <= pair2Int[0] && pair1Int[1] >= pair2Int[1]) || (pair1Int[0] >= pair2Int[0] && pair1Int[1] <= pair2Int[1]))
                {
                    counter++;
                }
            }
            Console.WriteLine($"Day 4 (Part 1): {counter}");
        }

        public override void RunPart2()
        {
            int counter = 0;
            foreach (string pair in pairs)
            {
                string[] splitPair = pair.Split(",");
                var pair1Int = splitPair[0].Split("-").Select(x => Convert.ToInt32(x));
                var pair2Int = splitPair[1].Split("-").Select(x => Convert.ToInt32(x));
                var pair1Range = Enumerable.Range(pair1Int.ElementAt(0), (pair1Int.ElementAt(1) - pair1Int.ElementAt(0)) + 1);
                var pair2Range = Enumerable.Range(pair2Int.ElementAt(0), (pair2Int.ElementAt(1) - pair2Int.ElementAt(0)) + 1);

                var both = pair1Range.Intersect(pair2Range);
                if (both.Count() > 0) counter++;
            }
            Console.WriteLine($"Day 4 (Part 2): {counter}");
        }
    }
}
