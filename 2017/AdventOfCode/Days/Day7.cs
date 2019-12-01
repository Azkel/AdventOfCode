using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace AdventOfCode.Days
{
    public class Day7 : AbstractDay
    {
        public string FilePath = "../../Inputs/Day7.txt";

        private List<Tuple<string, int, List<string>>> ProgramList;

        protected override string GetResultFirst()
        {
            ProgramList = new List<Tuple<string, int, List<string>>>();
            List<string> neighbours;
            Regex re = new Regex(@"^([a-z]{1,}) \((\d{1,})\)(?: -> (([a-z]*(?:, |$))*)|$)", RegexOptions.Compiled);
            try
            {
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    string currentLine = "";
                    while ((currentLine = sr.ReadLine()) != null)
                    {
                        var result = re.Match(currentLine);
                        neighbours = result.Groups[3].Value.Split(',').Select(x => x.Trim()).ToList();
                        ProgramList.Add(new Tuple<string, int, List<string>>(result.Groups[1].Value, Int32.Parse(result.Groups[2].Value), neighbours));
                        
                    }
                }
                return ProgramList.Where(x => x.Item3.Any() && !ProgramList.Where(y => y.Item3.Contains(x.Item1)).Any()).First().Item1;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured during processing! Details:" + e.Message);
                throw;
            }
        }

        protected override string GetResultSecond()
        {
            int endResult = 0;
            ProgramList = new List<Tuple<string, int, List<string>>>();
            List<string> neighbours;
            Regex re = new Regex(@"^([a-z]{1,}) \((\d{1,})\)(?: -> (([a-z]*(?:, |$))*)|$)", RegexOptions.Compiled);
            try
            {
                using (StreamReader sr = new StreamReader(FilePath))
                {
                    string currentLine = "";
                    while ((currentLine = sr.ReadLine()) != null)
                    {
                        var result = re.Match(currentLine);
                        neighbours = result.Groups[3].Value.Split(',').Select(x => x.Trim()).ToList();
                        ProgramList.Add(new Tuple<string, int, List<string>>(result.Groups[1].Value, Int32.Parse(result.Groups[2].Value), neighbours));

                    }
                }
                var root = ProgramList.Where(x => x.Item3.Any() && !ProgramList.Where(y => y.Item3.Contains(x.Item1)).Any()).First();
                bool notFound = true;
                IEnumerable<Tuple<string, int, List<string>>> rootChildrens;
                IEnumerable<Tuple<string, int>> weights;
                Tuple<string, int, List<string>> wrongChild;
                int lastProper = 0;
                while (notFound)
                {
                    rootChildrens = ProgramList.Where(x => root.Item3.Contains(x.Item1));
                    weights = rootChildrens.Select(x => new Tuple<string, int>(x.Item1, GetWeight(x)));
                    var weightsCount = weights.GroupBy(x => x.Item2).OrderBy(x => x.Count());
                    if(weightsCount.Count() == 1)
                    {
                        return Math.Abs(lastProper + root.Item2 - GetWeight(root)).ToString();
                    }
                    else
                    {
                        lastProper = weightsCount.Skip(1).First().First().Item2;
                        wrongChild = ProgramList.Where(x => x.Item1.Equals(weightsCount.First().First().Item1)).First();
                        if (wrongChild.Item3.Any())
                        {
                            root = wrongChild;

                        }
                        else
                        {
                            lastProper = weightsCount.Skip(1).First().First().Item2;
                            notFound = false;
                        }
                    }
                    
                    
                }
                
                return endResult.ToString();
                //return Math.Abs(rootChildrens.First() - rootChildrens.Skip(1).First()).ToString();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error occured during processing! Details:" + e.Message);
                throw;
            }
        }

        private int GetWeight(Tuple<string, int, List<string>> node)
        {
            var result = node.Item2; 
                if(node.Item3.Any())
            {
                var nodes = ProgramList.Where(x => node.Item3.Contains(x.Item1));
                if(nodes.Any())
                {
                    result += nodes.Select(x => GetWeight(x)).Sum();
                }
            }
            return result;
        }
    }
}
