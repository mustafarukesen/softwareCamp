using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    //inheratance- : sonrası yaptığımız işin adı
    class CorporateCustomer:Customer
    {

        public string CompanyName { get; set; }
        public string TaxNum { get; set; }
    }
}
