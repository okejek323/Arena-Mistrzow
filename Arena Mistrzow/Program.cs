using Arena_Mistrzow;

bool alive = true;

Console.WriteLine("Gracz jeden wybierz klase postaci: ");
Console.WriteLine("1 - Wojownik");
Console.WriteLine("2 - Łucznik");
Console.WriteLine("3 - Mag");

string wybór1 = Console.ReadLine();

switch (wybór1)
{
    case "1":
        Console.WriteLine("Wybrano Wojownika");
        Bohater.Wojownik wojownik = new Bohater.Wojownik();
        wojownik.Imie = "Wojownik";
        wojownik.HP = 200;
        break;
    case "2":
        Console.WriteLine("Wybrano Łucznik");
        Bohater.Łucznik łucznik = new Bohater.Łucznik();
        łucznik.Imie = "Łucznik";
        łucznik.HP = 100;
        break;
    case "3":
        Console.WriteLine("Wybrano Mag");
        Bohater.Mag mag = new Bohater.Mag();
        mag.Imie = "Mag";
        mag.HP = 80;

        break;
}

Console.WriteLine("Gracz jeden wybierz klase postaci: ");
Console.WriteLine("1 - Wojownik");
Console.WriteLine("2 - Łucznik");
Console.WriteLine("3 - Mag");

string wybór2 = Console.ReadLine();

switch (wybór2)
{
    case "1":
        Console.WriteLine("Wybrano Wojownika");
        Bohater.Wojownik wojownik2 = new Bohater.Wojownik();
        wojownik2.Imie = "Wojownik";
        wojownik2.HP = 200;
        break;
    case "2":
        Console.WriteLine("Wybrano Łucznik");
        Bohater.Łucznik łucznik2 = new Bohater.Łucznik();
        łucznik2.Imie = "Łucznik";
        łucznik2.HP = 100;
        break;
    case "3":
        Console.WriteLine("Wybrano Mag");
        Bohater.Mag mag2 = new Bohater.Mag();
        mag2.Imie = "Mag";
        mag2.HP = 80;

        break;
}


while (alive)
{

}
