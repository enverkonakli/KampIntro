internal class Program
{
    private static void Main(string[] args)
    {
        //type safety = tip güvenliği
        string kategoriEtiketi = "Kategori";
        int ogrenciSayisi = 32000;
        double faizOranı = 1.45;
        bool sistemeGirisYapmismi = false;
        double dolarDun = 7.35;
        double dolarBugun = 7.45;

        if (dolarDun > dolarBugun) 
        {
            Console.WriteLine("Azalış Butonu");
        }
        else if (dolarDun < dolarBugun)
        {
            Console.WriteLine("Artış Butonu");
        }
        else
        {
            Console.WriteLine("Değişmedi");
        }

        if (sistemeGirisYapmismi == true)
        {
            Console.WriteLine("Ayarlar Butonu");
        }
        else 
        {
            Console.WriteLine("Giriş Yap Butonu");
        }



    }
}