using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RailWayCoffee.Infrastructure.Logging
{
    public interface ILogger
    {
        void Info(string message);
        void Acknowledge(string message);
        void Confirm(string message);
        void Diagnose(string message);
        void Error(Exception exception,string message);
        void AliveSignal(string message);
    }
}
