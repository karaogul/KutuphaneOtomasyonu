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
    public partial class GeriAlForm : Form
    {
        public GeriAlForm()
        {
            InitializeComponent();
        }

        KutuphaneOtomasyonEntities db = new KutuphaneOtomasyonEntities();

        private void GeriAlForm_Load(object sender, EventArgs e)
        {
            var kayitlar = db.Kayitlar.Where(x => x.durum == false).ToList();
            dataGridView1.DataSource = kayitlar.ToList();

            // istenmeyen kaynak ve kolonları gizleme
            dataGridView1.Columns[6].Visible = false;
            dataGridView1.Columns[7].Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int secilenKayitId = Convert.ToInt16(dataGridView1.CurrentRow.Cells[0].Value);
            var kayit = db.Kayitlar.Where(x=>x.kayit_id == secilenKayitId).FirstOrDefault();
            kayit.durum = true;

            //liste tazeleme
            var kayitlar = db.Kayitlar.Where(x => x.durum == false).ToList();
            dataGridView1.DataSource = kayitlar.ToList();
            db.SaveChanges();
        }
    }
}
