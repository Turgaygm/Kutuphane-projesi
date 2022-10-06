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
    public partial class kgiris : Form
    {
        
        public kgiris()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection("Data Source=302-12;Initial Catalog=Kutuphane;User ID=sa;Password=1234");
        private void button3_Click(object sender, EventArgs e)
        {
            Kayıtol kyt = new Kayıtol();
            kyt.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand login = new SqlCommand("Select * from kullanicig where K_kadı=@p1 and K_kparola=@p2", con);
            login.Parameters.AddWithValue("@p1", textBox1.Text);
            login.Parameters.AddWithValue("@p2", textBox2.Text);
            //SqlDataReader oku = login.ExecuteReader();

            SqlDataAdapter dataAdapter = new SqlDataAdapter(login);
            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);
            if (dt.Rows.Count>0)
            {
                Kullanıcı fr = new Kullanıcı();
                variables.k_id = Convert.ToInt32(dt.Rows[0]["K_id"]);
                variables.k_adsoyad = dt.Rows[0]["K_Adsoyad"].ToString();
                variables.k_telefon= dt.Rows[0]["K_Telefon"].ToString();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
            con.Close();
           
            
           
            if (dt.Rows.Count > 0)
            {

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand login = new SqlCommand("Select * from yonetici where Y_Adı=@p1 and Y_Parola=@p2", con);
            login.Parameters.AddWithValue("@p1", textBox1.Text);
            login.Parameters.AddWithValue("@p2", textBox2.Text);
            SqlDataReader oku = login.ExecuteReader();
            if (oku.Read())
            {
                yonetici fr = new yonetici();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş");
            }
            con.Close();
        }
    }
}
