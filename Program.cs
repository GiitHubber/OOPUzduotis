using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace OOPUzd
{
    public class Prekes
    { 
        public string[] Preke{ get; set; }
        public int[] Kaina { get; set; }
    }
    public class Siuntos
    {
        public int siuntosKaina;
        public string SiuntosDydis;
        public void SiuntosKaina(int ivedimas)
        {           
            if (ivedimas == 1)
            {
                siuntosKaina = 9;
            }
            else if (ivedimas == 2)
            {
                siuntosKaina = 18;
            }
            else if (ivedimas == 3)
            {
                siuntosKaina = 14;
            }
            else if (ivedimas == 4)
            {
                siuntosKaina = 24;
            }
            else
            {
                Console.WriteLine("Error"); 
            }
        }
        
        public void SiuntosNustatymas(int prekiuKiekis)
        {
            if (prekiuKiekis < 2)
            {
                SiuntosDydis = "S";
                if (prekiuKiekis >= 2 && prekiuKiekis < 5)
                {
                    SiuntosDydis = "M";
                }
            }
            else if (prekiuKiekis >=2 && prekiuKiekis <5)
            {
                SiuntosDydis = "M";
            }
            else if (prekiuKiekis >=5)
            {
                SiuntosDydis = "L";
            }
            else
            {
                SiuntosDydis = "Error";
            }
        }
    public int KainaViso(int krepsioSuma) 
        {
            if (SiuntosDydis == "S")
            {
                return krepsioSuma + siuntosKaina + 10;
            }
            else if (SiuntosDydis == "M")
            {
                return krepsioSuma + siuntosKaina + 22;
            }
            if (SiuntosDydis == "L")
            {
                return krepsioSuma + siuntosKaina + 34;
            }
            else
            {
                return 0;
            }
        }
    }

    class Program 
    {
        static void Main(string[] args)
        {
            int PrekiuKiekis=0;
            int KrepsioSuma;
            List<int> PrekiuKrepselisKaina = new List<int>();
            List<string> PrekiuKrepselisPav = new List<string>();
            Siuntos s = new Siuntos();
            Prekes p = new Prekes();
            #region declare
            p.Preke = new string[10];
            p.Preke[0] = "Lova";
            p.Preke[1] = "Stalas";
            p.Preke[2] = "Komoda";
            p.Preke[3] = "Spintele";
            p.Preke[4] = "Stalelis";
            p.Preke[5] = "Kede";
            p.Preke[6] = "Sofa";
            p.Preke[7] = "Tachta";
            p.Preke[8] = "Stovas";
            p.Preke[9] = "Lentyna";
            p.Kaina = new int[10];
            p.Kaina[0] = 110;
            p.Kaina[1] = 130;
            p.Kaina[2] = 70;
            p.Kaina[3] = 45;
            p.Kaina[4] = 72;
            p.Kaina[5] = 51;
            p.Kaina[6] = 150;
            p.Kaina[7] = 150;
            p.Kaina[8] = 43;
            p.Kaina[9] = 80;
            #endregion declare
            Console.WriteLine("Pasirinkite prekes, is zemiau esancio saraso, Kaina(Eur)");
            Console.WriteLine(" --------------------------------------------");
            Console.WriteLine("¦Siuntos dydis: S - 1preke              10Eur¦" +
            "\n¦               M - nuo 2 iki 4 prekiu  22Eur¦\n¦               L - nuo 5 prekiu        34Eur¦");
            Console.WriteLine(" --------------------------------------------");
            Console.WriteLine("Baigus spausti Enter\n");
            Console.WriteLine("1 - Lova     110\n2 - Stalas   130\n3 - Komoda    70\n4 - Spintele  45\n" +
                "5 - Stalelis  72\n6 - Kede      51\n7 - Sofa     150\n8 - Tachta   150\n9 - Stovas    43\n10- Lentyna   80\n ");
            int i32 = 0;
            for (int i = 0; i < p.Preke.Length; i++)
            {
                Console.Write("> ");
                string ivedimas = (Console.ReadLine());
                if (string.IsNullOrEmpty(ivedimas))
                {
                    break;
                }
                Int32.TryParse(ivedimas, out i32);
                if (i32 == 1)
                {
                    PrekiuKrepselisKaina.Add(p.Kaina[0]);
                    PrekiuKrepselisPav.Add(p.Preke[0]);
                }
                else if (i32 == 2)
                {
                    PrekiuKrepselisKaina.Add(p.Kaina[1]);
                    PrekiuKrepselisPav.Add(p.Preke[1]);
                }
                else if (i32 == 3)
                {
                    PrekiuKrepselisKaina.Add(p.Kaina[2]);
                    PrekiuKrepselisPav.Add(p.Preke[2]);
                }
                else if (i32 == 4)
                {
                    PrekiuKrepselisKaina.Add(p.Kaina[3]);
                    PrekiuKrepselisPav.Add(p.Preke[3]);
                }
                else if (i32 == 5)
                {
                    PrekiuKrepselisKaina.Add(p.Kaina[4]);
                    PrekiuKrepselisPav.Add(p.Preke[4]);
                }
                else if (i32 == 6)
                {
                    PrekiuKrepselisKaina.Add(p.Kaina[5]);
                    PrekiuKrepselisPav.Add(p.Preke[5]);
                }
                else if (i32 == 7)
                {
                    PrekiuKrepselisKaina.Add(p.Kaina[6]);
                    PrekiuKrepselisPav.Add(p.Preke[6]);
                }
                else if (i32 == 8)
                {
                    PrekiuKrepselisKaina.Add(p.Kaina[7]);
                    PrekiuKrepselisPav.Add(p.Preke[7]);
                }
                else if (i32 == 9)
                {
                    PrekiuKrepselisKaina.Add(p.Kaina[8]);
                    PrekiuKrepselisPav.Add(p.Preke[8]);
                }
                else if (i32 == 10)
                {
                    PrekiuKrepselisKaina.Add(p.Kaina[9]);
                    PrekiuKrepselisPav.Add(p.Preke[9]);
                }
                else
                {
                    Console.WriteLine("Error\n");
                    break;
                }
            }
            foreach (var item in PrekiuKrepselisKaina)
            {
                PrekiuKiekis++;
            }
            KrepsioSuma = PrekiuKrepselisKaina.Sum();
            s.SiuntosNustatymas(PrekiuKiekis);
            Console.WriteLine("\nPasirinkite siuntimo buda, Kaina(Eur)\n");
            Console.WriteLine("--------------------------------------\n");
            Console.WriteLine("1 - I namus per pasta         9\n2 - I namus per kurjeri      18\n3 - Pastomatu                14\n4 - Tarptautinis siuntimas   24 ");
            Console.Write("\n> ");         
            int Ivedimas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");
            s.SiuntosKaina(Ivedimas);
            s.KainaViso(KrepsioSuma);
            Console.WriteLine("▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀▄▀");
            Console.Write("\nKrepseli sudaro: ");
            foreach (var item in PrekiuKrepselisPav)
            {
                Console.Write(item+"  ");
            }
            Console.WriteLine("\nKrepselio suma,Eur - " + KrepsioSuma);
            Console.WriteLine("Siuntos dydis - "+s.SiuntosDydis);
            Console.WriteLine("Bendra suma,Eur - "+s.KainaViso(KrepsioSuma)+"\n");
        }
    }
}
