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
    public partial class AracKayit : Form
    {
        public AracKayit()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-KR485FT\SQLEXPRESS;Initial Catalog=AracOtomasyon;Persist Security Info=True;User ID=sa;Password=5665");
        #region Textleri Silme
        void TextleriTemizle()
        {
            txt_plaka.Text = "";
            cmb_marka.Text = "";
            cmb_seri.Text = "";
            txt_model.Text = "";
            cmb_renk.Text = "";
            txt_kilometre.Text = "";
            cmb_yakit.Text = "";
            txt_fiyat.Text = "";
            txt_plaka.Focus();
        }

        #endregion
        private void btn_arac_kaydet_Click(object sender, EventArgs e)
        {
            
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                DynamicParameters dp = new DynamicParameters();
                #region Oluşturduğum değişkenleri textlere atadım.
                dp.Add("@AracPlaka", txt_plaka.Text.ToUpper());
                dp.Add("@AracMarkaa",cmb_marka.SelectedIndex);
                dp.Add("@AracSerii", cmb_seri.SelectedIndex);
                dp.Add("@AracModel", txt_model.Text);
                dp.Add("@AracRenk", cmb_renk.Text);
                dp.Add("@AracKm", txt_kilometre.Text);
                dp.Add("@AracYakit", cmb_yakit.Text);
                dp.Add("@AracFiyati", txt_fiyat.Text);
                #endregion
                con.Execute("AracEkle", dp, commandType: CommandType.StoredProcedure);
                MessageBox.Show("Araç Eklendi", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                TextleriTemizle();
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                con.Close();
            }

        }

        private void cmb_marka_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            #region Araç Markalarını serilerine göre düzenledim.
            cmb_seri.Items.Clear();
            cmb_seri.Text = "";
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                SqlCommand komut = new SqlCommand("Select * from TblAracSeri where Marka=@p1", con);
                komut.Parameters.AddWithValue("@p1", cmb_marka.Text);
                SqlDataReader dr = komut.ExecuteReader();
                while (dr.Read())
                {
                    cmb_seri.Items.Add(dr["AracSeri"]);
                }
                con.Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            #endregion
        }

        private void AracKayit_Load(object sender, EventArgs e)
        {
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
    }
}
