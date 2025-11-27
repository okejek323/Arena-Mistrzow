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




while (alive)
{

}
