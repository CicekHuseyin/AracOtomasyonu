using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otomsayon
{
    public partial class AdminPaneli : Form
    {
        public AdminPaneli()
        {
            InitializeComponent();
        }
        string kadi, sifre;
        private void btn_giris_Click(object sender, EventArgs e)
        {   
            kadi = txt_kadi.Text;
            sifre = txt_sifre.Text;
            if ((kadi=="Admin"||kadi=="admin") && sifre=="1234")
            {
                Anasayfa anasayfa = new Anasayfa();
                anasayfa.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_kadi.Text = "";
                txt_sifre.Text = "";
                txt_kadi.Focus();
            }
        }
    }
}
