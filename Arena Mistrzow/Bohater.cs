namespace Arena_Mistrzow
{
        public class Bohater
        {
            private string imie;
            private int hp;

            public string Imie
            {
                get { return imie; }
                set { imie = value; }
            }

            public int HP
            {
                get { return hp; }
                set { hp = value; }
            }
        }

        public class Wojownik : Bohater
    {
            private string? imie;
            private int hp;
        }

        public class Łucznik : Bohater
    {
            private string? imie;
            private int hp;
        }

        public class Mag : Bohater
    {
            private string? imie;
            private int hp;
        }
    }