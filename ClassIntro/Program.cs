namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "Engin";
            int yas = 0;    

            Kurs kurs1 = new Kurs();
            kurs1.Eğitmen = "Engin";
            kurs1.Kursadi = "C#";
            kurs1.IzlenmeOrani = 69;

            Kurs kurs2 = new Kurs();
            kurs2.Eğitmen = "Enver";
            kurs2.Kursadi = "Java";
            kurs2.IzlenmeOrani = 69;

            Kurs kurs3 = new Kurs();
            kurs3.Eğitmen = "Eren";
            kurs3.Kursadi = "Pyhton";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.Eğitmen + ":" + kurs1.Eğitmen);
            //Console.WriteLine(kurs2.Eğitmen + ":" + kurs2.Eğitmen);


            Kurs[] kurslar = new Kurs[] { kurs1, kurs2, kurs3 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.Kursadi + " : " + kurs.Eğitmen);
            }

            Console.WriteLine("Hello, World!");
        }
    }
    class Kurs
    {
        public string Kursadi { get; set; }
        public string Eğitmen { get; set; }
        public int IzlenmeOrani { get; set; }
    }

}
