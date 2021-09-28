using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NATO.DTO
{
    public class HoaDon_DTO
    {
        public HoaDon_DTO()
        {
            this.MaHD = 0;
            this.Username = "";
            this.TongTien = 0;
            this.Date = DateTime.Today;
        }

        public int MaHD { get; set; }
        public string Username {get; set;}
        public float TongTien { get; set; }
        public DateTime Date { get; set; }
    }
}
