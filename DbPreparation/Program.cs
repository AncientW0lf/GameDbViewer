using System;
using CommandLine;

namespace DbPreparation
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ParserResult<AppArgs> res = Parser.Default.ParseArguments<AppArgs>(args);
            AppArgs resArgs;
            res.WithParsed(r => resArgs = r);
        }
    }
}
