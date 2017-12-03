using AdventOfCode.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Days
{
    public abstract class AbstractDay
    {

        public int GetResult(TaskNumber number)
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

        protected abstract int GetResultSecond();

        protected abstract int GetResultFirst();


    }
}
