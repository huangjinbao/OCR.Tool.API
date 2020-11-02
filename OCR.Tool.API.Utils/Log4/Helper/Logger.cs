using Microsoft.Extensions.Logging;
using System;

namespace OCR.Tool.API.Utils.Log4.Helper
{
    public class Logger
    {
        private static readonly ILoggerFactory _loggerFactory = null;

        private readonly ILogger _logger = null;

        static Logger()
        {
            var loggerFactory = LoggerFactory.Create(builder =>
            {
                builder.AddFilter("Microsoft", LogLevel.Warning)
                    .AddFilter("System", LogLevel.Warning)
                    .AddLog4Net();
            });

            _loggerFactory = loggerFactory;
        }

        public Logger(Type type)
        {
            _logger = _loggerFactory.CreateLogger(type);
        }

        /// <summary>
        /// Log4日志
        /// </summary>
        /// <param name="msg"></param>
        /// <param name="ex"></param>
        public void Error(string msg = "出现异常", Exception ex = null)
        {
            _logger.LogError(ex, msg);
        }

        /// <summary>
        /// Log4日志
        /// </summary>
        /// <param name="msg"></param>
        public void Warn(string msg)
        {
            _logger.LogWarning(msg);
        }

        /// <summary>
        /// Log4日志
        /// </summary>
        /// <param name="msg"></param>
        public void Info(string msg)
        {
            _logger.LogInformation(msg);
        }

        /// <summary>
        /// Log4日志
        /// </summary>
        /// <param name="msg"></param>
        public void Debug(string msg)
        {
            _logger.LogDebug(msg);
        }
    }
}