using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication25
{
    class Aplikacja 
    {
        public string klawisz;

        public void WczytajKlawisz()
        {
            Console.WriteLine("Dzień dobry! \nCo chesz zrobic? Nacisnij odpowiedni klawisz. \nP - dodaj produkt do koszyka \nK - skopiuj ostatnio wprowadzony produkt \nZ - pokaz zawartosc koszyka \nS - pokaz sume do zaplaty");
            Console.WriteLine("X - skasuj produkt z listy (musisz wczesniej znac numer na liscie \nW - wydrukuj paragon \nN - dodaj nowy koszyk \nE - zakoncz dzialanie programu");

            this.klawisz = Convert.ToString(Console.ReadLine());
        }

        public void WykonajDzialanie()
        {
            switch (klawisz)
            {
                case "P":
                Produkt p1 = new Produkt("nazwa", cenaJednostkowa, ilosc);
                break;
 
                case "K":
                Clone(); 
                break;
 
                case "Z":
                
                break;

                case "S":
                    
                break;

                case "X":
                    
                break;
                
                case "W":
                    
                break;
                
                case "N":
                
                break;
                
                case "E":
                    
                break;
 
                default:
                    Console.WriteLine("Zly przycisk\n");
                    WczytajKlawisz();
                    WykonajDzialanie();
                break;       
            }
        }
    }
}
