using System;
using System.Collections.Generic;
using System.Text;

namespace Jaylosy.Kernel.Log
{
    public class LoggerManager
    {
        string loggerName;
        public string LogFileName
        {
            get
            {
                string s_file = string.Format("log_{0}", DateTime.Now.ToString("yyyyMMdd"));
                if (!string.IsNullOrEmpty(loggerName))
                {
                    s_file = string.Format("{0}_{1}", loggerName, DateTime.Now.ToString("yyyyMMdd"));
                }
                return s_file;
            }
        }
        public LoggerManager(string loggerName)
        {
            this.loggerName = loggerName;
        }
        
        public void Info(string content)
        {
            WriteLog("INFO", content);
        }
        public void Warn(string content)
        {
            WriteLog("WARN", content);
        }
        public void Error(string content)
        {
            WriteLog("ERROR", content);
        }

        void WriteLog(string type,string content)
        {
            File.FileManager fileManager = new File.FileManager();
            string s_content = string.Format("{0}:{1} {2}", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss.fff"),type,content);
            fileManager.WriteText(LogFileName, s_content);
            GC.Collect();
        }
    }
}
