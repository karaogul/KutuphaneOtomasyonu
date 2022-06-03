using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KutuphaneOtomasyonu
{
    public partial class IslemPaneli : Form
    {
        public IslemPaneli()
        {
            InitializeComponent();
        }

        private void IslemPaneli_Load(object sender, EventArgs e)
        {
            //kullanıcı butonları girişte kapalıdır. (ekle-güncelle-sil)
            ekleKullanicibtn.Visible = false;
            guncelleKullanicibtn.Visible = false;
            silKullanicibtn.Visible = false;

            //kaynaklar butonları girişte kapalıdır. (ekle-güncelle-sil)
            ekleKaynakbtn.Visible = false;
            guncelleKaynakbtn.Visible = false;
            silKaynakbtn.Visible = false;
        }
        KullaniciListeForm klisteForm = new KullaniciListeForm();
        //kullanıcı listesini ve butonları açar

        private void button1_Click(object sender, EventArgs e)
        {
            
            if (ekleKullanicibtn.Visible == false)
            {
                ekleKullanicibtn.Visible = true;
                guncelleKullanicibtn.Visible = true;
                silKullanicibtn.Visible = true;
                klisteForm.MdiParent = this;
                klisteForm.Show();
            }
            else
            {
                ekleKullanicibtn.Visible = false;
                guncelleKullanicibtn.Visible = false;
                silKullanicibtn.Visible = false;
                klisteForm.Hide();
            }           
        }
        private Kullanici.KullaniciAddForm addForm;
        private bool ekleKullaniciDurum = false;
        private void ekleKullanicibtn_Click(object sender, EventArgs e)
        {
            if(ekleKullaniciDurum == false)
            {
                addForm= new Kullanici.KullaniciAddForm();
                addForm.MdiParent = this;
                addForm.Show();
                ekleKullaniciDurum=true;
            }
            else
            {
                addForm.Close();
                ekleKullaniciDurum=false;
            }
        }
        private Kullanici.KullaniciSilForm silForm;
        private bool silKullaniciDurum = false;
        private void silKullanicibtn_Click(object sender, EventArgs e)
        {
            if(silKullaniciDurum == false)
            {
                silForm = new Kullanici.KullaniciSilForm();
                silForm.MdiParent = this;
                silForm.Show();
                silKullaniciDurum=true;
            }

            else
            {
                silForm.Close();
                silKullaniciDurum = false;
            }
        }
        private Kullanici.KullaniciGuncelleForm guncelForm;
        private bool guncelleKullaniciDurum = false;
        private void guncelleKullanicibtn_Click(object sender, EventArgs e)
        {
            if(guncelleKullaniciDurum == false){
                guncelForm = new Kullanici.KullaniciGuncelleForm();
                guncelForm.MdiParent = this;
                guncelForm.Show();
                guncelleKullaniciDurum=true;
            }

            else
            {
                guncelForm?.Close();
                guncelleKullaniciDurum = false;
            }
        }
        Kaynak.KaynakListeForm kListe = new Kaynak.KaynakListeForm();

        private void button2_Click(object sender, EventArgs e)
        {
            if (ekleKaynakbtn.Visible == false)
            {
                ekleKaynakbtn.Visible = true;
                guncelleKaynakbtn.Visible = true;
                silKaynakbtn.Visible = true;
                kListe.MdiParent = this;
                kListe.Show();
            }
            else
            {
                ekleKaynakbtn.Visible = false;
                guncelleKaynakbtn.Visible = false;
                silKaynakbtn.Visible = false;
                kListe.Hide();
            }
                        
        }
        private Kaynak.KaynakEkleForm kEkle;
        private bool ekleKaynakDurum = false;
        private void ekleKaynakbtn_Click(object sender, EventArgs e)
        {
            if (ekleKaynakDurum == false)
            {
                kEkle = new Kaynak.KaynakEkleForm();
                kEkle.MdiParent = this;
                kEkle.Show();
                ekleKaynakDurum = true;
            }

            else
            {
                kEkle.Close();
                ekleKaynakDurum = false;
            }
        }
        private Kaynak.KaynakSilForm kSil;
        private bool silKaynakDurum = false;
        private void silKaynakbtn_Click(object sender, EventArgs e)
        {
            if (silKaynakDurum == false)
            {
                kSil = new Kaynak.KaynakSilForm();
                kSil.MdiParent = this;
                kSil.Show();
                silKaynakDurum = true;
            }
            else
            {
                kSil.Close();
                silKaynakDurum = false;
            }
        }
        private Kaynak.KaynakGuncelleForm kGuncel;
        private bool guncelKaynakDurum = false;
        private void guncelleKaynakbtn_Click(object sender, EventArgs e)
        {
            if (guncelKaynakDurum == false) {
                kGuncel= new Kaynak.KaynakGuncelleForm();
                kGuncel.MdiParent = this;
                kGuncel.Show();
                guncelKaynakDurum = true;
            }

            else
            {
                kGuncel.Close();
                guncelKaynakDurum = false;
            }
        }
        private Kayit.OduncVerForm odunc;
        private bool oduncKaynakDurum = false;
        private void button3_Click(object sender, EventArgs e)
        {
            if (oduncKaynakDurum == false)
            {
                odunc = new Kayit.OduncVerForm();
                odunc.MdiParent = this;
                odunc.Show();
                oduncKaynakDurum = true;
            }

            else
            {
                odunc.Close();
                oduncKaynakDurum = false;
            }
        }
        private Kayit.GeriAlForm geri;
        private bool geriKaynakDurum = false;
        private void button4_Click(object sender, EventArgs e)
        {
            if (geriKaynakDurum == false)
            {
                geri = new Kayit.GeriAlForm();
                geri.MdiParent = this;
                geri.Show();
                geriKaynakDurum = true;
            }

            else
            {
                geri.Close();
                geriKaynakDurum = false;
            }
        }
    }
}
