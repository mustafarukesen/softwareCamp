using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    //Method injection
    class ApplicationManager
    {
        public void ToApply(ICrediManager crediManager, List<ILoggerService> loggerServices)
        {
            //Başvuran bilgilerini değerlendirme
            //
            crediManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }
        }

        public void CrediMakePreInformation(List<ICrediManager> credits)
        {
            foreach (var credi in credits)
            {
                credi.Calculate();
            }
        }
    }
}
