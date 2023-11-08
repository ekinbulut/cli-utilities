/*
 * Empty folder detection and removal
 */

namespace Cleaner
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // https://learn.microsoft.com/en-us/archive/msdn-magazine/2019/march/net-parse-the-command-line-with-system-commandline
            // https://github.com/commandlineparser/commandline

            var app = new App();
            app.DisplayInfo();
            // parameters: -f {path} -r (recursive)
            // get parameters from args

            // TODO: validate arguments if is not valid return exit 0
            // configure app.

            app.Run("", false);

        }



    }
}