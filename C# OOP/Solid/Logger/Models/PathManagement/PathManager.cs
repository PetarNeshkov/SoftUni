using Logger.Models.Contracts.Layouts;
using System;
using System.IO;

namespace Logger.Models.PathManagement
{
    public class PathManager : IPathManager
    {
        private readonly string currentPath;
        private readonly string folderName;
        private readonly string fileName;
        //tells me the path where my app is running on user PC
        private PathManager()
        {
            currentPath = this.GetCurrentPath();
        }
        //they should pass folder Name and file name
        public PathManager(string folderName, string fileName)
            :this()
        {
            this.folderName = folderName;
            this.fileName = fileName;
        }
        public string CurrentDirectoryPath
            => Path.Combine(currentPath, folderName);

        public string CurrentFilePath
            => Path.Combine(CurrentDirectoryPath, fileName);

        public string GetCurrentPath()
        {
            return Directory.GetCurrentDirectory();
        }
        public void EnsureDirectoryAndFileExists()
        {
            if (!Directory.Exists(CurrentDirectoryPath))
            {
                Directory.CreateDirectory(CurrentDirectoryPath);
            }
            File.AppendAllText(CurrentFilePath, String.Empty);
        }

    }
}
