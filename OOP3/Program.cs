using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICrediManager needCreditManager = new NeedCreditManager();
            ICrediManager carCreditManager = new CarCreditManager();
            ICrediManager hauseCreditManager = new HauseCreditManager();

            ILoggerService dataBaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            List<ILoggerService> loggers = new List<ILoggerService>() { new SmsLoggerService(), new FileLoggerService() };

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.ToApply(new TradesmanCreditManager(),loggers);   //, den sonra için yukardaki ikisini yazmayıp new data.. yazabiliriz.


            List<ICrediManager> credits = new List<ICrediManager>() {needCreditManager, carCreditManager };

            //applicationManager.CrediMakePreInformation(credits);


        }
    }
}
