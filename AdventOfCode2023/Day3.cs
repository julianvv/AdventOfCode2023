using System.Text.RegularExpressions;

namespace AdventOfCode2023
{
    public class Day3 : DayChallenge
    {
        private string input;
        private Dictionary<char, int> alphabet;
        public Day3() 
        {
            input = File.ReadAllText("./Inputs/InputDay3.txt");
            alphabet = new Dictionary<char, int>
            {
                { 'a', 1 },{ 'b', 2 },{ 'c', 3 },{ 'd', 4 },
                { 'e', 5 },{ 'f', 6 },{ 'g', 7 },{ 'h', 8 },
                { 'i', 9 },{ 'j', 10 },{ 'k', 11 },{ 'l', 12 },
                { 'm', 13 },{ 'n', 14 },{ 'o', 15 },{ 'p', 16 },
                { 'q', 17 },{ 'r', 18 },{ 's', 19 },{ 't', 20 },
                { 'u', 21 },{ 'v', 22 },{ 'w', 23 },{ 'x', 24 },
                { 'y', 25 },{ 'z', 26 },
                { 'A', 27 },{ 'B', 28 },{ 'C', 29 },{ 'D', 30 },
                { 'E', 31 },{ 'F', 32 },{ 'G', 33 },{ 'H', 34 },
                { 'I', 35 },{ 'J', 36 },{ 'K', 37 },{ 'L', 38 },
                { 'M', 39 },{ 'N', 40 },{ 'O', 41 },{ 'P', 42 },
                { 'Q', 43 },{ 'R', 44 },{ 'S', 45 },{ 'T', 46 },
                { 'U', 47 },{ 'V', 48 },{ 'W', 49 },{ 'X', 50 },
                { 'Y', 51 },{ 'Z', 52 },
            };
        }

        public override void RunPart1()
        {
            List<int> dupePriorities = new List<int>();

            var backpacks = input.Split("\r\n");

            foreach (var backpack in backpacks)
            {
                string firstHalf = backpack.Substring(0, backpack.Length / 2);
                string secondHalf = backpack.Substring(backpack.Length / 2);
                List<char> foundChars = new List<char>();

                foreach (char x in firstHalf)
                {
                    if (secondHalf.Contains(x) && !foundChars.Contains(x))
                    {
                        foundChars.Add(x);
                        dupePriorities.Add(alphabet[x]);
                    }
                }
            }

            Console.WriteLine($"Day 3 (Part 1): {dupePriorities.Sum()}");
        }

        public override void RunPart2()
        {
            List<int> dupePriorities = new List<int>();

            var backpacks = input.Split("\r\n");



            foreach (var group in groups)
            {
                Console.WriteLine(group);
            }

            Console.WriteLine($"Day 3 (Part 1): {dupePriorities.Sum()}");
        }
    }
}
