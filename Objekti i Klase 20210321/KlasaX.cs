using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objekti_i_Klase_20210321
{
    class KlasaX
    {
        int[] arr = new int[100];
        int indeks;

        public int[] Arr { get => arr; set => arr = value; }
        public int Indeks { get => indeks; set => indeks = value; }

        public KlasaX(int[] arr, int indeks)
        {
            this.arr = arr;
            this.indeks = indeks;
        }

        public KlasaX()
        {
        }
    }
}
