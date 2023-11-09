using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cleaner
{
    internal class App
    {
        private string _path;

        public App()
        {
            _path = String.Empty;
            DisplayInfo();
        }

        private void DisplayInfo()
        {

            Console.WriteLine($"Name: {Info.Name}");
            Console.WriteLine($"Version: {Info.Version}");
            Console.WriteLine();
        }

        internal void Run(string path, bool recursive)
        {
            // read arguments

            // get empty folders
            var emptyFolders = GetEmptyFolders(path);

            // delete empty folders
            DeleteFolders(emptyFolders);

            // if recursive path will be in recursively search and delete empty folders
            // not search and delete only empty folders in given path

            // return result how many folder was empty and delete status
        }

        private List<string>? GetEmptyFolders(string path)
        {
            var exists = Directory.Exists(path);
            if (!exists) return null;

            DirectoryInfo dir = new DirectoryInfo(path);
            var subdirs = dir.GetDirectories();
            return CheckIfSubDirectoriesEmpty(subdirs);
        }

        private List<string> CheckIfSubDirectoriesEmpty(DirectoryInfo[] directories)
        {
            var result = new List<string>();

            foreach (var subdir in directories)
            {
                if (subdir.IsEmpty())
                {
                    result.Add(subdir.FullName);
                }
            }

            return result;
        }

        private void DeleteFolders(List<string> folders)
        {
            int counter = 0;
            foreach (var folder in folders)
            {
                Directory.Delete(folder);
                Console.WriteLine($"[{DateTime.Now.Date}] Delete: {folder}");
                counter++;
            }
            Console.WriteLine($"[{DateTime.Now.Date}] Result: {counter} folder removed");
        }
    }



}
