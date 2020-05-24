using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using MyLibrary;

namespace DAL
{
    public class SanPhamDAL : MySQLDB
    {
        public List<SanPham> layDuLieuRaList()
        {
            List<SanPham> sanPhams = new List<SanPham>();
            DataTable dt = getDataToDatatable("SELECT * FROM SANPHAM");
            if (dt != null)
            {
                SanPham sp;
                foreach(DataRow dr in dt.Rows)
                {
                    sp = new SanPham()
                    {
                        MaSanPham = int.Parse(dr[0].ToString()),
                        MaHangSX = int.Parse(dr[1].ToString()),
                        TenSanPham = dr[2].ToString(),
                        Gia = float.Parse(dr[3].ToString())
                    };
                    sanPhams.Add(sp);
                }

                return sanPhams;
            }

            return null;
        }

        public SanPham timSanphamTheoMa(int maSP)
        {
            SanPham sp = null;
            DataTable dt = getDataToDatatable("SELECT * FROM SANPHAM WHERE MASANPHAM = "+maSP);
            if (dt != null && dt.Rows.Count != 0)
            {
                DataRow dr = dt.Rows[0];
                sp = new SanPham()
                {
                    MaSanPham = int.Parse(dr[0].ToString()),
                    MaHangSX = int.Parse(dr[1].ToString()),
                    TenSanPham = dr[2].ToString(),
                    Gia = float.Parse(dr[3].ToString())
                };
                return sp;
            }

            return sp;
        }
    }
}
