using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TakipProjesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMüşteriKyt_Click(object sender, EventArgs e)
        {
            frmMüşteriKayıt ekle = new frmMüşteriKayıt();
            ekle.ShowDialog();
        }

        private void BtnÇıkış_Click(object sender, EventArgs e)
        {

        }

        private void btnSiparişKyt_Click(object sender, EventArgs e)
        {
            frmSiparişKayıt ekle = new frmSiparişKayıt();
            ekle.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMüşteriListeleme listele = new frmMüşteriListeleme();
            listele.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            frmKategori kategori = new frmKategori();
            kategori.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frmMarka marka = new frmMarka();
            marka.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            frmMüşteriListeleme listele = new frmMüşteriListeleme();
            listele.ShowDialog();
        }
    }
}
