using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class TradesmanCreditManager : ICrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("Esnaf kredisi odeme plani hesaplandi.");
        }

        public void ElseThing()
        {
            throw new NotImplementedException();
        }
    }
}
