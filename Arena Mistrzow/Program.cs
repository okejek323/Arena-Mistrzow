using Arena_Mistrzow;
using System.ComponentModel.Design;

Bohater Gracz1 = null; //zmienna dla Gracz1
Bohater Gracz2 = null; //zmienna dla Gracz2

Random rnd1 = new Random(); //w przyszłości
Random rnd2 = new Random();

bool alive = true;
bool start1 = true;
bool start2 = true;
 

//Wybór Gracza 1
Console.WriteLine("Gracz 1 wybierz klase postaci: ");
Console.WriteLine("1 - Wojownik");
Console.WriteLine("2 - Łucznik");
Console.WriteLine("3 - Mag");

string? wybór1 = Console.ReadLine();

while (start1)
{
    switch (wybór1)
    {
        case "1":
            Console.WriteLine("Wybrano Wojownika");
            Gracz1 = new wojownik();
            Gracz1.Imie = "Wojownik";
            Gracz1.HP = 150;
            Gracz1.Sila = rnd2.Next(25, 51);
            break;
        case "2":
            Console.WriteLine("Wybrano Łucznik");
            Gracz1 = new łucznik();
            Gracz1.Imie = "Łucznik";
            Gracz1.HP = 100;
            Gracz1.Sila = rnd2.Next(40, 61);
            break;
        case "3":
            Console.WriteLine("Wybrano Mag");
            Gracz1 = new mag();
            Gracz1.Imie = "Mag";
            Gracz1.HP = 75;
            Gracz1.Sila = rnd2.Next(50, 61);
            break;
    }
    start1 = false;
}

//Wybór Gracza 2
Console.Clear(); //Czyszczenie by konsola była przejrzysta
Console.WriteLine("Gracz 2 wybierz klase postaci: ");
Console.WriteLine("1 - Wojownik");
Console.WriteLine("2 - Łucznik");
Console.WriteLine("3 - Mag");

string? wybór2 = Console.ReadLine();

while (start2)
{
    switch (wybór2)
    {
        case "1":
            Console.WriteLine("Wybrano Wojownika");
            Gracz2 = new wojownik();
            Gracz2.Imie = "Wojownik";
            Gracz2.HP = 150;
            Gracz2.Sila = rnd2.Next(25,51);
            break;
        case "2":
            Console.WriteLine("Wybrano Łucznik");
            Gracz2 = new łucznik();
            Gracz2.Imie = "Łucznik";
            Gracz2.HP = 100;
            Gracz2.Sila = rnd2.Next(40, 61);
            break;
        case "3":
            Console.WriteLine("Wybrano Mag");
            Gracz2 = new mag();
            Gracz2.Imie = "Mag";
            Gracz2.HP = 75;
            Gracz2.Sila = rnd2.Next(50, 61);
            break;
    }
    start2 = false;
}

//Metoda by skrócić kod
void Walka(Bohater Gracz1, Bohater Gracz2)
{
    Console.WriteLine("Wybierz swój ruch: ");
    Console.WriteLine("1 - Atak");
    Console.WriteLine("2 - Ulecz");

}

Console.Clear();  //Czyszczenie by konsola była przejrzysta
Console.WriteLine($"Gracz 1 wybrał {Gracz1.Imie}\n");
Console.WriteLine($"Gracz 2 wybrał {Gracz2.Imie}");

//Główna część gry
while (alive)
{
    Walka(Gracz1, Gracz2);
    Gracz1.Atak(Gracz2);
    if (Gracz2.HP <= 0)
    {
        Console.WriteLine("\n {Gracz2} został pokonany");
        Console.WriteLine("\n {Gracz1} wygrał");
            break;
    }
    Gracz2.Ulecz();
    Gracz2.Atak(Gracz1);
    if (Gracz2.HP <= 0)
    {
        Console.WriteLine("\n {Gracz1} został pokonany");
        Console.WriteLine("\n {Gracz2} wygrał");
        break;
    }
    Gracz1.Ulecz();
        alive = false; // pętla wykona się tylko raz
}


