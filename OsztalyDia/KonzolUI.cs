using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OsztalyDia
{
    class KonzolUI
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\nProgram kezdődik...");

            Tanulo tanulo1 = new Tanulo("József", "Barnabás", 18, 36306893925, "Betlehem utca", "Debrecen", "Hajdu-Bihar megye", 4030, "Magyarország", 3.5, false);
            Console.WriteLine($"\nPozicíó:Tanuló");
            tanulo1.Nev();

            Oktato oktato1 = new Oktato("Gizella", "Hajdu", 32, 36307953256, "Jerikó utca", "Debrecen", "Hajdu-Bihar megye", 4030, "Magyarország", 20, 25, 20000, 5);
            Console.WriteLine($"\nPozicíó:Oktató");
            oktato1.Nev();

            Console.WriteLine("\nProgram Vége!");
            Console.ReadKey();
        }
    }
}
