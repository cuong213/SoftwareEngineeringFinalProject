
namespace CNPM
{
    partial class frmMain
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
            this.btnQuanLyPN = new System.Windows.Forms.Button();
            this.btnQuanLyPX = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnQuanLyPN
            // 
            this.btnQuanLyPN.Location = new System.Drawing.Point(127, 127);
            this.btnQuanLyPN.Name = "btnQuanLyPN";
            this.btnQuanLyPN.Size = new System.Drawing.Size(106, 49);
            this.btnQuanLyPN.TabIndex = 0;
            this.btnQuanLyPN.Text = "Quản Lý Phiếu Nhập";
            this.btnQuanLyPN.UseVisualStyleBackColor = true;
            this.btnQuanLyPN.Click += new System.EventHandler(this.btnQuanLyPN_Click);
            // 
            // btnQuanLyPX
            // 
            this.btnQuanLyPX.Location = new System.Drawing.Point(281, 127);
            this.btnQuanLyPX.Name = "btnQuanLyPX";
            this.btnQuanLyPX.Size = new System.Drawing.Size(106, 49);
            this.btnQuanLyPX.TabIndex = 1;
            this.btnQuanLyPX.Text = "Quản Lý Phiếu Xuất";
            this.btnQuanLyPX.UseVisualStyleBackColor = true;
            this.btnQuanLyPX.Click += new System.EventHandler(this.btnQuanLyPX_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(111, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(291, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Phần Mềm Quản Lý Kho";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 248);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnQuanLyPX);
            this.Controls.Add(this.btnQuanLyPN);
            this.Name = "frmMain";
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQuanLyPN;
        private System.Windows.Forms.Button btnQuanLyPX;
        private System.Windows.Forms.Label label1;
    }
}