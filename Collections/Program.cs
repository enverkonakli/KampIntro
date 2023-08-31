namespace Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] isimler = { "Enver", "Murat", "Kenan", "Selen" };
            Console.WriteLine(isimler[0]);
            Console.WriteLine(isimler[1]);
            Console.WriteLine(isimler[2]);
            Console.WriteLine(isimler[3]);

            Console.WriteLine("----------------------------------------------");
            List<string> isimler2 = new List<string>(); 
            foreach (string s in isimler) 
            {
                isimler2.Add(s);
                Console.WriteLine(s);
            }
        }
    }
}