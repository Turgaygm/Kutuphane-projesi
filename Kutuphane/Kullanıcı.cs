using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using Entity;


namespace Kutuphane
{
    public partial class Kullanıcı : Form
    {
        public Kullanıcı()
        {
            InitializeComponent();
        }
        KutuphaneEntities db = new KutuphaneEntities();
        SqlConnection con = new SqlConnection(@"Data Source = 302-12; Initial Catalog =Kutuphane; User ID = sa; Password=1234");
        private void Kullanıcı_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneDataSet.kitaplar' table. You can move, or remove it, as needed.
            this.kitaplarTableAdapter.Fill(this.kutuphaneDataSet.kitaplar);

            txtad.Enabled = false;
            txtid.Enabled = false;
            txtsayfa.Enabled = false;
            txtyazar.Enabled = false;
            richTextBox1.Enabled = false;
            cmbdurum.Enabled = false;
            cmbkategori.Enabled = false;
                
            label1.Text = $"{variables.k_adsoyad}" ;
            label2.Text = $"{variables.k_telefon}";
            
        }

        private void edebiyatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("select k_id,k_ad,k_kategori,k_yazar,k_durum,k_resim,k_ozet,k_sayfa from kitaplar inner join kategori on kitaplar.k_kategori=kategori.kategori_id where k_kategori=2", con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void fantastikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("select k_id,k_ad,k_kategori,k_yazar,k_durum,k_resim,k_ozet,k_sayfa from kitaplar inner join kategori on kitaplar.k_kategori=kategori.kategori_id where k_kategori=1", con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("select k_id,k_ad,k_kategori,k_yazar,k_durum,k_resim,k_ozet,k_sayfa from kitaplar inner join kategori on kitaplar.k_kategori=kategori.kategori_id where k_ad=@p1", con);
            komut.Parameters.AddWithValue("@p1", textBox1.Text);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut2 = new SqlCommand("Insert into kitapalma(a_adsoyad,a_tarih,a_kitapadı,a_telefon) Values(@p1,@p2,@p3,@p4)", con);
            
            komut2.Parameters.AddWithValue("@p1", label1.Text);
            komut2.Parameters.AddWithValue("@p2", DateTime.Now);
            komut2.Parameters.AddWithValue("@p3", txtad.Text);
            komut2.Parameters.AddWithValue("@p4", label2.Text);
            komut2.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kitap Alımı Başarılı");
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
            SqlDataAdapter dataAdapter = new SqlDataAdapter(new SqlCommand("SELECT k_resim FROM kitaplar WHERE k_id = '" + txtid.Text + "'", con));
            DataSet dataSet = new DataSet();
            dataAdapter.Fill(dataSet);
            Byte[] data = new Byte[0];
            data = (Byte[])(dataSet.Tables[0].Rows[0]["k_resim"]);
            MemoryStream mem = new MemoryStream(data);
            pictureBox1.Image = Image.FromStream(mem);
        }

        private void tarihToolStripMenuItem_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("select k_id,k_ad,k_kategori,k_yazar,k_durum,k_resim,k_ozet,k_sayfa from kitaplar inner join kategori on kitaplar.k_kategori=kategori.kategori_id where k_kategori=3", con);
            SqlDataAdapter da = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
            con.Close();
        }

        private void tümünüListeleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.kitaplarTableAdapter.Fill(this.kutuphaneDataSet.kitaplar);
        }

        private void button3_Click(object sender, EventArgs e)
        {
           dataGridView1.DataSource=(from x in db.kitaplars
                                                     select new

                                                     {
                                                         x.k_id,
                                                         x.k_ad,
                                                         x.k_kategori,
                                                         x.k_yazar,
                                                         x.k_durum,
                                                         x.k_resim,
                                                         x.k_ozet,
                                                         x.k_sayfa
                                                     }).ToList();
        }
    }
}
