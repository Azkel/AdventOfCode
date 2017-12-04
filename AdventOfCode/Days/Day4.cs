using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Days
{
    public class Day4 : AbstractDay
    {
        public string FilePath = "../../Inputs/Day4.txt";

        protected override int GetResultFirst()
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
                return sum;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured during processing! Details:" + e.Message);
                throw;
            }
        }

        protected override int GetResultSecond()
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
                return sum;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured during processing! Details:" + e.Message);
                throw;
            }
        }
    }
}
