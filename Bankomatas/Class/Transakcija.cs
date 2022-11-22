using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomatas.Class
{
    public class Transakcija
    {
        public Guid KortelesNumeris { get; set; }
        public DateTime OperacijosLaikas { get; set; }
        public string OperacijosTipas { get; set; }
        public int PiniguSuma { get; set; }

        public Transakcija(Guid kortelesNumeris, DateTime operacijosLaikas, string operacijosTipas, int piniguSuma)
        {
            KortelesNumeris = kortelesNumeris;
            OperacijosLaikas = operacijosLaikas;
            OperacijosTipas = operacijosTipas;
            PiniguSuma = piniguSuma;
        }
    }
}
