using RollerKolcsonzo;
int cikluszam = 0;
double  napibevetel = 0;
Console.WriteLine("Utazások részletei:");
List<RollerUtazas> utazasok = new List<RollerUtazas>();
string[] adat = File.ReadAllLines("rollerek.txt");
foreach(string sor in adat)
{
    utazasok.Add(new RollerUtazas(sor));
    Console.WriteLine(utazasok[cikluszam]);
    cikluszam += 1;
}
napibevetel = utazasok.Sum(x => x.FizetendoDij());
Console.WriteLine("\nStatisztika:");
Console.WriteLine($"\nKölcsönző teljes napi bevétele: {napibevetel} Ft");
RollerUtazas leg = utazasok.MaxBy(x => x.UtazasiIdoPerc);
Console.WriteLine($"Leghosszabb utazás: {leg.FelhasznaloNev} ({leg.UtazasiIdoPerc} perc)");