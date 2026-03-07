namespace Singleton
{
    internal class Program
    

    {
        static void Main(string[] args)
        {

            //BasicSingletonLogger.Instance.Log("Transaction Created");
         

            // LockSingletonLogger.Instance.Log("Transaction Approved");

            //  DoubleCheckSingletonLogger.Instance.Log("Transaction Completed");

            // EagerSingletonLogger.Instance.Log("Transaction Saved");
         

            //   LazySingletonLogger.Instance.Log("Transaction Updated");

            //  GenericSingletonLogger.Instance.Log("Transaction Deleted");


            Parallel.For(0,4, i =>
                {
                    var logger = BasicSingletonLogger.Instance;
                    logger.Log($"MultiThread {i+1}");
                });
         



            Console.ReadLine();


          



            
            
            
            
        }
    }
}

