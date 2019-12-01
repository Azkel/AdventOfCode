using System;
using System.IO;
using System.Linq;

namespace AdventOfCode.Days
{
    public class Day4 : AbstractDay
    {
        public string FilePath = "../../Inputs/Day4.txt";

        protected override string GetResultFirst()
        {
            int sum = 0;
            try
            {
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    string currentLine = "";
                    while ((currentLine = sr.ReadLine()) != null)
                    {
                        var array = currentLine.Split(' ');

                        sum += array.Distinct().Count() == array.Count() ? 1 : 0;
                    }
                }
                return sum.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured during processing! Details:" + e.Message);
                throw;
            }
        }

        protected override string GetResultSecond()
        {
            int sum = 0;
            try
            {
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    string currentLine = "";
                    while ((currentLine = sr.ReadLine()) != null)
                    {
                        var array = currentLine.Split(' ').Select(c => String.Concat(c.OrderBy(x => x)));
                        sum += array.Distinct().Count() == array.Count() ? 1 : 0;
                    }
                }
                return sum.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured during processing! Details:" + e.Message);
                throw;
            }
        }
    }
}
