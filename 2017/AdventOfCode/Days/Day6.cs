using System;
using System.Collections.Generic;
using System.Linq;

namespace AdventOfCode.Days
{
    public class Day6 : AbstractDay
    {
        public string InputString = "11	11	13	7	0	15	5	5	4	4	1	1	7	1	15	11";


        protected override string GetResultSecond()
        {
            var numbers = InputString.Split('	').Select(x => Int32.Parse(x.ToString())).ToArray();
            int result = 0;
            bool repeated = false;
            Dictionary<string, int> occurences = new Dictionary<string, int>();
            while (!repeated)
            {
                int startingValue = numbers.Max(), index = numbers.ToList().IndexOf(startingValue), currentValueOccurences = 0;
                numbers[index] = 0;
                while (startingValue != 0)
                {
                    index++;
                    if (index >= numbers.Length)
                    {
                        index = 0;
                    }
                    startingValue--;
                    numbers[index]++;
                }
                if(occurences.TryGetValue(string.Join(";", numbers), out currentValueOccurences))
                {
                    repeated = true;
                    result = currentValueOccurences;
                }
                else
                {
                    occurences.Add(string.Join(";", numbers), 0);
                    var keys = occurences.Keys.ToList() ;
                    foreach(var occurence in keys)
                    {
                        occurences[occurence]++;
                    }
                }
            }
            return result.ToString();
        }

        protected override string GetResultFirst()
        {
            var numbers = InputString.Split('	').Select(x => Int32.Parse(x.ToString())).ToArray();
            int numberOfSteps = 0;
            bool addedSuccesful = true;
            HashSet<string> alreadyExistingValues = new HashSet<string>();
            while(addedSuccesful)
            {
                int startingValue = numbers.Max(), index = numbers.ToList().IndexOf(startingValue);
                numbers[index] = 0;
                while(startingValue != 0)
                {
                    index++;
                    if(index >= numbers.Length)
                    {
                        index = 0;
                    }
                    startingValue--;
                    numbers[index]++;
                }
                addedSuccesful = alreadyExistingValues.Add(string.Join(";", numbers));
                numberOfSteps++;
            }
            return numberOfSteps.ToString();
        }
    }
}
