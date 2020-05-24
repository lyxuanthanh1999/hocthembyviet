namespace ThietKeUserControls
{
    partial class UC_SanPham
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbMaSanPham = new System.Windows.Forms.Label();
            this.lbTenSanPham = new System.Windows.Forms.Label();
            this.tbTenSanPham = new System.Windows.Forms.TextBox();
            this.btnNext = new System.Windows.Forms.Button();
            this.tbMaSanPham = new ThietKeControls.tbNhapSo();
            this.lbMaHangSX = new System.Windows.Forms.Label();
            this.tbMaHangSX = new System.Windows.Forms.TextBox();
            this.lbGia = new System.Windows.Forms.Label();
            this.tbGia = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lbMaSanPham
            // 
            this.lbMaSanPham.AutoSize = true;
            this.lbMaSanPham.Location = new System.Drawing.Point(3, 3);
            this.lbMaSanPham.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaSanPham.Name = "lbMaSanPham";
            this.lbMaSanPham.Size = new System.Drawing.Size(80, 13);
            this.lbMaSanPham.TabIndex = 0;
            this.lbMaSanPham.Text = "Ma San Pham: ";
            // 
            // lbTenSanPham
            // 
            this.lbTenSanPham.AutoSize = true;
            this.lbTenSanPham.Location = new System.Drawing.Point(2, 40);
            this.lbTenSanPham.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbTenSanPham.Name = "lbTenSanPham";
            this.lbTenSanPham.Size = new System.Drawing.Size(84, 13);
            this.lbTenSanPham.TabIndex = 0;
            this.lbTenSanPham.Text = "Ten San Pham: ";
            // 
            // tbTenSanPham
            // 
            this.tbTenSanPham.Location = new System.Drawing.Point(98, 40);
            this.tbTenSanPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbTenSanPham.Name = "tbTenSanPham";
            this.tbTenSanPham.ReadOnly = true;
            this.tbTenSanPham.Size = new System.Drawing.Size(138, 20);
            this.tbTenSanPham.TabIndex = 2;
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(98, 74);
            this.btnNext.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(62, 24);
            this.btnNext.TabIndex = 3;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // tbMaSanPham
            // 
            this.tbMaSanPham.Location = new System.Drawing.Point(98, 3);
            this.tbMaSanPham.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMaSanPham.Name = "tbMaSanPham";
            this.tbMaSanPham.Size = new System.Drawing.Size(138, 20);
            this.tbMaSanPham.TabIndex = 1;
            this.tbMaSanPham.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbMaSanPham_KeyDown);
            // 
            // lbMaHangSX
            // 
            this.lbMaHangSX.AutoSize = true;
            this.lbMaHangSX.Location = new System.Drawing.Point(248, 7);
            this.lbMaHangSX.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbMaHangSX.Name = "lbMaHangSX";
            this.lbMaHangSX.Size = new System.Drawing.Size(71, 13);
            this.lbMaHangSX.TabIndex = 0;
            this.lbMaHangSX.Text = "Ma HangSX: ";
            // 
            // tbMaHangSX
            // 
            this.tbMaHangSX.Location = new System.Drawing.Point(321, 3);
            this.tbMaHangSX.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbMaHangSX.Name = "tbMaHangSX";
            this.tbMaHangSX.ReadOnly = true;
            this.tbMaHangSX.Size = new System.Drawing.Size(138, 20);
            this.tbMaHangSX.TabIndex = 2;
            // 
            // lbGia
            // 
            this.lbGia.AutoSize = true;
            this.lbGia.Location = new System.Drawing.Point(248, 41);
            this.lbGia.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbGia.Name = "lbGia";
            this.lbGia.Size = new System.Drawing.Size(32, 13);
            this.lbGia.TabIndex = 0;
            this.lbGia.Text = "Gia:  ";
            // 
            // tbGia
            // 
            this.tbGia.Location = new System.Drawing.Point(321, 37);
            this.tbGia.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.tbGia.Name = "tbGia";
            this.tbGia.ReadOnly = true;
            this.tbGia.Size = new System.Drawing.Size(138, 20);
            this.tbGia.TabIndex = 2;
            // 
            // UC_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnNext);
            this.Controls.Add(this.tbGia);
            this.Controls.Add(this.tbMaHangSX);
            this.Controls.Add(this.tbTenSanPham);
            this.Controls.Add(this.tbMaSanPham);
            this.Controls.Add(this.lbGia);
            this.Controls.Add(this.lbTenSanPham);
            this.Controls.Add(this.lbMaHangSX);
            this.Controls.Add(this.lbMaSanPham);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "UC_SanPham";
            this.Size = new System.Drawing.Size(476, 115);
            this.Load += new System.EventHandler(this.UC_SanPham_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbMaSanPham;
        private System.Windows.Forms.Label lbTenSanPham;
        private ThietKeControls.tbNhapSo tbMaSanPham;
        private System.Windows.Forms.TextBox tbTenSanPham;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lbMaHangSX;
        private System.Windows.Forms.TextBox tbMaHangSX;
        private System.Windows.Forms.Label lbGia;
        private System.Windows.Forms.TextBox tbGia;
    }
}
