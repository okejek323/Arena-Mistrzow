using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arena_Mistrzow
{
    internal class Bohater
    {
        class Postac
        {
            private string imie;
            private int HP;
            public string zmienne() 
            {
                return "0";
            }
        }
        class Wojownik : Postac {
            imie = "Wojownik";
            private int HP;
        }
        class Łucznik : Postac
        {
            imie = "Łucznik";
            private int HP;
        }
        class Mag : Postac
        {
            imie = "Mag";
            private int HP;
        }
    }
}