
using Logger.Common;
using Logger.IOManagement;
using Logger.Models.Contracts;
using Logger.Models.Contracts.Layouts;
using Logger.Models.Enumerations;
using System;

namespace Logger.Models.Appenders
{
    public class ConsoleAppender : Appender
    {
        private readonly IWriter writer;
        public ConsoleAppender(ILayout layout, Level level)
            :base(layout,level)
        {
            writer = new ConsoleWriter();
        }
        public override void Append(IError error)
        {
            string format = Layout.Format;

            DateTime dateTime = error.DateTime;
            string message = error.Message;
            Level level = error.Level;

            string formattedString = string.Format
                (format, dateTime.ToString(GlobalConstants.DateTimeFormat),
                level.ToString(),message);

            writer.WriteLine(formattedString);
            messagesAppended++;
        }  
    }
}
