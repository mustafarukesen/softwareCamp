﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class NeedCreditManager : ICrediManager
    {
        public void Calculate()
        {
            Console.WriteLine("Ihtiyac kredisi odeme plani hesaplandi");
        }

        public void ElseThing()
        {
            throw new NotImplementedException();
        }
    }
}
