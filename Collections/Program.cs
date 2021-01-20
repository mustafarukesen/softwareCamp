using System;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "mustafa", "Faruk", "Steve", "Dennis" };
            //console.writeline(names[0]);
            //console.writeline(names[1]);
            //console.writeline(names[2]);
            //console.writeline(names[3]);

            //names = new string[5];
            //names[4] = "Ken";
            //console.writeline(names[4]);

            List<string> names2 = new List<string> { "Mustafa", "Faruk", "Steve", "Dennis" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("Ken");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);
            

        }
    }
}
