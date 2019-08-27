using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Jaylosy.Kernel
{
    public class BaseException:System.Exception
    {
        Log.LoggerManager Logger = new Log.LoggerManager("error");
        public BaseException(string message)
            :base(message)
        {
            Logger.Error(message);
        }
        public BaseException()
            :base()
        {

        }

        public BaseException(string message, Exception innerException)
            :base(message,innerException)
        {
            Logger.Error(message);
            if (innerException != null)
            {
                Logger.Error(innerException.ToString());
            }
        }
        public override string HelpLink
        {
            get
            {
                return base.HelpLink;
            }
            set
            {
                base.HelpLink = value;
                Logger.Error(base.HelpLink);
            }
        }
        public override string Source
        {
            get
            {
                return base.Source;
            }
            set
            {
                base.Source = value;
                Logger.Error(base.Source);
            }
        }

        public override string Message
        {
            get
            {
                Logger.Error(base.Message);
                return base.Message;
            }
        }

        public override string StackTrace
        {
            get
            {
                Logger.Error(base.StackTrace);
                return base.StackTrace;
            }
        }
    }
}
