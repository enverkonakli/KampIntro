namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.Name = "Apple";
            product1.Price = 100;
            product1.Explain = "Apple Like Apple";
            product1.Stock = 4;

            Product product2 = new Product();
            product2.Name = "Cherry";
            product2.Price = 100;
            product2.Explain = "Cherry Like Cherry";
            product2.Stock = 5;

            Product product3 = new Product();
            product3.Name = "Watermelon";
            product3.Price = 75;
            product3.Explain = "Watermelon Like Watermelon";
            product3.Stock = 3;

            Product[] products = new Product[] { product1, product2, product3 };

            foreach (Product product in products) 
            {
                Console.WriteLine(product.Name);
                Console.WriteLine(product.Price);
                Console.WriteLine(product.Explain);
                Console.WriteLine("-----------------------------------------");
            }
            Console.WriteLine("-------------------------------Metotlar----------------------------------------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Add(product1);
            sepetManager.Add(product2);
            sepetManager.Add(product3);


            Console.WriteLine("Hello, World!");
        }
    }
}