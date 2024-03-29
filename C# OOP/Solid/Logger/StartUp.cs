﻿using Logger.Common;
using Logger.Factories;
using Logger.IOManagement;
using Logger.IOManagement.Contracts;
using Logger.Models;
using Logger.Models.Contracts;
using Logger.Models.Contracts.Files;
using Logger.Models.Contracts.Layouts;
using Logger.Models.Enumerations;
using Logger.Models.PathManagement;
using Loggers.Core;
using System;
using System.Collections.Generic;

namespace Logger
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            LayoutFactory layoutFactory = new LayoutFactory();
            AppenderFactory appenderFactory = new AppenderFactory();

            IReader reader = new ConsoleReader();
            IWriter writer = new ConsoleWriter();
            IPathManager pathManager = new PathManager("logs", "logs.txt");
            IFile file = new LogFile(pathManager);

            ILogger logger = SetUpLogger(n,writer,reader,file,
                layoutFactory,appenderFactory);

            IEngine engine = new Engine(logger, reader, writer);
            engine.Run();
        }
        private static ILogger SetUpLogger(int appendersCount, IWriter writer,
            IReader reader,IFile file,LayoutFactory layoutFactory,
            AppenderFactory appenderFactory)
        {
            ICollection<IAppender> appenders = new HashSet<IAppender>();

            for (int i = 0; i < appendersCount; i++)
            {
                string[] appendersArgs = reader.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                string appenderType = appendersArgs[0];
                string layoutType = appendersArgs[1];

                bool hasError = false;
                Level level = ParseLevel(appendersArgs, writer, ref hasError);
                if (hasError)
                {
                    continue;
                }
                try
                {
                    ILayout layout = layoutFactory.CreateLayout(layoutType);
                    IAppender appender =
                        appenderFactory.CreateAppender
                        (appenderType, layout,level,file);

                    appenders.Add(appender);
                }
                catch (InvalidOperationException ioe)
                {
                    Console.WriteLine(ioe.Message);
                }
            }

            ILogger logger = new LoggeR(appenders);

            return logger;
        }
        private static Level ParseLevel(string[] levelStr, IWriter writer, ref bool hasError)
        {
            Level appenderLevel = Level.INFO;

            if (levelStr.Length == 3)
            {
                bool isEnumValid = Enum.TryParse(typeof(Level),
                    levelStr[2], true, out object EnumParsed);

                if (!isEnumValid)
                {
                    writer.WriteLine(GlobalConstants.InvalidLevelType);
                    hasError = true;
                }
                appenderLevel = (Level)EnumParsed;
            }
            return appenderLevel;
        }
    }
}
