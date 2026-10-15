using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P.A
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            double chiSoDau, chiSoCuoi;

            if (!double.TryParse(txtChiSoDau.Text, out chiSoDau) ||
                !double.TryParse(txtChiSoCuoi.Text, out chiSoCuoi))
            {
                MessageBox.Show("Vui lòng nhập chỉ số điện hợp lệ!");
                return;
            }

            if (chiSoCuoi < chiSoDau)
            {
                MessageBox.Show("Chỉ số cuối phải lớn hơn hoặc bằng chỉ số đầu!");
                return;
            }

            double kWh = chiSoCuoi - chiSoDau;
            double tienDien = 0;

            if (kWh <= 100)
            {
                tienDien = kWh * 500;
            }
            else if (kWh <= 250)
            {
                tienDien = 100 * 500
                         + (kWh - 100) * 600;
            }
            else if (kWh <= 300)
            {
                tienDien = 100 * 500
                         + 150 * 600
                         + (kWh - 250) * 800;
            }
            else
            {
                tienDien = 100 * 500
                         + 150 * 600
                         + 50 * 800
                         + (kWh - 300) * 1000;
            }

            txtTienDien.Text = tienDien.ToString("N0") + " đ";
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtChiSoDau.Clear();
            txtChiSoCuoi.Clear();
            txtTienDien.Clear();

            txtChiSoDau.Focus();
        }
    }
}
