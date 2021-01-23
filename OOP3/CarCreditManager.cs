using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class CarCreditManager : ICrediManager
    {
        public void Calculate()
        {



            Console.WriteLine("Tasit kredisi odeme plani hesaplandi.");
        }

        public void ElseThing()
        {
            throw new NotImplementedException();
        }
    }
}
