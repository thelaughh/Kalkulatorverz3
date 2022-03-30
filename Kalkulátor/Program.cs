// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
bool Uživatel;
while (true)
{
    Console.WriteLine("Zadej první číslo");
    int cislo1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Zadej druhé čílo");
    int cislo2 = Convert.ToInt32(Console.ReadLine());

    int výsledeksčítání = cislo1 + cislo2;
    int výsledeknásobení = cislo1 * cislo2;
    int výsledekdělení = cislo1 / cislo2;
    int výsledekodečítání = cislo1 - cislo2;
    Console.WriteLine("Konečný výsledek je " + výsledeksčítání);
    Console.WriteLine("Konečný výsledek je " + výsledeknásobení);
    Console.WriteLine("Konečný výsledek je " + výsledekdělení);
    Console.WriteLine("Konečný výsledek je " + výsledekodečítání);

    Console.WriteLine("Příklad je u konce můžeš odznovu LULW");
}

