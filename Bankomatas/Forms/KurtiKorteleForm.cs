using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bankomatas.Forms
{
    public partial class form_KurtiKortele : Form
    {
        public form_KurtiKortele()
        {
            InitializeComponent();
        }

        private void button_iseiti_Click(object sender, EventArgs e)
        {
            var bankomatas = new Form_bankomatas();
            this.Close();
            bankomatas.ShowDialog();

        }

        private void button_generuotiKortelesNumeri_Click(object sender, EventArgs e)
        {
            Guid kortelesNumeris = Guid.NewGuid();
            tb_kortelesNumeris.Text = kortelesNumeris.ToString();
        }

        private void button_generuotiPinKoda_Click(object sender, EventArgs e)
        {
            var random = new Random();
            int kortelesPin = random.Next(1000, 9999);
            tb_PinKodas.Text = kortelesPin.ToString();
        }

        private void button_kurtiKortele_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(tb_kortelesNumeris.Text) || string.IsNullOrEmpty(tb_PinKodas.Text))
            {
                MessageBox.Show("Prieš sukuriant naują kortelę b9tina sugeneruoti jos duomenis");
                return;
            }

            double saskaitosLikutis = 0;
            File.AppendAllText(@"C:\Users\petre\Desktop\CodeAcademy\Bankomatas\BankoKorteles.txt",
                string.Format("{0},{1},{2}\n", tb_kortelesNumeris.Text, tb_PinKodas.Text, saskaitosLikutis.ToString()));
            MessageBox.Show("Nauja kortelė sėkmingai sukurta");
            tb_kortelesNumeris.Clear();
            tb_PinKodas.Clear();
        }
    }
}
