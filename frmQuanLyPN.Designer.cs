
namespace CNPM
{
    partial class frmQuanLyPN
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
            this.btnTaoPN = new System.Windows.Forms.Button();
            this.btnXoaPN = new System.Windows.Forms.Button();
            this.btnSuaPN = new System.Windows.Forms.Button();
            this.dgvCTPN = new System.Windows.Forms.DataGridView();
            this.tbNgayNhap = new System.Windows.Forms.TextBox();
            this.tbNguoiNhap = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dgvPN = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMaPN = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPN)).BeginInit();
            this.SuspendLayout();
            // 
            // btnTaoPN
            // 
            this.btnTaoPN.Location = new System.Drawing.Point(482, 36);
            this.btnTaoPN.Name = "btnTaoPN";
            this.btnTaoPN.Size = new System.Drawing.Size(145, 23);
            this.btnTaoPN.TabIndex = 0;
            this.btnTaoPN.Text = "Tạo Phiếu Nhập";
            this.btnTaoPN.UseVisualStyleBackColor = true;
            this.btnTaoPN.Click += new System.EventHandler(this.btnTaoPN_Click);
            // 
            // btnXoaPN
            // 
            this.btnXoaPN.Location = new System.Drawing.Point(482, 83);
            this.btnXoaPN.Name = "btnXoaPN";
            this.btnXoaPN.Size = new System.Drawing.Size(145, 23);
            this.btnXoaPN.TabIndex = 1;
            this.btnXoaPN.Text = "Xoá Phiếu Nhập";
            this.btnXoaPN.UseVisualStyleBackColor = true;
            this.btnXoaPN.Click += new System.EventHandler(this.btnXoaPN_Click);
            // 
            // btnSuaPN
            // 
            this.btnSuaPN.Location = new System.Drawing.Point(482, 129);
            this.btnSuaPN.Name = "btnSuaPN";
            this.btnSuaPN.Size = new System.Drawing.Size(145, 23);
            this.btnSuaPN.TabIndex = 2;
            this.btnSuaPN.Text = "Sửa Phiếu Nhập";
            this.btnSuaPN.UseVisualStyleBackColor = true;
            this.btnSuaPN.Click += new System.EventHandler(this.btnSuaPN_Click_1);
            // 
            // dgvCTPN
            // 
            this.dgvCTPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPN.Location = new System.Drawing.Point(323, 199);
            this.dgvCTPN.Name = "dgvCTPN";
            this.dgvCTPN.Size = new System.Drawing.Size(365, 120);
            this.dgvCTPN.TabIndex = 3;
            // 
            // tbNgayNhap
            // 
            this.tbNgayNhap.Location = new System.Drawing.Point(105, 225);
            this.tbNgayNhap.Name = "tbNgayNhap";
            this.tbNgayNhap.Size = new System.Drawing.Size(100, 20);
            this.tbNgayNhap.TabIndex = 4;
            // 
            // tbNguoiNhap
            // 
            this.tbNguoiNhap.Location = new System.Drawing.Point(105, 262);
            this.tbNguoiNhap.Name = "tbNguoiNhap";
            this.tbNguoiNhap.Size = new System.Drawing.Size(100, 20);
            this.tbNguoiNhap.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(320, 174);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Chi Tiết Phiếu Nhập:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(21, 225);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Ngày nhập:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(21, 262);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Người Nhập:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Danh Sách Phiếu Nhập:";
            // 
            // dgvPN
            // 
            this.dgvPN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPN.Location = new System.Drawing.Point(0, 36);
            this.dgvPN.Name = "dgvPN";
            this.dgvPN.Size = new System.Drawing.Size(425, 116);
            this.dgvPN.TabIndex = 10;
            this.dgvPN.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPN_CellContentClick);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(21, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(84, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Mã Phiếu Nhập:";
            // 
            // txtMaPN
            // 
            this.txtMaPN.AutoSize = true;
            this.txtMaPN.Location = new System.Drawing.Point(126, 199);
            this.txtMaPN.Name = "txtMaPN";
            this.txtMaPN.Size = new System.Drawing.Size(0, 13);
            this.txtMaPN.TabIndex = 12;
            // 
            // frmQuanLyPN
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 318);
            this.Controls.Add(this.txtMaPN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dgvPN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbNguoiNhap);
            this.Controls.Add(this.tbNgayNhap);
            this.Controls.Add(this.dgvCTPN);
            this.Controls.Add(this.btnSuaPN);
            this.Controls.Add(this.btnXoaPN);
            this.Controls.Add(this.btnTaoPN);
            this.Name = "frmQuanLyPN";
            this.Text = "Quan Ly Phieu Nhap";
            this.Load += new System.EventHandler(this.frmQuanLyPN_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPN)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPN)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnTaoPN;
        private System.Windows.Forms.Button btnXoaPN;
        private System.Windows.Forms.Button btnSuaPN;
        private System.Windows.Forms.DataGridView dgvCTPN;
        private System.Windows.Forms.TextBox tbNgayNhap;
        private System.Windows.Forms.TextBox tbNguoiNhap;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvPN;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label txtMaPN;
    }
}