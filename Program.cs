using RollerKolcsonzo;
List<RollerUtazas> utazasok = new List<RollerUtazas>();
string[] adat = File.ReadAllLines("rollerek.txt");
foreach(string sor in adat)
{
    utazasok.Add(new RollerUtazas(sor));
}
