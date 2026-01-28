



namespace meetoditetöö
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tervitus();//tervitus

            double summa = SumNumbers(); //arvuta kokku
            Console.WriteLine("rrvude summa:" + summa);

            Console.WriteLine("sisesta oma nime:");//küsin nimi
            string name = Console.ReadLine();
            int letters = CountLetters(name);
            Console.WriteLine("tähtede arv nimes: " + letters);

            Console.WriteLine("mis kiirus sa sõitsid?");//küsin kiirus
            int kiirus = int.Parse(Console.ReadLine());
            string tekst = KiirusTekst(kiirus);
            Console.WriteLine(tekst);


        }

        private static string KiirusTekst(int kiirus)
        {
            if (kiirus >= 20 && kiirus < 40)
            {
                Console.WriteLine("ainult poodi jõudsid");
            }
            if (kiirus >= 40 && kiirus < 60)
            {
                Console.WriteLine("üle linna kõndisid");
            }
            if (kiirus >= 60 && kiirus <= 100)
            {
                Console.WriteLine("ebanimilikult kaugele jõudsid");
            }
              

            
        }

        private static int CountLetters(object name)
        {
            Console.WriteLine($"{name}");
        }

        private static double SumNumbers()
        {
            double a = 2.5;
            double b = 3.5;
            double c = 4.0;
            double d = 4.5;
            double e = 5.0;

            return a + b + c + d + e;
        }

        private static void Tervitus()
        {
            Console.WriteLine("Tere kasutaja!");
        }
        
    }
}
