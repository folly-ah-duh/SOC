using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Common
{
    public static class Tools
    {

        public static void CopyDirectory(string sourceDir, string destinyDir)
        {
            DirectoryInfo dirInfo = new DirectoryInfo(sourceDir);
            if (!Directory.Exists(destinyDir))
                Directory.CreateDirectory(destinyDir);
            foreach (FileInfo fileInfo in dirInfo.GetFiles())
                fileInfo.CopyTo(Path.Combine(destinyDir, fileInfo.Name), true);
            foreach (DirectoryInfo subDirInfo in dirInfo.GetDirectories())
                CopyDirectory(subDirInfo.FullName, Path.Combine(destinyDir, subDirInfo.Name));

        }

        public static void DeleteDirectory(string dir)
        {
            foreach (string directory in Directory.GetDirectories(dir))
            {
                DeleteDirectory(directory);
            }

            try
            {
                Directory.Delete(dir, true);
            }
            catch (IOException)
            {
                Directory.Delete(dir, true);
            }
            catch (System.UnauthorizedAccessException)
            {
                Directory.Delete(dir, true);
            }
        }

    }
}
