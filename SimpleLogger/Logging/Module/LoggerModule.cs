using System;

namespace SimpleLogger.Logging.Module
{
    public abstract class LoggerModule : IDisposable
    {
        public virtual void BeforeLog() { }
        public virtual void AfterLog(LogMessage logMessage) { }
        public virtual void ExceptionLog(Exception exception) { }
        public virtual void Dispose() { }
    }
}