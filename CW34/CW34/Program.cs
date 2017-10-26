using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW34
{
    class Program
    {
        static void Main(string[] args)
        {
            Samochód samochód1 = new Samochód();
            samochód1.Model = "Fabia";
            samochód1.Marka = "Skoda";

            samochód1.Cena = 5000.24;


            //Console.WriteLine(Double.Parse(samochód1.Cena));
        }        
    }
}

