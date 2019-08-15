using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOC.Classes.Assets
{
    public class FileAssets
    {
        List<string> FPKfolderAsset = new List<string>();
        List<string> FPKDfolderAsset = new List<string>();
        Dictionary<string, string> individualFiles = new Dictionary<string, string>();

        public readonly string questFPKPath; 
        public readonly string questFPKDPath;

        public FileAssets(string dir, string fpkName)
        {
            questFPKPath = $@"{dir}/Assets/tpp/pack/mission2/quest/ih/{fpkName}_fpk";
            questFPKDPath = $@"{dir}/Assets/tpp/pack/mission2/quest/ih/{fpkName}_fpkd";
        }

        public void AddIndividualFile(string whereToFind, string whereToPlace)
        {
            if (!individualFiles.ContainsKey(whereToFind))
                individualFiles.Add(whereToFind, whereToPlace);
        }

        public void AddFPKFolder(string directory)
        {
            FPKfolderAsset.Add(directory);
        }

        public void AddFPKDFolder(string directory)
        {
            FPKDfolderAsset.Add(directory);
        }

        public void SendAssets()
        {
            if (!Directory.Exists(questFPKPath))
                Directory.CreateDirectory(questFPKPath);

            if (!Directory.Exists(questFPKDPath))
                Directory.CreateDirectory(questFPKDPath);

            foreach (string dir in FPKfolderAsset)
            {
                CopyDirectory(dir, questFPKPath);
            }

            foreach(string dir in FPKDfolderAsset)
            {
                CopyDirectory(dir, questFPKDPath);
            }

            foreach(KeyValuePair<string, string> asset in individualFiles)
            {
                if (File.Exists(asset.Key))
                {
                    string destinationDir = Path.GetDirectoryName(asset.Value);
                    if (!Directory.Exists(destinationDir))
                        Directory.CreateDirectory(destinationDir);

                    File.Copy(asset.Key, asset.Value, true);
                }
            }
        }

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
