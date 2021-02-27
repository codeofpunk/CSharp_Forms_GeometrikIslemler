using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometri_Odev.Classes.Bases
{
    class YuvarlakSekiller
    {
        public double YariCap { get; set; }
        

        public double AlanHesapla()
        {
         return Math.PI * YariCap * YariCap;
        }

        public double CevreHesapla()
        {
            
            return 2 * Math.PI * YariCap;
        }
    }
}
