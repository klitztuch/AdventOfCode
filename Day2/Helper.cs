using System;
using System.IO;
using System.Linq;

namespace Day2
{
    public static class Helper
    {
        public static Command[] File2CommandArray(string fileName)
        {
            var fileInput = File.ReadAllLines(fileName).Select(o =>
            {
                var command = o.Split(" ");
                return new Command()
                {
                    Movement = Enum.Parse<Movement>(command[0], true),
                    Steps = int.Parse(command[1])
                };
            });
            return fileInput.ToArray();

        }
    }
}