using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometri_Odev.Classes.Bases;

namespace Geometri_Odev.Classes
{
    class Dikdortgen_Kare : Sekiller,IHesaplama
    {
        public double AlanHesapla()
        {
            return Taban * Yukseklik;
        }

        public double CevreHesapla()
        {
            return 2 * (Taban + Yukseklik);
        }
    }
}
