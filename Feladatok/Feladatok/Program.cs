using Collections;

namespace Feladatok
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1. Filmek hosszát tároló lista
 * - hozz létre egy filmek hosszát (percben) tároló listát az alábbi film hosszakkal:
 *      89, 125, 215, 102, 378, 101, 101, 86, 97, 187
 * - írd ki konzolra az összes filmhosszat a listából
 * 
 */

            /*

            List<int> filmHossz = new List<int>() { 89, 125, 215, 102, 378, 101, 101, 86, 97, 187 };
            foreach (int i in filmHossz)
            {
                Console.WriteLine(i);
            }


            //2. írd ki, hogy hány 'film' van a lsitában

            int counter = filmHossz.Count;
            Console.WriteLine("\n 2.feladat");
            Console.WriteLine(counter);

            //3. írd ki, hogy van-e 101 hosszú film a listában
            Console.WriteLine("\n 3.feladat");

            bool van = false;
            foreach (int i in filmHossz)
            {
                if (i == 101)
                {
                    van = true;
                    break;
                }

            }
            if (van)
            {
                Console.WriteLine("Van");
            }
            else
            {
                Console.WriteLine("Nincs");
            }

            //4. töröld ki a 101 hosszú filmet a listából és ezután írd ki újra a lista tartalmát és hogy jelenleg hány film van a listában
            Console.WriteLine("\n 4.feladat");
            filmHossz.Remove(101);

            foreach (int i in filmHossz)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            counter = filmHossz.Count;
            Console.WriteLine(counter);

            //5. illeszd be a 2. helyre a '123' számot
            Console.WriteLine("\n 5.feladat");
            filmHossz.Insert(1, 123);

            foreach (int i in filmHossz)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //6. keresd meg a '123' hosszú film indexét a listában és irasd ki a konzolra
            Console.WriteLine("\n 6. feladat");
            int index123 = filmHossz.IndexOf(123);
            Console.WriteLine(index123);

            //7. amit a 6-os feladatban kaptál indexet: töröld ki a számot ezen az indexen
            Console.WriteLine("\n 7. feladat");
            filmHossz.RemoveAt(index123);

            Console.WriteLine();

            //8. irasd ki a listában lévő elemeket
            Console.WriteLine("8. feladat");

            foreach (int i in filmHossz)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            //9. fordítsd meg a listában lévő elemek sorrendjét és írasd ki a konzolra újra a lista elemeit
            Console.WriteLine("9. feladat");
            filmHossz.Reverse();

            foreach (int i in filmHossz)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();


            //10. rendezd növekvő sorrendbe a lsta elemeit, és írd ki őkat a konzolra
            Console.WriteLine("10. feladat");
            filmHossz.Sort();

            foreach (int i in filmHossz)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();

            */


            Director jackson = new Director("Jackson");
            Director kurosawa = new Director("Kurosawa");
            Director scott = new Director("Scott");

            Movie abc = new Movie("abc", 123, jackson);
            Movie abcd = new Movie("abcd", 89, jackson);
            Movie samurai = new Movie("samurai", 89, kurosawa);
            Movie alien = new Movie("alien", 117, scott);
            Movie runner = new Movie("runner", 117, scott);

            List<Movie> movies = new List<Movie>();
            movies.Add(abc);
            movies.Add(abcd);
            movies.Add(samurai);
            movies.Add(alien);
            movies.Add(runner);

            Console.WriteLine("\n 13.feladat");
            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine(movies[i].Title);
            }

            Console.WriteLine("\n 14.feladat");

            Console.WriteLine(movies.Count);

            Console.WriteLine("\n 15.feladat");

            bool van = false;
            int indexsamurai = 0;
            for (int i = 0; i < movies.Count; i++) 
            {
                if (movies[i].Title == "samurai") 
                {
                    van = true;
                    Console.WriteLine("Benn van a listában");
                    indexsamurai = i;
                    break;

                }
            }
            if (van) 
            {
                movies.RemoveAt(indexsamurai);
            }


            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine(movies[i].Title);
            }







            Console.WriteLine("\n 16.feladat");
            Director guillermo = new Director("Guillermo");
            Movie pacific = new Movie("pacific rim", 133, guillermo);
            movies.Insert(movies.Count, pacific);

            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine(movies[i].Title);
            }


            Console.WriteLine("\n 17.feladat");

            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine($"{movies[i].Title}   {movies[i].Length}");
            }

            Console.WriteLine("\n 18.feladat");

            int rovid = 1000000000;

            for (int i = 0; i < movies.Count; i++) 
            {
                if (movies[i].Length < rovid)                 
                {
                    rovid = movies[i].Length;
                }
            }
            for (int i = 0; i < movies.Count; i++) 
            {
                if (rovid == movies[i].Length) 
                {
                    Console.WriteLine(movies[i].Title);
                }
            }

            Console.WriteLine("\n 19.feladat");


            int hosszu = 0;

            for (int i = 0; i < movies.Count; i++)
            {
                if (movies[i].Length > hosszu)
                {
                    hosszu = movies[i].Length;
                }
            }
            for (int i = 0; i < movies.Count; i++)
            {
                if (hosszu == movies[i].Length)
                {
                    Console.WriteLine(movies[i].Title);
                }
            }

            Console.WriteLine("\n 20.feladat");

            for (int i = 0; i < movies.Count; i++) 
            {
                if (i == 1) 
                {
                    Console.WriteLine($"{movies[i].Title}   {movies[i].Directo.Name}");
                    break;
                }
            }

            Console.WriteLine("\n 21.feladat");

            int atlag = 0;

            for (int i = 0; i < movies.Count; i++) 
            {
                atlag += movies[i].Length;
            }
            Console.WriteLine(atlag / movies.Count);

            Console.WriteLine("\n 22.feladat");

            string nevhossz = "";
            string afv = "";

            for (int i = 0; i < movies.Count; i++) 
            {
                afv = movies[i].Title;
                if (afv.Length > nevhossz.Length) 
                {
                    nevhossz = afv;
                }
                
            }
            Console.WriteLine(nevhossz);

            Console.WriteLine("\n 23.feladat");

            for (int i = 0; i < movies.Count; i++) 
            {
                Console.WriteLine($"{movies[i].Title}   {movies[i].Length}  {movies[i].Directo.Name}");
            }




        }
    }
}
