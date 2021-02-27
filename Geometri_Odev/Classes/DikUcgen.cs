using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometri_Odev.Classes.Bases;

namespace Geometri_Odev.Classes
{
    class DikUcgen : Sekiller, IHesaplama
    {
        public double hipotenus;
        public double AlanHesapla()
        {
            return Taban * Yukseklik / 2;
        }

        public double CevreHesapla()
        {
            hipotenus = Math.Sqrt(Math.Pow(Taban, 2) + Math.Pow(Yukseklik, 2)); 
            return hipotenus + Taban + Yukseklik;
        }

        
    }
}
