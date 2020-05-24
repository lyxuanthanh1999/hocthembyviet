using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPham
    {
        private int maSanPham;
        private int maHangSX;
        private string tenSanPham;
        private float gia;

        public int MaSanPham { get => maSanPham; set => maSanPham = value; }
        public int MaHangSX { get => maHangSX; set => maHangSX = value; }
        public string TenSanPham { get => tenSanPham; set => tenSanPham = value; }
        public float Gia { get => gia; set => gia = value; }
    }
}
