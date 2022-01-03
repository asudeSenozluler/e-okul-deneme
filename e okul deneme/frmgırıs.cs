using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace e_okul_deneme
{
    public partial class frmgırıs : Form
    {
        public frmgırıs()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm_ogrenci_detay frm = new frm_ogrenci_detay();
            frm.numara = maskedTextBox1.Text;
            frm.Show(); 
            this.Hide();
        }

        

        private void maskedTextBox1_TextChanged(object sender, EventArgs e)
        {
            if(maskedTextBox1.Text=="1111")
            {
                frmogretmen fr = new frmogretmen();
                fr.Show();
            }
        }
    }
}
