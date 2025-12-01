using System.Runtime.ConstrainedExecution;

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
        public void Atak(Bohater cel)
        {
            int dmg = Sila;
            cel.HP -= dmg;
            Console.WriteLine($"{cel.imie} atakauje {dmg} dmg {cel.imie} ma teraz {cel.HP}");
            if (cel.HP <= 0)
            {
                cel.HP = 0;
                Console.WriteLine("Gracz został pokonany");
            }
        }
        public void Ulecz()
        {
            Random rnd = new Random();
            int heal = rnd.Next(25, 51);
            HP += heal;

            Console.WriteLine($"{imie} leczy się o {heal} HP i ma teraz {HP} HP.");
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