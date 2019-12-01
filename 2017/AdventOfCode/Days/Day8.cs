using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode.Days
{
    public class Day8 : AbstractDay
    {
        public string FilePath = "../../Inputs/Day8.txt";

        private Dictionary<string, int> registers;

        protected override string GetResultFirst()
        {
            registers = new Dictionary<string, int>();
            Regex re = new Regex(@"^([a-z]*) (inc|dec|) (-?\d*) if ([a-z]*) (>|<|==|>=|<=|!=) (-?\d*)$", RegexOptions.Compiled);
            try
            {
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    string currentLine = "";
                    while ((currentLine = sr.ReadLine()) != null)
                    {
                        var result = re.Match(currentLine);
                        if(ParseCondition(result.Groups[4].Value, result.Groups[5].Value, result.Groups[6].Value)) {
                            int value = int.Parse(result.Groups[3].Value);
                            if(!registers.ContainsKey(result.Groups[1].Value))
                            {
                                registers.Add(result.Groups[1].Value, 0);
                            }
                            if (result.Groups[2].Value.Equals("inc"))
                            {
                                registers[result.Groups[1].Value] += value;
                            }
                            else
                            {
                                registers[result.Groups[1].Value] -= value;
                            }
                        }
                    }
                }
                return registers.Values.Max().ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured during processing! Details:" + e.Message);
                throw;
            }
        }

        protected override string GetResultSecond()
        {
            registers = new Dictionary<string, int>();
            Regex re = new Regex(@"^([a-z]*) (inc|dec|) (-?\d*) if ([a-z]*) (>|<|==|>=|<=|!=) (-?\d*)$", RegexOptions.Compiled);
            int max = int.MinValue;
            try
            {
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    string currentLine = "";
                    while ((currentLine = sr.ReadLine()) != null)
                    {
                        var result = re.Match(currentLine);
                        if (ParseCondition(result.Groups[4].Value, result.Groups[5].Value, result.Groups[6].Value))
                        {
                            int value = int.Parse(result.Groups[3].Value);
                            if (!registers.ContainsKey(result.Groups[1].Value))
                            {
                                registers.Add(result.Groups[1].Value, 0);
                            }
                            if (result.Groups[2].Value.Equals("inc"))
                            {
                                registers[result.Groups[1].Value] += value;
                            }
                            else
                            {
                                registers[result.Groups[1].Value] -= value;
                            }
                            if (registers[result.Groups[1].Value] > max)
                            {
                                max = registers[result.Groups[1].Value];
                            }
                        }
                    }
                }
                return max.ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured during processing! Details:" + e.Message);
                throw;
            }
        }

        private bool ParseCondition(string register, string ifOperator, string value)
        {
            if(!registers.ContainsKey(register))
            {
                registers.Add(register, 0);
            }
            int parsedValue = Int32.Parse(value);
            switch(ifOperator)
            {
                case "==":
                    {
                        return registers[register] == parsedValue;
                    }
                case "!=":
                    {

                        return registers[register] != parsedValue;
                    }
                case ">":
                    {
                        return registers[register] > parsedValue;
                    }
                case "<":
                    {
                        return registers[register] < parsedValue;
                    }
                case ">=":
                    {
                        return registers[register] >= parsedValue;
                    }
                case "<=":
                    {
                        return registers[register] <= parsedValue;
                    }
                default:
                    {
                        throw new ArgumentException("Wrong type of operator provided!");
                    }
            }
        }
    }
}
