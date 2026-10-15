namespace P.A
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblDB = new System.Windows.Forms.Label();
            this.lblChieuDai = new System.Windows.Forms.Label();
            this.lblChieuRong = new System.Windows.Forms.Label();
            this.lblChuVi = new System.Windows.Forms.Label();
            this.lblDienTich = new System.Windows.Forms.Label();
            this.txtChieuDai = new System.Windows.Forms.TextBox();
            this.txtChieuRong = new System.Windows.Forms.TextBox();
            this.txtChuVi = new System.Windows.Forms.TextBox();
            this.txtDienTich = new System.Windows.Forms.TextBox();
            this.btnTinh = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDB.Location = new System.Drawing.Point(171, 76);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(507, 29);
            this.lblDB.TabIndex = 0;
            this.lblDB.Text = "TÍNH CHU VI DIỆN TÍCH HÌNH CHỮ NHẬT";
            // 
            // lblChieuDai
            // 
            this.lblChieuDai.AutoSize = true;
            this.lblChieuDai.Location = new System.Drawing.Point(82, 143);
            this.lblChieuDai.Name = "lblChieuDai";
            this.lblChieuDai.Size = new System.Drawing.Size(65, 16);
            this.lblChieuDai.TabIndex = 0;
            this.lblChieuDai.Text = "Chiều Dài";
            // 
            // lblChieuRong
            // 
            this.lblChieuRong.AutoSize = true;
            this.lblChieuRong.Location = new System.Drawing.Point(82, 207);
            this.lblChieuRong.Name = "lblChieuRong";
            this.lblChieuRong.Size = new System.Drawing.Size(77, 16);
            this.lblChieuRong.TabIndex = 0;
            this.lblChieuRong.Text = "Chiều Rộng";
            // 
            // lblChuVi
            // 
            this.lblChuVi.AutoSize = true;
            this.lblChuVi.Location = new System.Drawing.Point(82, 270);
            this.lblChuVi.Name = "lblChuVi";
            this.lblChuVi.Size = new System.Drawing.Size(45, 16);
            this.lblChuVi.TabIndex = 0;
            this.lblChuVi.Text = "Chu Vi";
            // 
            // lblDienTich
            // 
            this.lblDienTich.AutoSize = true;
            this.lblDienTich.Location = new System.Drawing.Point(82, 340);
            this.lblDienTich.Name = "lblDienTich";
            this.lblDienTich.Size = new System.Drawing.Size(64, 16);
            this.lblDienTich.TabIndex = 0;
            this.lblDienTich.Text = "Diện Tích";
            // 
            // txtChieuDai
            // 
            this.txtChieuDai.Location = new System.Drawing.Point(185, 143);
            this.txtChieuDai.Name = "txtChieuDai";
            this.txtChieuDai.Size = new System.Drawing.Size(424, 22);
            this.txtChieuDai.TabIndex = 1;
            // 
            // txtChieuRong
            // 
            this.txtChieuRong.Location = new System.Drawing.Point(185, 207);
            this.txtChieuRong.Name = "txtChieuRong";
            this.txtChieuRong.Size = new System.Drawing.Size(424, 22);
            this.txtChieuRong.TabIndex = 1;
            // 
            // txtChuVi
            // 
            this.txtChuVi.Location = new System.Drawing.Point(185, 270);
            this.txtChuVi.Name = "txtChuVi";
            this.txtChuVi.Size = new System.Drawing.Size(424, 22);
            this.txtChuVi.TabIndex = 1;
            // 
            // txtDienTich
            // 
            this.txtDienTich.Location = new System.Drawing.Point(185, 340);
            this.txtDienTich.Name = "txtDienTich";
            this.txtDienTich.Size = new System.Drawing.Size(424, 22);
            this.txtDienTich.TabIndex = 1;
            // 
            // btnTinh
            // 
            this.btnTinh.Location = new System.Drawing.Point(136, 422);
            this.btnTinh.Name = "btnTinh";
            this.btnTinh.Size = new System.Drawing.Size(129, 38);
            this.btnTinh.TabIndex = 2;
            this.btnTinh.Text = "Tính";
            this.btnTinh.UseVisualStyleBackColor = true;
            this.btnTinh.Click += new System.EventHandler(this.btnTinh_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(417, 422);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(129, 38);
            this.btnLamLai.TabIndex = 2;
            this.btnLamLai.Text = "Làm Lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(850, 528);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnTinh);
            this.Controls.Add(this.txtDienTich);
            this.Controls.Add(this.txtChuVi);
            this.Controls.Add(this.txtChieuRong);
            this.Controls.Add(this.txtChieuDai);
            this.Controls.Add(this.lblDienTich);
            this.Controls.Add(this.lblChuVi);
            this.Controls.Add(this.lblChieuRong);
            this.Controls.Add(this.lblChieuDai);
            this.Controls.Add(this.lblDB);
            this.Name = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblDB;
        private System.Windows.Forms.Label lblChieuDai;
        private System.Windows.Forms.Label lblChieuRong;
        private System.Windows.Forms.Label lblChuVi;
        private System.Windows.Forms.Label lblDienTich;
        private System.Windows.Forms.TextBox txtChieuDai;
        private System.Windows.Forms.TextBox txtChieuRong;
        private System.Windows.Forms.TextBox txtChuVi;
        private System.Windows.Forms.TextBox txtDienTich;
        private System.Windows.Forms.Button btnTinh;
        private System.Windows.Forms.Button btnLamLai;
    }
}