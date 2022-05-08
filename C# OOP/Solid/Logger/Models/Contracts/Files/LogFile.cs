using Logger.Common;
using Logger.Models.Contracts.Layouts;
using Logger.Models.Enumerations;
using System;
using System.IO;
using System.Linq;

namespace Logger.Models.Contracts.Files
{
    public class LogFile : IFile
    {
        private readonly IPathManager pathManager;
        public LogFile(IPathManager pathManager)
        {
            this.pathManager = pathManager;
            this.pathManager.EnsureDirectoryAndFileExists();
        }
        public string Path
            => pathManager.CurrentFilePath;

        public long Size
            => CalculateFileSize();

        public string Write(ILayout layout, IError error)
        {
            string format = layout.Format;
            DateTime dateTime = error.DateTime;
            string message = error.Message;
            Level level = error.Level;

            string formattedMessage = string.Format(format,
                dateTime.ToString(GlobalConstants.DateTimeFormat),
                level.ToString(),message);

            return formattedMessage;
        }
        private long CalculateFileSize()
        {
            string fileText = File.ReadAllText(this.Path);
            return fileText
                .ToCharArray()
                .Where(c=>char.IsLetter(c))
                .Sum(c => c);
        }
    }
}
