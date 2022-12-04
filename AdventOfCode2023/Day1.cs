namespace AdventOfCode2023
{
    public class Day1 : DayChallenge
    {
        private IOrderedEnumerable<int> _elves;
        public Day1()
        {
            _elves = File.ReadAllText("./Inputs/InputDay1.txt")
                .Split("\n\r\n")
                .Select(k => k
                    .Split("\r\n")
                    .Select(l => Convert.ToInt32(l))
                    .Sum()
                ).OrderBy(m => -m);
        }

        public override void RunPart1()
        {
            Console.WriteLine($"Day 1 (Part 1): {_elves.FirstOrDefault()}");
        }

        public override void RunPart2()
        {
            Console.WriteLine($"Day 1 (Part 2): {_elves.Take(3).Sum()}");
        }
    }
}
