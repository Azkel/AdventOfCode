using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdventOfCode.Days
{


    public class Day3 : AbstractDay
    {
        private enum Direction
        {
            Up, Down, Left, Right
        }

        public int Input = 347991;

        protected override int GetResultFirst()
        {
            int y = 0, x = 0, currentValue = 1, step = 1, currentStepValue = 0;
            Direction currentDirection = Direction.Right;
            while (currentValue != Input)
            {
                currentValue++;
                Move(ref currentStepValue, ref currentDirection, ref x, ref y, ref step);

            }
            return Math.Abs(x) + Math.Abs(y);
        }

        protected override int GetResultSecond()
        {
            List<Tuple<int, int, int>> currentValues = new List<Tuple<int, int, int>>
            {
                //                       Value  X   Y
                new Tuple<int, int, int>(   1,  0,  0)
            };
            int y = 0, x = 0, currentValue = 1, step = 1, currentStepValue = 0;
            Direction currentDirection = Direction.Right;
            while (currentValue < Input)
            {
                Move(ref currentStepValue, ref currentDirection, ref x, ref y, ref step);
                currentValue = currentValues.Where(z => (Math.Abs(z.Item2 - x) <= 1 && Math.Abs(z.Item3 - y) <= 1)).Select(z => z.Item1).Sum();
                currentValues.Add(new Tuple<int, int, int>(currentValue, x, y));
            }
            if(currentValue <= Input) // If Input value is on the grid, calculate result once more
            {
                Move(ref currentStepValue, ref currentDirection, ref x, ref y, ref step);
                currentValue = currentValues.Where(z => (Math.Abs(z.Item2 - x) <= 1 && Math.Abs(z.Item3 - y) <= 1)).Select(z => z.Item1).Sum();
            }
            return currentValue;
        }

        private void Move(ref int currentStepValue, ref Direction currentDirection, ref int x, ref int y, ref int step)
        {
            currentStepValue++;

            switch (currentDirection)
            {
                case Direction.Right:
                    {
                        x++;
                        if (currentStepValue == step)
                        {
                            currentDirection = Direction.Up;
                            currentStepValue = 0;
                        }
                        break;
                    }
                case Direction.Left:
                    {
                        x--;
                        if (currentStepValue == step)
                        {
                            currentDirection = Direction.Down;
                            currentStepValue = 0;
                        }
                        break;
                    }
                case Direction.Up:
                    {
                        y++;
                        if (currentStepValue == step)
                        {
                            currentDirection = Direction.Left;
                            currentStepValue = 0;
                            step++;
                        }
                        break;
                    }
                case Direction.Down:
                    {
                        if (currentStepValue == step)
                        {
                            currentDirection = Direction.Right;
                            currentStepValue = 0;
                            step++;
                        }
                        y--;
                        break;
                    }
            }
        }

    }
}