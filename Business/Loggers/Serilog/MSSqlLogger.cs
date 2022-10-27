using Core.CrossCuttingConcerns.Logging;
using Serilog;
using Serilog.Sinks.MSSqlServer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Loggers.Serilog
{
    public class MSSqlLogger : LoggerServiceBase
    {
        public MSSqlLogger()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Logger;";

            var sinkOptions = new MSSqlServerSinkOptions() { TableName="Logs",AutoCreateSqlTable=true };

            var columnOpts = new ColumnOptions();
            columnOpts.Store.Remove(StandardColumn.Message);
            columnOpts.Store.Remove(StandardColumn.Properties);

            Logger = new LoggerConfiguration()
                .WriteTo
                .MSSqlServer(connectionString: connectionString, sinkOptions: sinkOptions,columnOptions:columnOpts)
                .CreateLogger();
        }
    }
}
