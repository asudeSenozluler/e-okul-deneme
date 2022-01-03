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

namespace e_okul_deneme
{
    public partial class frm_ogrenci_detay : Form
    {
        public frm_ogrenci_detay()
        {
            InitializeComponent();
        }
        public string numara;
        SqlConnection baglanti = new SqlConnection(@"Data Source=DESKTOP-RE91BPD\SQLEXPRESS;Initial Catalog=DbNotKayıt;Integrated Security=True");
        private void frm_ogrenci_detay_Load(object sender, EventArgs e)
        {
            lblnum.Text = numara;
            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * from TBLDERS where OGRNUMARA=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", numara);
            SqlDataReader dr = komut.ExecuteReader();

            while(dr.Read())
            {
                lblad.Text = dr[2].ToString() + " " + dr[3].ToString();
                lbls1.Text = dr[4].ToString();
                lbls2.Text = dr[5].ToString();
                lbls3.Text = dr[6].ToString();
                lblort.Text = dr[7].ToString();
                lbldurum.Text = dr[8].ToString();
            }
            baglanti.Close();

        }
       
    }
}
