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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnTinh_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtBanKinh.Text, out double r))
            {
                MessageBox.Show("Vui lòng nhập bán kính hợp lệ!");
                txtBanKinh.Focus();
                return;
            }

            if (r <= 0)
            {
                MessageBox.Show("Bán kính phải lớn hơn 0!");
                txtBanKinh.Focus();
                return;
            }

            double chuVi = 2 * Math.PI * r;
            double dienTich = Math.PI * r * r;

            txtChuVi.Text = chuVi.ToString("0.00");
            txtDienTich.Text = dienTich.ToString("0.00");
        }

        private void btnLamLai_Click(object sender, EventArgs e)
        {
            txtBanKinh.Clear();
            txtChuVi.Clear();
            txtDienTich.Clear();

            txtBanKinh.Focus();
        }

        private void bài1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
        }

        private void bài2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }

        private void bài3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
        }

        private void bài4ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
