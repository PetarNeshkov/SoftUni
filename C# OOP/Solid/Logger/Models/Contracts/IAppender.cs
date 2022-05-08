
using Logger.Models.Enumerations;

namespace Logger.Models.Contracts.Layouts
{
   public interface IAppender
    {
        ILayout Layout { get; }
        Level Level { get; }
        void Append(IError error);
    }
}
