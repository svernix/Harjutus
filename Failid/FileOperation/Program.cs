using System.Numerics;

namespace FileOperation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Kirjuta siia oma postkasti aadress");

            //string filePath = "C:\\Users\\opilane\\source\\repos\\svernix\\Harjutus\\Failid\\FileOperation\\postkastiaadress.txt";
            //string aadress = Console.ReadLine();

            //File.WriteAllText(filePath, aadress);

            Console.WriteLine("Kõik laulusõnad");
            //DisplayThisFile();

            FindWord("Viin");
        }
        public static void FindWord(string findThisWord)
        {
            using (StreamReader readFile = new StreamReader("C:\\Users\\opilane\\source\\repos\\svernix\\Harjutus\\Failid\\FileOperation\\Laulusõnad.txt"))
            {
                int lnr = 0;
                while (readFile.EndOfStream == false)
                {
                    string line = readFile.ReadLine();
                    
                    if (line.Contains(findThisWord) == true)
                    {
                        Console.WriteLine(findThisWord+ "leiti reast" + lnr);
                    }
                }
                readFile.Close();
            }

        }


        private static void DisplayThisFile()
        {
            string Line = "";
            try
            {
                using (StreamReader readThisThing = new StreamReader("C:\\Users\\opilane\\source\\repos\\svernix\\Harjutus\\Failid\\FileOperation\\Laulusõnad.txt"))
                {
                    int LineCount = 0;
                    while (readThisThing.EndOfStream == false)
                    {
                        LineCount++;
                        Line = readThisThing.ReadLine();
                        int pikkus = Line.Length;
                        Console.WriteLine(LineCount+" "+Line+" . Reapikkus on"+pikkus);
                    }
                    readThisThing.Close();
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Ei saa lugeda sest:"+e.Message);
                throw;
            }
        }
    }
}
