using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class BasicSingletonLogger
    { 
        /// <summary>
        /// when i use multithread 
        /// No thread safe
        /// solution -> eager or lazy
        /// </summary>
        private static BasicSingletonLogger _instance;
 

        private BasicSingletonLogger() 
        {
            
            Console.WriteLine("BasicSingletonLogger: in ");
          
          
        }

        public static BasicSingletonLogger Instance
        {
            get
            {
                if (_instance == null)
                {
                   
                    _instance = new BasicSingletonLogger();
                   
                }
                return _instance;
            }
        }

        public void Log(string message)
        {
            Console.WriteLine("Basic: " + message);
        }
    }



    public class EagerSingletonLogger
    {
        /// <summary>
        /// thread safe 
        /// print all in constructor first after that print threads
        /// </summary>
        private static readonly EagerSingletonLogger _instance = new EagerSingletonLogger();

        private EagerSingletonLogger()
        {
        
            Console.WriteLine("EagerSingletonLogger: in");
           

        }

        public static EagerSingletonLogger Instance
        {
            get { return _instance; }
        }

        public void Log(string message)
        {
            Console.WriteLine("Eager: " + message);
        }
    }




    public class LazySingletonLogger
    {
        private static readonly Lazy<LazySingletonLogger> _instance =
            new Lazy<LazySingletonLogger>(() => new LazySingletonLogger());

        private LazySingletonLogger() 
        {

            Console.WriteLine("LazySingletonLogger: in");
    
        }

        public static LazySingletonLogger Instance
        {
            get { return _instance.Value; }
        }

        public void Log(string message)
        {
            Console.WriteLine("Lazy: " + message);
        }
    }
}

