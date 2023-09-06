using Serilog;

namespace LoggingMongoApp.Logger
{
    public class FLogger : IFLogger
    {
        private static Serilog.ILogger _logger;
        public FLogger()
        {
            _logger = new LoggerConfiguration()
             .MinimumLevel.Information()
             .WriteTo.MongoDBBson("mongodb://localhost:27017/LogDB", "LogEntries")
             .CreateLogger();
        }
        public void LogDebug(Exception exception)
        {
            _logger.Debug(exception,"Debug Message");
        }

        public void LogError(Exception exception)
        {
            _logger.Error(exception, "Error Message");
        }

        public void LogInfo(Exception exception)
        {
            _logger.Information(exception, "Information Message");
        }

        public void LogWarn(Exception exception)
        {
            _logger.Warning(exception, "Warning Message");
        }
    }
}
