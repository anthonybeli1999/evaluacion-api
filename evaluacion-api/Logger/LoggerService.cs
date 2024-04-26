namespace evaluacion_api.Logger
{
    public class LoggerService
    {
        private readonly string _logFilePath;

        public LoggerService(string logFilePath)
        {
            _logFilePath = logFilePath;
        }
        public async Task LogPostTime()
        {
            string logMessage = $"{DateTime.UtcNow:yyyy-MM-dd HH:mm:ss} - POST request made";

            await File.AppendAllTextAsync(_logFilePath, logMessage + Environment.NewLine);
        }
    }
}
