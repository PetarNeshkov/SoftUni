

namespace Logger.Models.Contracts.Layouts
{
   public interface IPathManager
    {
        //bin/debug
        string CurrentDirectoryPath { get; }
        //bin/debug/logfile.txt
        string CurrentFilePath { get; }
        //it tells me where my app is running now on user pc
        string GetCurrentPath();
        // it will ensure that selected directory and file exist
        void EnsureDirectoryAndFileExists();
    }
}
