using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ProductService
{
    class Logger
    {
        private static Logger logInstance = null;
        private FileStream fs;
        private StreamWriter sw;
        private Logger()
        {
            fs = new FileStream("c:\\Logging.txt", FileMode.Append, FileAccess.Write);
            sw = new StreamWriter(fs);
        }
        public static Logger getInstance()
        {
            if (logInstance == null)
                logInstance = new Logger();

            return logInstance;
        }
        public void LogMessage(String messages)
        {
            sw.WriteLine(messages);
            sw.Flush();
        }
    }
}
