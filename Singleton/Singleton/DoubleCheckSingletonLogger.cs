using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class DoubleCheckSingletonLogger
    {
        private static DoubleCheckSingletonLogger _instance;
        private static readonly object _lock = new object();

        private DoubleCheckSingletonLogger() 
        {
           
            Console.WriteLine("DoubleCheckSingletonLogger: in");
          
        }

        public static DoubleCheckSingletonLogger Instance
        {
            get
            {
                if (_instance == null)
                {
                    lock (_lock)
                    {
                        if (_instance == null)
                        {
                            _instance = new DoubleCheckSingletonLogger();
                        }
                    }
                }
                return _instance;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine("DoubleCheck: " + message);
        }
    }
}
