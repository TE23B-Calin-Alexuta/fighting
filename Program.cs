
Console.WriteLine("Skriv ditt namn:");
string name = Console.ReadLine();

while (name == "")
{
    Console.WriteLine("SKRIV DITT NAMN!");
    name = Console.ReadLine();
}
int heroHp = 100;
int villainHp = 100;

string heroName = "Carlos";
string villainName = "Sobolan";

Random generator = new Random();

while (heroHp > 0 && villainHp > 0)
{
  Console.WriteLine("\n----- ===== NEW ROUND ===== -----");
  Console.WriteLine($"{heroName}: {heroHp}  {villainName}: {villainHp}\n");

  int heroDamage = generator.Next(20);
  villainHp -= heroDamage;
  villainHp = Math.Max(0, villainHp);
  Console.WriteLine($"{heroName} gör {heroDamage} skada på {villainName}");

  int villainDamage = generator.Next(20);
  heroHp -= villainDamage;
  heroHp = Math.Max(0, heroHp);
  Console.WriteLine($"{villainName} gör {villainDamage} skada på {heroName}");

  Console.WriteLine("Tryck på valfri knapp för att fortsätta.");
  Console.ReadKey();
}

Console.WriteLine("\n----- ===== GAME OVER ===== -----");

if (heroHp == 0 && villainHp == 0)
{
  Console.WriteLine("Alla är döda!");
}
else if (heroHp == 0)
{
  Console.WriteLine($"{villainName} vann!");
}
else
{
  Console.WriteLine($"{heroName} vann!");
}

Console.WriteLine("Tryck på valfri knapp för att avsluta.");
Console.ReadKey();