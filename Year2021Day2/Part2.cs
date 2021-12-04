using System;

namespace Day2
{
    public static class Part2
    {
        public static int Calculate(Command[] commands)
        {
            var horizontalPos = 0;
            var depth = 0;
            var aim = 0;

            foreach (var command in commands)
            {
                switch (command.Movement)
                {
                    case Movement.Forward:
                        horizontalPos += command.Steps;
                        depth += aim * command.Steps;
                        break;
                    case Movement.Down:
                        aim += command.Steps;
                        break;
                    case Movement.Up:
                        aim -= command.Steps;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            return horizontalPos * depth;
        }
    }
}