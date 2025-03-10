using System.Net.WebSockets;

namespace LayoutHelper
{
    internal class NameItemsAfterFolders
    {
        internal static void Now(string root)
        {
            var folders = Directory.GetDirectories(root);
            foreach (var folder in folders)
            {
                Console.WriteLine(folder);
                NameFromFolder(folder);
            }
        }

        private static void NameFilesIn(string folder)
        {
            string name = Path.GetFileName(folder);
            var files = Directory.GetFiles(folder);
            foreach (var file in files)
            {
                string fileName = Path.GetFileName(file);
                if (!fileName.Contains(name))
                {
                    string newName = fileName.Replace(".", " " + name + ".");
                    File.Move(file, folder + "\\" + newName, true);
                }
                
            }
        }

        private static void NameFromFolder(string folderRoot)
        {
            //var folders = Directory.GetDirectories(folderRoot);
            //foreach (var folder in folders)
            {
                NameFilesIn(folderRoot);
            }
        }
    }
}