using System;
using System.IO;
using System.Linq;

namespace AdventOfCode.Days
{
    public class Day2 : AbstractDay
    {
        public string FilePath = "../../Inputs/Day2.txt";


        protected override string GetResultFirst()
        {
            int sum = 0;
            try
            {
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    string currentLine = "";
                    while((currentLine = sr.ReadLine()) != null)
                    {
                        var array = currentLine.Split('	').Select(x => Int32.Parse(x)).ToArray();
                        sum += array.Max() - array.Min();
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
                        var array = currentLine.Split('	').Select(x => Int32.Parse(x)).ToArray();
                        for(int i=0; i<array.Length; i++)
                        {
                            for(int j = 0; j < array.Length; j++)
                            {
                                if(i != j && array[i] > array[j] && array[i] % array[j] == 0)
                                {
                                    sum += array[i] / array[j];
                                }
                            }
                        }
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
