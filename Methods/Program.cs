using System;

namespace Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Cost = 15;
            product1.Explain = "Amasya apple";

            Product product2 = new Product();
            product2.Name = "Watermelon";
            product2.Cost = 80;
            product2.Explain = "Diyarbakır watermelon";

            Product[] products = new Product[] { product1, product2};

            foreach (var product in products)
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Cost);
                Console.WriteLine(product.Explain);
                Console.WriteLine("--------------------------------------");
            }

            Console.WriteLine("----------------------Methods---------------------");
            
            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);

            sepetManager.Add2("Melon", "Yellow", 10, 5);
            sepetManager.Add2("Orange", "Green", 15, 6);
            sepetManager.Add2("Banana", "Red", 20, 7);
        }
    }
}
