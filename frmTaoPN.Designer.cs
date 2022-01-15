
namespace CNPM
{
    partial class frmTaoPN
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tbMaPN = new System.Windows.Forms.TextBox();
            this.tbMaKT = new System.Windows.Forms.TextBox();
            this.tbMaSP = new System.Windows.Forms.TextBox();
            this.tbSoLuong = new System.Windows.Forms.TextBox();
            this.tbDonGia = new System.Windows.Forms.TextBox();
            this.dtNgayNhap = new System.Windows.Forms.DateTimePicker();
            this.btnThemSP = new System.Windows.Forms.Button();
            this.dgvCTPN = new System.Windows.Forms.DataGridView();
            this.btnTaoPN = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.tbTenSP = new System.Windows.Forms.TextBox();
            this.tbMaLH = new System.Windows.Forms.TextBox();
            this.tbDonVi = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(302, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(163, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Phiếu Nhập Kho";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(29, 50);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã Phiếu Nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(236, 50);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Ngày Nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(440, 50);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã Kế Toán:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 149);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Mã Sản Phẩm:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(236, 149);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(56, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số Lượng:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(441, 149);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(49, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Đơn Giá:";
            // 
            // tbMaPN
            // 
            this.tbMaPN.Location = new System.Drawing.Point(112, 43);
            this.tbMaPN.Name = "tbMaPN";
            this.tbMaPN.Size = new System.Drawing.Size(100, 20);
            this.tbMaPN.TabIndex = 7;
            // 
            // tbMaKT
            // 
            this.tbMaKT.Location = new System.Drawing.Point(513, 44);
            this.tbMaKT.Name = "tbMaKT";
            this.tbMaKT.Size = new System.Drawing.Size(100, 20);
            this.tbMaKT.TabIndex = 9;
            // 
            // tbMaSP
            // 
            this.tbMaSP.Location = new System.Drawing.Point(112, 146);
            this.tbMaSP.Name = "tbMaSP";
            this.tbMaSP.Size = new System.Drawing.Size(100, 20);
            this.tbMaSP.TabIndex = 10;
            // 
            // tbSoLuong
            // 
            this.tbSoLuong.Location = new System.Drawing.Point(316, 146);
            this.tbSoLuong.Name = "tbSoLuong";
            this.tbSoLuong.Size = new System.Drawing.Size(100, 20);
            this.tbSoLuong.TabIndex = 11;
            // 
            // tbDonGia
            // 
            this.tbDonGia.Location = new System.Drawing.Point(511, 146);
            this.tbDonGia.Name = "tbDonGia";
            this.tbDonGia.Size = new System.Drawing.Size(102, 20);
            this.tbDonGia.TabIndex = 12;
            // 
            // dtNgayNhap
            // 
            this.dtNgayNhap.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtNgayNhap.Location = new System.Drawing.Point(306, 44);
            this.dtNgayNhap.Name = "dtNgayNhap";
            this.dtNgayNhap.Size = new System.Drawing.Size(100, 20);
            this.dtNgayNhap.TabIndex = 13;
            // 
            // btnThemSP
            // 
            this.btnThemSP.Location = new System.Drawing.Point(655, 129);
            this.btnThemSP.Name = "btnThemSP";
            this.btnThemSP.Size = new System.Drawing.Size(75, 23);
            this.btnThemSP.TabIndex = 14;
            this.btnThemSP.Text = "Thêm SP";
            this.btnThemSP.UseVisualStyleBackColor = true;
            this.btnThemSP.Click += new System.EventHandler(this.btnThemSP_Click);
            // 
            // dgvCTPN
            // 
            this.dgvCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPN.Location = new System.Drawing.Point(0, 216);
            this.dgvCTPN.Name = "dgvCTPN";
            this.dgvCTPN.Size = new System.Drawing.Size(758, 134);
            this.dgvCTPN.TabIndex = 15;
            // 
            // btnTaoPN
            // 
            this.btnTaoPN.Location = new System.Drawing.Point(646, 36);
            this.btnTaoPN.Name = "btnTaoPN";
            this.btnTaoPN.Size = new System.Drawing.Size(100, 41);
            this.btnTaoPN.TabIndex = 16;
            this.btnTaoPN.Text = "Tạo Phiếu Nhập";
            this.btnTaoPN.UseVisualStyleBackColor = true;
            this.btnTaoPN.Click += new System.EventHandler(this.btnTaoPN_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Danh sách sản phẩm :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(29, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(81, 13);
            this.label9.TabIndex = 18;
            this.label9.Text = "Tên Sản Phẩm:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(236, 112);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(77, 13);
            this.label10.TabIndex = 19;
            this.label10.Text = "Mã Loại Hàng:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(441, 115);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(68, 13);
            this.label11.TabIndex = 20;
            this.label11.Text = "Đơn Vị Tính:";
            // 
            // tbTenSP
            // 
            this.tbTenSP.Location = new System.Drawing.Point(112, 112);
            this.tbTenSP.Name = "tbTenSP";
            this.tbTenSP.Size = new System.Drawing.Size(100, 20);
            this.tbTenSP.TabIndex = 21;
            // 
            // tbMaLH
            // 
            this.tbMaLH.Location = new System.Drawing.Point(316, 109);
            this.tbMaLH.Name = "tbMaLH";
            this.tbMaLH.Size = new System.Drawing.Size(100, 20);
            this.tbMaLH.TabIndex = 22;
            // 
            // tbDonVi
            // 
            this.tbDonVi.Location = new System.Drawing.Point(511, 112);
            this.tbDonVi.Name = "tbDonVi";
            this.tbDonVi.Size = new System.Drawing.Size(100, 20);
            this.tbDonVi.TabIndex = 23;
            // 
            // frmTaoPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 347);
            this.Controls.Add(this.tbDonVi);
            this.Controls.Add(this.tbMaLH);
            this.Controls.Add(this.tbTenSP);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.btnTaoPN);
            this.Controls.Add(this.dgvCTPN);
            this.Controls.Add(this.btnThemSP);
            this.Controls.Add(this.dtNgayNhap);
            this.Controls.Add(this.tbDonGia);
            this.Controls.Add(this.tbSoLuong);
            this.Controls.Add(this.tbMaSP);
            this.Controls.Add(this.tbMaKT);
            this.Controls.Add(this.tbMaPN);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmTaoPN";
            this.Text = "Tao Phieu Nhap";
            this.Load += new System.EventHandler(this.frmTaoPN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbMaPN;
        private System.Windows.Forms.TextBox tbMaKT;
        private System.Windows.Forms.TextBox tbMaSP;
        private System.Windows.Forms.TextBox tbSoLuong;
        private System.Windows.Forms.TextBox tbDonGia;
        private System.Windows.Forms.DateTimePicker dtNgayNhap;
        private System.Windows.Forms.Button btnThemSP;
        private System.Windows.Forms.DataGridView dgvCTPN;
        private System.Windows.Forms.Button btnTaoPN;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbTenSP;
        private System.Windows.Forms.TextBox tbMaLH;
        private System.Windows.Forms.TextBox tbDonVi;
    }
}