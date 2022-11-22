using Bankomatas.Repozitorijos;
using System;
using System.Collections;
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
    public partial class InestiPinigusForm : Form
    {
        public InestiPinigusForm()
        {
            InitializeComponent();
        }

        private void button_Prideti_Click(object sender, EventArgs e)
        {
            var _bankoKorteleRepozitorija = new BankoKorteleRepozitorija();
            var kortele = _bankoKorteleRepozitorija.GrazintiKortelesDuomenis(Form_bankomatas.kortelesNumeris);

            string tekstas = string.Join(",", kortele.KortelesNumeris, kortele.PinKodas, kortele.PiniguSuma);

            string duomenys = File.ReadAllText(@"C:\Users\petre\Desktop\CodeAcademy\Bankomatas\BankoKorteles.txt");

            string pakeistiDuomenys = duomenys.Replace(tekstas, 
                                                       $"{kortele.KortelesNumeris.ToString()}," +
                                                       $"{kortele.PinKodas.ToString()}," +
                                                       $"{((kortele.PiniguSuma + double.Parse(tb_iveskitePiniguSuma.Text))).ToString()}");

            File.WriteAllText(@"C:\Users\petre\Desktop\CodeAcademy\Bankomatas\BankoKorteles.txt", pakeistiDuomenys);

            MessageBox.Show($"Į Jūsų sąskaitą sėkmingai pridėta {tb_iveskitePiniguSuma.Text} Eur");

            File.AppendAllText(@"C:\Users\petre\Desktop\CodeAcademy\Bankomatas\Transakcija.txt",
            string.Format("{0},{1},{2},{3}\n", kortele.KortelesNumeris.ToString(), 
                                               DateTime.Now.ToString(), 
                                               "deposit",
                                               tb_iveskitePiniguSuma.Text));

            tb_iveskitePiniguSuma.Clear();
        }

        private void button_gristi_Click(object sender, EventArgs e)
        {
            var pasirinkimai = new form_Pasirinkimai();
            this.Hide();
            pasirinkimai.ShowDialog();
        }

        private void button_iseiti_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
