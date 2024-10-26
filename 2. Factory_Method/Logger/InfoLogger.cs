using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2._Factory_Method.Logger
{
    public class InfoLogger : ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"INFO: {message}");
        }
    }
}
