using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Days
{
    public class Day2 : AbstractDay
    {
        public string FilePath = "../../Inputs/Day2.txt";


        protected override int GetResultFirst()
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
