using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.CrossCuttingConcerns.Logging
{
    public abstract class LoggerServiceBase
    {
        protected ILogger Logger { get; set; }

        public void Info(string message) => Logger.Information(message);
        public void Error(string message) => Logger.Error(message);
        public void Fatal(string message) => Logger.Fatal(message);
        public void Warn(string message) => Logger.Warning(message);

    }
}
