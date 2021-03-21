using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objekti_i_Klase_20210321
{
    class GeometrijskiLik
    {
        int BrojStranica;
        double[] Stranice = new double[10];

        public int BrojStranice1 { get => BrojStranica; set => BrojStranica = value; }
        public double[] Stranice1 { get => Stranice; set => Stranice = value; }

        public void UcitajStranice()
        {
            for (int i = 0; i < BrojStranica; i++)
            {
                Console.Write((i + 1) + " = ");
                this.Stranice[i] = Convert.ToDouble(Console.ReadLine());
            }
        }
        public float Opseg()
        {
            float opseg = 0;
            foreach (int broj in Stranice)
            {
                opseg += broj;
            }
            return opseg;
        }

        public GeometrijskiLik(int brojStranica)
        {
            BrojStranica = brojStranica;
        }
    }
}
