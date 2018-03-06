using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailWayCoffee.Infrastructure.Logging
{
    public class NLogLogger : ILogger
    {
        private NLog.Logger Logger = null;
        public NLogLogger()
        {
            Logger = NLog.LogManager.GetCurrentClassLogger();
        }

        public void Error(Exception exception, string message)
        {
            Logger.Error(exception, message);
        }

        public void Info(string message)
        {
            Logger.Info(message);
        }
        public void Acknowledge(string message)
        {

        }

        public void AliveSignal(string message)
        {
            throw new NotImplementedException();
        }

        public void Confirm(string message)
        {
            throw new NotImplementedException();
        }

        public void Diagnose(string message)
        {
            throw new NotImplementedException();
        }


    }
}
