using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode.Days
{
    public class Day5 : AbstractDay
    {
        public string FilePath = "../../Inputs/Day5.txt";


        protected override string GetResultFirst()
        {
            int sum = 0;
            List<int> listOfValues = new List<int>();
            try
            {
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    string currentLine = "";
                    while((currentLine = sr.ReadLine()) != null)
                    {
                        listOfValues.Add(Int32.Parse(currentLine));
                    }
                }
                int currentIndex = 0, jumpCount = 0;
                var values = listOfValues.ToArray();
                while (currentIndex >= 0 && currentIndex < values.Count())
                {
                    jumpCount++;
                    values[currentIndex]++;
                    currentIndex += (values[currentIndex] - 1);
                }
                return jumpCount.ToString();
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
            List<int> listOfValues = new List<int>();
            try
            {
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    string currentLine = "";
                    while((currentLine = sr.ReadLine()) != null)
                    {
                        listOfValues.Add(Int32.Parse(currentLine));
                    }
                }
                int currentIndex = 0, jumpCount = 0;
                int offset = 0;
                var values = listOfValues.ToArray();
                while (currentIndex >= 0 && currentIndex < values.Count())
                {
                    jumpCount++;
                    if(values[currentIndex] >= 3)
                    {
                        offset = 1;
                        values[currentIndex]--;
                    }
                    else
                    {
                        offset = -1;
                        values[currentIndex]++;
                    }
                    currentIndex += (values[currentIndex] + offset);
                }
                return jumpCount.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured during processing! Details:" + e.Message);
                throw;
            }
        }
    }
}
