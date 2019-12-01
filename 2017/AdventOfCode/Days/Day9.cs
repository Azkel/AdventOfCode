using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace AdventOfCode.Days
{
    public class Day9 : AbstractDay
    {
        public string FilePath = "../../Inputs/Day9.txt";


        protected override string GetResultSecond()
        {

            int sum = 0;
            bool ignore = false;
            try
            {
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    char currentChar;
                    while (sr.Peek() != -1)
                    {
                        currentChar = Convert.ToChar(sr.Read());
                        switch (currentChar)
                        {
                            case '<':
                                {
                                    if(ignore)
                                    {
                                        sum++;
                                    }
                                    ignore = true;
                                    break;
                                }
                            case '>':
                                {
                                    ignore = false;
                                    break;
                                }
                            case '!':
                                {
                                    sr.Read();
                                    break;
                                }
                            default:
                                {
                                    if (ignore)
                                    {
                                        sum++;
                                    }
                                    break;
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

        protected override string GetResultFirst()
        {
            int groups = 0;
            int sum = 0;
            bool ignore = false;
            try
            {
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    char currentChar;
                    while (sr.Peek() != -1)
                    {
                        currentChar = Convert.ToChar(sr.Read());
                        switch (currentChar)
                        {
                            case '{':
                                {
                                    if (!ignore)
                                    {
                                        groups += 1;
                                    }
                                    break;
                                }
                            case '}':
                                {
                                    if (!ignore)
                                    {
                                        sum += groups;
                                        groups -= 1;
                                    }
                                    break;
                                }
                            case '<':
                                {
                                    ignore = true;
                                    break;
                                }
                            case '>':
                                {
                                    ignore = false;
                                    break;
                                }
                            case '!':
                                {
                                    sr.Read();
                                    break;
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
