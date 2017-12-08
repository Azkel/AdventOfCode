using AdventOfCode.Days;
using System;
using AdventOfCode.Enums;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstractDay day = new Day8();
            Console.WriteLine("Day 1st result: {0}", day.GetResult(TaskNumber.First));
            Console.WriteLine("Day 2nd result: {0}", day.GetResult(TaskNumber.Second));
            Console.ReadLine();
        }
    }
}
