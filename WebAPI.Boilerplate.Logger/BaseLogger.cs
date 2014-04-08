using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI.Boilerplate.Logger
{
    public abstract class BaseLogger
    {
        string clientLoggerIdentifier;
        ILog logger;

        public BaseLogger()
        {
            //This will have a multi tenancy code
            log4net.Config.XmlConfigurator.Configure();
            this.clientLoggerIdentifier = "LogFileAppender";
            this.logger = LogManager.GetLogger(this.clientLoggerIdentifier);
        }

        public ILog Logger
        {
            get { return this.logger; }
        }
    }
}
