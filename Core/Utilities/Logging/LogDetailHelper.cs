using Core.CrossCuttingConcerns.Logging;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Core.Utilities.Logging
{
    public static class LogDetailHelper
    {
        public static string GetLogDetails<T>(string methodName, PropertyInfo[] properties, T obj)
        {
            LogDetail logDetail = new LogDetail();
            logDetail.MethodName = methodName;

            List<LogParameter> parameters = new List<LogParameter>();
            foreach (var item in properties)
            {
                parameters.Add(new LogParameter() { Name = item.Name, Value = item.GetValue(obj) });
            }
            logDetail.LogParameters = parameters;
            return JsonConvert.SerializeObject(logDetail);
        }
    }
}
