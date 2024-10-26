using _2._Factory_Method.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._Factory_Method.LoggerFactory
{
    public interface ILoggerFactory
    {
        public ILogger createLogger();
    }
}
