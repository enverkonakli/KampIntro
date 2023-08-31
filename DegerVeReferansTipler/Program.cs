namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int sayi1 =10; int sayi2 =30;
            sayi1 = sayi2;
            sayi2 = 63;
            //sayi1?

            int[] sayilar1 = new int[] { 10, 23, 30 };
            int[] sayilar2 = new int[] { 100, 200, 3000 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            // sayilar1[0]?



        }
    }
}