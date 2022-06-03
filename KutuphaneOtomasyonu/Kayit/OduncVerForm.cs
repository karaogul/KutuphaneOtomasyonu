using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu.Kayit
{
    public partial class OduncVerForm : Form
    {
        public OduncVerForm()
        {
            InitializeComponent();
        }

        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();

        private void OduncVerForm_Load(object sender, EventArgs e)
        {
            //kayıt listeleri
            var kayitList = db.Kayitlar.ToList();
            dataGridView1.DataSource = kayitList.ToList();


            //kaynak listeleri
            var kaynakList = db.Kaynaklar.ToList();
            dataGridView2.DataSource = kaynakList.ToList();

            // id ve kayıtlar kolonunu gizleme bölümü
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string arananSecilen = TCBultxt.Text;
            var kullaniciVarMi = db.Kullanicilar.Where(x => x.kullanici_tc == arananSecilen).FirstOrDefault();

            if (kullaniciVarMi != null)
                label2.Text = kullaniciVarMi.kullanici_ad + " " + kullaniciVarMi.kullanici_soyad;
            else
                label2.Text = "Henüz böyle bir kullanıcı yok.";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string gelenAd = textBox1.Text;
            var bulunanKaynaklar = db.Kaynaklar.Where(x=>x.kaynak_ad.Contains(gelenAd)).ToList();
            dataGridView2.DataSource = bulunanKaynaklar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //seçilen kişi
            string secilenKisiTC = TCBultxt.Text;
            var secilenKisi = db.Kullanicilar.Where(x => x.kullanici_tc.Equals(secilenKisiTC)).FirstOrDefault();

            //seçilen kitap
            int secilenKitapId = Convert.ToInt16(dataGridView2.CurrentRow.Cells[0].Value);
            var secilenKitap = db.Kaynaklar.Where(x=>x.kaynak_id == secilenKitapId).FirstOrDefault();

            Kayitlar yenikayit = new Kayitlar();
            yenikayit.kitap_id = secilenKitap.kaynak_id;
            yenikayit.kullanici_id = secilenKisi.kullanici_id;
            yenikayit.alis_tarih = DateTime.Today;
            yenikayit.son_tarih = DateTime.Today.AddDays(15);
            yenikayit.durum = false;
            db.Kayitlar.Add(yenikayit);
            db.SaveChanges();
            var kayitList = db.Kayitlar.ToList();
            dataGridView1.DataSource = kayitList.ToList();
        }
    }
}
