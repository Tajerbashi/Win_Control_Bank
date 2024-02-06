using Infrastructure.Library.Models.DTOs.SEC;
using log4net;
using Microsoft.Extensions.Logging;
using System;

namespace Presentation.Extentions
{
    public class LoggerProvider<T>
        where T : class
    {
        private readonly ILog _log = LogManager.GetLogger(typeof(T));
        public void Logger(LogLevel level, string Message)
        {
            switch (level)
            {
                case LogLevel.Debug:
                    {
                        _log.Debug(Message);
                        break;
                    }
                case LogLevel.Information:
                    {
                        _log.Info(Message);
                        break;
                    }
                case LogLevel.Error:
                    {
                        _log.Error(Message);
                        break;
                    }
                case LogLevel.Warning:
                    {
                        _log.Warn(Message);
                        break;
                    }
                default:
                    {
                        _log.Warn(Message);
                        break;
                    }
            }
        }
        public void Logger(LogLevel level, Exception exception)
        {
            switch (level)
            {
                case LogLevel.Debug:
                    {
                        _log.Debug(exception);
                        break;
                    }
                case LogLevel.Information:
                    {
                        _log.Info(exception);
                        break;
                    }
                case LogLevel.Error:
                    {
                        _log.Error(exception);
                        _log.Logger.Repository.Shutdown();
                        break;
                    }
                case LogLevel.Warning:
                    {
                        _log.Warn(exception);
                        break;
                    }
                default:
                    {
                        _log.Warn(exception);
                        break;
                    }
            }
        }

    }
}
