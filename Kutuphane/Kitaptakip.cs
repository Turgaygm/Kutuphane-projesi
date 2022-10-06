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
namespace Kutuphane
{
    public partial class Kitaptakip : Form
    {
        public Kitaptakip()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source = 302-12; Initial Catalog =Kutuphane; User ID = sa; Password=1234");
        private void button1_Click(object sender, EventArgs e)
        {
            yonetici yntc = new yonetici();
            yntc.Show();
            this.Hide();
        }

        private void btnlistele_Click(object sender, EventArgs e)
        {
            this.kitapalmaTableAdapter.Fill(this.kutuphaneDataSet.kitapalma);
        }

        private void Kitaptakip_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'kutuphaneDataSet.kitapalma' table. You can move, or remove it, as needed.
           

        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut3 = new SqlCommand("delete from kitapalma where a_id=@p1",con);
            
            komut3.Parameters.AddWithValue("@p1", textBox2.Text);
            komut3.ExecuteNonQuery() ;
            con.Close();
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut4 = new SqlCommand("update kitapalma set a_adsoyad=@p2,a_tarih=@p3,a_kitapadı=@p4,a_telefon=@p5, WHERE a_id=@p1", con);
            komut4.Parameters.AddWithValue("@p1",textBox2.Text);
            komut4.Parameters.AddWithValue("@p2", txtad);
            komut4.Parameters.AddWithValue("@p3", maskedTextBox1.Text);
            komut4.Parameters.AddWithValue("@p4", textBox4.Text);
            komut4.Parameters.AddWithValue("@p5", maskedTextBox2.Text);
            komut4.ExecuteNonQuery();
            con.Close();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secim = dataGridView1.SelectedCells[0].RowIndex;
            textBox2.Text = dataGridView1.Rows[secim].Cells[0].Value.ToString();
            txtad.Text = dataGridView1.Rows[secim].Cells[1].Value.ToString();
            maskedTextBox1.Text = dataGridView1.Rows[secim].Cells[2].Value.ToString();
            textBox4.Text = dataGridView1.Rows[secim].Cells[3].Value.ToString();
            maskedTextBox2.Text = dataGridView1.Rows[secim].Cells[4].Value.ToString();
           
        }
    }
}
