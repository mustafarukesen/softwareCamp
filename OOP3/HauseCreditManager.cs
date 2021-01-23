using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class HauseCreditManager : ICrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("Konut kredisi odeme plani hesaplandi");
        }

        public void ElseThing()
        {
            throw new NotImplementedException();
        }
    }
}
