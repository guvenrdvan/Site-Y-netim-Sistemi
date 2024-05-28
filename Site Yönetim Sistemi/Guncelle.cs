using System;
using System.Windows.Forms;

namespace Site_Yönetim_Sistemi
{
    public partial class Guncelle: Form 
        
    {
        uye uye;

        public Guncelle(uye uye)
        {
            InitializeComponent();
            this.uye = uye;
            formDoldur();
        }

        void formDoldur()
        {
            cmbCinsiyet.Items.Add("Kadın");
            cmbCinsiyet.Items.Add("Erkek");
            cmbMedeni.Items.Add("Evli");
            cmbMedeni.Items.Add("Bekar");
        }

        private void Guncelle_Load(object sender, EventArgs e) 
        {

            txtAd.Text = uye.kullanici.ad;
            txtSoyad.Text = uye.kullanici.soyAd;
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
          

        }

       /* private void btnAracEkle_Click(object sender, EventArgs e)
        {
            

        }*/

       /* private void btnAracSil_Click(object sender, EventArgs e)
        {
           
                
        }*/

      /*  private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }*/

        private void btnDaireSakiniEkle_Click(object sender, EventArgs e)
        {
          
        }

        private void btnDaireSakiniSil_Click(object sender, EventArgs e)
        {
          
        }

        private void btnDaireSakiniGuncelle_Click(object sender, EventArgs e)
        {
           
        }
    }
}
