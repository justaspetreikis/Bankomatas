using Bankomatas.Repozitorijos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bankomatas.Forms
{
    public partial class form_KeistiPin : Form
    {
        public form_KeistiPin()
        {
            InitializeComponent();
        }

        private void button_Keisti_Click(object sender, EventArgs e)
        {
            var pasirinkimai = new form_Pasirinkimai();
            this.Hide();
            pasirinkimai.ShowDialog();
        }

        private void button_Gristi_Click(object sender, EventArgs e)
        {
            int ivestasPin;
            bool ivestaGerasPin = int.TryParse(tb_EsamasPin.Text, out ivestasPin);
            bool naujasGerasPin = int.TryParse(tb_NaujasPin.Text, out ivestasPin);
            bool pakartotasGerasPin = int.TryParse(tb_NaujasPin.Text, out ivestasPin);
            if (ivestaGerasPin == false || naujasGerasPin == false || pakartotasGerasPin == false)
            {
                MessageBox.Show("Blogai įvestas PIN kodas. PIN kodas turi būti sudarytas iš 4 skaičių.");
                tb_EsamasPin.Clear();
                tb_NaujasPin.Clear();
                tb_PakartotiNaujaPin.Clear();
                return;
            }

            var _bankoKorteleRepozitorija = new BankoKorteleRepozitorija();
            var kortele = _bankoKorteleRepozitorija.GrazintiKortelesDuomenis(Form_bankomatas.kortelesNumeris);

            bool teisingasEsamasPin = int.Parse(tb_EsamasPin.Text) == kortele.PinKodas;
            bool vienodiNaujiPin = int.Parse(tb_NaujasPin.Text) == int.Parse(tb_PakartotiNaujaPin.Text);

            if(teisingasEsamasPin == false)
            {
                MessageBox.Show("Blogai įvestas esamas PIN kodas");
                tb_EsamasPin.Clear();
            }

            if(vienodiNaujiPin == false)
            {
                MessageBox.Show("Nesutampa naujas PIN kodas");
            }
            if(teisingasEsamasPin && vienodiNaujiPin)
            {
                string tekstas = string.Join(",", kortele.KortelesNumeris, kortele.PinKodas, kortele.PiniguSuma);

                string duomenys = File.ReadAllText(@"C:\Users\petre\Desktop\CodeAcademy\Bankomatas\BankoKorteles.txt");

                string pakeistiDuomenys = duomenys.Replace(tekstas,
                                                           $"{kortele.KortelesNumeris.ToString()}," +
                                                           $"{tb_NaujasPin.Text}," +
                                                           $"{kortele.PiniguSuma.ToString()}");

                File.WriteAllText(@"C:\Users\petre\Desktop\CodeAcademy\Bankomatas\BankoKorteles.txt", pakeistiDuomenys);
                MessageBox.Show("PIN kodas sėkmingai pakeistas");
                tb_EsamasPin.Clear();
                tb_NaujasPin.Clear();
                tb_PakartotiNaujaPin.Clear();
            }

            



        }
    }
}
