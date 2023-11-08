using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner
{
    internal static class Helper
    {
        internal static bool IsEmpty(this DirectoryInfo dir)
        {
            return dir.GetFiles().Length == 0 && dir.GetDirectories().Length == 0;
        }
    }
}
