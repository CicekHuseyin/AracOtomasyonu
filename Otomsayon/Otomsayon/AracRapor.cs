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
    public partial class AracRapor : Form
    {
        public AracRapor()
        {
            InitializeComponent();
        }

        private void AracRaporla_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'AracOtomasyonDataSet.TblArac' table. You can move, or remove it, as needed.
            this.TblAracTableAdapter.Fill(this.AracOtomasyonDataSet.TblArac);

            this.reportViewer1.RefreshReport();
        }
    }
}
