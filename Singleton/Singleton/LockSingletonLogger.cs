using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class LockSingletonLogger
    {
        private static LockSingletonLogger _instance;
        private static readonly object _lock = new object();

        private LockSingletonLogger() 
        {
      
            Console.WriteLine("DoubleCheckSingletonLogger: in");
          
        }

        public static LockSingletonLogger Instance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new LockSingletonLogger();
                    }
                    return _instance;
                }
            }
        }

        public void Log(string message)
        {
            Console.WriteLine("Lock: " + message);
        }
    }
}
