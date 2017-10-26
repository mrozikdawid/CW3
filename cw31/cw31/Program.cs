using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw31
{
    class Program
    {
        static void Main(string[] args)
        {
            //Car car1 = new Car(); tworznie obiektu
            //car1.pojemnoscSilnika = 1999.9; dodawanie wartości        
            //car1.marka = "Ford"; dodawanie wartości do obiektu

            //Car car2 = new Car(); tworznie obiektu 
            //car2.dodajmarke("mercedes"); dodawanie wartości do obiektu z pomocą konstruktora

            Car car3 = Car.Create(233,"Skoda"); //stworzenie obiektu poprzez metode create

            Console.ReadKey();



        }
    }
}
