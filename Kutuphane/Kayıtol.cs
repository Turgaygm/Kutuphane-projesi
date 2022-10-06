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
    public partial class Kayıtol : Form
    {
        public Kayıtol()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=302-12;Initial Catalog=Kutuphane;User ID=sa;Password=1234");
        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("Insert into kullanicig(K_kadı,K_kparola,K_Adsoyad,K_Telefon)values(@p1,@p2,@p3,@p4)", con);
            komut.Parameters.AddWithValue("@p1", txtkadı.Text);
            komut.Parameters.AddWithValue("@p2", txtparola.Text);
            komut.Parameters.AddWithValue("@p3", txtadsoyad.Text);
            komut.Parameters.AddWithValue("@p4", maskedTextBox1.Text);
            komut.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Kayıt Başarılı");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kgiris kgrs = new kgiris();
            kgrs.Show();
            this.Hide();
        }
    }
}
