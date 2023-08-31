using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        string kurs1 = "Yazılım Geliştirme Yetiştirme Kampı";
        string kurs2 = "Programlamaya Başlamak için Temel Kurs";
        string kurs3 = "Java";
        string kurs4 = "Pyhton";
        string kurs5 = "C#";

        List<string> kurslar = new List<string>();
        kurslar.Add(kurs1);
        kurslar.Add(kurs2);
        kurslar.Add(kurs3);


        foreach (string kurs in kurslar) 
        {
            Console.WriteLine(kurs);
        }

        for (int i = 1; i <= 10; i++)
        {
            Console.WriteLine(i);
        }

        Console.WriteLine("Sayfa Sonu");    
    }
}