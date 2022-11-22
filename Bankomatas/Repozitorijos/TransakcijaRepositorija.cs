using Bankomatas.Class;
using Bankomatas.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bankomatas.Repozitorijos
{
    public class TransakcijaRepositorija : IGrazintiDuomenis<Transakcija>
    {

        public List<Transakcija> OperacijuListas { get; set; }

        public TransakcijaRepositorija()
        {
            OperacijuListas = new List<Transakcija>();
            string duomenys = @"C:\Users\petre\Desktop\CodeAcademy\Bankomatas\Transakcija.txt";
            string[] bankoKorteles = File.ReadAllLines(duomenys);
            foreach (string transakcija in bankoKorteles)
            {
                var bankoKorteliuListas = transakcija.Split(',');
                Guid kortelesNumeris = Guid.Parse(bankoKorteliuListas[0]);
                DateTime operacijosLaikas = DateTime.Parse(bankoKorteliuListas[1]);
                string operacijosTipas = bankoKorteliuListas[2];
                int piniguSuma = int.Parse(bankoKorteliuListas[3]);

                OperacijuListas.Add(new Transakcija(kortelesNumeris, operacijosLaikas, operacijosTipas, piniguSuma));
            }
        }
        public List<Transakcija> GrazintiVisuKorteliuLista()
        {
            return OperacijuListas;
        }


        public Transakcija GrazintiKortelesOperacijuDuomenis(string kortelesNumeris)
        {
            return OperacijuListas.Where(x => x.KortelesNumeris == Guid.Parse(kortelesNumeris)).First();
        }
    }
}
