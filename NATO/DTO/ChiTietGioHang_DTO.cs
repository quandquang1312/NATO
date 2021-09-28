using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NATO.DTO
{
    public class ChiTietGioHang_DTO
    {
        public ChiTietGioHang_DTO()
        {
            this.Username = "";
            this.MaHang = "";
            this.SoLuong = 0;
            this.TenHang = "";
            this.MoTa = "";
            this.Gia = 0;
            this.HinhAnh = "";
            this.ThanhTien = 0;
        }

        public string Username { get; set; }
        public string MaHang { get; set; }
        public int SoLuong { get; set; }
        public string TenHang { get; set; }
        public string MoTa { get; set; }
        public float Gia { get; set; }
        public string HinhAnh { get; set; }
        public float ThanhTien { get; set; }
    }
}
