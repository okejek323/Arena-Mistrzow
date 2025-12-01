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
    public void obrazena(Bohater cel)
        {
            Random rnd = new Random();
            int dmg = Sila;
            rnd.Next(0, 4);
            cel.HP -= dmg;
            Console.WriteLine($"{cel.imie} atakauje {dmg} dmg {cel.imie} ma teraz {cel.HP}");
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