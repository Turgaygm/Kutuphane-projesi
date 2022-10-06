using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAL;
using Entity;
using Logiclayer;
using System.IO;
using System.Data.SqlClient;

namespace Kutuphane
{
    public partial class yonetici : Form
    {
        public yonetici()
        {
            InitializeComponent();
        }
        KutuphaneEntities db = new KutuphaneEntities();
        private void yonetici_Load(object sender, EventArgs e)
        {
            var kategori = (from x in db.kategoris
                            select new

                            {
                                x.kategori_id,
                                x.kategori_ad
                            }).ToList();
            cmbkategori.ValueMember = "kategori_id";
            cmbkategori.DisplayMember = "kategori_ad";
            cmbkategori.DataSource = kategori;
        }

        private void btnrsm_Click(object sender, EventArgs e)
        {
            Stream myStream = null;

            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            openFileDialog1.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            openFileDialog1.Filter = "JPEG (*.jpg; *jpeg; *jpe)|*.jpg; *jpeg; *jpe|All files (*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                if ((myStream = openFileDialog1.OpenFile()) != null)
                {
                    using (myStream)
                    {
                        foreach (string s in openFileDialog1.FileNames)
                        {
                            pictureBox1.ImageLocation = s;
                        }
                    }
                }
            }
        }

        private void btnekle_Click(object sender, EventArgs e)
        {
            kitaplar ent = new kitaplar();
            ent.k_ad = txtad.Text;
            ent.k_kategori = Convert.ToInt32(cmbkategori.SelectedValue);
            ent.k_yazar = txtyazar.Text;
            ent.k_durum = cmbdurum.Text;
            ent.k_sayfa = int.Parse(txtsayfa.Text);
            ent.k_ozet = richTextBox1.Text;

            byte[] ImageByteArray = File.ReadAllBytes(pictureBox1.ImageLocation.ToString());
            ent.k_resim = ImageByteArray;

            Class1.LLPersonelekle(ent);
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            kitaplar ent = new kitaplar();
            ent.k_id = int.Parse(txtid.Text);
            ent.k_ad = txtad.Text;
            ent.k_kategori = Convert.ToInt32(cmbkategori.SelectedValue);
            ent.k_yazar = txtyazar.Text;
            ent.k_durum = cmbdurum.Text;
            ent.k_sayfa = int.Parse(txtsayfa.Text);
            ent.k_ozet = richTextBox1.Text;

            //byte[] ImageByteArray = File.ReadAllBytes(pictureBox2.ImageLocation.ToString());
            //ent.k_resim = ImageByteArray;

            Class1.LLPersonelguncelle(ent);
        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            kitaplar ent = new kitaplar();
            ent.k_id = Convert.ToInt32(txtid.Text);
            Class1.DLPersonelSil(ent.k_id);
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            txtid.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            cmbkategori.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            txtyazar.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            cmbdurum.Text = dataGridView1.Rows[secim].Cells[4].Value.ToString();
            txtsayfa.Text = dataGridView1.Rows[secim].Cells[7].Value.ToString();
            richTextBox1.Text = dataGridView1.Rows[secim].Cells[6].Value.ToString();

            SqlConnection con = new SqlConnection(@"Data Source = 302-12; Initial Catalog =Kutuphane; User ID = sa; Password=1234");
            SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand("SELECT k_resim FROM kitaplar WHERE k_id = '" + txtid.Text + "'", con));

            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            Byte[] data = new Byte[0];
            data = (Byte[])(dataSet.Tables[0].Rows[0]["k_resim"]);
            MemoryStream mem = new MemoryStream(data);
            pictureBox1.Image = Image.FromStream(mem);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kitaptakip ktptkp = new Kitaptakip();
            ktptkp.Show();
            this.Hide();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            List<kitaplar> perlist = Class1.LLoPersonellistesi();
            dataGridView1.DataSource = perlist;
        }
    }
}
