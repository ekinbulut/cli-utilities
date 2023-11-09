/*
 * Empty folder detection and removal
 */


namespace Cleaner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var app = new App();

            var options = new Options();
            options.Parse(args);


            var path = Options.Path;
            var isRecursive = Options.IsRecursive;

            if (!string.IsNullOrEmpty(path))
            {
                app.Run(path, isRecursive);
            }
        }
    }
}