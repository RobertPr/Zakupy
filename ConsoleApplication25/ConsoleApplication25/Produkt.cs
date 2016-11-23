using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Produkt : ICloneable
    {
        public string nazwa;
        public int cenaJednostkowa;
        public int ilosc;

        public Produkt(string nazwa, int cenaJednostkowa, int ilosc)
        {
            this.nazwa = nazwa;
            this.cenaJednostkowa = cenaJednostkowa;
            this.ilosc = ilosc;
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }


    }
}
