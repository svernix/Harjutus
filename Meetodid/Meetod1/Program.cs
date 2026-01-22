using System.Security.Cryptography.X509Certificates;

namespace Meetod1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> filmid = GetMovies();
            Console.WriteLine("Milline on sinu lemmikfilm");
            string lemmikFilm = ReadAnswer();
            DoesMovieExist(filmid, lemmikFilm);
            filmid = DoYouLikeThisMovie(filmid, "Tron 1983");
            //foreach (string item in filmid)
            //{
            //    Console.WriteLine(item);
            //}
            List<string> otsitavadFilmid = new List<string> { "Terminator", "Vanamehe Film", "Kratt" };
            IdentifyMovies(filmid,otsitavadFilmid);
            


        }

        public static void IdentifyMovies(List<string> collection, List<string> filter)
        {
            string messages = "";
            foreach (var movie in collection)
            {
                int itemnr = 0;
                foreach (var filterItem in filter)
                {
                    if (itemnr ==  0)
                    {
                        messages += "I'll be back. \n";
                    }
                    else if (itemnr == 1)
                    {
                        messages += "Šnikurs\n";
                    }
                    else if (itemnr == 2)
                    {
                        messages += "Vaata et ta sul tehisplära ajama ei hakka\n";
                    }
                    itemnr++;
                }
                itemnr = 0;
            }
            Console.WriteLine(messages);
        }

        public static List<string> DoYouLikeThisMovie(List<string> collection, string movieToAdd)
        {
            if (collection.Contains(movieToAdd) == false)
            {
                Console.WriteLine($"Kas sulle meeldib{movieToAdd}?");
                string vastus = ReadAnswer();

                if(vastus == "jah")
                {
                    collection.Add(movieToAdd);
                    Console.WriteLine("Lisasin filmi sulle");
                }
                else
                {
                    Console.WriteLine("Aga miks? See on ju hea film");
                }

            }
            return collection;
        }


        public static void DoesMovieExist(List<string> collection, string findThis)
        {
            bool itExists = false;
            foreach (string item in collection)
            {
                if (item == findThis)
                {
                    itExists = true;
                }
            }
            if ( itExists == true)
            {
                Console.WriteLine("Näe mäletasid ikka!");
            }
            else
            {
                Console.WriteLine("a kus on sinu lemmikfilm");
            }
        }

        public static string ReadAnswer()
        {
            string sisend = "";
            while (sisend == "")
            {
                sisend = Console.ReadLine();
            }
            return sisend;
        }


        public static List<string> GetMovies()
        {
            Console.WriteLine("Mis on su lemmikfilmid, sisesta üks haaval, kui sisestada rohkem ei taha\n sisesta \"ei ole\"");
            string sisestus = "";
            List<string> siinOnFilmid = new List<string>();
            while (sisestus != "ei ole")
            {
                Console.Write("Järgmine film:");
                sisestus = Console.ReadLine();
                if (sisestus != "ei ole")
                {
                    siinOnFilmid.Add(sisestus);
                }
            }
            return siinOnFilmid;


            //string kasutajaNimi = "Paul";
            //string salasõna = "1234";
            //while (kasutajaNimi == "Paul")
            //{
            //    Console.WriteLine("Mis on sinu nimi?");
            //    kasutajaNimi = Console.ReadLine();
            //    if (kasutajaNimi == "Paul")
            //    {
            //        Console.WriteLine("Kasutaja nimi on õige");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Isik pole registeeritud");
            //    }

            //    Console.WriteLine("Mis on parool");
            //    salasõna = Console.ReadLine();
            //    if (salasõna == "1234")
            //    {
            //        Console.WriteLine("Parool on õige");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{kasutajaNimi} parool on vale");
            //    }

            //}

            //string[] loomad = new string[3];

            //int loend = 0;

            //while (loend < loomad.Length)
            //{
            //    Console.WriteLine($"Sisesta oma{loend + 1} lemmikloom nimi");
            //    loomad[loend] = Console.ReadLine();
            //    loend++;
            //}

            //Console.WriteLine($"Sa sisestasid {loend} lemmiklooma nimed");

            //int valik = 0;

            //do
            //{
            //    Console.WriteLine("Milline neist on su lemmikuim? (vali number 1-3)");
            //    valik = int.Parse(Console.ReadLine());
            //} while (valik < 1 || valik > 3);
            //Console.WriteLine($"Sinu lemmikuim loom on: {loomad[valik - 1]}");
        }
    }
}
