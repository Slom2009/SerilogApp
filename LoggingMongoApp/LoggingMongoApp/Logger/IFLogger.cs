namespace LoggingMongoApp.Logger
{
    public interface IFLogger
    {
        void LogInfo(Exception exception);
        void LogWarn(Exception exception);
        void LogDebug(Exception exception);
        void LogError(Exception exception);
    }
}
