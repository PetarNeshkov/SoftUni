using Logger.Models.Contracts;
using Logger.Models.Contracts.Layouts;
using System.Collections.Generic;
using System.Text;

namespace Logger.Models
{
    public class LoggeR : ILogger
    {
        private readonly ICollection<IAppender> appenders;
        public LoggeR(ICollection<IAppender> appenders)
        {
            this.appenders = appenders;
        }
        public LoggeR(params IAppender[] appenders)
        {
            this.appenders = appenders;
        }
        public IReadOnlyCollection<IAppender> Appenders
            => (IReadOnlyCollection < IAppender >)appenders;

        public void Log(IError error)
        {
            foreach (IAppender appender in appenders)
            {
                if (error.Level>=appender.Level)
                {
                    appender.Append(error);
                }
            }
        }
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Logger info");
            foreach (var appender in appenders)
            {
                sb.AppendLine(appender.ToString());
            }
            return sb.ToString().TrimEnd();
        }
    }
}
