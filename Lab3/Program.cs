using System;
using System.Collections.Generic;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. feladat
            /*
            int index = 0;
            string[] szam = { "2", "3", "4", "5", "6", "7", "8", "9","10", "Jumbó", "Dáma", "Király", "Ász" };
            string[] szin = { "Kör", "Káró", "Treff", "Pikk" };
            string[] lapok = new string[52];
            for (int i = 0; i < szin.Length; i++)
            {
                for (int j = 0; j < szam.Length; j++)
                {
                    lapok[index] = szin[i] + " " + szam[j];
                    index++;
                }
            }
            /*
            #endregion
            #region 2. feladat
            /*
            Random rnd = new Random();
            for (int i = 0; i < lapok.Length - 1; i++)
            {
                int j = rnd.Next(i, lapok.Length);
                string temp = lapok[i];
                lapok[i] = lapok[j];
                lapok[j] = temp;
            }
            for(int i = 0;i < lapok.Length; i++)
            {
                Console.WriteLine(lapok[i]);
            }
            */
            #endregion
            #region 3. feladat
            /*
            string[] words = new string [5];
            for(int i = 0;i < 5; i++)
            {
                Console.Write("{0}/5 Adj meg egy szót: ", i+1);
                words[i] = Console.ReadLine();
            }
            Console.Write("Add meg a keresett szót: ");
            string answer = Console.ReadLine();
            int j = 0;
            while(j< words.Length && words[j] != answer)
            {
                j++;
            }
            if( j < words.Length ) Console.WriteLine("A szó benne van a {0} helyen", j+1);
            else Console.WriteLine("A szó nincs benne");
            */
            #endregion
            #region 4. feladat
            /*
            List<string> list = new List<string>();
            string answer = "";
            do
            {
                Console.Write("Adj meg egy szót vagy írd be azt hogy STOP: ");
                answer = Console.ReadLine();
                list.Add(answer);
            } while (answer != "STOP");
            int j = 0;
            Console.Write("Add meg melyik szóra keressek: ");
            string keresett_szo = Console.ReadLine();
            while (j < list.Count && list[j] != keresett_szo)
            {
                j++;
            }
            if (j < list.Count) Console.WriteLine("A szó benne van a {0} helyen", j + 1);
            else Console.WriteLine("A szó nincs benne");
            */
            #endregion
            #region 5. feladat
            /*
            List<string> nev = new List<string>();
            List<int> eletkor = new List<int>();
            List<bool> tapasztalat = new List<bool>();
            for(int i = 0; i < 3; i++)
            {
                Console.Write("{0}/3 Add meg a nevedet ", i+1);
                nev.Add(Console.ReadLine());
                Console.Write("{0}/3 Add meg az életkorod ", i+1);
                eletkor.Add(int.Parse(Console.ReadLine()));
                Console.Write("{0}/3 Add meg a tapasztalatod (i/n) ", i+1);
                string answ = Console.ReadLine();
                if (answ == "i") tapasztalat.Add(true);
                if (answ == "n") tapasztalat.Add(false);
            }
            int atlag = 0;
            foreach(var item in eletkor)
            {
                atlag += item;
            }
            atlag /= eletkor.Count;
            Console.WriteLine("Az átlag: " + atlag);
            int atlag_tapasztalatlan = 0;
            count = 0;
            for(int i = 0; i < nev.Count; i++)
            {
                if (tapasztalat[i] == false)
                {
                    atlag_tapasztalatlan += eletkor[i];
                    count++;
                }
            }
            atlag_tapasztalatlan /= count;
            Console.WriteLine("A tapasztalatkanok átlaga: " + atlag_tapasztalatlan);
            string legidősebb_nev = "";
            int legidosebb_eletkor = 0;
            for(int i = 0; i< nev.Count; i++)
            {
                if (eletkor[i]> legidosebb_eletkor && tapasztalat[i] == true)
                {
                    legidősebb_nev = nev[i];
                    legidosebb_eletkor = eletkor[i];
                }
            }
            Console.WriteLine("A legidősebb programozó neve: {0}, életkora: {1}", legidősebb_nev, legidosebb_eletkor);
            */
            #endregion
            #region 6. feladat
            /*
            Random rnd = new Random();
            int n = rnd.Next(2, 10);
            int m = rnd.Next(2, 10);
            int[,] matrix = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    int szam = rnd.Next(-9, 10);
                    matrix[i, j] = szam;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("");
            int[,] forditott = new int[m,n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    forditott[j,i] = matrix[i,j];
                }
            }
            for (int i = 0; i < forditott.GetLength(0); i++)
            {
                for (int j = 0; j < forditott.GetLength(1); j++)
                {
                    Console.Write(forditott[i, j] + "\t");
                }
                Console.WriteLine("");
            }
            */
            #endregion
            #region 7. feladat
            /*
            Random rnd = new Random();
            int sor = rnd.Next(2, 6);
            int oszlop = rnd.Next(2, 6);
            int[,] adatok = new int[sor, oszlop];
            for (int i = 0; i < sor; i++)
            {
                for (int j = 0; j < oszlop; j++)
                {
                    adatok[i, j] = rnd.Next(0, 6);
                    Console.Write(adatok[i, j] + "\t");
                }
                Console.WriteLine("");
            }
            int hal = 0;
            for (int i = 0; i < sor; i++)
            {
                for (int j = 0; j < oszlop; j++)
                {
                    if (adatok[i, j] > 0)
                    {
                        hal += adatok[i, j];
                    }
                }
                Console.WriteLine("{0}. halból ennyit fogtak: {1} ", i + 1, hal);
                hal = 0;
            }
            int legjobbHorgasz = 0;
            int halakÖsszesen = 0;
            int legtobbHal = 0;
            bool legrosszabbHorgasz = false;
            for(int i = 0;i < oszlop; i++)
            {
                for(int j = 0; j < sor; j++)
                {
                    halakÖsszesen += adatok[j, i];
                }
                if(halakÖsszesen > legtobbHal)
                {
                    legtobbHal = halakÖsszesen;
                    legjobbHorgasz = i;
                }
                if(halakÖsszesen == 0)
                {
                    legrosszabbHorgasz = true;
                }
                halakÖsszesen = 0;
            }
            Console.WriteLine("A legjobb horgász: {0} ", legjobbHorgasz+1);
            if(legrosszabbHorgasz == true) Console.WriteLine("Volt olyan horgász, aki nem fogott semmit");
            else Console.WriteLine("Nem volt olyan horgász, aki semmit nem fogott");
            */
            #endregion
            #region 8. feladat
            /*
            Console.Write("Adj egy pozítív egész számot: ");
            int szam = int.Parse(Console.ReadLine());
            List<int> list = new List<int>();
            list.Add(szam);
            int i = 1;
            while (list[i-1] != 1)
            {
                if (list[i - 1] % 2 == 0) list.Add(list[i - 1] / 2);
                else list.Add(list[i - 1] * 3 + 1);
                Console.WriteLine(list[i]);
                i++;
            }
            */
            #endregion
            #region 9. feladat
            /*
            int[] x = { 1, 2, 3, 4, 5, 6, 7, 8 };
            for (int i = 0; i < x.Length; i++)
            {
                int tmp = x[i];
                x[i] = x[x.Length - i - 1];
                x[x.Length - 1 - i] = tmp;
            }
            for (int i = 0; i < x.Length; ++i)
            {
                Console.Write(x[i] + " ");
            }
            Console.WriteLine(x[x.Length - 0 - 1]);
            */
            #endregion
            Console.ReadKey();
        }
    }
}
