using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileMover
{
    internal class FileArchiver
    {
        internal const string FilePath = "C:\\JustForTesting\\";
        internal const string ArchivePath = FilePath + "Archive\\";

        internal static bool IsThereAFile()
        {
            bool isFile = false;

            DirectoryInfo di = new DirectoryInfo(FilePath);
            var fi = di.GetFiles();
            if (fi.Length > 0)
            {
                isFile = true;
            }

            return isFile;
        }

        internal static void MoveTheFiles()
        {
            if (!Directory.Exists(ArchivePath))
            {
                Directory.CreateDirectory(ArchivePath);
            }
            DirectoryInfo di = new DirectoryInfo(FilePath);
            
            foreach(var fi in di.GetFiles())
            {
                fi.MoveTo(ArchivePath + fi.Name, true);
            }
        }
    }
}
