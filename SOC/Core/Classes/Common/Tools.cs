using System.Diagnostics;
using System.IO;
using System.Reflection;

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

        public static string FoxToolPath = Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "SOCassets//ToolAssets//FoxTool.exe");

        public static void CompileFile(string toolArg, string ToolPath)
        {
            Process compileProcess = new Process();
            compileProcess.StartInfo.FileName = ToolPath;
            compileProcess.StartInfo.Arguments = toolArg;
            compileProcess.StartInfo.UseShellExecute = false;
            compileProcess.StartInfo.CreateNoWindow = true;
            compileProcess.Start();
            compileProcess.WaitForExit();
        }

    }
}
