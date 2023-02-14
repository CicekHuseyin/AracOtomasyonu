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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AracKayit arackayit = new AracKayit();
            arackayit.Show();
            
        }


        private void button6_Click(object sender, EventArgs e)
        {
            AracRapor aracrapor = new AracRapor();
            aracrapor.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            AracListele araclistele = new AracListele();
            araclistele.Show();
        }
    }
}
