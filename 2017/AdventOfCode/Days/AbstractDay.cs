using AdventOfCode.Enums;
using System;

namespace AdventOfCode.Days
{
    public abstract class AbstractDay
    {

        public string GetResult(TaskNumber number)
        {

            switch (number)
            {
                case TaskNumber.First:
                    {
                        return GetResultFirst();
                    }
                case TaskNumber.Second:
                    {
                        return GetResultSecond();
                    }
                default:
                    throw new Exception("This code should be unreachable");
            }

        }

        protected abstract string GetResultSecond();

        protected abstract string GetResultFirst();


    }
}
