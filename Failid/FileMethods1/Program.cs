using System.Security.Cryptography.X509Certificates;

namespace FileMethods1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             
            Programm küsib kasutajalt reahaaval luuletuse ridu, küsitakse 4 korda ja kontrollitakse kas kasutaja on sisestanud
            keelatud sõnu, keelatud sõnad ise asuvad loendis, kui kasutaja on sisestanud keelatud sõnu, küsitakse kogu rida
            kasutajal uuesti.
            Kui küsimus on lõppenud küsitakse kasutajalt failinime, ja luuletus salvestatakse faili, pärast salvestus kuvatakse
            failisisu kasutajale tagasi
             
            */
            Console.WriteLine("Sisesta oma luuletus, salvesta see faili ja vaata oma luuletus hiljem üle");
            int riduOlemas = 0;
            string olemasOlevSisu = "";
            while (riduOlemas < 4)
            {
                Console.WriteLine("Luuletuse järgmise rea sisestuseks kirjuta midagi");
                List<string> keelatudSõnad = new List<string>() { "hullumaja", "betty" };
                string hetkeSisestus = "";
                while (hetkeSisestus == "")
                {
                    hetkeSisestus = ReadAnswer();
                    foreach (var ks in hetkeSisestus)
                    {
                        if (hetkeSisestus.Contains(ks))
                        {
                            hetkeSisestus = "";
                            Console.WriteLine("On leitud keelatud sõna, sisestus on tühistatud.");
                        }
                    }
                }
                olemasOlevSisu += "\n"+hetkeSisestus;
                riduOlemas++;
            }
            Console.WriteLine("Sisesta failinimi, kuhu soovid oma luuletuse salvestada: ");
            string failinimi = ReadAnswer();
            string filePath = "C:\\Users\\opilane\\source\\repos\\svernix\\Harjutus\\Failid\\FileMethods1\\" + failinimi + ".txt";
            File.WriteAllText(filePath, olemasOlevSisu);
            DisplayLuuletus(filePath);
        }

        public static void DisplayLuuletus(string location)
        {
            using (StreamReader readluuletus = new StreamReader(location))
            {
                while (readluuletus.EndOfStream == false)
                {
                    Console.WriteLine(readluuletus.ReadLine());
                }
                readluuletus.Close();
            }
        }


        public static string ReadAnswer()
        {
            string vastus = "";
            while (vastus == "")
            {
                Console.WriteLine("Tee vastav sisestus: ");
                vastus = Console.ReadLine();
            }
            return vastus;
        }
    }
}
