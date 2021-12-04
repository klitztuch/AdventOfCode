using System;

namespace Day2
{
    public static class Part1
    {
        public static int Calculate(Command[] commands)
        {
            var horizontalPos = 0;
            var depth = 0;
            foreach (var command in commands)
            {
                switch (command.Movement)
                {
                    case Movement.Forward:
                        horizontalPos += command.Steps;
                        break;
                    case Movement.Down:
                        depth += command.Steps;
                        break;
                    case Movement.Up:
                        depth -= command.Steps;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }

            return horizontalPos * depth;
        }
    }
}