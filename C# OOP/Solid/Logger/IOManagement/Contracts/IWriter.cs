﻿
namespace Logger.IOManagement
{
   public interface IWriter
    {
        void Write(string text);
        void WriteLine(string text);

    }
}
