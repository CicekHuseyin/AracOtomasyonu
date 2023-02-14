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
using Dapper;

namespace Otomsayon
{
    public partial class AracListele : Form
    {
        public AracListele()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KR485FT\SQLEXPRESS;Initial Catalog=AracOtomasyon;Persist Security Info=True;User ID=sa;Password=5665");

        public object Aracİd { get; private set; }

        #region Verileri Göster
        void VerileriGoster()
        {
            try
            {
                if (con.State == ConnectionState.Closed) //Eğer bağlantı yoksa
                {
                    con.Open(); //Bağlantıyı aç
                }
                DynamicParameters dp = new DynamicParameters();
                List<AracBilgileri> list = con.Query<AracBilgileri>("AracListele", dp, commandType: CommandType.StoredProcedure).ToList<AracBilgileri>();
                dataGridView1.DataSource = list;


            }
            catch (Exception e)
            {

                MessageBox.Show(e.Message);
            }

        }
        #endregion
        #region PlakaAra
        void PlakaAra()
        {
            DynamicParameters dp = new DynamicParameters();
            dp.Add("@Ara", txt_plakara.Text.Trim());
            List<AracBilgileri> list = con.Query<AracBilgileri>("PlakaAra", dp, commandType: CommandType.StoredProcedure).ToList<AracBilgileri>();
            dataGridView1.DataSource = list;
        }
        #endregion
        #region Textboxları Temizle
        void Temizle()
        {
            txt_plaka.Text = "";
            cmb_marka.Text = "";
            cmb_seri.Text = "";
            txt_model.Text = "";
            txt_renk.Text = "";
            txt_kilometre.Text = "";
            cmb_yakit.Text = "";
            txt_fiyat.Text = "";
            txt_plaka.Focus();

        }
        #endregion
        private void AracListele_Load(object sender, EventArgs e)
        {
            VerileriGoster();
            #region Combobax a otomatik markaları listele
            try
            {
                if (con.State == ConnectionState.Closed) //Eğer bağlantı yoksa
                {
                    con.Open(); //Bağlantıyı aç
                }
                SqlCommand komut = new SqlCommand();
                komut.CommandText = "select * from TblAracMarka";
                komut.Connection = con;
                komut.CommandType = CommandType.Text;

                SqlDataReader dr;
                dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    cmb_marka.Items.Add(dr["AracMarka"]);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            con.Close();
            #endregion
        }

        private void btn_sil_Click(object sender, EventArgs e)
        {
            #region Sime İşlemi
            try
            {
                DynamicParameters dp = new DynamicParameters();
                dp.Add("@Aracİd", Aracİd);
                con.Execute("AracSil", dp, commandType: CommandType.StoredProcedure);
                Temizle();
                VerileriGoster();
                MessageBox.Show("Silme Başarılı", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception)
            {

                throw;
            }
            #endregion

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            #region DataGrid'e tıklandığında verileri texte aktarma
            try
            {
                if (dataGridView1.CurrentRow.Index != -1)
                {
                    Aracİd = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                    txt_plaka.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    cmb_marka.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    cmb_seri.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
                    txt_model.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
                    txt_renk.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
                    txt_kilometre.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
                    cmb_yakit.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
                    txt_fiyat.Text = dataGridView1.CurrentRow.Cells[8].Value.ToString();
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            #endregion

        }

        private void btn_guncelle_Click(object sender, EventArgs e)
        {
            #region Güncelleme İşlemi
            try
            {
                if (con.State == ConnectionState.Closed) //Eğer bağlantı yoksa
                {
                    con.Open(); //Bağlantıyı aç
                }
                DynamicParameters dp = new DynamicParameters();
                #region Değişkenlere textboxlara atadım.
                dp.Add("@Aracİd", Aracİd);
                dp.Add("@AracPlaka", txt_plaka.Text);
                dp.Add("@AracMarka", cmb_marka.Text);
                dp.Add("@AracSeri", cmb_seri.Text);
                dp.Add("@AracModel", txt_model.Text);
                dp.Add("@AracRenk", txt_renk.Text);
                dp.Add("@AracKm", txt_kilometre.Text);
                dp.Add("@AracYakit", cmb_yakit.Text);
                dp.Add("@AracFiyati", txt_fiyat.Text);
                #endregion
                con.Execute("AracGuncelle", dp, commandType: CommandType.StoredProcedure);
                MessageBox.Show("Veriler Güncellendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                VerileriGoster();
                Temizle();

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }
            #endregion

        }

        private void cmb_marka_SelectedIndexChanged(object sender, EventArgs e)
        {
            #region Araç Markalarını serilerine göre düzenledim.
            cmb_seri.Text = "";
            if (cmb_marka.SelectedIndex == 0)
            {
                cmb_seri.Items.Clear();
                cmb_seri.Items.Add("A1");
                cmb_seri.Items.Add("A2");
                cmb_seri.Items.Add("A3");
                cmb_seri.Items.Add("A4");
                cmb_seri.Items.Add("A5");
                cmb_seri.Items.Add("A6");
                cmb_seri.Items.Add("A7");
                cmb_seri.Items.Add("A8");
            }
            if (cmb_marka.SelectedIndex == 1)
            {
                cmb_seri.Items.Clear();
                cmb_seri.Items.Add("1 Serisi");
                cmb_seri.Items.Add("2 Serisi");
                cmb_seri.Items.Add("3 Serisi");
                cmb_seri.Items.Add("4 Serisi");
                cmb_seri.Items.Add("5 Serisi");
                cmb_seri.Items.Add("6 Serisi");
                cmb_seri.Items.Add("7 Serisi");
                cmb_seri.Items.Add("8 Serisi");
            }
            if (cmb_marka.SelectedIndex == 2)
            {
                cmb_seri.Items.Clear();
                cmb_seri.Items.Add("Lodgy");
                cmb_seri.Items.Add("Logan");
            }
            if (cmb_marka.SelectedIndex == 3)
            {
                cmb_seri.Items.Clear();
                cmb_seri.Items.Add("Albea");
                cmb_seri.Items.Add("Bravo");
            }
            if (cmb_marka.SelectedIndex == 4)
            {
                cmb_seri.Items.Clear();
                cmb_seri.Items.Add("Civic");
                cmb_seri.Items.Add("City");
            }
            if (cmb_marka.SelectedIndex == 5)
            {
                cmb_seri.Items.Clear();
                cmb_seri.Items.Add("XF");
                cmb_seri.Items.Add("XE");
            }
            if (cmb_marka.SelectedIndex == 6)
            {
                cmb_seri.Items.Clear();
                cmb_seri.Items.Add("Favorite");
                cmb_seri.Items.Add("Fabia");
            }
            if (cmb_marka.SelectedIndex == 7)
            {
                cmb_seri.Items.Clear();
                cmb_seri.Items.Add("Scala");
                cmb_seri.Items.Add("Superb");
            }
            #endregion
        }

        private void txt_plakara_TextChanged(object sender, EventArgs e)
        {
            #region Text'e plaka arandığında
            try
            {
                PlakaAra();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            #endregion

        }
    
    }
    class AracBilgileri
    {
        public int Aracİd { get; set; }
        public string AracPlaka { get; set; }
        public int AracMarkaa { get; set; }
        public int AracSerii { get; set; }
        public int AracModel { get; set; }
        public string AracRenk { get; set; }
        public int AracKm { get; set; }
        public string AracYakit { get; set; }
        public int AracFiyati { get; set; }
    }
}
