
using Logger.Common;
using Logger.IOManagement;
using Logger.IOManagement.Contracts;
using Logger.Models.Contracts;
using Logger.Models.Contracts.Layouts;
using Logger.Models.Enumerations;
using Logger.Models.Errors;
using System;
using System.Globalization;

namespace Loggers.Core
{
    public class Engine : IEngine
    {
        private readonly ILogger logger;
        private readonly IReader reader;
        private readonly IWriter writer;
        public Engine(ILogger logger, IReader reader, IWriter writer)
        {
            this.logger = logger;
            this.reader = reader;
            this.writer = writer;
        }

        public IFormatProvider Culture { get; private set; }

        public void Run()
        {
            string command;
            while ((command = this.reader.ReadLine()) != "END")
            {
                string[] errorArgs = command.Split("|");

                string levelStr = errorArgs[0];
                string dateTimeStr = errorArgs[1];
                string message = errorArgs[2];

                bool isLevelValid =
                    Enum.TryParse(typeof(Level), levelStr, true, out object levelObj);

                if (!isLevelValid)
                {
                    this.writer.WriteLine(GlobalConstants.InvalidLevelType);
                    continue;
                }
                Level level=(Level) levelObj;

                bool isDateTimeValid = DateTime.TryParseExact
                    (dateTimeStr, GlobalConstants.DateTimeFormat,
                    CultureInfo.InvariantCulture, DateTimeStyles.None,out DateTime dateTime);

                if (!isDateTimeValid)
                {
                    writer.WriteLine(GlobalConstants.InvalidDateTimeFormat);
                    continue;
                }

                IError error = new Error(dateTime, message, level);

                this.logger.Log(error);
            }
            this.writer.WriteLine(logger.ToString());
        }
    }
}
