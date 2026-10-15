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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnDongY_Click(object sender, EventArgs e)
        {
            double hki, hkii;

            if (!double.TryParse(txtHKI.Text, out hki) ||
                !double.TryParse(txtHKII.Text, out hkii))
            {
                MessageBox.Show("Vui lòng nhập điểm hợp lệ!");
                return;
            }

            if (hki < 0 || hki > 10 || hkii < 0 || hkii > 10)
            {
                MessageBox.Show("Điểm phải nằm trong khoảng từ 0 đến 10!");
                return;
            }

            double dtb = (hki + hkii * 2) / 3;

            if (dtb >= 8.0)
            {
                txtXepLoai.Text = "Giỏi";
            }
            else if (dtb >= 6.5)
            {
                txtXepLoai.Text = "Khá";
            }
            else if (dtb >= 5.0)
            {
                txtXepLoai.Text = "Trung bình";
            }
            else
            {
                txtXepLoai.Text = "Yếu";
            }
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtHKI.Clear();
            txtHKII.Clear();
            txtXepLoai.Clear();

            txtHKI.Focus();

        }
    }
}
