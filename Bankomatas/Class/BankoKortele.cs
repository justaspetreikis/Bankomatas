using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomatas.Class
{
    public class BankoKortele
    {
        public Guid KortelesNumeris { get; set; }
        public int PinKodas { get; set; }
        public double PiniguSuma { get; set; }

        public BankoKortele(Guid kortelesNumeris, int pinKodas, double piniguSuma)
        {
            KortelesNumeris = kortelesNumeris;
            PinKodas = pinKodas;
            PiniguSuma = piniguSuma;
        }
    }
}
