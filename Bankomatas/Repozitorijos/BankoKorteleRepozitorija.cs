using Bankomatas.Class;
using Bankomatas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomatas.Repozitorijos
{
    public class BankoKorteleRepozitorija: IGrazintiDuomenis<BankoKortele> 
    {
        public List<BankoKortele> KorteliuListas { get; set; }

        public BankoKorteleRepozitorija()
        {
            KorteliuListas = new List<BankoKortele>();
            string path = @"C:\Users\petre\Desktop\CodeAcademy\Bankomatas\BankoKorteles.txt";
            string[] bankoKorteles = File.ReadAllLines(path);
            foreach (string kortele in bankoKorteles)
            {
                var bankoKorteliuListas = kortele.Split(',');
                Guid kortelesNumeris = Guid.Parse(bankoKorteliuListas[0]);
                int pinKodas = int.Parse(bankoKorteliuListas[1]);
                double piniguSuma = double.Parse(bankoKorteliuListas[2]);

                KorteliuListas.Add(new BankoKortele(kortelesNumeris, pinKodas, piniguSuma));
            }
        }

        public List<BankoKortele> GrazintiVisuKorteliuLista()
        {
            return KorteliuListas;
        }

        public BankoKortele GrazintiKortelesDuomenis(string kortelesNumeris)
        {
            return KorteliuListas.Where(x => x.KortelesNumeris == Guid.Parse(kortelesNumeris)).FirstOrDefault();
        }

        public bool PatikrintiArGerasPinKodas(string kortelesNumeris, int PinKodas)
        {
            bool duomenysTeisingi = true;
            var kortelesDuomenys = KorteliuListas.Where(x => x.KortelesNumeris == Guid.Parse(kortelesNumeris)).FirstOrDefault();
            if (kortelesDuomenys.PinKodas != PinKodas)
            {
                duomenysTeisingi = false;
            }
            return duomenysTeisingi;

        }
    }
}
