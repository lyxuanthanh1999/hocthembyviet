using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SanPhamBLL
    {
        private SanPhamDAL sanPhamDAL;

        public List<SanPham> layDuLieuRaList()
        {
            sanPhamDAL = new SanPhamDAL();
            return sanPhamDAL.layDuLieuRaList();
        }

        public SanPham timSanphamTheoMa(int maSP)
        {
            sanPhamDAL = new SanPhamDAL();
            if (maSP < 0)
                return null;
            return sanPhamDAL.timSanphamTheoMa(maSP);
        }
    }
}
