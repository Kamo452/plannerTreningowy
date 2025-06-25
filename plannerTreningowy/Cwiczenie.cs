using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace plannerTreningowy
{
    public interface ICwiczenie
    {
        string Nazwa { get; }
        int Kcal { get; }
        string Opis { get; }
        string Grupa { get; }
        string PobierzOpisPelny();
    }

    public abstract class CwiczenieBase : ICwiczenie
    {
        public string Nazwa { get; set; } = string.Empty;
        public string Opis { get; set; } = string.Empty;
        public int Kcal { get; set; }
        public string Grupa { get; set; } = string.Empty;

        public abstract string PobierzOpisPelny();

        public override string ToString() => $"{Nazwa} ({Kcal} kcal)";
    }

    public class Cwiczenie : CwiczenieBase
    {
        public override string PobierzOpisPelny()
        {
            return $"Ćwiczenie: {Nazwa}\nGrupa: {Grupa}\nOpis: {Opis}\nKalorie: {Kcal}";
        }
    }
}