using System;
using System.Collections.Generic;
using System.Text;

namespace RollerKolcsonzo
{
    public class RollerUtazas
    {
        public string FelhasznaloNev { set; get; }
        public int UtazasiIdoPerc{ set; get; }
        public double MegtettKm{ set; get; }
        public RollerUtazas(string sor)
        {
            string[] soradatok = sor.Split(";");
            FelhasznaloNev = soradatok[0];
            UtazasiIdoPerc = int.Parse(soradatok[1]);
            MegtettKm = double.Parse(soradatok[2]);
        }
        public int FizetendoDij()
        {
            int eredmeny = 300 + (UtazasiIdoPerc * 60);
            return eredmeny;
        }
        public override string ToString()
        {
            return $"{FelhasznaloNev}: {UtazasiIdoPerc} perc, {MegtettKm} km - Fizetendő: {FizetendoDij()} Ft";
        }
    }
}
