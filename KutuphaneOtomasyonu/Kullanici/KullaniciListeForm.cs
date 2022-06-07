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
    public partial class KullaniciListeForm : Form
    {
        public KullaniciListeForm()
        {
            InitializeComponent();
        }

        public void Listele()
        {
            KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();
            var kullanicilar=db.Kullanicilar.ToList();
            dataGridView1.DataSource = kullanicilar.ToList();
            // id ve kayıtlar kolonunu gizleme bölümü
            dataGridView1.Columns[0].Visible = false;
            dataGridView1.Columns[8].Visible = false;

            //kolon isimlerini düzenleme
            dataGridView1.Columns[1].HeaderText = "Ad";
            dataGridView1.Columns[2].HeaderText = "Soyad";
            dataGridView1.Columns[3].HeaderText = "TC Kimlik No";
            dataGridView1.Columns[4].HeaderText = "Mail";
            dataGridView1.Columns[5].HeaderText = "Telefon No";
            dataGridView1.Columns[6].HeaderText = "Ceza";
            dataGridView1.Columns[7].HeaderText = "Cinsiyet";

        }

        private void KullaniciListeForm_Load(object sender, EventArgs e)
        {
            Listele();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            excel.Application app = new excel.Application();
            app.Visible = true;
            Workbook Kullanicilar = app.Workbooks.Add(System.Reflection.Missing.Value);
            Worksheet kaynak = (Worksheet)Kullanicilar.Worksheets[1];
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                Range alan = (Range)kaynak.Cells[1, 1];
                alan.Cells[1, i + 1] = dataGridView1.Columns[i].HeaderText;
            }
            for (int i = 0; i < dataGridView1.Columns.Count; i++)
            {
                for (int j = 0; j < dataGridView1.Rows.Count; j++)
                {
                    Range alan2 = (Range)kaynak.Cells[j+1,i+1];
                    alan2.Cells[2 , 1] = dataGridView1[i, j].Value;
                }
            }
        }
    }
}
