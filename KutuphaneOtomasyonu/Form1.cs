﻿using System;
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
    public partial class Form1 : Form
    {
        KutuphaneOtomasyonEntities db= new KutuphaneOtomasyonEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string gelenAd = klnAdTxt.Text;
            string gelenSifre = sifreTxt.Text;

            var personel = db.Personeller.Where(x => x.personel_ad.Equals(gelenAd) && x.personel_sifre.Equals(gelenSifre)).FirstOrDefault();

            if (personel == null)
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre hatalı.");
            }
            else
            {
                MessageBox.Show("Giriş Başarılı.");
                IslemPaneli panel = new IslemPaneli();
                panel.Show();
                this.Hide();
            }
        }
    }
}
