namespace Arena_Mistrzow
{
    public class Bohater
    {
        private string imie;
        private int hp;
        private int sila;
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

        public int Sila
        {
            get { return sila; }
            set { sila = value; }
        }
    }

    public class wojownik : Bohater
    {
        private string? imie;
        private int hp;
        private int sila;
    }

    public class łucznik : Bohater
    {
        private string? imie;
        private int hp;
        private int sila;
    }

    public class mag : Bohater
    {
        private string? imie;
        private int hp;
        private int sila;
    }
}