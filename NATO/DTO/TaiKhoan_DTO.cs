using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NATO.DTO
{
    public class TaiKhoan_DTO
    {
        public TaiKhoan_DTO()
        {
            this.Username = "";
            this.HoTen = "";
            this.Email = "";
            this.SDT = "";
            this.DiaChi = "";
            this.GT = false;
            this.QuocTich = "";
            this.MatKhau = "";
            this.IsAdmin = false;
            this.HinhAnh = "";
        }

        public string Username { get; set; }
        public string HoTen { get; set; }
        public string Email { get; set; }
        public string SDT { get; set; }
        public string DiaChi { get; set; }
        public bool GT { get; set; }
        public string QuocTich { get; set; }
        public string MatKhau { get; set; }
        public bool IsAdmin { get; set; }
        public string HinhAnh { get; set; }
    }
}
