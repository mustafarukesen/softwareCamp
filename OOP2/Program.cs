using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNum = "12343";
            customer1.Name = "Mustafa Faruk";
            customer1.SurName = "ESEN";
            customer1.TcNum = "2423424234";


            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNum = "234234";
            customer2.CompanyName = "EsenCompany";
            customer2.TaxNum = "12312313132";


            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();

            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);
            customerManager.Add(customer2);

        }
    }
}
