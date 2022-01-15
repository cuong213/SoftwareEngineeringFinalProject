
namespace CNPM
{
    partial class frmQuanLyPX
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
            this.dgvPX = new System.Windows.Forms.DataGridView();
            this.dgvCTPX = new System.Windows.Forms.DataGridView();
            this.btnTaoPX = new System.Windows.Forms.Button();
            this.btnSuaPX = new System.Windows.Forms.Button();
            this.btnXoaPX = new System.Windows.Forms.Button();
            this.tbNgayXuat = new System.Windows.Forms.TextBox();
            this.tbNguoiXuat = new System.Windows.Forms.TextBox();
            this.txtMaPX = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPX)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPX)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Danh Sách Phiếu Xuất";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(216, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Chi Tiết Phiếu Xuất:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 202);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Mã Phiếu Xuất:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày Xuất:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Người Xuất:";
            // 
            // dgvPX
            // 
            this.dgvPX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPX.Location = new System.Drawing.Point(23, 25);
            this.dgvPX.Name = "dgvPX";
            this.dgvPX.Size = new System.Drawing.Size(513, 150);
            this.dgvPX.TabIndex = 5;
            this.dgvPX.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPX_CellContentClick);
            // 
            // dgvCTPX
            // 
            this.dgvCTPX.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCTPX.Location = new System.Drawing.Point(219, 218);
            this.dgvCTPX.Name = "dgvCTPX";
            this.dgvCTPX.Size = new System.Drawing.Size(476, 111);
            this.dgvCTPX.TabIndex = 6;
            // 
            // btnTaoPX
            // 
            this.btnTaoPX.Location = new System.Drawing.Point(567, 25);
            this.btnTaoPX.Name = "btnTaoPX";
            this.btnTaoPX.Size = new System.Drawing.Size(93, 23);
            this.btnTaoPX.TabIndex = 7;
            this.btnTaoPX.Text = "Tạo Phiếu Xuất";
            this.btnTaoPX.UseVisualStyleBackColor = true;
            this.btnTaoPX.Click += new System.EventHandler(this.btnTaoPX_Click);
            // 
            // btnSuaPX
            // 
            this.btnSuaPX.Location = new System.Drawing.Point(567, 89);
            this.btnSuaPX.Name = "btnSuaPX";
            this.btnSuaPX.Size = new System.Drawing.Size(93, 23);
            this.btnSuaPX.TabIndex = 8;
            this.btnSuaPX.Text = "Sửa Phiếu Xuất";
            this.btnSuaPX.UseVisualStyleBackColor = true;
            this.btnSuaPX.Click += new System.EventHandler(this.btnSuaPX_Click);
            // 
            // btnXoaPX
            // 
            this.btnXoaPX.Location = new System.Drawing.Point(567, 152);
            this.btnXoaPX.Name = "btnXoaPX";
            this.btnXoaPX.Size = new System.Drawing.Size(93, 23);
            this.btnXoaPX.TabIndex = 9;
            this.btnXoaPX.Text = "Xoá Phiếu Xuất";
            this.btnXoaPX.UseVisualStyleBackColor = true;
            this.btnXoaPX.Click += new System.EventHandler(this.btnXoaPX_Click);
            // 
            // tbNgayXuat
            // 
            this.tbNgayXuat.Location = new System.Drawing.Point(96, 238);
            this.tbNgayXuat.Name = "tbNgayXuat";
            this.tbNgayXuat.Size = new System.Drawing.Size(100, 20);
            this.tbNgayXuat.TabIndex = 10;
            // 
            // tbNguoiXuat
            // 
            this.tbNguoiXuat.Location = new System.Drawing.Point(96, 288);
            this.tbNguoiXuat.Name = "tbNguoiXuat";
            this.tbNguoiXuat.Size = new System.Drawing.Size(100, 20);
            this.tbNguoiXuat.TabIndex = 11;
            // 
            // txtMaPX
            // 
            this.txtMaPX.AutoSize = true;
            this.txtMaPX.Location = new System.Drawing.Point(127, 202);
            this.txtMaPX.Name = "txtMaPX";
            this.txtMaPX.Size = new System.Drawing.Size(0, 13);
            this.txtMaPX.TabIndex = 12;
            // 
            // frmQuanLyPX
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 331);
            this.Controls.Add(this.txtMaPX);
            this.Controls.Add(this.tbNguoiXuat);
            this.Controls.Add(this.tbNgayXuat);
            this.Controls.Add(this.btnXoaPX);
            this.Controls.Add(this.btnSuaPX);
            this.Controls.Add(this.btnTaoPX);
            this.Controls.Add(this.dgvCTPX);
            this.Controls.Add(this.dgvPX);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmQuanLyPX";
            this.Text = "Quan Ly Phieu Xuat";
            this.Load += new System.EventHandler(this.frmQuanLyPX_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPX)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCTPX)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPX;
        private System.Windows.Forms.DataGridView dgvCTPX;
        private System.Windows.Forms.Button btnTaoPX;
        private System.Windows.Forms.Button btnSuaPX;
        private System.Windows.Forms.Button btnXoaPX;
        private System.Windows.Forms.TextBox tbNgayXuat;
        private System.Windows.Forms.TextBox tbNguoiXuat;
        private System.Windows.Forms.Label txtMaPX;
    }
}