namespace P.A
{
    partial class Form3
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
            this.lbldb = new System.Windows.Forms.Label();
            this.lblHKI = new System.Windows.Forms.Label();
            this.lblHKII = new System.Windows.Forms.Label();
            this.lblXepLoai = new System.Windows.Forms.Label();
            this.txtHKI = new System.Windows.Forms.TextBox();
            this.txtHKII = new System.Windows.Forms.TextBox();
            this.txtXepLoai = new System.Windows.Forms.TextBox();
            this.btnDongY = new System.Windows.Forms.Button();
            this.btnLamLai = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbldb
            // 
            this.lbldb.AutoSize = true;
            this.lbldb.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbldb.Location = new System.Drawing.Point(242, 57);
            this.lbldb.Name = "lbldb";
            this.lbldb.Size = new System.Drawing.Size(289, 32);
            this.lbldb.TabIndex = 0;
            this.lbldb.Text = "XẾP LOẠI HỌC TẬP";
            // 
            // lblHKI
            // 
            this.lblHKI.AutoSize = true;
            this.lblHKI.Location = new System.Drawing.Point(167, 125);
            this.lblHKI.Name = "lblHKI";
            this.lblHKI.Size = new System.Drawing.Size(62, 16);
            this.lblHKI.TabIndex = 0;
            this.lblHKI.Text = "Điểm HKI";
            // 
            // lblHKII
            // 
            this.lblHKII.AutoSize = true;
            this.lblHKII.Location = new System.Drawing.Point(167, 196);
            this.lblHKII.Name = "lblHKII";
            this.lblHKII.Size = new System.Drawing.Size(65, 16);
            this.lblHKII.TabIndex = 0;
            this.lblHKII.Text = "Điểm HKII";
            // 
            // lblXepLoai
            // 
            this.lblXepLoai.AutoSize = true;
            this.lblXepLoai.Location = new System.Drawing.Point(167, 265);
            this.lblXepLoai.Name = "lblXepLoai";
            this.lblXepLoai.Size = new System.Drawing.Size(60, 16);
            this.lblXepLoai.TabIndex = 0;
            this.lblXepLoai.Text = "Xếp Loại";
            // 
            // txtHKI
            // 
            this.txtHKI.Location = new System.Drawing.Point(245, 125);
            this.txtHKI.Name = "txtHKI";
            this.txtHKI.Size = new System.Drawing.Size(227, 22);
            this.txtHKI.TabIndex = 1;
            // 
            // txtHKII
            // 
            this.txtHKII.Location = new System.Drawing.Point(245, 196);
            this.txtHKII.Name = "txtHKII";
            this.txtHKII.Size = new System.Drawing.Size(227, 22);
            this.txtHKII.TabIndex = 1;
            // 
            // txtXepLoai
            // 
            this.txtXepLoai.Location = new System.Drawing.Point(245, 265);
            this.txtXepLoai.Name = "txtXepLoai";
            this.txtXepLoai.Size = new System.Drawing.Size(227, 22);
            this.txtXepLoai.TabIndex = 1;
            // 
            // btnDongY
            // 
            this.btnDongY.Location = new System.Drawing.Point(110, 333);
            this.btnDongY.Name = "btnDongY";
            this.btnDongY.Size = new System.Drawing.Size(127, 39);
            this.btnDongY.TabIndex = 2;
            this.btnDongY.Text = "Đòng Ý";
            this.btnDongY.UseVisualStyleBackColor = true;
            this.btnDongY.Click += new System.EventHandler(this.btnDongY_Click);
            // 
            // btnLamLai
            // 
            this.btnLamLai.Location = new System.Drawing.Point(361, 333);
            this.btnLamLai.Name = "btnLamLai";
            this.btnLamLai.Size = new System.Drawing.Size(127, 39);
            this.btnLamLai.TabIndex = 2;
            this.btnLamLai.Text = "Làm Lại";
            this.btnLamLai.UseVisualStyleBackColor = true;
            this.btnLamLai.Click += new System.EventHandler(this.btnLamLai_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnLamLai);
            this.Controls.Add(this.btnDongY);
            this.Controls.Add(this.txtXepLoai);
            this.Controls.Add(this.txtHKII);
            this.Controls.Add(this.txtHKI);
            this.Controls.Add(this.lblXepLoai);
            this.Controls.Add(this.lblHKII);
            this.Controls.Add(this.lblHKI);
            this.Controls.Add(this.lbldb);
            this.Name = "Form3";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbldb;
        private System.Windows.Forms.Label lblHKI;
        private System.Windows.Forms.Label lblHKII;
        private System.Windows.Forms.Label lblXepLoai;
        private System.Windows.Forms.TextBox txtHKI;
        private System.Windows.Forms.TextBox txtHKII;
        private System.Windows.Forms.TextBox txtXepLoai;
        private System.Windows.Forms.Button btnDongY;
        private System.Windows.Forms.Button btnLamLai;
    }
}