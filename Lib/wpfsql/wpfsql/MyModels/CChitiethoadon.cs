using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using wpfsql.Models;

namespace wpfsql.MyModels
{
    class CChitiethoadon
    {
        public string Sohd { get; set; }
        public string Mahang { get; set; }
        public double? Dongia { get; set; }
        public int? Soluong { get; set; }

        public Hanghoa MahangNavigation { get; set; }
        public string TenHang
        {
            get
            {
                if (MahangNavigation == null) return string.Empty;
                else return MahangNavigation.Tenhang;
            }
        }
        public string Dvt
        {
            get
            {
                if (MahangNavigation == null) return string.Empty;
                else return MahangNavigation.Dvt;
            }
        }
        public double? ThanhTien
        {
            get
            {
                if (Soluong.HasValue && Dongia.HasValue)
                
                    return Dongia.Value * Soluong.Value;
                else return 0;
            }
        }
    }
}
