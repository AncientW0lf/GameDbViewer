using System;
using CommandLine;

namespace DbPreparation
{
    internal class Program
    {
        private static int Main(string[] args)
        {
            ParserResult<AppArgs> res = Parser.Default.ParseArguments<AppArgs>(args);
            AppArgs resArgs = null;
            res.WithParsed(r => resArgs = r);

            if (resArgs.Any(arg => string.IsNullOrWhiteSpace(arg?.ToString())))
            {
                Console.WriteLine("One or more required parameters are missing. Use \"--help\" for more information.");
                return 1;
            }

            return 0;
        }
    }
}
