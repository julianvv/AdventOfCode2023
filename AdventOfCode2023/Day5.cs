using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode2023
{
    public class Day5 : DayChallenge
    {
        private string input;
        private string[] commands;
        public Day5() 
        { 
            input = File.ReadAllText("./Inputs/InputDay5.txt");
            commands = input.Split("\r\n 1   2   3   4   5   6   7   8   9 \r\n\r\n")[1].Split("\r\n");

        }

        public override void RunPart1()
        {
            string solution = "";
            List<Stack<char>> stacks = new List<Stack<char>>();
            stacks.Add(new Stack<char>(new[] { 'R', 'N', 'P', 'G' }));
            stacks.Add(new Stack<char>(new[] { 'T', 'J', 'B', 'L', 'C', 'S', 'V', 'H' }));
            stacks.Add(new Stack<char>(new[] { 'T', 'D', 'B', 'M', 'N', 'L' }));
            stacks.Add(new Stack<char>(new[] { 'R', 'V', 'P', 'S', 'B' }));
            stacks.Add(new Stack<char>(new[] { 'G', 'C', 'Q', 'S', 'W', 'M', 'V', 'H' }));
            stacks.Add(new Stack<char>(new[] { 'W', 'Q', 'S', 'C', 'D', 'B', 'J' }));
            stacks.Add(new Stack<char>(new[] { 'F', 'Q', 'L' }));
            stacks.Add(new Stack<char>(new[] { 'W', 'M', 'H', 'T', 'D', 'L', 'F', 'V' }));
            stacks.Add(new Stack<char>(new[] { 'L', 'P', 'B', 'V', 'M', 'J', 'F' }));
            
            foreach (string commandString in commands)
            {
                Command command = parseCommand(commandString);
                for (int i = 0; i < command.Amount; i++)
                {
                    // Pop from 'from' stack
                    char c = stacks[command.From - 1].Pop();
                    // Push onto 'to' stack
                    stacks[command.To - 1].Push(c);
                }
            }

            foreach (Stack<char> stack in stacks)
            {
                solution += stack.Peek();
            }

            Console.WriteLine($"Day 5 (Part 1): {solution}");
        }

        private Command parseCommand(string command)
        {
            var parts = command.Split(" ");
            return new Command(Convert.ToInt32(parts[1]), Convert.ToInt32(parts[3]), Convert.ToInt32(parts[5]));
        }

        public override void RunPart2()
        {
            string solution = "";
            List<Stack<char>> stacks = new List<Stack<char>>();
            stacks.Add(new Stack<char>(new[] { 'R', 'N', 'P', 'G' }));
            stacks.Add(new Stack<char>(new[] { 'T', 'J', 'B', 'L', 'C', 'S', 'V', 'H' }));
            stacks.Add(new Stack<char>(new[] { 'T', 'D', 'B', 'M', 'N', 'L' }));
            stacks.Add(new Stack<char>(new[] { 'R', 'V', 'P', 'S', 'B' }));
            stacks.Add(new Stack<char>(new[] { 'G', 'C', 'Q', 'S', 'W', 'M', 'V', 'H' }));
            stacks.Add(new Stack<char>(new[] { 'W', 'Q', 'S', 'C', 'D', 'B', 'J' }));
            stacks.Add(new Stack<char>(new[] { 'F', 'Q', 'L' }));
            stacks.Add(new Stack<char>(new[] { 'W', 'M', 'H', 'T', 'D', 'L', 'F', 'V' }));
            stacks.Add(new Stack<char>(new[] { 'L', 'P', 'B', 'V', 'M', 'J', 'F' }));

            foreach (string commandString in commands)
            {
                Command command = parseCommand(commandString);
                Stack<char> temp = new Stack<char>();
                
                for (int i = 0; i < command.Amount; i++)
                {
                    temp.Push(stacks[command.From - 1].Pop());
                }

                foreach (char c in temp) 
                {
                    stacks[command.To -1].Push(c);
                }
            }

            foreach (Stack<char> stack in stacks)
            {
                solution += stack.Peek();
            }

            Console.WriteLine($"Day 5 (Part 2): {solution}");
        }
    }

    public class Command
    {
        public int Amount { get; set; }
        public int From { get; set; }
        public int To { get; set; }

        public Command(int amount, int from, int to) 
        {
            Amount = amount;
            From = from;
            To = to;
        }

        public override string ToString()
        {
            return $"Command: amount = {Amount}, from = {From}, to = {To}";
        }
    }
}
