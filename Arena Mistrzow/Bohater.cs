namespace Arena_Mistrzow
{
    internal class Bohater
    {
        public class Postac
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

        public class Wojownik : Postac
        {
            private string? imie;
            private int hp;
        }

        public class Łucznik : Postac
        {
            private string? imie;
            private int hp;
        }

        public class Mag : Postac
        {
            private string? imie;
            private int hp;
        }
    }
} 