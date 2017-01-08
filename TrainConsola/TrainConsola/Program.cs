using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Pociag pociag = new Pociag();
            string m="";

            do
            {
                Console.Clear();
                Console.WriteLine("Aplikacja do skladania pociagow\nCo chcesz zrobic?\n");
                Console.WriteLine("L - dodaj lokomotywe");
                Console.WriteLine("W - dodaj wagon");
                Console.WriteLine("Z - wypisz zawartosc");
                Console.WriteLine("S - sprawdz czy moze jechac");
                Console.WriteLine("E - wyjscie");

                m = Console.ReadLine();

                if (m == "L")
                {
                    bool p = true;
                    Console.Clear();
                    string model="";
                    int masa=0;
                    Console.WriteLine("Dodawanie Lokomotywy\nPodaj model");
                    model = Console.ReadLine();
                    Console.WriteLine("Podaj mase w kg");
                    try
                    {
                        masa = int.Parse(Console.ReadLine());
                        if (masa < 0) throw new ArgumentOutOfRangeException();
                    }
                    catch
                    {
                        Console.WriteLine("Masa musi byc liczba dodatnia");
                        p = false;
                    }


                    if (p == true)
                    {
                        pociag.DodajLokomotywe(masa, model);
                        Console.WriteLine("Dodano lokomotywe");
                    }
                    else
                    {
                        Console.WriteLine("Nie dodano lokomotwywy");
                        Console.ReadLine();
                    }
                }

                if (m == "W")
                {
                    string model = "";
                    int masa = 0;
                    string rodzaj = "";
                    string r;
                    Console.Clear();
                    Console.WriteLine("Dodawanie wagonu\nJakiego rodzaju wagon chcesz dodac?");
                    Console.WriteLine("O - osobowy\nT - towarowy");
                    r = Console.ReadLine();
                    if (r == "O")
                    {
                        Console.Clear();
                        Console.WriteLine("Dodawanie wagonu Osobowego\nPodaj model");
                        model = Console.ReadLine();
                        Console.WriteLine("Podaj mase");
                        masa = int.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj rodzaj wagonu");
                        rodzaj = Console.ReadLine();

                        pociag.DodajOsobowy(masa, model, rodzaj);
                        Console.WriteLine("Dodano wagon osobowy");

                    }

                    if (r == "T")
                    {
                        Console.Clear();
                        Console.WriteLine("Dodawanie wagonu Towarowego\nPodaj model");
                        model = Console.ReadLine();
                        Console.WriteLine("Podaj mase");
                        masa = int.Parse(Console.ReadLine());
                        Console.WriteLine("Podaj ladunek");
                        rodzaj = Console.ReadLine();

                        pociag.DodajTowarowy(masa, model, rodzaj);
                        Console.WriteLine("Dodano wagon towarowy");
                    }
                }

                if (m == "Z")
                {
                    Console.Clear();
                    Console.WriteLine(pociag.Informacje());
                    Console.WriteLine("\nWcisnij dowolny przycisk aby wrocic do menu");
                    Console.ReadLine();
                }

                if (m == "S")
                {
                    Console.Clear();
                    if (pociag.MozeJechac() == true) Console.WriteLine("Moze Jechac");
                    else
                        Console.WriteLine("Nie moze jechac");
                    Console.ReadLine();
                }
            } while (m != "E");
        }
    }
}
