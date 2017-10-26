using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cw31
{
    class Car
    {
        private double pojemnoscSilnika;
        private string marka;

        private Car() //konstruktor bez parametrów
        {

        }

        private Car(double pojemnoscSilnika, string marka) //przeciążenie konstruktora poprzez stworzenie nowego konstruktora parametrycznego
        {
            this.pojemnoscSilnika = pojemnoscSilnika; //ustawienie wartości pola
            this.marka = marka; // ustawienie wartości pola
        }

        public void dodajmarke(string marka) // tworzenie obiektu za pomocą konstruktora parametrycznego
        {
            this.marka = marka;
            Console.WriteLine("marka samochody {0}",marka);
        }

        public static Car Create(double pojemnosc, string marka) //Metoda która zwraca obiekt 
        {
            Car temp = new Car(pojemnosc, marka);
            return temp;
        }

        public readonly static int iloscKol; // statyczne pole tylko do odczytu

        static Car() // konstruktor tworzący iloscKol
        {
            iloscKol = 4;
        }
        public const int iloscDrzwi = 4; // pupliczne stale pole iloscDrzwi

        ~Car() //destruktor 
        {
            Console.WriteLine("Zwalniam pamiec");
            Console.ReadKey();
        }
    }
}
