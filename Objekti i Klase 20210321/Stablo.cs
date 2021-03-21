using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Objekti_i_Klase_20210321
{
    class Stablo : Biljka
    {
        bool opadajuListovi;

        public bool OpadajuListovi { get => opadajuListovi; set => opadajuListovi = value; }

        public Stablo(bool opadajuListovi)
        {
            this.opadajuListovi = opadajuListovi;
        }
    }
}
