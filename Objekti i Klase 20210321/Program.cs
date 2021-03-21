using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objekti_i_Klase_20210321
{
    class Program
    {
        static void Main(string[] args)
        {
            int Biraj = 4;
            do
            {
                Console.WriteLine();
                Console.Write("Prvi:1 Drugi:2 Treci:3 Kraj:0 Izbor:");
                Biraj = Convert.ToInt32(Console.ReadLine());
                switch (Biraj)
                {
                    case 1:
                        Bijelogoricno Hrast = new Bijelogoricno(true);
                        Crnogoricno Bor = new Crnogoricno(true);
                        Console.WriteLine(Hrast.OpadajuListovi);
                        Console.WriteLine(Bor.OpadajuListovi);

                        break;

                    case 2:
                        Trokut Trokut = new Trokut();
                        Cetverokut Cetverokut = new Cetverokut();
                        Console.WriteLine("Unesite stranice za Trokut:");
                        Trokut.UcitajStranice();
                        Console.WriteLine("Opseg Trokuta je: " + Trokut.Opseg());

                        Console.WriteLine();
                        Console.WriteLine("Unesite stranice za Kvadrat:");
                        Cetverokut.UcitajStranice();
                        Console.WriteLine("Opseg Cetverokuta je: " + Cetverokut.Opseg());

                        break;

                    case 3:
                        KlasaX x = new KlasaX();
                        for (x.Indeks = 0; x.Indeks < 100; x.Indeks++)
                        {
                            x.Arr[x.Indeks] = x.Indeks + 1;
                        }
                        Console.WriteLine("50. broj u polju Arr = " + x.Arr[49]);
                        break;
                }
            } while (Biraj != 0);
        }
    }
}
