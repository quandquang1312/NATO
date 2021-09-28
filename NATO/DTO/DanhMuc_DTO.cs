using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NATO.DTO
{
    public class DanhMuc_DTO
    {
        public DanhMuc_DTO()
        {
            this.MaDM = "";
            this.TenDM = "";
            this.MoTa = "";
        }

        public string MaDM { get; set; }
        public string TenDM { get; set; }
        public string MoTa { get; set; }
    }
}
