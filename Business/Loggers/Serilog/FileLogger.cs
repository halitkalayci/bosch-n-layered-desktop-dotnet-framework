using Core.CrossCuttingConcerns.Logging;
using Serilog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Loggers.Serilog
{
    public class FileLogger : LoggerServiceBase
    {
        public FileLogger()
        {
            string logFilePath = $"{Directory.GetCurrentDirectory()}/logs.txt";
            //Logger konfigürasyonu
            Logger = new LoggerConfiguration().WriteTo.File(
                logFilePath,
                rollingInterval: RollingInterval.Day,
                retainedFileCountLimit: null,
                fileSizeLimitBytes: null,
                outputTemplate: "{Timestamp:yyyy-MM-dd HH:mm:ss.fff zzz} {Level} {Message}{NewLine}"
                ).CreateLogger();
        }
    }
}

// message = "Add Methodu Çalıştı"

// Add methodu çalıştı

