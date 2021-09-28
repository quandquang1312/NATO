using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NATO.DTO
{
    public class MatHang_DTO
    {
        public MatHang_DTO()
        {
            this.MaHang = "";
            this.TenHang = "";
            this.SoLuong = 0;
            this.HinhAnh = "";
            this.Gia = 0;
            this.MoTa = "";
            this.MaDM = "";
        }

        public string MaHang { get; set; }
        public string TenHang { get; set; }
        public int SoLuong { get; set; }
        public string HinhAnh { get; set; }
        public float Gia { get; set; }
        public string MoTa { get; set; }
        public string MaDM { get; set; }
    }
}
