/*
 * Empty folder detection and removal
 */


namespace Cleaner
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var options = new Dictionary<string, string>
            {
                { "-d","Directory to search and destory empty folders" },
                { "-r","Recursive search and destory empty folders" },
            };

            var app = new App();
            app.DisplayInfo();

            if (args.Length == 0)
            {
                foreach (var option in options)
                {

                    Console.WriteLine($"{option.Key} {option.Value}");
                    Console.WriteLine();
                }

                return;
            }

            var path = "";
            var isRecursive = false;
            for (int i = 0; i < args.Length; i++)
            {
                if (options.ContainsKey(args[i]))
                {
                    switch (args[i])
                    {
                        case "-d":
                            path = args[i + 1];
                            break;

                        case "-r":
                            isRecursive = true;
                            break;
                        default:
                            break;
                    }
                }
            }

            if (!string.IsNullOrEmpty(path))
            {
                app.Run(path, isRecursive);
            }
        }
    }
}