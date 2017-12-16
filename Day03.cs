using System;
using System.Linq;

namespace advent_of_code.Days
{
    public class DayThree
    {
        public static int PartOne(int puzzleInput)
        {
            var start = new Point();
            var found = CalculateCoordinatesOf(puzzleInput);

            return (Math.Abs(found.X)) + (Math.Abs(found.Y));
        }

        public static int PartTwo(string puzzleInput)
        {
            throw new NotImplementedException();
        }

        private static Point CalculateCoordinatesOf(int value)
        {
            var x = 0;
            var y = 0;
            var direction = Direction.Start;
            var stepsTaken = 0;
            var stepsRequired = 1;
            var incrementStepsRequired = false;

            for (int i = 1; i < value + 1; i++)
            {
                switch (direction)
                {
                    case Direction.Start:
                    x = 0;
                    y = 0;
                    direction = Direction.Right;
                    break;

                    case Direction.Right:
                    x += 1;
                    stepsTaken += 1;
                    if (stepsTaken == stepsRequired)
                    {
                        stepsTaken = 0;
                        direction = Direction.Up;
                        if (incrementStepsRequired)
                        {
                            stepsRequired += 1;
                        }
                        incrementStepsRequired = !incrementStepsRequired;
                    }
                    break;

                    case Direction.Up:
                    y += 1;
                    stepsTaken += 1;
                    if (stepsTaken == stepsRequired)
                    {
                        stepsTaken = 0;
                        direction = Direction.Left;
                        if (incrementStepsRequired)
                        {
                            stepsRequired += 1;
                        }
                        incrementStepsRequired = !incrementStepsRequired;
                    }
                    break;

                    case Direction.Left:
                    x -= 1;
                    stepsTaken += 1;
                    if (stepsTaken == stepsRequired)
                    {
                        stepsTaken = 0;
                        direction = Direction.Down;
                        if (incrementStepsRequired)
                        {
                            stepsRequired += 1;
                        }
                        incrementStepsRequired = !incrementStepsRequired;
                    }
                    break;

                    case Direction.Down:
                    y -= 1;
                    stepsTaken += 1;
                    if (stepsTaken == stepsRequired)
                    {
                        stepsTaken = 0;
                        direction = Direction.Right;
                        if (incrementStepsRequired)
                        {
                            stepsRequired += 1;
                        }
                        incrementStepsRequired = !incrementStepsRequired;
                    }
                    break;
                }
            }
            return new Point{ X = x, Y = y };
        }
    }

    public class Point
    {
        public int X {get; set; } = 0;
        public int Y {get; set; } = 0;

        public override string ToString()
        {
            return $"x:{X} y:{Y}";
        }
    }

    public enum Direction
    {
        Start = 0,
        Right = 1,
        Up = 2,
        Left = 3,
        Down = 4
    }
}