using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculator.Extensions
{
    internal static class LoggerWrapper
    {
        /**
         * TODO: debug ビルドの場合はConsoleAppender
         * release ビルドの場合はFileAppenderを使うよう切り替えてください
         */
        internal static ILog GetLogger(Type type)
        {
#if DEBUG
            return LogManager.GetLogger(type);
#else
            return
#endif
        }
    }
}
