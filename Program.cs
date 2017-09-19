using System;
using System.IO;
using Avalonia;
using Serilog;

namespace RSSReader
{
    class Program
    {
        static void Main(string[] args)
        {
            var logsPath = Path.Combine(Directory.GetCurrentDirectory(),"logs", "log-{Date}.txt");
            Log.Logger = new LoggerConfiguration()
                .WriteTo.RollingFile(logsPath)
                .CreateLogger();

            AppBuilder.Configure<App>()
                .UsePlatformDetect()
                .Start<MainWindow>();
        }
    }
}
