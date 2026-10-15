namespace P.A
{
    partial class Form4
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
            this.lblChiSoDau = new System.Windows.Forms.Label();
            this.lblChiSoCuoi = new System.Windows.Forms.Label();
            this.lblTienDien = new System.Windows.Forms.Label();
            this.txtChiSoDau = new System.Windows.Forms.TextBox();
            this.txtChiSoCuoi = new System.Windows.Forms.TextBox();
            this.txtTienDien = new System.Windows.Forms.TextBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDB
            // 
            this.lblDB.AutoSize = true;
            this.lblDB.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDB.Location = new System.Drawing.Point(324, 55);
            this.lblDB.Name = "lblDB";
            this.lblDB.Size = new System.Drawing.Size(235, 32);
            this.lblDB.TabIndex = 0;
            this.lblDB.Text = "TÍNH TIỀN ĐIỆN";
            // 
            // lblChiSoDau
            // 
            this.lblChiSoDau.AutoSize = true;
            this.lblChiSoDau.Location = new System.Drawing.Point(102, 113);
            this.lblChiSoDau.Name = "lblChiSoDau";
            this.lblChiSoDau.Size = new System.Drawing.Size(70, 16);
            this.lblChiSoDau.TabIndex = 0;
            this.lblChiSoDau.Text = "Chỉ số đầu";
            // 
            // lblChiSoCuoi
            // 
            this.lblChiSoCuoi.AutoSize = true;
            this.lblChiSoCuoi.Location = new System.Drawing.Point(102, 174);
            this.lblChiSoCuoi.Name = "lblChiSoCuoi";
            this.lblChiSoCuoi.Size = new System.Drawing.Size(76, 16);
            this.lblChiSoCuoi.TabIndex = 0;
            this.lblChiSoCuoi.Text = "Chỉ Số Cuối";
            // 
            // lblTienDien
            // 
            this.lblTienDien.AutoSize = true;
            this.lblTienDien.Location = new System.Drawing.Point(89, 244);
            this.lblTienDien.Name = "lblTienDien";
            this.lblTienDien.Size = new System.Drawing.Size(111, 16);
            this.lblTienDien.TabIndex = 0;
            this.lblTienDien.Text = "Số tiền phải đóng";
            // 
            // txtChiSoDau
            // 
            this.txtChiSoDau.Location = new System.Drawing.Point(216, 113);
            this.txtChiSoDau.Name = "txtChiSoDau";
            this.txtChiSoDau.Size = new System.Drawing.Size(250, 22);
            this.txtChiSoDau.TabIndex = 1;
            // 
            // txtChiSoCuoi
            // 
            this.txtChiSoCuoi.Location = new System.Drawing.Point(216, 174);
            this.txtChiSoCuoi.Name = "txtChiSoCuoi";
            this.txtChiSoCuoi.Size = new System.Drawing.Size(250, 22);
            this.txtChiSoCuoi.TabIndex = 1;
            // 
            // txtTienDien
            // 
            this.txtTienDien.Location = new System.Drawing.Point(216, 244);
            this.txtTienDien.Name = "txtTienDien";
            this.txtTienDien.Size = new System.Drawing.Size(250, 22);
            this.txtTienDien.TabIndex = 1;
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(141, 324);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(124, 36);
            this.btnDongY.TabIndex = 2;
            this.btnDongY.Text = "Đồng ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(374, 324);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(124, 36);
            this.btnLamLai.TabIndex = 2;
            this.btnLamLai.Text = "Làm Lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtTienDien);
            this.Controls.Add(this.txtChiSoCuoi);
            this.Controls.Add(this.txtChiSoDau);
            this.Controls.Add(this.lblTienDien);
            this.Controls.Add(this.lblChiSoCuoi);
            this.Controls.Add(this.lblChiSoDau);
            this.Controls.Add(this.lblDB);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDB;
        private System.Windows.Forms.Label lblChiSoDau;
        private System.Windows.Forms.Label lblChiSoCuoi;
        private System.Windows.Forms.Label lblTienDien;
        private System.Windows.Forms.TextBox txtChiSoDau;
        private System.Windows.Forms.TextBox txtChiSoCuoi;
        private System.Windows.Forms.TextBox txtTienDien;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnLamLai;
    }
}