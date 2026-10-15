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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            double chieuDai, chieuRong;

            if (!double.TryParse(txtChieuDai.Text, out chieuDai) ||
                !double.TryParse(txtChieuRong.Text, out chieuRong))
            {
                MessageBox.Show("Vui lòng nhập số hợp lệ!");
                return;
            }

            if (chieuDai <= 0 || chieuRong <= 0)
            {
                MessageBox.Show("Chiều dài và chiều rộng phải lớn hơn 0!");
                return;
            }

            double chuVi = 2 * (chieuDai + chieuRong);
            double dienTich = chieuDai * chieuRong;

            txtChuVi.Text = chuVi.ToString();
            txtDienTich.Text = dienTich.ToString();
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtChieuDai.Clear();
            txtChieuRong.Clear();
            txtChuVi.Clear();
            txtDienTich.Clear();

            txtChieuDai.Focus();
        }
    }
}
