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
            }
            return string.Empty;
        }

        protected abstract string GetResultSecond();

        protected abstract string GetResultFirst();


    }
}
