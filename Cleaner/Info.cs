using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner
{
    internal static class Info
    {
        public static string Name = Assembly.GetEntryAssembly().GetName().Name;
        public static string Version = Assembly.GetEntryAssembly().GetName().Version.ToString();

    }
}
