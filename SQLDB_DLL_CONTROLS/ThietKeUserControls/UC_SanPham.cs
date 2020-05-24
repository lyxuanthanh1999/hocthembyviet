using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MyLibrary;
using BLL;
using DTO;

namespace ThietKeUserControls
{
    public partial class UC_SanPham: UserControl
    {
        private SanPhamBLL sanPhamBLL;
        private int id;
        private List<SanPham> sanPhams;

        public UC_SanPham()
        {
            InitializeComponent();
        }

        private void tbMaSanPham_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                int ma = int.Parse(tbMaSanPham.Text);
                SanPham sp = sanPhamBLL.timSanphamTheoMa(ma);
                if (sp is null)
                {
                    MessageBox.Show("Not Found!");
                    tbTenSanPham.Clear();
                    return;
                }

                hienThiSanPham(sp);

                tbMaSanPham.Clear();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (id == -1)
                id = 0;
            hienThiSanPham(sanPhams[id++]);
            if (id == sanPhams.Count)
                id = 0;
        }

        private void hienThiSanPham(SanPham sp)
        {
            tbMaSanPham.Text = sp.MaSanPham.ToString();
            tbTenSanPham.Text = sp.TenSanPham;
            tbMaHangSX.Text = "Ma Hang:" + sp.MaHangSX;
            tbGia.Text = string.Format("{0:N0} VND", sp.Gia);
        }

        private void UC_SanPham_Load(object sender, EventArgs e)
        {
            sanPhamBLL = new SanPhamBLL();
            id = -1;
            sanPhams = sanPhamBLL.layDuLieuRaList();
        }
    }
}
