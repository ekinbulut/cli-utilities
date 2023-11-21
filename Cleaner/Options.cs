using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner
{
    internal class Options
    {
        public static string Path { get; set; }
        public static bool IsRecursive { get; set; }

        private readonly Dictionary<string, string> Args;

        public Options()
        {
            Args = new Dictionary<string, string>()
            {
                { "-d,--directory","\t\tDirectory to search and destory empty folders" },
                { "-r,--recursive","\t\tRecursive search and destory empty folders" },
            };
        }

        private void DisplayArgs()
        {
            foreach (var arg in Args)
            {

                Console.WriteLine($"{arg.Key} {arg.Value}");
                Console.WriteLine();
            }
        }

        public void Parse(string[] args)
        {
            if (args.Length == 0)
            {
                DisplayArgs();
                return;
            }

            for (int i = 0; i < args.Length; i++)
            {
                if (Args.ContainsKey(args[i]))
                {
                    switch (args[i])
                    {
                        case "--directory":
                        case "-d":
                            Path = args[i + 1];
                            break;

                        case "--recursive":
                        case "-r":
                            IsRecursive = true;
                            break;
                        default:
                            break;
                    }
                }
            }
        }
    }
}
