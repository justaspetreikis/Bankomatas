using Bankomatas.Forms;
using Bankomatas.Repozitorijos;

namespace Bankomatas
{
    public partial class Form_bankomatas : Form
    {
        private int meginimaiPrisijungti= 0;
        public static string kortelesNumeris = "";
        public Form_bankomatas()
        {
            InitializeComponent();   
            
        }

        private void button_Iseiti_Click(object sender, EventArgs e)
        {
            tb_bankoKortelesNumeris.Text = "8df41adb-debb-4c8d-962c-da291df05116";
            tb_pinKodas.Text = "7017";
            //Application.Exit();
        }

        private void button_NaujaKortele_Click(object sender, EventArgs e)
        {
            var kurtiKortele = new form_KurtiKortele();
            this.Hide();
            kurtiKortele.Show();
        }

        private void button_Prisijungti_Click(object sender, EventArgs e)
        {

            var _bankoKorteleRepozitorija = new BankoKorteleRepozitorija();
            bool ArPavykoPrisijungti = _bankoKorteleRepozitorija.PatikrintiArGerasPinKodas(tb_bankoKortelesNumeris.Text, int.Parse(tb_pinKodas.Text));

            if (ArPavykoPrisijungti == false && meginimaiPrisijungti < 4)
            {
                meginimaiPrisijungti ++;
                MessageBox.Show($"Blogai ávestas PIN kodas. Jums liko {3 - meginimaiPrisijungti} meginimai");
                tb_pinKodas.Clear();
            }

            if(meginimaiPrisijungti == 3)
            {
                MessageBox.Show("Iðnaudotas meginimø prisijungti limitas");
                Application.Exit();
            }
            if(ArPavykoPrisijungti == true)
            {
                kortelesNumeris = tb_bankoKortelesNumeris.Text;
                var pasirinkimai = new form_Pasirinkimai();
                this.Hide();
                pasirinkimai.ShowDialog();
            }
           
        }
    }
}