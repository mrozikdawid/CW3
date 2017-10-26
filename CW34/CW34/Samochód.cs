using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW34
{
    class Samochód
    {
        private string model;

        public string Model
        {
            get => model;
            set => model = value;
        }

        private double cena;

        public double Cena 
        {
            get { return cena; }
            set { cena = value; }
        }

        private string marka;

        public string Marka
        {
            get { return marka; }
            set { marka = value; }
        }

    }
}
