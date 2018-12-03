using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    struct wiz
    {
        public string imie, nazwisko, mail;
        public string tel;
    }

    public static class StringExtensions
    {
        public static string PadBoth(this string str, int length)
        {
            int spaces = length - str.Length;
            int padLeft = spaces / 2 + str.Length;
            return str.PadLeft(padLeft).PadRight(length);
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            wiz os;
            Console.Write("Podaj imię: ");
            os.imie = Console.ReadLine();
            Console.Write("Podaj nazwisko: ");
            os.nazwisko = Console.ReadLine();
            string nazwa = os.imie + " " + os.nazwisko;
            Console.Write("Podaj swojego @: ");
            os.mail = Console.ReadLine();
            string poczta = "e - mail: " + os.mail;
            Console.Write("Podaj swój nr. telefonu komórkowego: ");
            os.tel = Console.ReadLine();
            string tele = "tel. " + os.tel;


            Console.WriteLine("********************************");
            Console.Write("*");
            //dodać wolną przestrzeń
            Console.Write(StringExtensions.PadBoth(nazwa, 30));
            //dodać wolną przestrzeń
            Console.Write("*\n");
            Console.Write("*");
            //dodać wolną przestrzeń
            Console.Write(StringExtensions.PadBoth(poczta, 30));
            //dodać wolną przestrzeń
            Console.Write("*\n");
            Console.Write("*");
            //dodać wolną przestrzeń
            Console.Write(StringExtensions.PadBoth(tele, 30));
            //dodać wolną przestrzeń
            Console.WriteLine("*");
            Console.WriteLine("********************************");




            Console.ReadKey();



        }
    }
}
