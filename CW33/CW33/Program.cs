using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW33
{
    class Program
    {
        static string OpiszTyp()//Metoda zwraca string METODA BEZ ARGUMENTÓW
        {
            return "Metoda bez argumentów";
        }
        static string OpiszTyp(int x)//jeśli podamy liczbe całkowita metoda zwraca napis liczba całkowita
        {
            return "Liczba całkowita";
        }
        static string OpiszTyp(string x)// jeśli podamy ciag znaków metoda zwraca napis łańcuch znaków
        {
            return "Łańcuch znaków"; 
        }
        static string OpiszTyp(int x, int y)// jeśli podamy 2 liczby całkowite metoda zwraca napis DWIE LICZBY CAŁKOWITE
        {
            return "Dwie liczby calkowite";
        }
        static void Main(string[] args)
        {
            Console.WriteLine(OpiszTyp());//Wywołanie wszystkich metod
            Console.WriteLine(OpiszTyp(5));
            Console.WriteLine(OpiszTyp("sdds"));
            Console.WriteLine(OpiszTyp(4, 5));

            Console.ReadKey();
        }
    }
}
