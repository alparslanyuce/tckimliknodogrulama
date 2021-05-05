using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tckimliknoDogrulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void btnKontrolEt_Click(object sender, EventArgs e)
        {
            TCKimlikNoDogrulama.KPSPublic kps = new TCKimlikNoDogrulama.KPSPublic();
          bool kontrol =  kps.TCKimlikNoDogrula(long.Parse(txttckimlikno.Text), txtisim.Text.ToUpper(), txtsoyisim.Text.ToUpper(), int.Parse(txtdogumyil.Text));
            if (kontrol)
            {
                MessageBox.Show("Bilgileriniz Doğrulandı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Bilgileriniz Doğrulanamadı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
