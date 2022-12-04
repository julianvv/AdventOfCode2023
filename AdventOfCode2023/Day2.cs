using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2023
{
    public class Day2 : DayChallenge
    {
        private string input;
        public Day2()
        {
            input = File.ReadAllText("./Inputs/InputDay2.txt");
        }

        public override void RunPart1()
        {
            int score = 0;
            var possibilities = new Dictionary<string, int>
            {
                { "A X", 4 },
                { "A Y", 8 },
                { "A Z", 3 },
                { "B X", 1 },
                { "B Y", 5 },
                { "B Z", 9 },
                { "C X", 7 },
                { "C Y", 2 },
                { "C Z", 6 }
            };
         
            var rounds = input.Split("\r\n");
            foreach (var round in rounds)
            {
                score += possibilities[round];
            }
            Console.WriteLine($"Day 2 (Part 1): {score}");
        }

        public override void RunPart2()
        {
            int score = 0;
            var elementToPlay = new Dictionary<string, string>
            {
                { "A X", "C" },
                { "A Y", "A" },
                { "A Z", "B" },
                { "B X", "A" },
                { "B Y", "B" },
                { "B Z", "C" },
                { "C X", "B" },
                { "C Y", "C" },
                { "C Z", "A" }
            };

            var elements = new Dictionary<string, int>
            {
                { "A", 1 },
                { "B", 2 },
                { "C", 3 },
            };

            var outcomes = new Dictionary<string, int>
            {
                { "X", 0 },
                { "Y", 3 },
                { "Z", 6 },
            };

            var rounds = input.Split("\r\n");
            
            foreach (string round in rounds)
            {
                string[] roundSplit = round.Split(" ");
                string element = elementToPlay[round];
                int elementPoints = elements[element];
                int outcomePoints = outcomes[roundSplit[1]];
                score += elementPoints + outcomePoints;
            }
            Console.WriteLine($"Day 2 (Part 2): {score}");
        }
    }
}
