using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BankaHesaplari
{
    public partial class frmAnasayfa : Form
    {
        public frmAnasayfa()
        {
            InitializeComponent();
        }

        private void mitmCikis_Click(object sender, EventArgs e)
        {
            //this.Close(); //Aktif formu kapatır.
            Application.Exit(); //Tüm uygulamayı sonlandırır.
        }

        private void mitmMusteriTanimlama_Click(object sender, EventArgs e)
        {
            frmMusteriler frm = new frmMusteriler();
            //FormAcikmi(frm);
            frm.MdiParent = this;
            frm.Show(); //Formu ekranda gösterir ama anasayfanın içinde açılmaz, bağımsızdır. Bağımlı hale getirmek için üst satırı yazdık.


        }
    }
}
